Public Class Checker1

    Private Sub Checker1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error Resume Next
        Dim startup As String = Application.StartupPath
        List_Unresolved1.Items.Clear()
        'File m2.exe
        If My.Computer.FileSystem.FileExists(startup + "\Black\m2.exe") Then
        Else
            List_Unresolved1.Items.Add("m2.exe")
        End If
        'Fine file m2.exe
        'Cartella XML
        If My.Computer.FileSystem.DirectoryExists(startup + "\Black\XML") Then
        Else
            List_Unresolved1.Items.Add("XML")
        End If
        'Fine XML
        'TempData.data
        If My.Computer.FileSystem.FileExists(startup + "\Black\TempData.data") Then
        Else
            List_Unresolved1.Items.Add("TempData.data")
        End If
        'Fine TempData.data
        'Cartella Black
        If My.Computer.FileSystem.DirectoryExists(startup + "\Black") Then
        Else
            List_Unresolved1.Items.Add("Black")
        End If
        'Fine Black
        'DataDownLoad.exe
        If My.Computer.FileSystem.FileExists(startup + "\Black\DataDownLoad.exe") Then
        Else
            List_Unresolved1.Items.Add("DataDownLoad.exe")
        End If
        'Fine DataDownLoad.exe
        'icona.ico
        If My.Computer.FileSystem.FileExists(startup + "\Black\icona.ico") Then
        Else
            List_Unresolved1.Items.Add("icona.ico")
        End If
        'icona.ico
        If List_Unresolved1.Items.Count = 0 Then
            Timer1.Enabled = True
        End If

        If List_Unresolved1.Items.Count > 0 Then
            On Error Resume Next

            'Black assente
            If List_Unresolved1.Items.Contains("Black") = True Then
                MkDir(startup + "\Black")
                List_Resolved1.Items.Add("Black")
            End If
            'm2.exe
            If List_Unresolved1.Items.Contains("m2.exe") = True Then
                m2.RunWorkerAsync()
                Timer2.Enabled = True
            End If
            'XML
            If List_Unresolved1.Items.Contains("XML") = True Then
                MkDir(startup + "\Black\XML")
                List_Resolved1.Items.Add("XML")
            End If
            'icona.ico
            If List_Unresolved1.Items.Contains("icona.ico") = True Then
                icona1.RunWorkerAsync()
                Timer4.Enabled = True
            End If
            'TempData
            If List_Unresolved1.Items.Contains("TempData.data") = True Then
                FileOpen(1, startup & "\Black\TempData.data", OpenMode.Output, OpenAccess.Write)
                PrintLine(1, "1" & vbCrLf & "1")
                FileClose(1)
                List_Resolved1.Items.Add("TempData.data")
            End If
            'DataDownLoad.exe
            If List_Unresolved1.Items.Contains("DataDownLoad.exe") = True Then
                DataDownLoad1.RunWorkerAsync()
                Timer3.Enabled = True
            End If
        End If
    End Sub

    Private Sub m2_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles m2.DoWork
        On Error Resume Next
        Dim startup As String = Application.StartupPath
        My.Computer.Network.DownloadFile("http://myserverlist.xl.lc/m2.exe", startup + "\Black\m2.exe")
    End Sub

    Private Sub DataDownLoad1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles DataDownLoad1.DoWork
        On Error Resume Next
        Dim startup As String = Application.StartupPath
        My.Computer.Network.DownloadFile("http://myserverlist.xl.lc/DataDownLoad.exe", startup + "\Black\DataDownLoad.exe")
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        On Error Resume Next
        StartForm1.WindowState = FormWindowState.Normal
        StartForm1.Opacity = 1
        StartForm1.ShowInTaskbar = True
        StartForm1.Start()
        Me.Close()
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        On Error Resume Next
        If m2.IsBusy = False Then
            List_Resolved1.Items.Add("m2.exe")
            If List_Resolved1.Items.Count = List_Unresolved1.Items.Count Then
                StartForm1.WindowState = FormWindowState.Normal
                StartForm1.Opacity = 1
                StartForm1.ShowInTaskbar = True
                StartForm1.Start()
                Me.Close()
            End If
            Timer2.Enabled = False
        End If
    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        On Error Resume Next
        If DataDownLoad1.IsBusy = False Then
            List_Resolved1.Items.Add("DataDownLoad.exe")
            If List_Resolved1.Items.Count = List_Unresolved1.Items.Count Then
                StartForm1.WindowState = FormWindowState.Normal
                StartForm1.Opacity = 1
                StartForm1.ShowInTaskbar = True
                StartForm1.Start()
                Me.Close()
            End If
            Timer3.Enabled = False
        End If
    End Sub

    Private Sub icona1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles icona1.DoWork
        On Error Resume Next
        Dim startup As String = Application.StartupPath
        My.Computer.Network.DownloadFile("http://myserverlist.xl.lc/icona.ico", startup + "\Black\icona.ico")
    End Sub

    Private Sub Timer4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer4.Tick
        On Error Resume Next
        If icona1.IsBusy = False Then
            List_Resolved1.Items.Add("icona.ico")
            If List_Resolved1.Items.Count = List_Unresolved1.Items.Count Then
                StartForm1.WindowState = FormWindowState.Normal
                StartForm1.Opacity = 1
                StartForm1.ShowInTaskbar = True
                StartForm1.Start()
                Me.Close()
            End If
            Timer4.Enabled = False
        End If
    End Sub
End Class