Imports Microsoft.Win32
Imports System.IO
Imports System.Security.Cryptography
Imports System.Security
Imports System.Text

Public Class frmMain
    Public Ultimate As Boolean = False
    Public isClosing As Boolean = False
    Public Sub TfrmMain()
        'frmMain
        Translation.Tranaslate("string", "START_MENU_EXIT", TExit, Me)
        Translation.Tranaslate("string", "START_MENU_OPEN", TOpen, Me)
        Translation.Tranaslate("string", "START_MENU_DECRYPT", TDecrypt, Me)
        Translation.Tranaslate("string", "START_MENU_RECRYPT", TRecrypt, Me)
        Translation.Tranaslate("string", "START_MENU_DELETE_ALL", TDeleteAll, Me)
        Translation.Tranaslate("string", "START_MENU_ITEM_PROTO_DECRYPT", TDecryptIP, Me)
        Translation.Tranaslate("string", "START_MENU_ITEM_PROTO_RECRYPT", TRecryptIP, Me)
        Translation.Tranaslate("string", "START_MENU_MOB_PROTO_DECRYPT", TDecryptMP, Me)
        Translation.Tranaslate("string", "START_MENU_MOB_PROTO_RECRYPT", TRecryptMP, Me)
        Translation.Tranaslate("string", "START_MENU_MORE_INFO", TMoreInfo, Me)
        Translation.Tranaslate("string", "START_MENU_SETTINGS", TSettings, Me)
        Translation.Tranaslate("string", "START_MENU_DOWNLOAD_SCRIPT", TScriptDownload, Me)
        Translation.Tranaslate("string", "START_MENU_INFO_BUGS", TInfo, Me)
        Translation.Tranaslate("string", "START_MENU_INFO_GFO", TAboutGFO, Me)
        Translation.Tranaslate("string", "START_LABEL_RIGHTS", Label3, Me)
        Translation.Tranaslate("string", "START_LABEL_VISIT", Label2, Me)
        Translation.Tranaslate("string", "START_LABEL_CURRENTLY_FILE", Label4, Me)
        Translation.Tranaslate("string", "START_BUTTON_CLOSE_INFO", InfoClose1, Me)
        Translation.Tranaslate("string", "START_BUTTON_OPEN_INFO", InfoOpen1, Me)
        Translation.Tranaslate("string", "START_GROUP_INFO", GroupBox1, Me)
        Translation.Tranaslate("string", "START_NAME_INFO", InfoName, Me)
        Translation.Tranaslate("string", "START_SIZE_INFO", InfoSize, Me)
        'NotifyIcon
        Translation.Tranaslate("string", "START_MENU_SETTINGS", TrOption, Me)
        Translation.Tranaslate("string", "START_MENU_EXIT", TrExit, Me)
        Translation.Tranaslate("string", "START_MENU_DOWNLOAD_SCRIPT", TrDownloadScript, Me)
        Translation.Tranaslate("string", "START_MENU_INFO_BUGS", TrInfoBugs, Me)
        Translation.Tranaslate("string", "START_MENU_INFO_GFO", TrAboutGFO, Me)
        'New
        Translation.Tranaslate("string", "START_MENU_DEACTIVATE_ULTIMATE", DeactiveUltimate, Me)
        Translation.Tranaslate("string", "START_MENU_ACTIVATE_ULTIMATE", ActivateUltimate, Me)
    End Sub

    Public Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        TfrmMain()
        Start()
    End Sub

    Public Sub SvuotaDir(ByVal cartella As String)

        Dim di As IO.DirectoryInfo = _
                New IO.DirectoryInfo(cartella)
        For Each oFile As IO.FileInfo In di.GetFiles()
            oFile.Delete()
        Next
    End Sub

    Private Sub Timer5_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer5.Tick

        'Avvia Deleter
        Shell(Application.StartupPath & "\Deleter.bat")
        Timer5.Enabled = False
    End Sub

    Public Sub Start()
        Dim RegKey As RegistryKey = Registry.ClassesRoot.OpenSubKey(".epk")
        Dim WParam As RegistryKeyPermissionCheck = RegistryKeyPermissionCheck.ReadWriteSubTree
        Dim chiave As Microsoft.Win32.RegistryKey

        Try
            chiave = My.Computer.Registry.ClassesRoot.CreateSubKey(".epk", Microsoft.Win32.RegistryKeyPermissionCheck.Default)
            chiave.SetValue("", "EPack")
            chiave = My.Computer.Registry.ClassesRoot.CreateSubKey("EPack", Microsoft.Win32.RegistryKeyPermissionCheck.Default)
            chiave.SetValue("", "Encrypted Pack")
            chiave = My.Computer.Registry.ClassesRoot.CreateSubKey("EPack\DefaultIcon", Microsoft.Win32.RegistryKeyPermissionCheck.Default)
            chiave.SetValue("", Application.StartupPath & "\Black\icon.ico")
            chiave = My.Computer.Registry.ClassesRoot.CreateSubKey("EPack\Shell\open\command", Microsoft.Win32.RegistryKeyPermissionCheck.Default)
            chiave.SetValue("", Application.ExecutablePath & " %1")
            chiave = My.Computer.Registry.ClassesRoot.CreateSubKey("EPack\Shell\Decrypt with Game Files Open\Command", Microsoft.Win32.RegistryKeyPermissionCheck.Default)
            chiave.SetValue("", Application.ExecutablePath & " %1")
            chiave = My.Computer.Registry.ClassesRoot.CreateSubKey("EPack\Shell\Decrypt with Game Files Open\Icon", Microsoft.Win32.RegistryKeyPermissionCheck.Default)
            chiave.SetValue("", Application.StartupPath & "\Black\icon.ico")
            chiave = My.Computer.Registry.ClassesRoot.CreateSubKey("EPack\Shell\Decrypt with Game Files Open\Position", Microsoft.Win32.RegistryKeyPermissionCheck.Default)
            chiave.SetValue("", "Top")
            chiave = My.Computer.Registry.ClassesRoot.CreateSubKey(".eix", Microsoft.Win32.RegistryKeyPermissionCheck.Default)
            chiave.SetValue("", "EIX")
            chiave = My.Computer.Registry.ClassesRoot.CreateSubKey("EIX", Microsoft.Win32.RegistryKeyPermissionCheck.Default)
            chiave.SetValue("", "Encrypted Pack Header")
            chiave = My.Computer.Registry.ClassesRoot.CreateSubKey("EIX\DefaultIcon", Microsoft.Win32.RegistryKeyPermissionCheck.Default)
            chiave.SetValue("", Application.StartupPath & "\Black\icon.ico")
            chiave = My.Computer.Registry.ClassesRoot.CreateSubKey("EIX\Shell\open\command", Microsoft.Win32.RegistryKeyPermissionCheck.Default)
            chiave.SetValue("", Application.ExecutablePath & " %1")
            chiave = My.Computer.Registry.ClassesRoot.CreateSubKey("EIX\Shell\Decrypt with Game Files Open\Command", Microsoft.Win32.RegistryKeyPermissionCheck.Default)
            chiave.SetValue("", Application.ExecutablePath & " %1")
            chiave = My.Computer.Registry.ClassesRoot.CreateSubKey("EIX\Shell\Decrypt with Game Files Open\Icon", Microsoft.Win32.RegistryKeyPermissionCheck.Default)
            chiave.SetValue("", Application.StartupPath & "\Black\icon.ico")
            chiave = My.Computer.Registry.ClassesRoot.CreateSubKey("EIX\Shell\Decrypt with Game Files Open\Position", Microsoft.Win32.RegistryKeyPermissionCheck.Default)
            chiave.SetValue("", "Top")
            chiave.Close()
        Catch ex As Exception
        End Try
        'AutoPatcher
        Dim data As New TextBox
        data.Multiline = True
        TempData_Error()
        data.Text = My.Computer.FileSystem.ReadAllText(Application.StartupPath + "\Black\TempData.data")

        If data.Lines(0) = "1" Then
            AutoPatcher1.RunWorkerAsync()
        End If
        'Ultimate
        If My.Computer.FileSystem.FileExists(Application.StartupPath & "\Plugins\Ultimate.ini") Then
            ActivateUltimate.Enabled = True
            ActivateUltimate.Visible = True
        End If
    End Sub

    Private Sub Timer7_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer7.Tick

        'Eliminatore
        Dim data As New TextBox
        data.Multiline = True
        TempData_Error()
        data.Text = My.Computer.FileSystem.ReadAllText(Application.StartupPath + "\Black\TempData.data")
        If data.Lines(1) = "1" Then
            Cancella_File()
        End If
        Timer7.Enabled = False
    End Sub

    Private Sub Cancella_File()
        On Error Resume Next

        'Cancella
        Kill(Application.StartupPath & "\Deleter.bat")
        Kill(Application.StartupPath & "\Black\SystemDecompiler.xml")
        Kill(Application.StartupPath & "\Black\MyArchive.eix")
        Kill(Application.StartupPath & "\Black\MyArchive.epk")
        Kill(Application.StartupPath & "\Black\TempShell.bat")
        Kill(Application.StartupPath & "\Black\version.txt")
    End Sub

    Public Sub AutoPatcher1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles AutoPatcher1.DoWork
        On Error Resume Next
        'AutoPatcher
        Dim base As String = "http://gamefilesopen.com/patcher/"
        Dim startup As String = Application.StartupPath
        Kill(startup + "\Black\version.txt")
        My.Computer.Network.DownloadFile(base + "version.txt", startup + "\Black\version.txt")
        Dim newversion As Double = Convert.ToDouble(My.Computer.FileSystem.ReadAllText(startup + "\Black\version.txt"))
        If newversion > Application.ProductVersion Then
            Translation.msg("AutoPatcher", "NEW_VERSION", MsgBoxStyle.Information)
            Cancella_File()
        Else
            Cancella_File()
        End If
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        System.Diagnostics.Process.Start("http://www.gamefilesopen.com")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InfoOpen1.Click
        InfoClose1.Visible = True
        InfoClose1.Enabled = True
        InfoOpen1.Visible = False
        InfoOpen1.Enabled = False
        GroupBox1.Visible = True
        If Not My.Computer.FileSystem.FileExists(Sfoglia_text1.Text) Then
            GoTo NotExist
        End If
        'Nome
        NameBox1.Text = Mid$(Sfoglia_text1.Text, InStrRev(Sfoglia_text1.Text, "\") + 1)
        NameBox1.Text = NameBox1.Text.Replace(".epk", "") + " (.epk)"
        'Grandezza
        Dim MyFile As New FileInfo(Sfoglia_text1.Text)
        Dim FileSize As Long = MyFile.Length
        SizeBox1.Text = FileSize.ToString + " Byte"
        'MD5
        Dim hash As Byte() = Nothing
        Dim inputStream As New FileStream(Sfoglia_text1.Text, FileMode.Open, FileAccess.Read, FileShare.Read, &H2000)
        Dim provider As New MD5CryptoServiceProvider
        provider.ComputeHash(inputStream)
        hash = provider.Hash
        inputStream.Close()
        Dim builder As New StringBuilder(hash.Length)
        Dim num2 As Integer = (hash.Length - 1)
        Dim i As Integer = 0
        Do While (i <= num2)
            builder.Append(hash(i).ToString("X2"))
            i += 1
        Loop
        MD5Box1.Text = builder.ToString
        'HashCode
        Dim HashCode As New TextBox
        HashCode.Multiline = True
        HashCode.Text = My.Computer.FileSystem.ReadAllText(Sfoglia_text1.Text)
        HashBox1.Text = HashCode.Text.GetHashCode.ToString
        Exit Sub
NotExist:
        MD5Box1.Text = ""
        HashBox1.Text = ""
        NameBox1.Text = ""
        SizeBox1.Text = ""
    End Sub

    Private Sub InfoClose1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InfoClose1.Click

        GroupBox1.Visible = False
        InfoClose1.Visible = False
        InfoClose1.Enabled = False
        InfoOpen1.Visible = True
        InfoOpen1.Enabled = True
    End Sub

    Private Sub trayIcon_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles trayIcon.MouseDoubleClick
        Me.ShowInTaskbar = True
        Me.Show()
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrExit.Click
        trayIcon.Visible = False
        isClosing = True
        Application.Exit()
    End Sub

    Private Sub StartForm1_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If isClosing = True Then
            trayIcon.Visible = False
        Else
            e.Cancel = True
            Me.Hide()
            Me.ShowInTaskbar = False
        End If
    End Sub

    Private Sub OpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TOpen.Click
        With dlgOpen
            .Filter = "Game Files|*.*"
            If .ShowDialog = DialogResult.OK Then
                frmScansion.Scansion(.FileName)
                frmScansion.Show(Me)
            End If
        End With
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TExit.Click
        isClosing = True
        Application.Exit()
    End Sub


    Private Sub AboutGFOToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TAboutGFO.Click, TrAboutGFO.Click
        frmAbout.ShowDialog(Me)
    End Sub

    Private Sub InfoAboutbugsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TInfo.Click, TrInfoBugs.Click
        frmBugInfo.ShowDialog(Me)
    End Sub

    Private Sub SettingsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSettings.Click, TrOption.Click
        frmSettings.ShowDialog(Me)
    End Sub

    Private Sub HowToToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Translation.msg("Normal", "HOW_TO_LOCALE_ADDR", MsgBoxStyle.Information)
    End Sub

    Private Sub MenageECLToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenageECLToolStripMenuItem.Click, MenageECLToolStripMenuItem1.Click
        frmECL.ShowDialog(Me)
    End Sub

    Private Sub FileOperationsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TDecrypt.Click
        If My.Computer.FileSystem.FileExists(Sfoglia_text1.Text) Then
            OpenModule.EPack(Sfoglia_text1.Text, Mid$(Sfoglia_text1.Text, InStrRev(Sfoglia_text1.Text, ".")))
        Else
            Translation.msg("Normal", "FILE_DOESNT_EXIST", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub RepackEpackToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TRecrypt.Click
        RecryptEPack()
    End Sub

    Private Sub MenagePackIndexToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TMenagePackIndex.Click, MenagePackIndexToolStripMenuItem.Click
        frmPack.ShowDialog(Me)
    End Sub

    Private Sub UnpackItemprotoToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TDecryptIP.Click
        Dim startup As String = Application.StartupPath
        'Sfoglia
        Dim ApriFile As New OpenFileDialog
        With ApriFile
            .Filter = "File MIPX |*.*"
            If .ShowDialog = DialogResult.OK Then
                OpenModule.DemapItemProto(.FileName, Mid$(.FileName, InStrRev(.FileName, "\") + 1))
            Else
                Exit Sub
            End If
        End With
    End Sub

    Private Sub RepackToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TRecryptIP.Click
        OpenModule.RemapItemProto()
    End Sub

    Private Sub DeleteAllFilesToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TDeleteAll.Click
        'Cartella Deleter
        FileOpen(1, "Deleter.bat", OpenMode.Output, OpenAccess.Write)
        PrintLine(1, "rmdir /Q /S Black\OutFile")
        FileClose(1)
        Shell(Application.StartupPath & "\Deleter.bat")
        'Cartella XML
        Dim cartella As String
        cartella = "Black\XML"
        SvuotaDir(cartella)
        Kill(Application.StartupPath & "\Black\locale_it.txt")
        'Elimina Deleter
        Timer7.Enabled = True
    End Sub

    Private Sub MenagePackIndexToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenagePackIndexToolStripMenuItem1.Click
        Translation.msg("Normal", "INDEX_INFO", MsgBoxStyle.Information)
    End Sub

    Private Sub ItemprotoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TIP.Click
        Translation.msg("Normal", "ITEM_PROTO_INFO", MsgBoxStyle.Information)
    End Sub

    Private Sub LocaleaddrToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LocaleaddrToolStripMenuItem.Click
        Translation.msg("Normal", "LOCALE_ADDR_INFO", MsgBoxStyle.Information)
    End Sub

    Private Sub ScriptDownloadToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TScriptDownload.Click, TrDownloadScript.Click
        frmScript.ShowDialog(Me)
    End Sub

    Private Sub RecryptMobprotoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TRecryptMP.Click
        OpenModule.RemapMobProto()
    End Sub

    Private Sub DecryptMobprotoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TDecryptMP.Click
        Dim startup As String = Application.StartupPath
        'Sfoglia
        Dim ApriFile As New OpenFileDialog
        With ApriFile
            .Filter = "File MMPT |*.*"
            If .ShowDialog = DialogResult.OK Then
                OpenModule.DemapMobProto(.FileName, Mid$(.FileName, InStrRev(.FileName, "\") + 1))
            Else
                Exit Sub
            End If
        End With
    End Sub

    Private Sub mob_proto_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mob_proto.Tick
        Dim pname As String
        If Ultimate = False Then
            pname = "m3"
        Else
            pname = "Ultimate2"
        End If
        Dim pProcess() As Process = System.Diagnostics.Process.GetProcessesByName(pname)
        For Each p As Process In pProcess
            p.Kill()
        Next
        mob_proto.Enabled = False
    End Sub

    Private Sub ReadlocaleaddrToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReadlocaleaddrToolStripMenuItem1.Click
        TextBox3.Text = TextBox3.Text.Replace("locale_addr.txt", Application.StartupPath & "\Black\locale_addr.txt")
        'Apri locale_it.addr
        My.Computer.FileSystem.WriteAllText(Application.StartupPath & "\Black\locale_addr.txt", "", False)
        'File serverinfo.py
        Dim ApriFile As New OpenFileDialog
        With ApriFile
            .InitialDirectory = Application.StartupPath & "\Black\OutFile"
            .Filter = "File ServerInfo (.py)|*serverinfo.py"
            If .ShowDialog = DialogResult.OK Then
                My.Computer.FileSystem.WriteAllText(.FileName, TextBox3.Text, False)
            End If
        End With
    End Sub

    Private Sub ActivateUltimate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActivateUltimate.Click
        Ultimate = True
        ActivateUltimate.Enabled = False
        ActivateUltimate.Visible = False
        DeactiveUltimate.Enabled = True
        DeactiveUltimate.Visible = True
    End Sub

    Private Sub DeactiveUltimate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeactiveUltimate.Click
        Ultimate = False
        ActivateUltimate.Enabled = True
        ActivateUltimate.Visible = True
        DeactiveUltimate.Enabled = False
        DeactiveUltimate.Visible = False
    End Sub
End Class
