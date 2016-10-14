Imports System.IO

Public Class Open1

    Private Sub Open1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If My.Computer.FileSystem.FileExists(StartForm1.Sfoglia_text1.Text) Then
            Exit Sub
        End If
        On Error Resume Next
        Me.TopLevel = True
        StartForm1.WindowState = FormWindowState.Minimized
        StartForm1.Opacity = 0
        StartForm1.ShowInTaskbar = False

        Dim Path As String = My.Application.CommandLineArgs(0)
        Dim Name As String
        Dim MyFile As New FileInfo(Path)
        Dim FileSize As Long = MyFile.Length
        TextBox1.Text = Path
        Name = Mid$(Path, InStrRev(Path, "\") + 1)
        Label1.Text = "Decompressione file { " & Name & " }"
        Label4.Text = "Grandezza : " & FileSize & " Bytes"

        If FileSize < 500000 Then
            ProgressBar1.Value = 100
        Else
            Timer1.Interval = FileSize \ 500000
            Timer2.Interval = FileSize \ 500000
            Timer1.Enabled = True
        End If

        If FileSize > 0 Then
            Dim startup As String = Application.StartupPath
            Dim text_out1 As New TextBox
            text_out1.Text = Name
            Dim Percorso As String = Replace(TextBox1.Text, ".epk", "")
            Dim OutPath As String = Replace(text_out1.Text, ".epk", "")
            Dim strAppPath As String
            strAppPath = System.AppDomain.CurrentDomain.BaseDirectory
            'File XML
            FileOpen(1, Application.StartupPath & "\Black\SystemDecompiler.xml", OpenMode.Output, OpenAccess.Write)
            PrintLine(1, "<Buildfile version='1.1'><Action type='extract' archivePath='" & Percorso & "' outputPath='OutFile\" & OutPath & "' extractAll='doSo' createXML='something' xmlPath='" & strAppPath & "Black\XML\" & OutPath & ".xml' /></Buildfile>")
            FileClose(1)

            FileOpen(2, Application.StartupPath & "\Black\TempShell.bat", OpenMode.Output, OpenAccess.Write)
            PrintLine(2, "cd " & strAppPath & "Black" & vbCrLf & "m2 SystemDecompiler.xml")
            FileClose(2)
            Shell(strAppPath & "Black\TempShell.bat")
        Else
            MsgBox("Il file selezionato non è idoneo o non esiste!", MsgBoxStyle.Critical)
        End If
    End Sub

    Public Sub General_decompile(ByVal path As String)
        Me.TopLevel = True
        Button1.Visible = False
        Button1.Enabled = False
        Button2.Visible = True
        Button2.Enabled = True
        Dim Name As String
        Dim MyFile As New FileInfo(path)
        Dim FileSize As Long = MyFile.Length
        TextBox1.Text = path
        Name = Mid$(path, InStrRev(path, "\") + 1)
        Label1.Text = "Decompressione file { " & Name & " }"
        Label4.Text = "Grandezza : " & FileSize & " Bytes"

        If FileSize < 500000 Then
            ProgressBar1.Value = 100
        Else
            Timer1.Interval = FileSize \ 500000
            Timer2.Interval = FileSize \ 500000
            Timer1.Enabled = True
        End If

        If FileSize > 0 Then
            Dim startup As String = Application.StartupPath
            Dim text_out1 As New TextBox
            text_out1.Text = Name
            Dim Percorso As String = Replace(TextBox1.Text, ".epk", "")
            Dim OutPath As String = Replace(text_out1.Text, ".epk", "")
            Dim strAppPath As String
            strAppPath = System.AppDomain.CurrentDomain.BaseDirectory
            'File XML
            FileOpen(1, Application.StartupPath & "\Black\SystemDecompiler.xml", OpenMode.Output, OpenAccess.Write)
            PrintLine(1, "<Buildfile version='1.1'><Action type='extract' archivePath='" & Percorso & "' outputPath='OutFile\" & OutPath & "' extractAll='doSo' createXML='something' xmlPath='" & strAppPath & "Black\XML\" & OutPath & ".xml' /></Buildfile>")
            FileClose(1)

            FileOpen(2, Application.StartupPath & "\Black\TempShell.bat", OpenMode.Output, OpenAccess.Write)
            PrintLine(2, "cd " & strAppPath & "Black" & vbCrLf & "m2 SystemDecompiler.xml")
            FileClose(2)
            Shell(strAppPath & "Black\TempShell.bat")
        Else
            MsgBox("Il file selezionato non è idoneo o non esiste!", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        On Error Resume Next
        'ProgressBar
        If ProgressBar1.Value = 100 Then Timer1.Enabled = False Else ProgressBar1.Value = ProgressBar1.Value + 1
        Timer2.Enabled = True
        Timer1.Enabled = False
    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        On Error Resume Next
        'ProgressBar
        If ProgressBar1.Value = 100 Then Timer2.Enabled = False Else ProgressBar1.Value = ProgressBar1.Value + 1
        Timer1.Enabled = True
        Timer2.Enabled = False
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        On Error Resume Next
        StartForm1.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.TopMost = False
        Me.Close()
    End Sub
End Class