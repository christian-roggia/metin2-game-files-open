Public Class Black_Debugger1

    Private Sub Scansione1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Scansione1.Click
        On Error Resume Next
        Problem1.Text = "0"
        Resolved1.Text = "0"
        Dim startup As String = Application.StartupPath
        Lista_Bug1.Items.Clear()
        'Cartella Black
        If My.Computer.FileSystem.DirectoryExists(startup + "\Black") Then
            'File m2.exe
            If My.Computer.FileSystem.FileExists(startup + "\Black\m2.exe") Then
            Else
                Lista_Bug1.Items.Add("File 'm2.exe' assente")
                Problem1.Text = Problem1.Text + 1
            End If
            'Fine file m2.exe
            'Cartella XML
            If My.Computer.FileSystem.DirectoryExists(startup + "\Black\XML") Then
            Else
                Lista_Bug1.Items.Add("Cartella 'XML' assente")
                Problem1.Text = Problem1.Text + 1
            End If
            'Fine XML
            'string.dll
            If My.Computer.FileSystem.FileExists(startup + "\Black\string.dll") Then
            Else
                Lista_Bug1.Items.Add("File 'string.dll' assente")
                Problem1.Text = Problem1.Text + 1
            End If
            'fine string.dll
        Else
            Lista_Bug1.Items.Add("Cartella 'Black' assente")
            Problem1.Text = Problem1.Text + 1
        End If
        'Fine Black
        If Lista_Bug1.Items.Count = 0 Then
            Lista_Bug1.Items.Add("Non è stato riscontrato nessun errore!")
            MsgBox("Non è stato riscontrato nessun errore!", MsgBoxStyle.Information)
        Else
            If Lista_Bug1.Items.Count = 1 Then
                MsgBox("E' stato riscontrato un errore!", MsgBoxStyle.Critical)
            Else
                MsgBox("Sono stati riscontrati " + Problem1.Text + " errori!", MsgBoxStyle.Critical)
            End If
        End If
    End Sub

    Private Sub Ripristino1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ripristino1.Click
        On Error Resume Next
        Dim startup As String = Application.StartupPath
        If Lista_Bug1.Items.Item(0) = "Non è stato riscontrato nessun errore!" Then
            Exit Sub
        Else
            If Lista_Bug1.Items.Item(0) = "Avvia la scansione..." Then
                MsgBox("Devi avviare prima la scansione!", MsgBoxStyle.Information)
            End If

            'Inizia a mettere a posto
            If Lista_Bug1.Items.Contains("Cartella 'pack' assente") = True Then
                MsgBox("La cartella pack è assente, una nuova installazione del client può risolvere il problema!", MsgBoxStyle.Critical)
            End If
            'Black assente
            If Lista_Bug1.Items.Contains("Cartella 'Black' assente") = True Then
                If MsgBox("Voui scaricare la cartella 'Black' con all'interno tutti i file necessari?", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then
                    MkDir(startup + "\Black")
                    MkDir(startup + "\Black\XML")
                    FileOpen(1, startup & "\Black\string.dll", OpenMode.Output, OpenAccess.Write)
                    PrintLine(1, "1")
                    FileClose(1)
                    My.Computer.Network.DownloadFile("http://myserverlist.xl.lc/m2.exe", startup + "\Black\m2.exe")
                    Resolved1.Text = Resolved1.Text + 1
                End If
            End If
            'm2.exe
            If Lista_Bug1.Items.Contains("File 'm2.exe' assente") = True Then
                If MsgBox("Voui scaricare il file 'm2.exe'?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    My.Computer.Network.DownloadFile("http://myserverlist.xl.lc/m2.exe", startup + "\Black\m2.exe")
                    Resolved1.Text = Resolved1.Text + 1
                End If
            End If
            'XML
            If Lista_Bug1.Items.Contains("Cartella 'XML' assente") = True Then
                MkDir(startup + "\Black\XML")
                Resolved1.Text = Resolved1.Text + 1
            End If
            'dll
            If Lista_Bug1.Items.Contains("File 'string.dll' assente") = True Then
                FileOpen(1, startup & "\Black\string.dll", OpenMode.Output, OpenAccess.Write)
                PrintLine(1, "1")
                FileClose(1)
                Resolved1.Text = Resolved1.Text + 1
            End If
            If Resolved1.Text = "1" Then
                MsgBox("E' stato risolto un errore!", MsgBoxStyle.Information)
            Else
                If Resolved1.Text = "0" Then
                    MsgBox("Non è stato risolto nessun errore!", MsgBoxStyle.Critical)
                Else
                MsgBox("Sono stati risolti " & Resolved1.Text & " errori!", MsgBoxStyle.Information)
            End If
            End If
        End If
    End Sub
End Class


