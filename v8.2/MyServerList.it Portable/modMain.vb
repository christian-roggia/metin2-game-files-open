Module modMain
    Private WithEvents Domain As AppDomain = AppDomain.CurrentDomain
    Private WithEvents bg As AlphaBG
    Sub Main()
        Application.EnableVisualStyles()
        If My.Application.CommandLineArgs.Count > 0 Then
            Dim ext As String
            Dim path As String
            path = My.Application.CommandLineArgs(0)
            Try
                ext = Mid$(path, InStrRev(path, "."))
            Catch ex As Exception
                ext = "."
            End Try
            OpenModule.EPack(path, ext)
            Application.Run(frmOpen)
        Else
            bg = New AlphaBG(My.Resources.splash, frmSplash, AlphaBG.Settings.DrawControls)
            bg.StartPosition = FormStartPosition.CenterScreen
            Application.Run(bg)
        End If
    End Sub

    Private Sub Domain_UnhandledException(ByVal sender As Object, ByVal e As System.UnhandledExceptionEventArgs) Handles Domain.UnhandledException
        Error_Log(frmSplash, e.ToString, "Normal")
    End Sub

    Private Sub bg_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles bg.Load
        bg.Fade(0)
        bg.Show()
        Dim t As Stopwatch
        For i As Double = 0 To Math.PI / 2 Step Math.PI / 90
            t = Stopwatch.StartNew()
            bg.Fade(Math.Sin(i))
            Do Until t.ElapsedMilliseconds >= 10
                Application.DoEvents()
            Loop
        Next
        check_in.check_in()
    End Sub

    Public Sub finish()
        Dim t As Stopwatch
        t = Stopwatch.StartNew()
        For i As Double = Math.PI / 2 To 0 / 2 Step (Math.PI / 90) * -1
            t = Stopwatch.StartNew()
            bg.Fade(Math.Sin(i))
            Do Until t.ElapsedMilliseconds >= 10
                Application.DoEvents()
            Loop
        Next
        bg.Hide()
        bg.ShowInTaskbar = False
        frmMain.Show()
    End Sub
End Module
