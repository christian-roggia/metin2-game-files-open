Module check_in
    Public Sub check_in()
        Dim startup As String = Application.StartupPath
        If Not My.Computer.FileSystem.DirectoryExists(startup + "\Black") Then
            Error_Log(frmSplash, "Directory 'Black' doesn't exist.", "critical")
            Exit Sub
        End If
        If Not My.Computer.FileSystem.FileExists(startup + "\Black\m2.exe") Then
            Error_Log(frmSplash, "File 'm2.exe' doesn't Exist.", "critical")
        End If
        If Not My.Computer.FileSystem.FileExists(startup + "\Black\m3.exe") Then
            Error_Log(frmSplash, "File 'm3.exe' doesn't Exist.", "critical")
        End If
        If Not My.Computer.FileSystem.DirectoryExists(startup + "\Black\XML") Then
            My.Computer.FileSystem.CreateDirectory(startup + "\Black\XML")
        End If
        If Not My.Computer.FileSystem.DirectoryExists(startup + "\Plugins") Then
            My.Computer.FileSystem.CreateDirectory(startup + "\Plugins")
        End If
        If Not My.Computer.FileSystem.DirectoryExists(startup + "\Lang") Then
            Error_Log(frmSplash, "Directory 'Lang' doesn't exist.", "critical")
            My.Computer.FileSystem.CreateDirectory(startup + "\Black\XML")
        End If
        If Not My.Computer.FileSystem.FileExists(startup + "\Black\TempData.data") Then
            Error_Log(frmSplash, "File 'TempData.data' doesn't Exist.", "Normal")
        End If
        If Not My.Computer.FileSystem.FileExists(startup + "\Alpha Blended Form.dll") Then
            Error_Log(frmSplash, "File 'Alpha Blended Form.dll' doesn't Exist.", "critical")
        End If
        modMain.finish()
    End Sub

    Public Sub Error_Log(ByVal nForm As Form, ByVal err As String, ByVal type As String)
        Dim startup As String = Application.StartupPath
        err = "(" & nForm.Name & ") " & Now.Hour & ":" & Now.Minute & ":" & Now.Second & " :: " & err & vbCrLf
        If Not My.Computer.FileSystem.DirectoryExists(startup + "\Black") Then
            My.Computer.FileSystem.CreateDirectory(startup + "\Black")
        End If
        My.Computer.FileSystem.WriteAllText(startup + "\Black\ErrorLog.txt", err, True)
        If type = "critical" Then
            MsgBox(err, MsgBoxStyle.Critical)
            frmMain.isClosing = True
            frmMain.Close()
            frmSplash.Close()
        Else
            MsgBox(err, MsgBoxStyle.Information)
        End If
    End Sub

    Public Sub TempData_Error()
        If Not My.Computer.FileSystem.FileExists(Application.StartupPath + "\Black\TempData.data") Then
            Error_Log(frmSplash, "File 'TempData.data' doesn't Exist.", "critical")
            My.Computer.FileSystem.WriteAllText(Application.StartupPath + "\Black\TempData.data", "0" & vbCrLf & "0" & vbCrLf & "EN", False)
        End If
    End Sub
End Module
