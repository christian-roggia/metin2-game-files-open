Public Class SpecialFile

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles item_up1.Click
        On Error Resume Next
        'Scompatta item_proto
        FileOpen(1, Application.StartupPath & "\Decompiler.bat", OpenMode.Output, OpenAccess.Write)
        PrintLine(1, "Black\m2 SystemDecompiler.xml")
        FileClose(1)
        'File XML
        FileOpen(2, Application.StartupPath & "\SystemDecompiler.xml", OpenMode.Output, OpenAccess.Write)
        PrintLine(2, TextBox1.Text)
        FileClose(2)
        'Avvio Decompilatore
        Shell(Application.StartupPath & "\Decompiler.bat")
        'Pulizia
        StartForm1.Timer7.Enabled = True
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles item_down1.Click
        On Error Resume Next
        'Ricompatta item_proto
        FileOpen(1, Application.StartupPath & "\Recompiler.bat", OpenMode.Output, OpenAccess.Write)
        PrintLine(1, "Black\m2 SystemRecompiler.xml")
        FileClose(1)
        'File XML
        FileOpen(2, Application.StartupPath & "\SystemRecompiler.xml", OpenMode.Output, OpenAccess.Write)
        PrintLine(2, TextBox2.Text)
        FileClose(2)
        'Avvio Decompilatore
        Shell(Application.StartupPath & "\Recompiler.bat")
        'Pulizia
        StartForm1.Timer7.Enabled = True
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles address1.Click
        On Error Resume Next
        'Apri locale_it.addr
        FileOpen(1, Application.StartupPath & "\Black\locale_it.txt", OpenMode.Output, OpenAccess.Write)
        PrintLine(1, "")
        FileClose(1)
        'File serverinfo.py
        FileOpen(2, Application.StartupPath & "\Black\OutFile\root\serverinfo.py", OpenMode.Output, OpenAccess.Write)
        PrintLine(2, TextBox3.Text)
        FileClose(2)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        On Error Resume Next
        Me.Visible = False
    End Sub
End Class