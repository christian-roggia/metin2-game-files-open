Public Class Lato_Client1
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        On Error Resume Next
        'Sfoglia
        Dim ApriFile As New OpenFileDialog
        Dim percorso As String
        Dim startup As String = Application.StartupPath
        With ApriFile
            .Filter = "File uiwhisper (.py)|*uiwhisper.py"
            If .ShowDialog = DialogResult.OK Then
                percorso = .FileName
            Else
                Exit Sub
            End If
        End With


        FileOpen(1, percorso, OpenMode.Output, OpenAccess.Write)
        PrintLine(1, TextBox3.Text)
        FileClose(1)
        ProgressBar1.Value = 0
        Timer1.Enabled = True
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        On Error Resume Next
        'Sfoglia
        Dim ApriFile As New OpenFileDialog
        Dim percorso As String
        Dim startup As String = Application.StartupPath
        With ApriFile
            .Filter = "File locale (.py)|*locale.py"
            If .ShowDialog = DialogResult.OK Then
                percorso = .FileName
            Else
                Exit Sub
            End If
        End With

        FileOpen(1, percorso, OpenMode.Output, OpenAccess.Write)
        PrintLine(1, TextBox5.Text & TextBox2.Text & TextBox4.Text)
        FileClose(1)
        ProgressBar1.Value = 0
        Timer1.Enabled = True
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        On Error Resume Next
        'Sfoglia
        Dim ApriFile As New OpenFileDialog
        Dim percorso As String
        Dim startup As String = Application.StartupPath
        With ApriFile
            .Filter = "File serverinfo (.py)|*serverinfo.py"
            If .ShowDialog = DialogResult.OK Then
                percorso = .FileName
            Else
                Exit Sub
            End If
        End With

        FileOpen(1, percorso, OpenMode.Output, OpenAccess.Write)
        PrintLine(1, TextBox6.Text & TextBox1.Text & TextBox7.Text & TextBox1.Text & TextBox8.Text & TextBox1.Text & TextBox9.Text & TextBox1.Text & TextBox10.Text)
        FileClose(1)
        ProgressBar1.Value = 0
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        On Error Resume Next
        'ProgressBar
        If ProgressBar1.Value = 100 Then Timer1.Enabled = False Else ProgressBar1.Value = ProgressBar1.Value + 1
        Timer2.Enabled = True
        Timer1.Enabled = False
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        On Error Resume Next
        'ProgressBar
        If ProgressBar1.Value = 100 Then Timer2.Enabled = False Else ProgressBar1.Value = ProgressBar1.Value + 1
        Timer1.Enabled = True
        Timer2.Enabled = False
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        On Error Resume Next
        System.Diagnostics.Process.Start("http://www.megaupload.com/?d=1EY16RCY")
        System.Diagnostics.Process.Start("http://www.cheatforge.net/community/metin2-discussioni-server-privati/69561-release-nuovo-client-completo-con-autopatcher-cheatforge.html")
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        On Error Resume Next
        Lato_Client2.Visible = True
    End Sub
End Class