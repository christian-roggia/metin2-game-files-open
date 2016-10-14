Public Class Lato_Server1

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        On Error Resume Next
        Lato_Server2.Visible = True
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        On Error Resume Next
        '71003
        If ComboBox1.Text = "Resetta Magie (71003)" Then
            Dim percorso As String = Application.StartupPath + "\Black\Lato_Server\71003\use"
            If My.Computer.FileSystem.DirectoryExists(percorso) Then
                FileOpen(1, percorso + "\reset_scroll.start", OpenMode.Output, OpenAccess.Write)
                PrintLine(1, TextBox3.Text)
                FileClose(1)
            Else
                MkDir(percorso)
                FileOpen(1, percorso + "\reset_scroll.start", OpenMode.Output, OpenAccess.Write)
                PrintLine(1, TextBox3.Text)
                FileClose(1)
            End If
        End If

        '50513
        If ComboBox1.Text = "Pietra delle Anime (50513)" Then
            Dim percorso As String = Application.StartupPath + "\Black\Lato_Server\50513\use"
            If My.Computer.FileSystem.DirectoryExists(percorso) Then
                FileOpen(1, percorso + "\training_grandmaster_skill.start", OpenMode.Output, OpenAccess.Write)
                PrintLine(1, TextBox2.Text)
                FileClose(1)
            Else
                MkDir(percorso)
                FileOpen(1, percorso + "\training_grandmaster_skill.start", OpenMode.Output, OpenAccess.Write)
                PrintLine(1, TextBox2.Text)
                FileClose(1)
            End If
        End If

        '71002
        If ComboBox1.Text = "Resetta Tutto (71002)" Then
            Dim percorso As String = Application.StartupPath + "\Black\Lato_Server\71002\use"
            If My.Computer.FileSystem.DirectoryExists(percorso) Then
                FileOpen(1, percorso + "\reset_scroll.start", OpenMode.Output, OpenAccess.Write)
                PrintLine(1, TextBox1.Text)
                FileClose(1)
            Else
                MkDir(percorso)
                FileOpen(1, percorso + "\reset_scroll.start", OpenMode.Output, OpenAccess.Write)
                PrintLine(1, TextBox1.Text)
                FileClose(1)
            End If
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        On Error Resume Next
        Dim percorso As String = Application.StartupPath + "\Black\Lato_Server\50512\use"
        If My.Computer.FileSystem.DirectoryExists(percorso) Then
            FileOpen(1, percorso + "\hair.start", OpenMode.Output, OpenAccess.Write)
            PrintLine(1, TextBox4.Text)
            FileClose(1)
        Else
            MkDir(percorso)
            FileOpen(1, percorso + "\hair.start", OpenMode.Output, OpenAccess.Write)
            PrintLine(1, TextBox4.Text)
            FileClose(1)
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        On Error Resume Next
        Dim percorso As String = Application.StartupPath + "\Black\Lato_Server\70021\use"
        If My.Computer.FileSystem.DirectoryExists(percorso) Then
            FileOpen(1, percorso + "\siege.start", OpenMode.Output, OpenAccess.Write)
            PrintLine(1, TextBox5.Text)
            FileClose(1)
        Else
            MkDir(percorso)
            FileOpen(1, percorso + "\siege.start", OpenMode.Output, OpenAccess.Write)
            PrintLine(1, TextBox5.Text)
            FileClose(1)
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        On Error Resume Next
        Dim percorso As String = Application.StartupPath + "\Black\Lato_Server\71047\use"
        If My.Computer.FileSystem.DirectoryExists(percorso) Then
            FileOpen(1, percorso + "\hair.start", OpenMode.Output, OpenAccess.Write)
            PrintLine(1, TextBox6.Text)
            FileClose(1)
        Else
            MkDir(percorso)
            FileOpen(1, percorso + "\hair.start", OpenMode.Output, OpenAccess.Write)
            PrintLine(1, TextBox6.Text)
            FileClose(1)
        End If
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        On Error Resume Next
        Dim percorso As String = Application.StartupPath + "\Black\Lato_Server\71055\use"
        If My.Computer.FileSystem.DirectoryExists(percorso) Then
            FileOpen(1, percorso + "\hair.start", OpenMode.Output, OpenAccess.Write)
            PrintLine(1, TextBox7.Text)
            FileClose(1)
        Else
            MkDir(percorso)
            FileOpen(1, percorso + "\hair.start", OpenMode.Output, OpenAccess.Write)
            PrintLine(1, TextBox7.Text)
            FileClose(1)
        End If
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        On Error Resume Next
        Lato_Server3.Visible = True
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        On Error Resume Next
        'percorso file
        Dim percorso As String = Application.StartupPath + "\Black\Lato_Server"

        'Cartella
        If My.Computer.FileSystem.DirectoryExists(percorso) Then
        Else
            MkDir(percorso)
        End If

        'big5_string
        If ComboBox2.Text = "big5_string" Then
            FileOpen(1, percorso + "\big5_string.txt", OpenMode.Output, OpenAccess.Write)
            PrintLine(1, big5_string1.Text)
            FileClose(1)
        End If

        'blend
        If ComboBox2.Text = "blend" Then
            FileOpen(1, percorso + "\blend.txt", OpenMode.Output, OpenAccess.Write)
            PrintLine(1, blend1.Text)
            FileClose(1)
        End If

        'fishing
        If ComboBox2.Text = "fishing" Then
            FileOpen(1, percorso + "\fishing.txt", OpenMode.Output, OpenAccess.Write)
            PrintLine(1, fishing1.Text)
            FileClose(1)
        End If

        'cube
        If ComboBox2.Text = "cube" Then
            FileOpen(1, percorso + "\cube.txt", OpenMode.Output, OpenAccess.Write)
            PrintLine(1, cube1.Text)
            FileClose(1)
        End If

        'forkedmapindex
        If ComboBox2.Text = "forkedmapindex" Then
            FileOpen(1, percorso + "\forkedmapindex.txt", OpenMode.Output, OpenAccess.Write)
            PrintLine(1, forkedmapindex1.Text)
            FileClose(1)
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        System.Diagnostics.Process.Start("http://www.mediafire.com/?zwzldm4mttz")
        System.Diagnostics.Process.Start("http://www.megaupload.com/?d=K5AJ2IOT")
        System.Diagnostics.Process.Start("http://www.cheatforge.net/community/metin2-discussioni-server-privati/70953-release-core-ita-fadetoblack-aggiornati.html")
    End Sub
End Class