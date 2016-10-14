Imports System.IO

Public Class Option1

    Private Sub Save1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Save1.Click
        On Error Resume Next
        'Leggi testo
        Dim data As New TextBox
        data.Multiline = True
        data.Text = My.Computer.FileSystem.ReadAllText(Application.StartupPath & "\Black\TempData.data")
 
        'AutoPatcher
        If Auto1.Checked = True Then
            data.Text = "1" + vbCrLf + data.Lines(1)
        Else
            data.Text = "0" + vbCrLf + data.Lines(1)
        End If
        'Eliminatore
        If DeleteAction1.Checked = True Then
            data.Text = data.Lines(0) + vbCrLf + "1"
        Else
            data.Text = data.Lines(0) + vbCrLf + "0"
        End If
        FileOpen(1, Application.StartupPath & "\Black\TempData.data", OpenMode.Output, OpenAccess.Write)
        PrintLine(1, data.Text)
        FileClose(1)
        Save1.Enabled = False
    End Sub

    Private Sub Auto1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Auto1.CheckedChanged
        On Error Resume Next
        If Manual1.Checked = True Then
            Search1.Enabled = True
        Else
            Search1.Enabled = False
        End If
        Save1.Enabled = True
    End Sub

    Private Sub Manual1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Manual1.CheckedChanged
        On Error Resume Next
        If Manual1.Checked = True Then
            Search1.Enabled = True
        Else
            Search1.Enabled = False
        End If
        Save1.Enabled = True
    End Sub

    Private Sub Exit1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Exit1.Click
        On Error Resume Next
        Me.Visible = False
    End Sub

    Private Sub Search1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Search1.Click
        On Error Resume Next
        StartForm1.AutoPatcher1.RunWorkerAsync()
    End Sub

    Private Sub Option1_VisibleChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.VisibleChanged
        On Error Resume Next
        'Verifica bottone
        Dim data As New TextBox
        data.Multiline = True
        data.Text = My.Computer.FileSystem.ReadAllText(Application.StartupPath + "\Black\TempData.data")
        If data.Lines(0) = "0" Then
            Auto1.Checked = False
            Manual1.Checked = True
            Search1.Enabled = True
        Else
            Auto1.Checked = True
            Manual1.Checked = False
        End If
        'Verifica bottone2
        If data.Lines(1) = "0" Then
            DeleteAction1.Checked = False
            DeleteOpen1.Checked = True
        Else
            DeleteAction1.Checked = True
            DeleteOpen1.Checked = False
        End If

        'Salva
        Save1.Enabled = False
    End Sub

    Private Sub DeleteAction1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteAction1.CheckedChanged
        On Error Resume Next
        Save1.Enabled = True
    End Sub

    Private Sub DeleteOpen1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteOpen1.CheckedChanged
        On Error Resume Next
        Save1.Enabled = True
    End Sub
End Class