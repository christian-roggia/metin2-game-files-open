Module Translation
    Public Sub Tranaslate(ByVal type As String, ByVal name As String, ByVal nObject As Object, ByVal nForm As Form)
        On Error GoTo Err
        'Lettura file
        Dim lang As New TextBox
        'File di lingua
        Dim langTxt As New TextBox
        Dim TempData As String = Application.StartupPath + "\Black\TempData.data"
        If My.Computer.FileSystem.FileExists(TempData) Then
            langTxt.Text = My.Computer.FileSystem.ReadAllText(Application.StartupPath + "\Black\TempData.data")
        Else
            My.Computer.FileSystem.WriteAllText(Application.StartupPath + "\Black\TempData.data", "0" & vbCrLf & "0" & vbCrLf & "EN", False)
            langTxt.Text = My.Computer.FileSystem.ReadAllText(Application.StartupPath + "\Black\TempData.data")
        End If

        lang.Text = My.Computer.FileSystem.ReadAllText(Application.StartupPath & "\Lang\" & langTxt.Lines(2) & ".lang")
        'Modifica name per evitare doppioni
        name = name & " = "
        'Tipo = title
        If type = "title" Then
            For i = 0 To lang.Lines.Count - 1
                If Not lang.Lines(i).Length < name.Length Then
                    If lang.Lines(i).Remove(name.Length, lang.Lines(i).Length - name.Length).ToString = name Then
                        nForm.Text = lang.Lines(i).Replace(name, "").Replace(Chr(34), "")
                    End If
                End If
            Next i
            'Tipo string
        ElseIf type = "string" Then
            For i = 0 To lang.Lines.Count - 1
                If Not lang.Lines(i).Length < name.Length Then
                    If lang.Lines(i).Remove(name.Length, lang.Lines(i).Length - name.Length).ToString = name Then
                        nObject.Text = lang.Lines(i).Replace(name, "").Replace(Chr(34), "")
                    End If
                End If
            Next i
        End If
        Exit Sub
Err:
check_in.Error_Log(frmSplash, ErrorToString, "Normal")
    End Sub

    Public Sub ListBox(ByVal columns As Integer, ByVal item As Integer, ByVal name As String, ByVal nObject As Object, ByVal all As Boolean)
        On Error GoTo Err
        'Lettura file
        Dim lang As New TextBox
        'File di lingua
        Dim langTxt As New TextBox
        Dim TempData As String = Application.StartupPath + "\Black\TempData.data"
        If My.Computer.FileSystem.FileExists(TempData) Then
            langTxt.Text = My.Computer.FileSystem.ReadAllText(Application.StartupPath + "\Black\TempData.data")
        Else
            My.Computer.FileSystem.WriteAllText(Application.StartupPath + "\Black\TempData.data", "0" & vbCrLf & "0" & vbCrLf & "EN", False)
            langTxt.Text = My.Computer.FileSystem.ReadAllText(Application.StartupPath + "\Black\TempData.data")
        End If

        lang.Text = My.Computer.FileSystem.ReadAllText(Application.StartupPath & "\Lang\" & langTxt.Lines(2) & ".lang")
        'Modifica name per evitare doppioni
        name = name & " = "
        'Tipo listbox
        For i = 0 To lang.Lines.Count - 1
            If Not lang.Lines(i).Length < name.Length Then
                If lang.Lines(i).Remove(name.Length, lang.Lines(i).Length - name.Length).ToString = name Then
                    Dim str As String = lang.Lines(i).Replace(name, "").Replace(Chr(34), "")
                    If all = True Then
                        For s = 0 To nObject.items.count - 1
                            nObject.Items(s).SubItems(columns).Text = str
                        Next s
                    Else
                        nObject.Items(item).SubItems(columns).Text = str
                    End If
                End If
            End If
        Next
        Exit Sub
Err:
check_in.Error_Log(frmSplash, ErrorToString, "Normal")
    End Sub

    Public Sub msg(ByVal type As String, ByVal name As String, ByVal style As MsgBoxStyle)
        On Error GoTo Err
        'Lettura file
        Dim lang As New TextBox
        'File di lingua
        Dim langTxt As New TextBox
        Dim TempData As String = Application.StartupPath + "\Black\TempData.data"
        If My.Computer.FileSystem.FileExists(TempData) Then
            langTxt.Text = My.Computer.FileSystem.ReadAllText(Application.StartupPath + "\Black\TempData.data")
        Else
            My.Computer.FileSystem.WriteAllText(Application.StartupPath + "\Black\TempData.data", "0" & vbCrLf & "0" & vbCrLf & "EN", False)
            langTxt.Text = My.Computer.FileSystem.ReadAllText(Application.StartupPath + "\Black\TempData.data")
        End If

        lang.Text = My.Computer.FileSystem.ReadAllText(Application.StartupPath & "\Lang\" & langTxt.Lines(2) & ".lang")
        'Modifica name per evitare doppioni
        name = name & " = "
        'Tipo Normal
        If type = "Normal" Then
            For i = 0 To lang.Lines.Count - 1
                If Not lang.Lines(i).Length < name.Length Then
                    If lang.Lines(i).Remove(name.Length, lang.Lines(i).Length - name.Length).ToString = name Then
                        MsgBox(lang.Lines(i).Replace(name, "").Replace(Chr(34), "").Replace("\n", vbCrLf), style)
                    End If
                End If
            Next i

            'Tipo Speciale "AlreadyOpen"
        ElseIf type = "AlreadyOpen" Then
            For i = 0 To lang.Lines.Count - 1
                If Not lang.Lines(i).Length < name.Length Then
                    If lang.Lines(i).Remove(name.Length, lang.Lines(i).Length - name.Length).ToString = name Then
                        If MsgBox(lang.Lines(i).Replace(name, "").Replace(Chr(34), "").Replace("\n", vbCrLf), MsgBoxStyle.Question & MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                            frmMain.isClosing = True
                            Application.Exit()
                        Else
                            Dim pProcess() As Process = System.Diagnostics.Process.GetProcessesByName("Game Files Open")
                            For Each p As Process In pProcess
                                p.Kill()
                            Next
                        End If
                    End If
                End If
            Next i
            'Tipo Speciale "AutoPatcher"
        ElseIf type = "AutoPatcher" Then
            For i = 0 To lang.Lines.Count - 1
                If Not lang.Lines(i).Length < name.Length Then
                    If lang.Lines(i).Remove(name.Length, lang.Lines(i).Length - name.Length).ToString = name Then
                        If MsgBox(lang.Lines(i).Replace(name, "").Replace(Chr(34), "").Replace("\n", vbCrLf), MsgBoxStyle.Question & MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                            Dim startup As String = Application.StartupPath
                            System.Diagnostics.Process.Start("http://www.gamefilesopen.com")
                        Else
                            Exit Sub
                        End If
                    End If
                End If
            Next i
        End If
        Exit Sub
Err:
check_in.Error_Log(frmSplash, ErrorToString, "Normal")
    End Sub
End Module
