Public Class frmBugInfo
    Private Sub Info_bug1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TfrmBugInfo()
    End Sub
    Public Sub TfrmBugInfo()
        Translation.Tranaslate("title", "BUG_TITLE", Me, Me)
        Translation.Tranaslate("string", "BUG_INFO", Label4, Me)
        Translation.Tranaslate("string", "BUG_TITLE_DESCRIPTION", ColumnHeader2, Me)
        Translation.ListBox(1, 0, "BUG_DESCRIPTION", ListView1, True)
    End Sub
End Class