Public Class Option1

    Private Sub Save1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Save1.Click
        On Error Resume Next
        'AutoPatcher
        If Auto1.Checked = True Then
            FileOpen(1, Application.StartupPath & "\Black\string.dll", OpenMode.Output, OpenAccess.Write)
            PrintLine(1, "1")
            FileClose(1)
        Else
            FileOpen(1, Application.StartupPath & "\Black\string.dll", OpenMode.Output, OpenAccess.Write)
            PrintLine(1, "0")
            FileClose(1)
        End If
        'Eliminatore
        If DeleteAction1.Checked = True Then
            FileOpen(1, Application.StartupPath & "\Black\x2ms.dll", OpenMode.Output, OpenAccess.Write)
            PrintLine(1, "1")
            FileClose(1)
        Else
            FileOpen(1, Application.StartupPath & "\Black\x2ms.dll", OpenMode.Output, OpenAccess.Write)
            PrintLine(1, "0")
            FileClose(1)
        End If
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
        StartForm1.AutoPatcher()
    End Sub

    Private Sub Option1_VisibleChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.VisibleChanged
        On Error Resume Next
        'Verifica bottone
        Dim dll_txt1 As New TextBox
        dll_txt1.Multiline = True
        dll_txt1.Text = My.Computer.FileSystem.ReadAllText(Application.StartupPath + "\Black\string.dll")
        If dll_txt1.Text = dll.Text Then
            Auto1.Checked = False
            Manual1.Checked = True
            Search1.Enabled = True
        Else
            Auto1.Checked = True
            Manual1.Checked = False
        End If
        'Verifica bottone2
        Dim killer1 As New TextBox
        killer1.Multiline = True
        killer1.Text = My.Computer.FileSystem.ReadAllText(Application.StartupPath + "\Black\x2ms.dll")
        If killer1.Text = dll.Text Then
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