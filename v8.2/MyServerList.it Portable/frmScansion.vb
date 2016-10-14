Imports System.Security.Cryptography
Imports System.Security
Imports System.Text
Imports System.IO

Public Class frmScansion

    Public Sub Scansion(ByVal path As String)
        Dim ext As String
        Dim name As String
        Dim MyFile As New FileInfo(path)
        Dim FileSize As String
        Dim md5 As String
        FileSize = (MyFile.Length \ 1024).ToString + " KB"
        Try
            ext = Mid$(path, InStrRev(path, "."))
        Catch ex As Exception
            ext = "."
        End Try
        name = Mid$(path, InStrRev(path, "\") + 1).Replace("." & ext, "")

        Dim hash As Byte() = Nothing
        Dim inputStream As New FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read, &H2000)
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
        md5 = builder.ToString

        Size1.Text = FileSize
        MD51.Text = md5
        Extension1.Text = ext
        Path1.Text = path
        frmMain.Sfoglia_text1.Text = path
        Name1.Text = name
        Magic1.Text = "..."
        Type1.Text = "..."
        BW1.RunWorkerAsync(path)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub Menage1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menage1.Click
        Select Case Type1.Text
            Case "File Index"
                frmPack.menager(Path1.Text)
                frmPack.Show(frmMain)
            Case "EClass File"
                frmECL.Menager(Path1.Text)
                frmECL.Show(frmMain)
        End Select
        Me.Close()
    End Sub

    Private Sub Disasm1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Disasm1.Click
        Translation.msg("Normal", "SCANSION_DISASSEMBLY", MsgBoxStyle.Information)
    End Sub

    Private Sub Decrypt1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Decrypt1.Click
        OpenModule.EPack(Path1.Text, Extension1.Text)
        Me.Close()
    End Sub

    Private Sub Demap1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Demap1.Click
        Select Case Type1.Text
            Case "Mapped Mob Prototype Table"
                OpenModule.DemapMobProto(Path1.Text, Name1.Text)
                Me.Close()
            Case "Mapped Item Prototype X."
                OpenModule.DemapItemProto(Path1.Text, Name1.Text)
        End Select
        Me.Close()
    End Sub

    Private Sub frmScansion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TfrmOpen()
    End Sub

    Public Sub TfrmOpen()
        Translation.Tranaslate("title", "SCANSION_FILE_TITLE", Me, Me)
        Translation.Tranaslate("string", "SCANSION_EXTENSION", Label1, Me)
        Translation.Tranaslate("string", "SCANSION_TYPE", Label2, Me)
        Translation.Tranaslate("string", "SCANSION_PATH", Label3, Me)
        Translation.Tranaslate("string", "SCANSION_NAME", Label4, Me)
        Translation.Tranaslate("string", "SCANSION_MAGIC", Label5, Me)
        Translation.Tranaslate("string", "SCANSION_MD5", Label7, Me)
        Translation.Tranaslate("string", "SCANSION_SIZE", Label8, Me)
        Translation.Tranaslate("string", "SCANSION_DECRYPT", Decrypt1, Me)
        Translation.Tranaslate("string", "SCANSION_DISASM", Disasm1, Me)
        Translation.Tranaslate("string", "SCANSION_DEMAP", Demap1, Me)
        Translation.Tranaslate("string", "SCANSION_UNKNOWN", Unknown1, Me)
        Translation.Tranaslate("string", "SCANSION_MENAGE", Menage1, Me)
    End Sub

    Private Sub BW1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BW1.DoWork
        Dim magic As String
        Try
            magic = My.Computer.FileSystem.ReadAllText(e.Argument).Substring(0, 4)
        Catch ex As Exception
            magic = "Unknown"
        End Try
        BW1.ReportProgress(100, magic)
    End Sub

    Private Sub BW1_ProgressChanged(ByVal sender As System.Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles BW1.ProgressChanged
        Magic1.Text = e.UserState
        Type1.Text = SelectType(Extension1.Text, Magic1.Text)
        Operation()
    End Sub

    Function SelectType(ByVal ext As String, ByVal magic As String)
        If frmMain.Ultimate = True Then
            Select Case ext
                Case UltimateModule.EXTENSION_1
                    Return "Ultimate Protection Data"
                    Exit Select
                Case UltimateModule.EXTENSION_2
                    Return "Ultimate Protection Header"
                    Exit Select
                Case Else
                    Return "Unknown"
                    Exit Select
            End Select
        End If
        Select Case ext
            Case ".epk"
                Return "Encrypted Pack"
                Exit Select
            Case ".eix"
                Return "EPack Header"
                Exit Select
            Case ".data"
                Return "Encrypted Data"
                Exit Select
            Case ".exe"
                Return "Executable"
                Exit Select
            Case ".dll"
                Return "Dynamy Link Library"
                Exit Select
            Case ".pck"
                Return "Pack File"
                Exit Select
            Case ".ecl"
                Return "EClass File"
                Exit Select
            Case ".addr"
                Return "Address File"
                Exit Select
            Case Else
                GoTo magic
        End Select
MAGIC:
        Select Case magic
            Case "MCOZ"
                Return "EPack / EPack Header"
                Exit Select
            Case "DDS "
                Return "Encrypted Pack"
                Exit Select
            Case "MMPT"
                Return "Mapped Mob Prototype Table"
                Exit Select
            Case "MIPX"
                Return "Mapped Item Prototype X."
                Exit Select
            Case "PACK"
                Return "File Index"
                Exit Select
            Case Else
                GoTo Executable
        End Select
Executable:
        Select Case ext.Substring(0, 2)
            Case "MZ"
                Return "Executable \ Dynamy Link Library"
                Exit Select
            Case Else
                Return "Unknown"
                Exit Select
        End Select
    End Function

    Function Operation()
        Select Case Type1.Text
            Case "Encrypted Pack"
                Decrypt1.Enabled = True
                Decrypt1.Visible = True
            Case "EPack Header"
                Decrypt1.Enabled = True
                Decrypt1.Visible = True
            Case "Executable"
                Disasm1.Enabled = True
                Disasm1.Visible = True
            Case "Dynamy Link Library"
                Disasm1.Enabled = True
                Disasm1.Visible = True
            Case "Mapped Mob Prototype Table"
                Demap1.Enabled = True
                Demap1.Visible = True
            Case "Mapped Item Prototype X."
                Demap1.Enabled = True
                Demap1.Visible = True
            Case "File Index"
                Menage1.Enabled = True
                Menage1.Visible = True
            Case "EClass File"
                Menage1.Enabled = True
                Menage1.Visible = True
            Case "Executable \ Dynamy Link Library"
                Disasm1.Enabled = True
                Disasm1.Visible = True
            Case "Ultimate Protection Data"
                Decrypt1.Enabled = True
                Decrypt1.Visible = True
            Case "Ultimate Protection Header"
                Decrypt1.Enabled = True
                Decrypt1.Visible = True
            Case Else
                Unknown1.Visible = True
        End Select
        Return 0
    End Function
End Class