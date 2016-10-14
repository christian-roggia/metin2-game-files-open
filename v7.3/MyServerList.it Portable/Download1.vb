Public Class Download1

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        On Error Resume Next
        If ProgressBar1.Value = 100 Then
            Timer1.Enabled = False
            Button1.Enabled = True
        Else
            ProgressBar1.Value = ProgressBar1.Value + 5
        End If
        Timer2.Enabled = True
        Timer1.Enabled = False
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        On Error Resume Next
        If ProgressBar1.Value = 100 Then
            Timer1.Enabled = False
            Button1.Enabled = True
        Else
            ProgressBar1.Value = ProgressBar1.Value + 5
        End If
        Timer1.Enabled = True
        Timer2.Enabled = False
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error Resume Next
        Timer1.Enabled = True
        'file download
        ListBox1.Items.Clear()
        Dim todownload As New TextBox
        todownload.Multiline = True
        todownload.Text = My.Computer.FileSystem.ReadAllText(Application.StartupPath + "\files.txt")
        Dim line As String = ""
        For Each line In todownload.Lines
            ListBox1.Items.Add(line)
        Next
        'file kill
        ListBox2.Items.Clear()
        Dim tokill As New TextBox
        tokill.Multiline = True
        tokill.Text = My.Computer.FileSystem.ReadAllText(Application.StartupPath + "\kill.txt")
        Dim lina As String = ""
        For Each lina In tokill.Lines
            ListBox2.Items.Add(lina)
        Next
        'novità
        Label4.Text = "Novità versione " & My.Computer.FileSystem.ReadAllText(Application.StartupPath + "\version.txt")
        Label5.Text = My.Computer.FileSystem.ReadAllText(Application.StartupPath + "\novità.txt")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        On Error Resume Next
        'Elimina Vecchi file
        Kill(Application.StartupPath & "\version.txt")
        Kill(Application.StartupPath & "\files.txt")
        Kill(Application.StartupPath & "\kill.txt")
        Kill(Application.StartupPath & "\novità.txt")
        SpecialFile.Close()
        Info_bug1.Close()
        Option1.Close()
        Me.Close()
        StartForm1.Close()
    End Sub
End Class