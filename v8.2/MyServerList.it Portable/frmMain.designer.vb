<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.Timer5 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer7 = New System.Windows.Forms.Timer(Me.components)
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.text_out1 = New System.Windows.Forms.TextBox()
        Me.decompiler2 = New System.Windows.Forms.TextBox()
        Me.decompiler1 = New System.Windows.Forms.TextBox()
        Me.AutoPatcher1 = New System.ComponentModel.BackgroundWorker()
        Me.trayIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.mnuTray = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.TrDownloadScript = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenagePackIndexToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenageECLToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MIPXEditorToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MMPTEditorToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
        Me.TrInfoBugs = New System.Windows.Forms.ToolStripMenuItem()
        Me.TrAboutGFO = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.TrOption = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.TrExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.menuTop = New System.Windows.Forms.MenuStrip()
        Me.TFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.TOpen = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator13 = New System.Windows.Forms.ToolStripSeparator()
        Me.TMetin2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TDecrypt = New System.Windows.Forms.ToolStripMenuItem()
        Me.TRecrypt = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.TMenagePackIndex = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator14 = New System.Windows.Forms.ToolStripSeparator()
        Me.TDecryptIP = New System.Windows.Forms.ToolStripMenuItem()
        Me.TRecryptIP = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.TDecryptMP = New System.Windows.Forms.ToolStripMenuItem()
        Me.TRecryptMP = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator15 = New System.Windows.Forms.ToolStripSeparator()
        Me.ReadlocaleaddrToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator16 = New System.Windows.Forms.ToolStripSeparator()
        Me.TMoreInfo = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenagePackIndexToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator17 = New System.Windows.Forms.ToolStripSeparator()
        Me.TIP = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator18 = New System.Windows.Forms.ToolStripSeparator()
        Me.LocaleaddrToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.TDeleteAll = New System.Windows.Forms.ToolStripMenuItem()
        Me.LastChaosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenageECLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DecryptPackFilespckToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RecryptPackFilesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.TExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.TTool = New System.Windows.Forms.ToolStripMenuItem()
        Me.TScriptDownload = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActivateUltimate = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeactiveUltimate = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.TSettings = New System.Windows.Forms.ToolStripMenuItem()
        Me.TInfo1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TInfo = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.TAboutGFO = New System.Windows.Forms.ToolStripMenuItem()
        Me.dlgOpen = New System.Windows.Forms.OpenFileDialog()
        Me.mob_proto = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Sfoglia_text1 = New System.Windows.Forms.TextBox()
        Me.InfoSize = New System.Windows.Forms.Label()
        Me.InfoName = New System.Windows.Forms.Label()
        Me.SizeBox1 = New System.Windows.Forms.TextBox()
        Me.NameBox1 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.MD5Box1 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.HashBox1 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Browser = New System.Windows.Forms.FolderBrowserDialog()
        Me.InfoClose1 = New GFO.RoundedButton()
        Me.InfoOpen1 = New GFO.RoundedButton()
        Me.mnuTray.SuspendLayout()
        Me.menuTop.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer5
        '
        Me.Timer5.Interval = 1000
        '
        'Timer7
        '
        Me.Timer7.Interval = 500
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(53, 546)
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(47, 20)
        Me.TextBox4.TabIndex = 50
        Me.TextBox4.Text = "0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.TextBox4.Visible = False
        '
        'text_out1
        '
        Me.text_out1.Location = New System.Drawing.Point(106, 546)
        Me.text_out1.Multiline = True
        Me.text_out1.Name = "text_out1"
        Me.text_out1.Size = New System.Drawing.Size(47, 20)
        Me.text_out1.TabIndex = 51
        Me.text_out1.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.text_out1.Visible = False
        '
        'decompiler2
        '
        Me.decompiler2.Location = New System.Drawing.Point(130, 572)
        Me.decompiler2.Multiline = True
        Me.decompiler2.Name = "decompiler2"
        Me.decompiler2.Size = New System.Drawing.Size(47, 20)
        Me.decompiler2.TabIndex = 53
        Me.decompiler2.Visible = False
        '
        'decompiler1
        '
        Me.decompiler1.Location = New System.Drawing.Point(159, 546)
        Me.decompiler1.Name = "decompiler1"
        Me.decompiler1.Size = New System.Drawing.Size(35, 20)
        Me.decompiler1.TabIndex = 54
        Me.decompiler1.Visible = False
        '
        'AutoPatcher1
        '
        '
        'trayIcon
        '
        Me.trayIcon.ContextMenuStrip = Me.mnuTray
        Me.trayIcon.Icon = CType(resources.GetObject("trayIcon.Icon"), System.Drawing.Icon)
        Me.trayIcon.Text = "Games File Open"
        Me.trayIcon.Visible = True
        '
        'mnuTray
        '
        Me.mnuTray.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TrDownloadScript, Me.MenagePackIndexToolStripMenuItem, Me.MenageECLToolStripMenuItem1, Me.MIPXEditorToolStripMenuItem1, Me.MMPTEditorToolStripMenuItem1, Me.ToolStripSeparator10, Me.TrInfoBugs, Me.TrAboutGFO, Me.ToolStripSeparator9, Me.TrOption, Me.ToolStripSeparator2, Me.TrExit})
        Me.mnuTray.Name = "ContextMenuStrip1"
        Me.mnuTray.Size = New System.Drawing.Size(186, 220)
        '
        'TrDownloadScript
        '
        Me.TrDownloadScript.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TrDownloadScript.Name = "TrDownloadScript"
        Me.TrDownloadScript.Size = New System.Drawing.Size(185, 22)
        Me.TrDownloadScript.Text = "Download Script"
        '
        'MenagePackIndexToolStripMenuItem
        '
        Me.MenagePackIndexToolStripMenuItem.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenagePackIndexToolStripMenuItem.Name = "MenagePackIndexToolStripMenuItem"
        Me.MenagePackIndexToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.MenagePackIndexToolStripMenuItem.Text = "Menage Pack Index"
        '
        'MenageECLToolStripMenuItem1
        '
        Me.MenageECLToolStripMenuItem1.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenageECLToolStripMenuItem1.Name = "MenageECLToolStripMenuItem1"
        Me.MenageECLToolStripMenuItem1.Size = New System.Drawing.Size(185, 22)
        Me.MenageECLToolStripMenuItem1.Text = "Menage ECL"
        '
        'MIPXEditorToolStripMenuItem1
        '
        Me.MIPXEditorToolStripMenuItem1.Enabled = False
        Me.MIPXEditorToolStripMenuItem1.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MIPXEditorToolStripMenuItem1.Name = "MIPXEditorToolStripMenuItem1"
        Me.MIPXEditorToolStripMenuItem1.Size = New System.Drawing.Size(185, 22)
        Me.MIPXEditorToolStripMenuItem1.Text = "MIPX Editor"
        Me.MIPXEditorToolStripMenuItem1.Visible = False
        '
        'MMPTEditorToolStripMenuItem1
        '
        Me.MMPTEditorToolStripMenuItem1.Enabled = False
        Me.MMPTEditorToolStripMenuItem1.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MMPTEditorToolStripMenuItem1.Name = "MMPTEditorToolStripMenuItem1"
        Me.MMPTEditorToolStripMenuItem1.Size = New System.Drawing.Size(185, 22)
        Me.MMPTEditorToolStripMenuItem1.Text = "MMPT Editor"
        Me.MMPTEditorToolStripMenuItem1.Visible = False
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(182, 6)
        '
        'TrInfoBugs
        '
        Me.TrInfoBugs.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TrInfoBugs.Name = "TrInfoBugs"
        Me.TrInfoBugs.Size = New System.Drawing.Size(185, 22)
        Me.TrInfoBugs.Text = "Info About Bugs"
        '
        'TrAboutGFO
        '
        Me.TrAboutGFO.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TrAboutGFO.Name = "TrAboutGFO"
        Me.TrAboutGFO.Size = New System.Drawing.Size(185, 22)
        Me.TrAboutGFO.Text = "AboutGFO"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(182, 6)
        '
        'TrOption
        '
        Me.TrOption.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TrOption.Name = "TrOption"
        Me.TrOption.Size = New System.Drawing.Size(185, 22)
        Me.TrOption.Text = "Settings"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(182, 6)
        '
        'TrExit
        '
        Me.TrExit.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TrExit.Name = "TrExit"
        Me.TrExit.Size = New System.Drawing.Size(185, 22)
        Me.TrExit.Text = "Exit"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(53, 572)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(71, 20)
        Me.TextBox3.TabIndex = 60
        Me.TextBox3.Text = resources.GetString("TextBox3.Text")
        Me.TextBox3.Visible = False
        '
        'menuTop
        '
        Me.menuTop.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menuTop.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TFile, Me.TTool, Me.TInfo1})
        Me.menuTop.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        Me.menuTop.Location = New System.Drawing.Point(0, 0)
        Me.menuTop.Name = "menuTop"
        Me.menuTop.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.menuTop.Size = New System.Drawing.Size(395, 25)
        Me.menuTop.TabIndex = 66
        '
        'TFile
        '
        Me.TFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TOpen, Me.ToolStripSeparator13, Me.TMetin2, Me.LastChaosToolStripMenuItem, Me.ToolStripMenuItem1, Me.ToolStripSeparator3, Me.TExit})
        Me.TFile.Name = "TFile"
        Me.TFile.Size = New System.Drawing.Size(40, 21)
        Me.TFile.Text = "&File"
        '
        'TOpen
        '
        Me.TOpen.Name = "TOpen"
        Me.TOpen.Size = New System.Drawing.Size(152, 22)
        Me.TOpen.Text = "&Open..."
        '
        'ToolStripSeparator13
        '
        Me.ToolStripSeparator13.Name = "ToolStripSeparator13"
        Me.ToolStripSeparator13.Size = New System.Drawing.Size(149, 6)
        '
        'TMetin2
        '
        Me.TMetin2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TDecrypt, Me.TRecrypt, Me.ToolStripSeparator1, Me.TMenagePackIndex, Me.ToolStripSeparator14, Me.TDecryptIP, Me.TRecryptIP, Me.ToolStripSeparator5, Me.TDecryptMP, Me.TRecryptMP, Me.ToolStripSeparator15, Me.ReadlocaleaddrToolStripMenuItem1, Me.ToolStripSeparator16, Me.TMoreInfo, Me.ToolStripSeparator4, Me.TDeleteAll})
        Me.TMetin2.Name = "TMetin2"
        Me.TMetin2.Size = New System.Drawing.Size(152, 22)
        Me.TMetin2.Text = "&Metin 2"
        '
        'TDecrypt
        '
        Me.TDecrypt.Name = "TDecrypt"
        Me.TDecrypt.Size = New System.Drawing.Size(186, 22)
        Me.TDecrypt.Text = "&Decrypt Epack"
        '
        'TRecrypt
        '
        Me.TRecrypt.Name = "TRecrypt"
        Me.TRecrypt.Size = New System.Drawing.Size(186, 22)
        Me.TRecrypt.Text = "&Recrypt Epack"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(183, 6)
        '
        'TMenagePackIndex
        '
        Me.TMenagePackIndex.Name = "TMenagePackIndex"
        Me.TMenagePackIndex.Size = New System.Drawing.Size(186, 22)
        Me.TMenagePackIndex.Text = "&Menage Pack Index"
        '
        'ToolStripSeparator14
        '
        Me.ToolStripSeparator14.Name = "ToolStripSeparator14"
        Me.ToolStripSeparator14.Size = New System.Drawing.Size(183, 6)
        '
        'TDecryptIP
        '
        Me.TDecryptIP.Name = "TDecryptIP"
        Me.TDecryptIP.Size = New System.Drawing.Size(186, 22)
        Me.TDecryptIP.Text = "&Decrypt item_proto"
        '
        'TRecryptIP
        '
        Me.TRecryptIP.Name = "TRecryptIP"
        Me.TRecryptIP.Size = New System.Drawing.Size(186, 22)
        Me.TRecryptIP.Text = "&Recrypt item_proto"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(183, 6)
        '
        'TDecryptMP
        '
        Me.TDecryptMP.Name = "TDecryptMP"
        Me.TDecryptMP.Size = New System.Drawing.Size(186, 22)
        Me.TDecryptMP.Text = "Decrypt mob_proto"
        '
        'TRecryptMP
        '
        Me.TRecryptMP.Name = "TRecryptMP"
        Me.TRecryptMP.Size = New System.Drawing.Size(186, 22)
        Me.TRecryptMP.Text = "Recrypt mob_proto"
        '
        'ToolStripSeparator15
        '
        Me.ToolStripSeparator15.Name = "ToolStripSeparator15"
        Me.ToolStripSeparator15.Size = New System.Drawing.Size(183, 6)
        '
        'ReadlocaleaddrToolStripMenuItem1
        '
        Me.ReadlocaleaddrToolStripMenuItem1.Enabled = False
        Me.ReadlocaleaddrToolStripMenuItem1.Name = "ReadlocaleaddrToolStripMenuItem1"
        Me.ReadlocaleaddrToolStripMenuItem1.Size = New System.Drawing.Size(186, 22)
        Me.ReadlocaleaddrToolStripMenuItem1.Text = "Read &locale.addr"
        '
        'ToolStripSeparator16
        '
        Me.ToolStripSeparator16.Name = "ToolStripSeparator16"
        Me.ToolStripSeparator16.Size = New System.Drawing.Size(183, 6)
        '
        'TMoreInfo
        '
        Me.TMoreInfo.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenagePackIndexToolStripMenuItem1, Me.ToolStripSeparator17, Me.TIP, Me.ToolStripSeparator18, Me.LocaleaddrToolStripMenuItem})
        Me.TMoreInfo.Name = "TMoreInfo"
        Me.TMoreInfo.Size = New System.Drawing.Size(186, 22)
        Me.TMoreInfo.Text = "&More Info"
        '
        'MenagePackIndexToolStripMenuItem1
        '
        Me.MenagePackIndexToolStripMenuItem1.Name = "MenagePackIndexToolStripMenuItem1"
        Me.MenagePackIndexToolStripMenuItem1.Size = New System.Drawing.Size(179, 22)
        Me.MenagePackIndexToolStripMenuItem1.Text = "&Index"
        '
        'ToolStripSeparator17
        '
        Me.ToolStripSeparator17.Name = "ToolStripSeparator17"
        Me.ToolStripSeparator17.Size = New System.Drawing.Size(176, 6)
        '
        'TIP
        '
        Me.TIP.Name = "TIP"
        Me.TIP.Size = New System.Drawing.Size(179, 22)
        Me.TIP.Text = "&MIPX (item_proto)"
        '
        'ToolStripSeparator18
        '
        Me.ToolStripSeparator18.Name = "ToolStripSeparator18"
        Me.ToolStripSeparator18.Size = New System.Drawing.Size(176, 6)
        '
        'LocaleaddrToolStripMenuItem
        '
        Me.LocaleaddrToolStripMenuItem.Name = "LocaleaddrToolStripMenuItem"
        Me.LocaleaddrToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.LocaleaddrToolStripMenuItem.Text = "&ADDR (Address)"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(183, 6)
        '
        'TDeleteAll
        '
        Me.TDeleteAll.Name = "TDeleteAll"
        Me.TDeleteAll.Size = New System.Drawing.Size(186, 22)
        Me.TDeleteAll.Text = "&Delete all files"
        '
        'LastChaosToolStripMenuItem
        '
        Me.LastChaosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenageECLToolStripMenuItem})
        Me.LastChaosToolStripMenuItem.Name = "LastChaosToolStripMenuItem"
        Me.LastChaosToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.LastChaosToolStripMenuItem.Text = "&Last Chaos"
        '
        'MenageECLToolStripMenuItem
        '
        Me.MenageECLToolStripMenuItem.Name = "MenageECLToolStripMenuItem"
        Me.MenageECLToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.MenageECLToolStripMenuItem.Text = "&Menage EClass"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DecryptPackFilespckToolStripMenuItem, Me.RecryptPackFilesToolStripMenuItem})
        Me.ToolStripMenuItem1.Enabled = False
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.ShowShortcutKeys = False
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.ToolStripMenuItem1.Text = "PerfectWorld"
        Me.ToolStripMenuItem1.Visible = False
        '
        'DecryptPackFilespckToolStripMenuItem
        '
        Me.DecryptPackFilespckToolStripMenuItem.Name = "DecryptPackFilespckToolStripMenuItem"
        Me.DecryptPackFilespckToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.DecryptPackFilespckToolStripMenuItem.Text = "Decrypt Pack Files"
        '
        'RecryptPackFilesToolStripMenuItem
        '
        Me.RecryptPackFilesToolStripMenuItem.Name = "RecryptPackFilesToolStripMenuItem"
        Me.RecryptPackFilesToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.RecryptPackFilesToolStripMenuItem.Text = "Recrypt Pack Files"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(149, 6)
        '
        'TExit
        '
        Me.TExit.Name = "TExit"
        Me.TExit.Size = New System.Drawing.Size(152, 22)
        Me.TExit.Text = "&Exit"
        '
        'TTool
        '
        Me.TTool.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TScriptDownload, Me.ActivateUltimate, Me.DeactiveUltimate, Me.ToolStripSeparator8, Me.TSettings})
        Me.TTool.Name = "TTool"
        Me.TTool.Size = New System.Drawing.Size(50, 21)
        Me.TTool.Text = "&Tools"
        '
        'TScriptDownload
        '
        Me.TScriptDownload.Name = "TScriptDownload"
        Me.TScriptDownload.Size = New System.Drawing.Size(177, 22)
        Me.TScriptDownload.Text = "Script Download"
        '
        'ActivateUltimate
        '
        Me.ActivateUltimate.Enabled = False
        Me.ActivateUltimate.Name = "ActivateUltimate"
        Me.ActivateUltimate.Size = New System.Drawing.Size(177, 22)
        Me.ActivateUltimate.Text = "Active Ultimate"
        '
        'DeactiveUltimate
        '
        Me.DeactiveUltimate.Enabled = False
        Me.DeactiveUltimate.Name = "DeactiveUltimate"
        Me.DeactiveUltimate.Size = New System.Drawing.Size(177, 22)
        Me.DeactiveUltimate.Text = "Deactive Ultimate"
        Me.DeactiveUltimate.Visible = False
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(174, 6)
        '
        'TSettings
        '
        Me.TSettings.Name = "TSettings"
        Me.TSettings.Size = New System.Drawing.Size(177, 22)
        Me.TSettings.Text = "&Settings"
        '
        'TInfo1
        '
        Me.TInfo1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TInfo, Me.ToolStripSeparator7, Me.TAboutGFO})
        Me.TInfo1.Name = "TInfo1"
        Me.TInfo1.Size = New System.Drawing.Size(26, 21)
        Me.TInfo1.Text = "&?"
        '
        'TInfo
        '
        Me.TInfo.Name = "TInfo"
        Me.TInfo.Size = New System.Drawing.Size(164, 22)
        Me.TInfo.Text = "Info about &bugs"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(161, 6)
        '
        'TAboutGFO
        '
        Me.TAboutGFO.Name = "TAboutGFO"
        Me.TAboutGFO.Size = New System.Drawing.Size(164, 22)
        Me.TAboutGFO.Text = "&About G.F.O."
        '
        'dlgOpen
        '
        Me.dlgOpen.Filter = "File Metin2 (.epk)|*.epk"
        '
        'mob_proto
        '
        Me.mob_proto.Interval = 3000
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Cyan
        Me.Label1.Location = New System.Drawing.Point(12, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 18)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Created by FadeToBlack"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label2.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Lime
        Me.Label2.Location = New System.Drawing.Point(12, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(138, 16)
        Me.Label2.TabIndex = 57
        Me.Label2.Text = "Visit GameFilesOpen.com"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Cyan
        Me.Label3.Location = New System.Drawing.Point(12, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 16)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "All rights reserved."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(15, 135)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 16)
        Me.Label4.TabIndex = 58
        Me.Label4.Text = "Currently open file:"
        '
        'Sfoglia_text1
        '
        Me.Sfoglia_text1.Location = New System.Drawing.Point(15, 154)
        Me.Sfoglia_text1.Name = "Sfoglia_text1"
        Me.Sfoglia_text1.Size = New System.Drawing.Size(121, 20)
        Me.Sfoglia_text1.TabIndex = 59
        '
        'InfoSize
        '
        Me.InfoSize.AutoSize = True
        Me.InfoSize.Location = New System.Drawing.Point(6, 71)
        Me.InfoSize.Name = "InfoSize"
        Me.InfoSize.Size = New System.Drawing.Size(30, 16)
        Me.InfoSize.TabIndex = 63
        Me.InfoSize.Text = "Size"
        '
        'InfoName
        '
        Me.InfoName.AutoSize = True
        Me.InfoName.Location = New System.Drawing.Point(6, 22)
        Me.InfoName.Name = "InfoName"
        Me.InfoName.Size = New System.Drawing.Size(37, 16)
        Me.InfoName.TabIndex = 63
        Me.InfoName.Text = "Name"
        '
        'SizeBox1
        '
        Me.SizeBox1.Location = New System.Drawing.Point(9, 87)
        Me.SizeBox1.Name = "SizeBox1"
        Me.SizeBox1.ReadOnly = True
        Me.SizeBox1.Size = New System.Drawing.Size(100, 22)
        Me.SizeBox1.TabIndex = 63
        '
        'NameBox1
        '
        Me.NameBox1.Location = New System.Drawing.Point(9, 38)
        Me.NameBox1.Name = "NameBox1"
        Me.NameBox1.ReadOnly = True
        Me.NameBox1.Size = New System.Drawing.Size(100, 22)
        Me.NameBox1.TabIndex = 64
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 115)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 16)
        Me.Label7.TabIndex = 63
        Me.Label7.Text = "MD5"
        '
        'MD5Box1
        '
        Me.MD5Box1.Location = New System.Drawing.Point(9, 131)
        Me.MD5Box1.Name = "MD5Box1"
        Me.MD5Box1.ReadOnly = True
        Me.MD5Box1.Size = New System.Drawing.Size(100, 22)
        Me.MD5Box1.TabIndex = 65
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 157)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 16)
        Me.Label8.TabIndex = 66
        Me.Label8.Text = "HashCode"
        '
        'HashBox1
        '
        Me.HashBox1.Location = New System.Drawing.Point(9, 173)
        Me.HashBox1.Name = "HashBox1"
        Me.HashBox1.ReadOnly = True
        Me.HashBox1.Size = New System.Drawing.Size(100, 22)
        Me.HashBox1.TabIndex = 67
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.HashBox1)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.MD5Box1)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.NameBox1)
        Me.GroupBox1.Controls.Add(Me.SizeBox1)
        Me.GroupBox1.Controls.Add(Me.InfoName)
        Me.GroupBox1.Controls.Add(Me.InfoSize)
        Me.GroupBox1.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 230)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(121, 204)
        Me.GroupBox1.TabIndex = 62
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Information"
        Me.GroupBox1.Visible = False
        '
        'InfoClose1
        '
        Me.InfoClose1.BackColor = System.Drawing.Color.Transparent
        Me.InfoClose1.BorderColor = System.Drawing.Color.Black
        Me.InfoClose1.Color1 = System.Drawing.Color.Gainsboro
        Me.InfoClose1.Color2 = System.Drawing.Color.DarkGray
        Me.InfoClose1.Enabled = False
        Me.InfoClose1.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InfoClose1.ForeColor = System.Drawing.Color.Blue
        Me.InfoClose1.HighlighColor1 = System.Drawing.Color.LightCyan
        Me.InfoClose1.HighlightColor2 = System.Drawing.Color.CadetBlue
        Me.InfoClose1.Location = New System.Drawing.Point(33, 193)
        Me.InfoClose1.Name = "InfoClose1"
        Me.InfoClose1.Shiny = True
        Me.InfoClose1.Size = New System.Drawing.Size(81, 20)
        Me.InfoClose1.TabIndex = 65
        Me.InfoClose1.Text = "Close info"
        Me.InfoClose1.TraceRadius = 2
        Me.InfoClose1.Visible = False
        '
        'InfoOpen1
        '
        Me.InfoOpen1.BackColor = System.Drawing.Color.Transparent
        Me.InfoOpen1.BorderColor = System.Drawing.Color.Black
        Me.InfoOpen1.Color1 = System.Drawing.Color.Gainsboro
        Me.InfoOpen1.Color2 = System.Drawing.Color.DarkGray
        Me.InfoOpen1.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InfoOpen1.ForeColor = System.Drawing.Color.Blue
        Me.InfoOpen1.HighlighColor1 = System.Drawing.Color.LightCyan
        Me.InfoOpen1.HighlightColor2 = System.Drawing.Color.CadetBlue
        Me.InfoOpen1.Location = New System.Drawing.Point(33, 193)
        Me.InfoOpen1.Name = "InfoOpen1"
        Me.InfoOpen1.Shiny = True
        Me.InfoOpen1.Size = New System.Drawing.Size(81, 20)
        Me.InfoOpen1.TabIndex = 61
        Me.InfoOpen1.Text = "Open info"
        Me.InfoOpen1.TraceRadius = 2
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(395, 530)
        Me.Controls.Add(Me.InfoClose1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.InfoOpen1)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Sfoglia_text1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.decompiler1)
        Me.Controls.Add(Me.decompiler2)
        Me.Controls.Add(Me.text_out1)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.menuTop)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.menuTop
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.Text = "Game Files Open"
        Me.mnuTray.ResumeLayout(False)
        Me.menuTop.ResumeLayout(False)
        Me.menuTop.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub


    Friend WithEvents Timer5 As System.Windows.Forms.Timer
    Friend WithEvents Timer7 As System.Windows.Forms.Timer
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents text_out1 As System.Windows.Forms.TextBox
    Friend WithEvents decompiler2 As System.Windows.Forms.TextBox
    Friend WithEvents decompiler1 As System.Windows.Forms.TextBox
    Friend WithEvents AutoPatcher1 As System.ComponentModel.BackgroundWorker



    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox












    Friend WithEvents trayIcon As System.Windows.Forms.NotifyIcon

    Friend WithEvents mnuTray As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents TrExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TrOption As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuTop As System.Windows.Forms.MenuStrip
    Friend WithEvents TFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TOpen As System.Windows.Forms.ToolStripMenuItem





    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator






    Friend WithEvents TTool As System.Windows.Forms.ToolStripMenuItem

    Friend WithEvents TExit As System.Windows.Forms.ToolStripMenuItem




    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TSettings As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TInfo1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TInfo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TAboutGFO As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents dlgOpen As System.Windows.Forms.OpenFileDialog
    Friend WithEvents TMetin2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TDecrypt As System.Windows.Forms.ToolStripMenuItem




    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator


















    Friend WithEvents ToolStripSeparator13 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents LastChaosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

    Friend WithEvents MenageECLToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TRecrypt As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TMenagePackIndex As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator14 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TDecryptIP As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TRecryptIP As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator15 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ReadlocaleaddrToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem


    Friend WithEvents ToolStripSeparator16 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TMoreInfo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenagePackIndexToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator17 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TIP As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator18 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents LocaleaddrToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TDeleteAll As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TScriptDownload As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TDecryptMP As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TRecryptMP As System.Windows.Forms.ToolStripMenuItem


    Friend WithEvents mob_proto As System.Windows.Forms.Timer
    Friend WithEvents TrInfoBugs As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TrAboutGFO As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TrDownloadScript As System.Windows.Forms.ToolStripMenuItem

    Friend WithEvents MIPXEditorToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MMPTEditorToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenagePackIndexToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator10 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MenageECLToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DecryptPackFilespckToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Sfoglia_text1 As System.Windows.Forms.TextBox
    Friend WithEvents InfoOpen1 As GFO.RoundedButton
    Friend WithEvents InfoSize As System.Windows.Forms.Label
    Friend WithEvents InfoName As System.Windows.Forms.Label
    Friend WithEvents SizeBox1 As System.Windows.Forms.TextBox
    Friend WithEvents NameBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents MD5Box1 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents HashBox1 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents InfoClose1 As GFO.RoundedButton
    Friend WithEvents Browser As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents ActivateUltimate As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeactiveUltimate As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RecryptPackFilesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem















End Class
