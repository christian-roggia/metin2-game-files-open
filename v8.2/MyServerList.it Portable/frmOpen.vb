Imports System.IO

Public Class frmOpen
    Public Sub General_decompile(ByVal path As String)
        TfrmOpen()
        Me.TopMost = True
        Dim Name As String
        Dim MyFile As New FileInfo(path)
        Dim FileSize As Long = MyFile.Length

        If FileSize <= 0 Then
            Translation.msg("Normal", "FILE_DOESNT_EXIST", MsgBoxStyle.Critical)
            Me.Close()
            Exit Sub
        End If

        TextBox1.Text = path
        Name = Mid$(path, InStrRev(path, "\") + 1)

        Label1.Text = Label1.Text & Name
        Label4.Text = Label4.Text & FileSize \ 1024 & " KBytes"
        Me.Refresh()
        DecryptEPack(FileSize, Name, path)
    End Sub

    Public Sub TfrmOpen()
        'frmOpen
        Translation.Tranaslate("title", "DECRYPT_FILE_TITLE", Me, Me)
        Translation.Tranaslate("string", "DECRYPT_FILE_PATH", Label3, Me)
        Translation.Tranaslate("string", "DECRYPT_FILE_FILE_NAME", Label1, Me)
        Translation.Tranaslate("string", "DECRYPT_FILE_AVERAGE_SPEED", Label2, Me)
        Translation.Tranaslate("string", "DECRYPT_FILE_FILE_SIZE", Label4, Me)
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value = 100 Then
            RunDirectory(Application.StartupPath & "\Black\OutFile")
            Me.Close()
            Timer1.Enabled = False
        Else
            ProgressBar1.Value = ProgressBar1.Value + 1
            Timer2.Enabled = True
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        If ProgressBar1.Value = 100 Then
            RunDirectory(Application.StartupPath & "\Black\OutFile")
            Me.Close()
            Timer2.Enabled = False
        Else
            ProgressBar1.Value = ProgressBar1.Value + 1
            Timer1.Enabled = True
            Timer2.Enabled = False
        End If
    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        Me.Close()
        Timer2.Enabled = False
    End Sub

    Public Sub RunDirectory(ByVal path As String)
        Process.Start("explorer.exe", path)
    End Sub
End Class