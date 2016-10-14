Imports System.IO
Imports System.Text.RegularExpressions

Public Class frmPack
    Private Sub SetStatus(ByVal txtStatus As String)
        lblStatus.Text = "Status: " & txtStatus
    End Sub

    Private Sub frmMain_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        If GlassModule.CompositionEnabled() Then
            ExtendGlass(Me, 0, 0, 0, lblStatus.Height)
            FillBlackRegion(e.Graphics, New Rectangle(0, lblStatus.Top, Me.ClientSize.Width, lblStatus.Height))
        End If
    End Sub

    Private Sub cmdLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLoad.Click
        If dlgOpen.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Dim sr As New StreamReader(dlgOpen.OpenFile())
            If Regex.IsMatch(sr.ReadLine(), "^pack$", RegexOptions.IgnoreCase) Then
                lstPack.Items.Clear()
                Do Until sr.EndOfStream
                    Dim temp As String = sr.ReadLine()
                    lstPack.Items.Add(New ListViewItem(New String() {sr.ReadLine(), temp}))
                Loop
                SetStatus("Loaded Index file.")
            Else
                SetStatus("Error - Invalid file given")
            End If
            sr.Close()
        End If
    End Sub

    Public Sub menager(ByVal path As String)
        Dim sr As New StreamReader(path)
        If Regex.IsMatch(sr.ReadLine(), "^pack$", RegexOptions.IgnoreCase) Then
            lstPack.Items.Clear()
            Do Until sr.EndOfStream
                Dim temp As String = sr.ReadLine()
                lstPack.Items.Add(New ListViewItem(New String() {sr.ReadLine(), temp}))
            Loop
            SetStatus("Loaded Index file.")
        Else
            SetStatus("Error - Invalid file given")
        End If
        sr.Close()
    End Sub

    Private _lineBeingEdited As Integer = -1

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        If lstPack.SelectedIndices(0) > -1 Then
            _lineBeingEdited = lstPack.SelectedIndices(0)
            cmdEdit.Enabled = False
            cmdSaveToList.Enabled = True
            txtName.Enabled = True
            txtPath.Enabled = True
            txtName.Text = lstPack.Items(_lineBeingEdited).SubItems(0).Text
            txtPath.Text = lstPack.Items(_lineBeingEdited).SubItems(1).Text
            SetStatus("Row " & (_lineBeingEdited + 1).ToString() & " is being edited.")
        End If
    End Sub

    Private Sub cmdSaveToList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSaveToList.Click
        If _lineBeingEdited > -1 Then
            lstPack.Items(_lineBeingEdited).SubItems(0).Text = txtName.Text
            lstPack.Items(_lineBeingEdited).SubItems(1).Text = txtPath.Text
            cmdEdit.Enabled = True
            cmdSaveToList.Enabled = False
            txtName.Enabled = False
            txtPath.Enabled = False
            txtName.Text = String.Empty
            txtPath.Text = String.Empty
            SetStatus("Row " & (_lineBeingEdited + 1) & " has been saved.")
            _lineBeingEdited = -1
        End If
    End Sub

    Private Sub cmdRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRemove.Click
        If lstPack.SelectedIndices.Count > 0 AndAlso lstPack.SelectedIndices(0) > -1 Then
            SetStatus("Row " & (lstPack.SelectedIndices(0) + 1) & " has been removed.")
            lstPack.Items.RemoveAt(lstPack.SelectedIndices(0))
        End If
    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        SetStatus("A new row has been added.")
        lstPack.Items.Add(New ListViewItem(New String() {String.Empty, String.Empty}))
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If dlgSave.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Dim sw As New StreamWriter(dlgSave.FileName, False)
            sw.WriteLine("PACK")
            For i As Integer = 0 To lstPack.Items.Count - 1
                sw.WriteLine(lstPack.Items(i).SubItems(1).Text)
                sw.WriteLine(lstPack.Items(i).SubItems(0).Text)
            Next
            SetStatus("File saved successfully.")
            sw.Close()
        End If
    End Sub

    Private Sub frmPack_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TfrmPack()
    End Sub

    Public Sub TfrmPack()
        'frmPack
        Translation.Tranaslate("title", "PACK_INDEX_EDITOR_TITLE", Me, Me)
        Translation.Tranaslate("string", "PACK_INDEX_EDITOR_LIST_PACK_NAME", colName, Me)
        Translation.Tranaslate("string", "PACK_INDEX_EDITOR_LIST_PACK_SIMULATED_PATH", colPath, Me)
        Translation.Tranaslate("string", "PACK_INDEX_EDITOR_LOAD_INDEX", cmdLoad, Me)
        Translation.Tranaslate("string", "PACK_INDEX_EDITOR_SAVE_MODIFIED_INDEX", cmdSave, Me)
        Translation.Tranaslate("string", "PACK_INDEX_EDITOR_EDIT", GroupBox1, Me)
        Translation.Tranaslate("string", "PACK_INDEX_EDITOR_EDIT_NAME", Label1, Me)
        Translation.Tranaslate("string", "PACK_INDEX_EDITOR_EDIT_PATH", Label2, Me)
        Translation.Tranaslate("string", "PACK_INDEX_EDITOR_EDIT_EDIT", cmdEdit, Me)
        Translation.Tranaslate("string", "PACK_INDEX_EDITOR_EDIT_SAVE", cmdSaveToList, Me)
        Translation.Tranaslate("string", "PACK_INDEX_EDITOR_ADD_LINE", cmdAdd, Me)
        Translation.Tranaslate("string", "PACK_INDEX_EDITOR_REMOVE_LINE", cmdRemove, Me)
    End Sub
End Class
