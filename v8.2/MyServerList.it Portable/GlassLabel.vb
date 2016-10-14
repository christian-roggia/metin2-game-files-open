
Public Class GlassLabel
    Private _forceRegularRendering As Boolean = False
    Private Enum eAlign
        Left = 0
        Center = 1
        Right = 2
    End Enum
    Public Property ForceRegularRendering() As Boolean
        Get
            Return _forceRegularRendering
        End Get
        Set(ByVal value As Boolean)
            _forceRegularRendering = value
            Me.Refresh()
        End Set
    End Property
    <System.Diagnostics.DebuggerStepThrough()> _
    Protected Overrides Sub OnTextChanged(ByVal e As System.EventArgs)
        Me.Invalidate()
        MyBase.OnTextChanged(e)
    End Sub
    <System.Diagnostics.DebuggerStepThrough()> _
    Protected Overrides Sub OnHandleCreated(ByVal e As System.EventArgs)
        MyBase.OnHandleCreated(e)
        Me.Invalidate()
    End Sub
    <System.Diagnostics.DebuggerStepThrough()> _
    Protected Overrides Sub OnPaintBackground(ByVal pevent As System.Windows.Forms.PaintEventArgs)
        If CompositionEnabled() And Not Me.DesignMode And Not _forceRegularRendering Then
            Me.BackColor = Color.Black
        End If
        MyBase.OnPaintBackground(pevent)
    End Sub
    <System.Diagnostics.DebuggerHidden()> _
    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        Dim g As Graphics = e.Graphics
        If Me.UseCompatibleTextRendering Then
            g.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
        End If
        Dim rect As New Rectangle()
        Dim textSize As Size = g.MeasureString(Replace(Me.Text, vbCrLf, String.Empty), Me.Font).ToSize
        textSize.Height *= CheckNewLines(Me.Text).Length
        textSize.Height += GetGlowSize()
        textSize.Width += GetGlowSize()
        rect.Size = textSize
        Select Case Me.TextAlign
            Case ContentAlignment.BottomCenter
                rect.X = (Me.Width / 2) - (rect.Width / 2) + GetGlowSize()
                rect.Y = Me.Height - rect.Height
                Me.DesignDrawText(g, rect, eAlign.Center)
            Case ContentAlignment.BottomLeft
                rect.X = 0
                rect.Y = Me.Height - rect.Height
                Me.DesignDrawText(g, rect, eAlign.Left)
            Case ContentAlignment.BottomRight
                rect.X = Me.Width - rect.Width
                rect.Y = Me.Height - rect.Height
                Me.DesignDrawText(g, rect, eAlign.Right)
            Case ContentAlignment.MiddleCenter
                rect.X = (Me.Width / 2) - (rect.Width / 2)
                rect.Y = (Me.Height / 2) - (rect.Height / 2)
                Me.DesignDrawText(g, rect, eAlign.Center)
            Case ContentAlignment.MiddleLeft
                rect.X = 0
                rect.Y = (Me.Height / 2) - (rect.Height / 2)
                Me.DesignDrawText(g, rect, eAlign.Left)
            Case ContentAlignment.MiddleRight
                rect.X = Me.Width - rect.Width
                rect.Y = (Me.Height / 2) - (rect.Height / 2)
                Me.DesignDrawText(g, rect, eAlign.Right)
            Case ContentAlignment.TopCenter
                rect.X = (Me.Width / 2) - (rect.Width / 2)
                rect.Y = 0
                Me.DesignDrawText(g, rect, eAlign.Center)
            Case ContentAlignment.TopLeft
                rect.X = 0
                rect.Y = 0
                Me.DesignDrawText(g, rect, eAlign.Left)
            Case ContentAlignment.TopRight
                rect.X = Me.Width - rect.Width
                rect.Y = 0
                Me.DesignDrawText(g, rect, eAlign.Right)
        End Select
    End Sub
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub DrawText(ByRef g As Graphics, ByVal Text As String, ByVal bounds As Rectangle)
        If CompositionEnabled() And Not Me.DesignMode And Not _forceRegularRendering Then
            DrawGlowingText(g, Text, Me.Font, bounds, Me.ForeColor, GetGlowSize() / 2, 0)
        ElseIf _forceRegularRendering Then
            Dim img As New Bitmap(bounds.X + bounds.Width, bounds.Y + bounds.Height)
            Dim g2 As Graphics = Graphics.FromImage(img)
            g2.TextRenderingHint = Drawing.Text.TextRenderingHint.AntiAliasGridFit
            g2.DrawString(Text, Me.Font, New SolidBrush(Me.ForeColor), bounds.X + GetGlowSize() / 2, bounds.Y + GetGlowSize() / 2)
            g2.Dispose()
            g.DrawImage(img, 0, 0)
            img.Dispose()
        Else
            g.DrawString(Text, Me.Font, New SolidBrush(Me.ForeColor), bounds.X + GetGlowSize() / 2, bounds.Y + GetGlowSize() / 2)
        End If
    End Sub

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub DesignDrawText(ByRef g As Graphics, ByVal bounds As Rectangle, ByVal Align As eAlign)
        Dim lines() As String = CheckNewLines(Me.Text)
        Dim lineHeight As Integer = bounds.Height / lines.Length
        Select Case Align
            Case eAlign.Left
                For i As Integer = 0 To lines.GetUpperBound(0)
                    DrawText(g, lines(i), New Rectangle(bounds.X, bounds.Y + (lineHeight * i), bounds.Width, lineHeight * 2))
                Next
            Case eAlign.Center
                For i As Integer = 0 To lines.GetUpperBound(0)
                    Dim textWidth As String = g.MeasureString(lines(i), Me.Font).ToSize.Width + GetGlowSize()
                    DrawText(g, lines(i), New Rectangle(bounds.X + ((bounds.Width / 2) - (textWidth / 2)), bounds.Y + (lineHeight * i), textWidth, lineHeight * 2))
                Next
            Case eAlign.Right
                For i As Integer = 0 To lines.GetUpperBound(0)
                    Dim textWidth As String = g.MeasureString(lines(i), Me.Font).ToSize.Width + GetGlowSize()
                    DrawText(g, lines(i), New Rectangle(bounds.X + (bounds.Width - textWidth), bounds.Y + (lineHeight * i), textWidth, lineHeight * 2))
                Next
        End Select
    End Sub

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Function CheckNewLines(ByVal Text As String) As String()
        Dim words() As String = System.Text.RegularExpressions.Regex.Split(Text, "[\ \	]", System.Text.RegularExpressions.RegexOptions.Compiled)
        CheckEmpty(words)
        If words.Length > 1 Then
            Dim g As Graphics = Me.CreateGraphics()
            Dim strBuffer As String() = {}
            Dim strLine As String = words(0)
            For i As Integer = 1 To words.GetUpperBound(0)
                If words(i).Contains(vbCrLf) Then
                    Dim tmp() As String = Split(words(i), vbCrLf)
                    For x As Integer = 0 To tmp.GetUpperBound(0)
                        ReDim Preserve strBuffer(strBuffer.GetUpperBound(0) + 1)
                        strBuffer(strBuffer.GetUpperBound(0)) = strLine & " " & tmp(x)
                        strLine = String.Empty
                    Next
                Else
                    If g.MeasureString(strLine & " " & words(i), Me.Font).ToSize.Width + GetGlowSize() >= Me.Width Then
                        ReDim Preserve strBuffer(strBuffer.GetUpperBound(0) + 1)
                        strBuffer(strBuffer.GetUpperBound(0)) = strLine
                        strLine = words(i)
                    Else
                        strLine &= " " & words(i)
                    End If
                End If
            Next
            ReDim Preserve strBuffer(strBuffer.GetUpperBound(0) + 1)
            strBuffer(strBuffer.GetUpperBound(0)) = strLine
            Return strBuffer
        ElseIf words.Length = 0 Then
            Return New String() {String.Empty}
        Else
            If words(0).Contains(vbCrLf) Then
                Return Split(words(0), vbCrLf)
            Else
                Return words
            End If
        End If
    End Function

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub CheckEmpty(ByRef arr As String())
        Dim buffer As String() = {}
        For i As Integer = 0 To arr.GetUpperBound(0)
            If Not String.IsNullOrEmpty(Trim(arr(i))) Then
                ReDim Preserve buffer(buffer.GetUpperBound(0) + 1)
                buffer(buffer.GetUpperBound(0)) = arr(i)
            End If
        Next
        arr = buffer
    End Sub

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Function GetGlowSize() As Integer
        Dim g As Graphics = Me.CreateGraphics()
        Return g.MeasureString("I", Me.Font).Height * 1.2
    End Function

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub GlassLabel_StyleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.StyleChanged
        Me.Invalidate()
    End Sub
End Class
