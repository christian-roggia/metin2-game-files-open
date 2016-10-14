Imports System.IO

Public Class frmSettings
    Private Sub Option1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Traduzione
        TfrmSettings()
        'TempData
        Dim data As New TextBox
        Dim path As String = Application.StartupPath + "\Black\TempData.data"
        data.Multiline = True
        'Lettura file
        TempData_Error()
        data.Text = My.Computer.FileSystem.ReadAllText(path)
        'Verifica bottone
        read(data)
    End Sub

    Private Sub Save1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Save1.Click

        'Leggi testo
        Dim data As New TextBox
        data.Multiline = True
        TempData_Error()
        data.Text = My.Computer.FileSystem.ReadAllText(Application.StartupPath & "\Black\TempData.data")

        'AutoPatcher
        If Auto1.Checked = True Then
            data.Text = "1" + vbCrLf + data.Lines(1) + vbCrLf + data.Lines(2)
        Else
            data.Text = "0" + vbCrLf + data.Lines(1) + vbCrLf + data.Lines(2)
        End If
        'Eliminatore
        If DeleteAction1.Checked = True Then
            data.Text = data.Lines(0) + vbCrLf + "1" + vbCrLf + data.Lines(2)
        Else
            data.Text = data.Lines(0) + vbCrLf + "0" + vbCrLf + data.Lines(2)
        End If
        'Lingua
        If LanguageBox.Text = "English" Then
            data.Text = data.Lines(0) + vbCrLf + data.Lines(1) + vbCrLf + "EN"
        ElseIf LanguageBox.Text = "Italiano" Then
            data.Text = data.Lines(0) + vbCrLf + data.Lines(1) + vbCrLf + "IT"
        ElseIf LanguageBox.Text = "Deutsch" Then
            data.Text = data.Lines(0) + vbCrLf + data.Lines(1) + vbCrLf + "DE"
        ElseIf LanguageBox.Text = "Français" Then
            data.Text = data.Lines(0) + vbCrLf + data.Lines(1) + vbCrLf + "FR"
        ElseIf LanguageBox.Text = "Polska" Then
            data.Text = data.Lines(0) + vbCrLf + data.Lines(1) + vbCrLf + "PL"
        ElseIf LanguageBox.Text = "Other.." Then
            data.Text = data.Lines(0) + vbCrLf + data.Lines(1) + vbCrLf + "OTHER"
        Else
            data.Text = data.Lines(0) + vbCrLf + data.Lines(1) + vbCrLf + "EN"
        End If
        FileOpen(1, Application.StartupPath & "\Black\TempData.data", OpenMode.Output, OpenAccess.Write)
        PrintLine(1, data.Text)
        FileClose(1)
        TfrmAll()
        Save1.Enabled = False
    End Sub

    Public Sub TfrmAll()
        frmBugInfo.TfrmBugInfo()
        frmECL.TfrmECL()
        frmAbout.TfrmInfo()
        frmMain.TfrmMain()
        frmOpen.TfrmOpen()
        frmPack.TfrmPack()
        frmScansion.TfrmOpen()
        TfrmSettings()
    End Sub

    Private Sub Auto1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Auto1.CheckedChanged
        If Manual1.Checked = True Then
            Search1.Enabled = True
        Else
            Search1.Enabled = False
        End If
        Save1.Enabled = True
    End Sub

    Private Sub Manual1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Manual1.CheckedChanged
        If Manual1.Checked = True Then
            Search1.Enabled = True
        Else
            Search1.Enabled = False
        End If
        Save1.Enabled = True
    End Sub

    Private Sub Exit1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Exit1.Click
        Me.Close()
    End Sub

    Private Sub Search1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Search1.Click
        frmMain.AutoPatcher1.RunWorkerAsync()
    End Sub

    Public Sub read(ByVal data As TextBox)
        If data.Lines(0) = "0" Then
            Auto1.Checked = False
            Manual1.Checked = True
            Search1.Enabled = True
        Else
            Auto1.Checked = True
            Manual1.Checked = False
        End If
        'Verifica bottone2
        If data.Lines(1) = "0" Then
            DeleteAction1.Checked = False
            DeleteOpen1.Checked = True
        Else
            DeleteAction1.Checked = True
            DeleteOpen1.Checked = False
        End If
        'Lingua
        If data.Lines(2) = "EN" Then
            LanguageBox.Text = "English"
        ElseIf data.Lines(2) = "IT" Then
            LanguageBox.Text = "Italiano"
        ElseIf data.Lines(2) = "DE" Then
            LanguageBox.Text = "Deutsch"
        ElseIf data.Lines(2) = "FR" Then
            LanguageBox.Text = "Français"
        ElseIf data.Lines(2) = "PL" Then
            LanguageBox.Text = "Polska"
        ElseIf data.Lines(2) = "OTHER" Then
            LanguageBox.Text = "Other..."
        Else
            LanguageBox.Text = "English"
        End If
        'Salva
        Save1.Enabled = False
    End Sub

    Private Sub DeleteAction1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteAction1.CheckedChanged

        Save1.Enabled = True
    End Sub

    Private Sub DeleteOpen1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteOpen1.CheckedChanged
        Save1.Enabled = True
    End Sub

    Private Sub TfrmSettings()
        'frmSettings
        Translation.Tranaslate("title", "SETTINGS_TITLE", Me, Me)
        Translation.Tranaslate("string", "SETTINGS_OPTION_AUTOPATCHER", GroupBox1, Me)
        Translation.Tranaslate("string", "SETTINGS_SEARCH_AUTOMATICALLY", Auto1, Me)
        Translation.Tranaslate("string", "SETTINGS_SERACH_MANUALLY", Manual1, Me)
        Translation.Tranaslate("string", "SETTINGS_SEARCH_NEW_VERSION", Search1, Me)
        Translation.Tranaslate("string", "SETTINGS_OPTION_DELETE_FILE", GroupBox2, Me)
        Translation.Tranaslate("string", "SETTINGS_DELETE_ANY_ACTION", DeleteAction1, Me)
        Translation.Tranaslate("string", "SETTINGS_DELETE_NEW_OPENING", DeleteOpen1, Me)
        Translation.Tranaslate("string", "SETTINGS_LANGUAGE", GroupBox3, Me)
        Translation.Tranaslate("string", "SETTINGS_SAVE", Save1, Me)
        Translation.Tranaslate("string", "SETTINGS_EXIT", Exit1, Me)
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LanguageBox.SelectedIndexChanged
        Save1.Enabled = True
    End Sub
End Class