Public Class Lato_Client2

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        On Error Resume Next
        'Sfoglia
        Dim ApriFile As New OpenFileDialog
        With ApriFile
            .Filter = "File colorinfo (.py)|*colorinfo.py"
            If .ShowDialog = DialogResult.OK Then
                Sfoglia_txt1.Clear()
                Sfoglia_txt1.Text = .FileName
            Else
                Exit Sub
            End If
        End With
        TextBox1.Text = My.Computer.FileSystem.ReadAllText(Sfoglia_txt1.Text)
        Save1.Enabled = False
        Undo1.Enabled = False
        Close1.Enabled = True
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If Sfoglia_txt1.Text = "" Then
            MsgBox("Scegli il file colorinfo.py del client con il tasto sfoglia!", MsgBoxStyle.Critical)
            Exit Sub
        End If
        ColorDialog1.Color = Color.FromArgb(235, 22, 9)
        If ColorDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Label6.Text = ColorDialog1.Color.R.ToString()
            Label5.Text = ColorDialog1.Color.G.ToString()
            Label4.Text = ColorDialog1.Color.B.ToString()
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Save1.Click
        FileOpen(1, Sfoglia_txt1.Text, OpenMode.Output, OpenAccess.Write)
        PrintLine(1, TextBox1.Text)
        FileClose(1)
        MsgBox("File salvato con sucesso!", MsgBoxStyle.Information)
        Save1.Enabled = False
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Close1.Click
        TextBox1.Clear()
        Sfoglia_txt1.Clear()
        Save1.Enabled = False
        Undo1.Enabled = False
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Undo1.Click
        TextBox1.Undo()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Save1.Enabled = True
        Undo1.Enabled = True
    End Sub

    Private Sub Lato_Client2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class