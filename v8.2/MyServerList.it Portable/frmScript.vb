Public Class frmScript
    Private Sub frmServerSide1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        WebBrowser1.Height = Me.Height
        WebBrowser1.Width = Me.Width
    End Sub

    Private Sub frmServerSide1_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        WebBrowser1.Height = Me.Height
        WebBrowser1.Width = Me.Width
    End Sub

    Private Sub frmServerSide1_ResizeBegin(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.ResizeBegin
        WebBrowser1.Height = Me.Height
        WebBrowser1.Width = Me.Width
    End Sub

    Private Sub frmServerSide1_ResizeEnd(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.ResizeEnd
        WebBrowser1.Height = Me.Height
        WebBrowser1.Width = Me.Width
    End Sub
End Class