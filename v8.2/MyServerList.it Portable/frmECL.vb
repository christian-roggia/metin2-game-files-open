Imports System.IO
Imports System.Text.RegularExpressions

Public Class frmECL
    Private Sub cmdLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLoad.Click
        If dlgOpen.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            For s = 0 To dlgOpen.FileNames.Count - 1
                Dim files As New TextBox
                files.Multiline = True
                files.Text = My.Computer.FileSystem.ReadAllText(dlgOpen.FileNames(s))
                Dim index As Integer
                index = lstPack.Items.Count
                lstPack.Items.Add(dlgOpen.FileNames(s))
                lstPack.Items(index).SubItems.Add(files.Lines(0).Replace("Package: ", ""))
                lstPack.Items(index).SubItems.Add(files.Lines(1).Replace("Class: ", ""))
            Next s
            SetStatus("Loaded EClass files.")
        End If
    End Sub

    Public Sub Menager(ByVal path1 As String)
        Dim text As New TextBox
        text.Multiline = True
        text.Text = My.Computer.FileSystem.ReadAllText(path1)
        Dim index As Integer
        index = lstPack.Items.Count
        lstPack.Items.Add(path1)
        lstPack.Items(index).SubItems.Add(text.Lines(0).Replace("Package: ", ""))
        lstPack.Items(index).SubItems.Add(text.Lines(1).Replace("Class: ", ""))
        SetStatus("Loaded EClass files.")
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        For i = 0 To lstPack.Items.Count - 1
            Dim index As Integer = i
            Dim txt As String = "Package: " & lstPack.Items(index).SubItems(1).Text & vbCrLf & "Class: " & lstPack.Items(index).SubItems(2).Text
            My.Computer.FileSystem.WriteAllText(lstPack.Items(index).Text, txt, False)
            SetStatus("Saved EClass files.")
        Next i
    End Sub

    Private line_edit = -1
    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        line_edit = lstPack.SelectedIndices(0)
        txtPackage.Text = lstPack.Items(line_edit).SubItems(1).Text
        txtClass.Text = lstPack.Items(line_edit).SubItems(2).Text
        txtPath.Text = lstPack.Items(line_edit).Text
        txtClass.Enabled = True
        txtPath.Enabled = True
        txtPackage.Enabled = True
        cmdSaveToList.Enabled = False
        SetStatus("Row " & line_edit & " is begin edited.")
    End Sub

    Private Sub cmdSaveToList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSaveToList.Click
        If line_edit > -1 Then
            lstPack.Items(line_edit).SubItems(1).Text = txtPackage.Text
            lstPack.Items(line_edit).SubItems(2).Text = txtClass.Text
            lstPack.Items(line_edit).Text = txtPath.Text
            cmdEdit.Enabled = True
            cmdSaveToList.Enabled = False
            txtPackage.Enabled = False
            txtPath.Enabled = False
            txtClass.Enabled = False
            txtPackage.Text = String.Empty
            txtPath.Text = String.Empty
            txtClass.Text = String.Empty
            line_edit = -1
            SetStatus("Row " & line_edit & " has been saved.")
        End If
    End Sub

    Private Sub txtPackage_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPackage.TextChanged
        cmdSaveToList.Enabled = True
    End Sub

    Private Sub txtClass_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtClass.TextChanged
        cmdSaveToList.Enabled = True
    End Sub

    Private Sub txtPath_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPath.TextChanged
        cmdSaveToList.Enabled = True
    End Sub

    Private Sub cmdRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRemove.Click
        lstPack.Items.RemoveAt(lstPack.SelectedIndices(0))
        SetStatus("Row " & lstPack.SelectedIndices(0) & " has been removed.")
    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        lstPack.Items.Add(New ListViewItem(New String() {String.Empty, String.Empty, String.Empty}))
        SetStatus("A new row has been added.")
    End Sub

    Private Sub frmECL_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TfrmECL()
    End Sub

    Public Sub TfrmECL()
        Translation.Tranaslate("string", "ECL_LOAD", cmdLoad, Me)
        Translation.Tranaslate("string", "ECL_ADD", cmdAdd, Me)
        Translation.Tranaslate("string", "ECL_EDIT", cmdEdit, Me)
        Translation.Tranaslate("string", "ECL_REMOVE", cmdRemove, Me)
        Translation.Tranaslate("string", "ECL_SAVE", cmdSave, Me)
        Translation.Tranaslate("string", "ECL_SAVE_TO_LIST", cmdSaveToList, Me)
        Translation.Tranaslate("string", "ECL_EDIT", GroupBox1, Me)
        Translation.Tranaslate("string", "ECL_PACKAGE", Label1, Me)
        Translation.Tranaslate("string", "ECL_CLASS", Label2, Me)
        Translation.Tranaslate("string", "ECL_PATH", Label3, Me)
        Translation.Tranaslate("string", "ECL_PATH", colPath, Me)
        Translation.Tranaslate("string", "ECL_PACKAGE", colPackage, Me)
        Translation.Tranaslate("string", "ECL_CLASS", colClass, Me)
    End Sub

    Private Sub SetStatus(ByVal txtStatus As String)
        lblStatus.Text = "Status: " & txtStatus
    End Sub

    Private Sub frmECL_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint
        If GlassModule.CompositionEnabled() Then
            ExtendGlass(Me, 0, 0, 0, lblStatus.Height)
            FillBlackRegion(e.Graphics, New Rectangle(0, lblStatus.Top, Me.ClientSize.Width, lblStatus.Height))
        End If
    End Sub
End Class