Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Apre il file in scrittura. Se non c'è, lo crea, se c'è lo svuota.
        'OpenMode = Modalità di apertura:
        'Append = Aggiunge informazioni a quelle esistenti. Predefinito
        'Binary = Accesso binario (non per i file di testo puro
        'Input = File aperto per accesso in scrittura
        'Output = File aperto per accesso in lettura
        'Random = File aperto per l'accesso casuale

        'OpenAccess
        'Default = Accesso in lettura e scrittura
        'Read = Lettura
        'Write = Scrittura
        'ReadWrite = Accesso in lettura e scrittura (uguale a Default).


        FileOpen(1, Application.StartupPath & "\data\SystemDecompile.xml", OpenMode.Output, OpenAccess.Write)

        'Esempio di scrittura
        PrintLine(1, "<Buildfile version='1.1'><Action type='extract' archivePath='pack\" & ComboBox1.Text & "' outputPath='" & ComboBox1.Text & "' extractAll='doSo' createXML='something' xmlPath='" & ComboBox1.Text & ".xml' /></Buildfile>")
        'IMPORTANTE!! Chiudere il file
        FileClose(1)
        Shell(Application.StartupPath & "\data\Decompile.bat")

        If ComboBox1.Text = "item" Then Timer1.Enabled = True Else Timer2.Enabled = True
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Shell(Application.StartupPath & "\data\Ricompile.bat")
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value = 100 Then ProgressBar1.Value = 0 Exit Sub Else ProgressBar1.Value = ProgressBar1.Value + 1
        Timer3.Enabled = True
        Timer1.Enabled = False

    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        If ProgressBar1.Value = 100 Then ProgressBar1.Value = 0 Exit Sub Else ProgressBar1.Value = ProgressBar1.Value + 1
        Timer4.Enabled = True
        Timer2.Enabled = False
    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        If ProgressBar1.Value = 100 Then ProgressBar1.Value = 0 Exit Sub Else ProgressBar1.Value = ProgressBar1.Value + 1
        Timer1.Enabled = True
        Timer3.Enabled = False
    End Sub

    Private Sub Timer4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer4.Tick
        If ProgressBar1.Value = 100 ThenProgressBar1.Value = 0 Exit Sub Else ProgressBar1.Value = ProgressBar1.Value + 1
            Timer2.Enabled = True
            Timer4.Enabled = False
    End Sub
End Class
