Module OpenModule
    Public Sub EPack(ByVal path As String, ByVal ext As String)
        If path = "" Then
            Translation.msg("Normal", "ANY_FILE_SELECTED", MsgBoxStyle.Critical)
        ElseIf My.Computer.FileSystem.FileExists(path) Then
            Dim default_data As String
            Dim default_header As String
            If frmMain.Ultimate = True Then
                default_data = UltimateModule.EXTENSION_1
                default_header = UltimateModule.EXTENSION_2
            Else
                default_data = ".epk"
                default_header = ".eix"
            End If
            Select Case ext
                Case default_data
                    frmOpen.Show(frmMain)
                    frmOpen.General_decompile(path)
                    frmMain.Timer7.Enabled = True
                Case default_header
                    path = path.Replace(default_header, default_data)
                    frmOpen.Show(frmMain)
                    frmOpen.General_decompile(path)
                    frmMain.Timer7.Enabled = True
                Case Else
                    Translation.msg("Normal", "UNIDENTIFICATED_EPACK", MsgBoxStyle.Critical)
            End Select
        Else
            Translation.msg("Normal", "FILE_DOESNT_EXIST", MsgBoxStyle.Critical)
        End If
    End Sub

    Public Sub DecryptEPack(ByVal filesize As Integer, ByVal name As String, ByVal path As String)
        Dim default_data As String
        Dim default_header As String
        If frmMain.Ultimate = True Then
            default_data = UltimateModule.EXTENSION_1
            default_header = UltimateModule.EXTENSION_2
        Else
            default_data = ".epk"
            default_header = ".eix"
        End If

        If filesize < 500000 Then
            frmOpen.ProgressBar1.Value = 100
            frmOpen.Timer3.Enabled = True
        Else
            frmOpen.Timer1.Interval = filesize \ 500000
            frmOpen.Timer2.Interval = filesize \ 500000
            frmOpen.Timer1.Enabled = True
        End If

        Dim startup As String = Application.StartupPath
        Dim Percorso As String = Replace(path, default_data, "")
        Dim OutPath As String = Replace(name, default_data, "")
        Dim strAppPath As String
        strAppPath = System.AppDomain.CurrentDomain.BaseDirectory
        'File XML
        FileOpen(1, Application.StartupPath & "\Black\SystemDecompiler.xml", OpenMode.Output, OpenAccess.Write)
        PrintLine(1, "<Buildfile version='1.1'><Action type='extract' archivePath='" & Percorso & "' outputPath='OutFile\" & OutPath & "' extractAll='doSo' createXML='something' xmlPath='" & strAppPath & "Black\XML\" & OutPath & ".xml' /></Buildfile>")
        FileClose(1)

        FileOpen(2, Application.StartupPath & "\Black\TempShell.bat", OpenMode.Output, OpenAccess.Write)
        If frmMain.Ultimate = False Then
            PrintLine(2, "cd " & strAppPath & "Black" & vbCrLf & "m2 SystemDecompiler.xml")
        Else
            PrintLine(2, "cd " & strAppPath & "Black" & vbCrLf & "Ultimate SystemDecompiler.xml")
        End If

        FileClose(2)
        Shell(strAppPath & "Black\TempShell.bat")
    End Sub

    Public Sub RecryptEPack()
        Dim startup As String = Application.StartupPath
        'Sfoglia
        Dim ApriFile As New OpenFileDialog
        With ApriFile
            .InitialDirectory = startup & "\Black\XML"
            .Filter = "File xml (.xml)|*.xml"
            If .ShowDialog = DialogResult.OK Then
                Dim Path As String = .FileName
                Dim Name As String
                Name = Mid$(Path, InStrRev(.FileName, "\") + 1)
                Dim outpath As String = Replace(Path, ".xml", "")
                'Avvio
                FileOpen(1, Application.StartupPath + "\Black\TempShell.bat", OpenMode.Output, OpenAccess.Write)
                If frmMain.Ultimate = False Then
                    PrintLine(1, "cd " + Application.StartupPath + "\Black" + vbCrLf + "m2 XML\" & Name)
                Else
                    PrintLine(1, "cd " + Application.StartupPath + "\Black" + vbCrLf + "Ultimate XML\" & Name)
                End If
                FileClose(1)
                Shell(Application.StartupPath & "\Black\TempShell.bat")
            Else
                Exit Sub
            End If
        End With
    End Sub

    Public Sub DemapItemProto(ByVal path As String, ByVal name As String)
        'Scompatta Item_proto
        FileOpen(1, Application.StartupPath + "\Black\TempShell.bat", OpenMode.Output, OpenAccess.Write)
        If frmMain.Ultimate = False Then
            PrintLine(1, "cd " + Application.StartupPath + "\Black" + vbCrLf + "m2 SystemDecompiler.xml")
        Else
            PrintLine(1, "cd " + Application.StartupPath + "\Black" + vbCrLf + "Ultimate SystemDecompiler.xml")
        End If
        FileClose(1)
        'File XML
        My.Computer.FileSystem.WriteAllText(Application.StartupPath & "/Black/SystemDecompiler.xml", "<Buildfile version='1.1'><Action type='item_proto_extract' path='" & path & "' output='XML\" & name & ".xml'/></Buildfile>", False)
        'Avvio Decompilatore
        Shell(Application.StartupPath & "/Black/TempShell.bat")
        System.Threading.Thread.Sleep(300)
        If My.Computer.FileSystem.FileExists(Application.StartupPath & "/Black/XML/" & name & ".xml") Then
            Translation.msg("Normal", "ITEM_PROTO_OK", MsgBoxStyle.Information)
            frmOpen.RunDirectory(Application.StartupPath & "\Black\XML")
        Else
            Translation.msg("Normal", "ITEM_PROTO_ERROR", MsgBoxStyle.Critical)
        End If
    End Sub

    Public Sub RemapItemProto()
        Dim startup As String = Application.StartupPath
        Dim ApriFile As New OpenFileDialog
        With ApriFile
            .InitialDirectory = startup & "\Black\XML"
            .Filter = "File xml (.xml)|*.xml"
            If .ShowDialog = DialogResult.OK Then
                'Ricompatta item_proto
                FileOpen(1, Application.StartupPath + "\Black\TempShell.bat", OpenMode.Output, OpenAccess.Write)
                If frmMain.Ultimate = False Then
                    PrintLine(1, "cd " + Application.StartupPath + "\Black" + vbCrLf + "m2 SystemDecompiler.xml")
                Else
                    PrintLine(1, "cd " + Application.StartupPath + "\Black" + vbCrLf + "Ultimate SystemDecompiler.xml")
                End If
                FileClose(1)
                'File XML
                My.Computer.FileSystem.WriteAllText(Application.StartupPath & "/Black/SystemDecompiler.xml", "<Buildfile version='1.1'><Action type='item_proto_create' path='" & .FileName & "' output='" & .FileName.Replace(Mid$(.FileName, InStrRev(.FileName, ".")), "") & "' /></Buildfile>", False)
                'Avvio Decompilatore
                Shell(Application.StartupPath & "/Black/TempShell.bat")
                frmMain.Timer7.Enabled = True
                frmOpen.RunDirectory(Application.StartupPath & "\Black\XML")
            Else
                Exit Sub
            End If
        End With
    End Sub

    Public Sub DemapMobProto(ByVal path As String, ByVal name As String)
        'Scompatta Mob_proto
        FileOpen(1, Application.StartupPath + "\Black\TempShell.bat", OpenMode.Output, OpenAccess.Write)
        If frmMain.Ultimate = False Then
            PrintLine(1, "cd " + Application.StartupPath + "\Black" + vbCrLf + "m3 SystemDecompiler.xml")
        Else
            PrintLine(1, "cd " + Application.StartupPath + "\Black" + vbCrLf + "Ultimate2 SystemDecompiler.xml")
        End If
        FileClose(1)
        'File XML
        My.Computer.FileSystem.WriteAllText(Application.StartupPath & "/Black/SystemDecompiler.xml", "<Buildfile version='1.1'><Action type='mob_proto_extract' path='" & path & "' output='XML\" & name & ".xml'/></Buildfile>", False)
        'Avvio Decompilatore
        Shell(Application.StartupPath & "/Black/TempShell.bat")
        System.Threading.Thread.Sleep(300)
        If My.Computer.FileSystem.FileExists(Application.StartupPath & "/Black/XML/" & name & ".xml") Then
            Translation.msg("Normal", "MOB_PROTO_OK", MsgBoxStyle.Information)
            frmOpen.RunDirectory(Application.StartupPath & "\Black\XML")
        Else
            Translation.msg("Normal", "MOB_PROTO_ERROR", MsgBoxStyle.Critical)
        End If
        frmMain.mob_proto.Enabled = True
    End Sub

    Public Sub RemapMobProto()
        Dim startup As String = Application.StartupPath
        Dim ApriFile As New OpenFileDialog
        With ApriFile
            .InitialDirectory = startup & "\Black\XML"
            .Filter = "File xml (.xml)|*.xml"
            If .ShowDialog = DialogResult.OK Then
                'Ricompatta mob_proto
                FileOpen(1, Application.StartupPath + "\Black\TempShell.bat", OpenMode.Output, OpenAccess.Write)
                If frmMain.Ultimate = False Then
                    PrintLine(1, "cd " + Application.StartupPath + "\Black" + vbCrLf + "m3 SystemDecompiler.xml")
                Else
                    PrintLine(1, "cd " + Application.StartupPath + "\Black" + vbCrLf + "Ultimate2 SystemDecompiler.xml")
                End If
                FileClose(1)
                'File XML
                My.Computer.FileSystem.WriteAllText(Application.StartupPath & "/Black/SystemDecompiler.xml", "<Buildfile version='1.1'><Action type='mob_proto_create' path='" & .FileName & "' output='" & .FileName.Replace(Mid$(.FileName, InStrRev(.FileName, ".")), "") & "' /></Buildfile>", False)
                'Avvio Decompilatore
                Shell(Application.StartupPath & "/Black/TempShell.bat")
                frmMain.Timer7.Enabled = True
                frmMain.mob_proto.Enabled = True
                frmOpen.RunDirectory(Application.StartupPath & "\Black\XML")
            Else
                Exit Sub
            End If
        End With
    End Sub
End Module
