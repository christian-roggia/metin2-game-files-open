Imports System.Drawing.Drawing2D
<System.Diagnostics.DebuggerStepThrough()> _
Public Class RoundedButton
#Region "Properties"
    Private _Shiny As Boolean = True
    Private _Radius As Integer = 10
    Private _TextRendering As Boolean = True
    Private hilit As Boolean = False
    Private down As Boolean = False
    Private hasfocus As Boolean = False
    Private Gradient As Color() = {System.Drawing.Color.Gainsboro, System.Drawing.Color.DarkGray, System.Drawing.Color.LightCyan, System.Drawing.Color.CadetBlue, Color.Black}

    <System.ComponentModel.DefaultValue(10)> _
    Public Property TraceRadius() As Integer
        <System.Diagnostics.DebuggerHidden()> _
        Get
            Return _Radius
        End Get
        <System.Diagnostics.DebuggerHidden()> _
        Set(ByVal value As Integer)
            If value <= IIf(Me.Height < Me.Width, Me.Height, Me.Width) Then
                _Radius = value
            ElseIf value < 1 Then
                _Radius = 1
            End If
            Me.Invalidate()
        End Set
    End Property
    <System.ComponentModel.DefaultValue(GetType(Cursor), "Hand")> _
    Public Overrides Property Cursor() As System.Windows.Forms.Cursor
        <System.Diagnostics.DebuggerHidden()> _
        Get
            Return MyBase.Cursor
        End Get
        <System.Diagnostics.DebuggerHidden()> _
        Set(ByVal value As System.Windows.Forms.Cursor)
            MyBase.Cursor = value
        End Set
    End Property
    Public Overrides Property Text() As String
        <System.Diagnostics.DebuggerHidden()> _
        Get
            Return MyBase.Text
        End Get
        <System.Diagnostics.DebuggerHidden()> _
        Set(ByVal value As String)
            MyBase.Text = value
            Me.Invalidate()
        End Set
    End Property
    Public Property Shiny() As Boolean
        <System.Diagnostics.DebuggerHidden()> _
        Get
            Return _Shiny
        End Get
        <System.Diagnostics.DebuggerHidden()> _
        Set(ByVal value As Boolean)
            _Shiny = value
            Me.Invalidate()
        End Set
    End Property
    Public Property Color1() As Color
        <System.Diagnostics.DebuggerHidden()> _
        Get
            Return Gradient(0)
        End Get
        <System.Diagnostics.DebuggerHidden()> _
        Set(ByVal value As Color)
            Gradient(0) = value
            Me.Invalidate()
        End Set
    End Property
    Public Property Color2() As Color
        <System.Diagnostics.DebuggerHidden()> _
        Get
            Return Gradient(1)
        End Get
        <System.Diagnostics.DebuggerHidden()> _
        Set(ByVal value As Color)
            Gradient(1) = value
            Me.Invalidate()
        End Set
    End Property
    Public Property HighlighColor1() As Color
        <System.Diagnostics.DebuggerHidden()> _
        Get
            Return Gradient(2)
        End Get
        <System.Diagnostics.DebuggerHidden()> _
        Set(ByVal value As Color)
            Gradient(2) = value
            Me.Invalidate()
        End Set
    End Property
    Public Property HighlightColor2() As Color
        <System.Diagnostics.DebuggerHidden()> _
        Get
            Return Gradient(3)
        End Get
        <System.Diagnostics.DebuggerHidden()> _
        Set(ByVal value As Color)
            Gradient(3) = value
            Me.Invalidate()
        End Set
    End Property
    Public Property BorderColor() As Color
        <System.Diagnostics.DebuggerHidden()> _
        Get
            Return Gradient(4)
        End Get
        <System.Diagnostics.DebuggerHidden()> _
        Set(ByVal value As Color)
            Gradient(4) = value
            Me.Invalidate()
        End Set
    End Property
    <System.ComponentModel.DefaultValue(True)> _
    Public Property UseCompatibleTextRendering() As Boolean
        <System.Diagnostics.DebuggerHidden()> _
        Get
            Return _TextRendering
        End Get
        <System.Diagnostics.DebuggerHidden()> _
        Set(ByVal value As Boolean)
            _TextRendering = value
            Me.Invalidate()
        End Set
    End Property
#End Region
#Region "Events"
    <System.Diagnostics.DebuggerStepThrough()> _
    Protected Overrides Sub OnMouseDown(ByVal e As System.Windows.Forms.MouseEventArgs)
        down = True
        Me.Focus()
        Me.Invalidate()
        MyBase.OnMouseDown(e)
    End Sub
    <System.Diagnostics.DebuggerStepThrough()> _
    Protected Overrides Sub OnMouseUp(ByVal e As System.Windows.Forms.MouseEventArgs)
        down = False
        Me.Invalidate()
        MyBase.OnMouseUp(e)
        Me.Focus()
    End Sub
    <System.Diagnostics.DebuggerStepThrough()> _
    Protected Overrides Sub OnMouseEnter(ByVal e As System.EventArgs)
        hilit = True
        Me.Invalidate()
        MyBase.OnMouseEnter(e)
    End Sub
    <System.Diagnostics.DebuggerStepThrough()> _
    Protected Overrides Sub OnMouseLeave(ByVal e As System.EventArgs)
        hilit = False
        Me.Invalidate()
        MyBase.OnMouseLeave(e)
    End Sub

    <System.Diagnostics.DebuggerStepThrough()> _
    Protected Overrides Sub OnKeyDown(ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Space Or e.KeyCode = Keys.Enter Then
            down = True
            Me.Invalidate()
        End If
        MyBase.OnKeyDown(e)
    End Sub
    <System.Diagnostics.DebuggerStepThrough()> _
    Protected Overrides Sub OnKeyUp(ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Space Or e.KeyCode = Keys.Enter Then
            down = False
            Me.Invalidate()
            Me.PerformClick()
        End If
        MyBase.OnKeyUp(e)
    End Sub
    <System.Diagnostics.DebuggerNonUserCode()> _
    Public Sub PerformClick()
        MyBase.OnClick(EventArgs.Empty)
    End Sub
    <System.Diagnostics.DebuggerStepThrough()> _
    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        Dim g As Graphics = e.Graphics
        Dim gp As New GraphicsPath(FillMode.Winding)

        gp.AddArc(0, 0, _Radius * 2, _Radius * 2, 180, 90)
        gp.AddArc(Me.Width - _Radius * 2 - 1, 0, _Radius * 2, _Radius * 2, 270, 90)
        gp.AddArc(Me.Width - _Radius * 2 - 1, Me.Height - _Radius * 2 - 1, _Radius * 2, _Radius * 2, 0, 90)
        gp.AddArc(0, Me.Height - _Radius * 2 - 1, _Radius * 2, _Radius * 2, 90, 90)
        gp.CloseFigure()
        g.SmoothingMode = SmoothingMode.AntiAlias
        If Me.Enabled Then
            g.FillPath(New LinearGradientBrush(New Rectangle(0, 0, Me.Width, Me.Height), CType(IIf(hilit, IIf(down, Gradient(3), Gradient(2)), Gradient(0)), Color), CType(IIf(hilit, IIf(down, Gradient(2), Gradient(3)), Gradient(1)), Color), LinearGradientMode.Vertical), gp)
        Else
            g.FillPath(New LinearGradientBrush(New Rectangle(0, 0, Me.Width, Me.Height), Color.Gainsboro, Color.Silver, LinearGradientMode.Vertical), gp)
        End If

        If _Shiny Then
            Dim gp2 As New GraphicsPath(FillMode.Winding)
            gp2.AddArc(0, 0, _Radius * 2, _Radius * 2, 180, 90)
            gp2.AddArc(Me.Width - _Radius * 2 - 1, 0, _Radius * 2, _Radius * 2, 270, 90)
            gp2.AddLine(Convert.ToSingle(Me.Width - 1), Convert.ToSingle(Me.Height / 2), 0, Convert.ToSingle(Me.Height / 2))
            g.FillPath(New LinearGradientBrush(New Point(0, 0), New Point(0, Me.Height * 0.55), Color.FromArgb(200, Color.White), Color.FromArgb(80, Color.White)), gp2)
        End If
        Dim p As New Pen(Gradient(4))
        g.DrawPath(p, gp)
        If hasfocus Then
            gp = New GraphicsPath(FillMode.Winding)
            Dim pB As New Pen(Color.Black)
            pB.DashCap = DashCap.Round
            pB.DashStyle = DashStyle.Dot
            Dim bRadius As Integer = _Radius * 2 - 2
            If bRadius < 1 Then bRadius = 1
            GPArc(gp, 2, 2, bRadius, bRadius, 180, 90)
            GPArc(gp, Me.Width - _Radius * 2 - 1, 2, bRadius, bRadius, 270, 90)
            GPArc(gp, Me.Width - _Radius * 2 - 1, Me.Height - _Radius * 2 - 1, bRadius, bRadius, 0, 90)
            GPArc(gp, 2, Me.Height - _Radius * 2 - 1, bRadius, bRadius, 90, 90)
            gp.CloseFigure()
            g.DrawPath(pB, gp)
        End If

        PaintText(g)
    End Sub
    <System.Diagnostics.DebuggerStepThrough()> _
    Protected Overrides Sub OnGotFocus(ByVal e As System.EventArgs)
        hasfocus = True
        Me.Invalidate()
        MyBase.OnGotFocus(e)
    End Sub
    <System.Diagnostics.DebuggerStepThrough()> _
    Protected Overrides Sub OnLostFocus(ByVal e As System.EventArgs)
        hasfocus = False
        hilit = False
        Me.Invalidate()
        MyBase.OnLostFocus(e)
    End Sub
#End Region
#Region "Routines"
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub PaintText(ByRef g As Graphics)
        If Me.UseCompatibleTextRendering Then
            g.TextRenderingHint = Drawing.Text.TextRenderingHint.ClearTypeGridFit
        Else
            g.TextRenderingHint = Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit
        End If
        Dim rect As New Rectangle()
        Dim textSize As Size = g.MeasureString(Replace(Me.Text, vbCrLf, String.Empty), Me.Font).ToSize
        textSize.Height *= CheckNewLines(g, Me.Text).Length
        rect.Size = textSize
        rect.X = (Me.Width / 2) - (rect.Width / 2)
        rect.Y = (Me.Height / 2) - (rect.Height / 2)
        DesignDrawText(g, rect)
    End Sub
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub DrawText(ByRef g As Graphics, ByVal Text As String, ByVal bounds As Rectangle)
        If Me.Enabled Then
            g.DrawString(Text, Me.Font, New SolidBrush(Me.ForeColor), bounds.X, bounds.Y)
        Else
            g.DrawString(Text, Me.Font, New SolidBrush(Color.Gray), bounds.X, bounds.Y)
        End If
    End Sub

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub DesignDrawText(ByRef g As Graphics, ByVal bounds As Rectangle)
        Dim lines() As String = CheckNewLines(g, Me.Text)
        Dim lineHeight As Integer = bounds.Height / lines.Length
        For i As Integer = 0 To lines.GetUpperBound(0)
            Dim textWidth As String = g.MeasureString(lines(i), Me.Font).ToSize.Width
            DrawText(g, lines(i), New Rectangle(bounds.X + ((bounds.Width / 2) - (textWidth / 2)), bounds.Y + (lineHeight * i), textWidth, lineHeight * 2))
        Next
    End Sub

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Function CheckNewLines(ByRef g As Graphics, ByVal Text As String) As String()
        Dim words() As String = System.Text.RegularExpressions.Regex.Split(Text, "[\ \	]", System.Text.RegularExpressions.RegexOptions.Compiled)
        CheckEmpty(words)
        If words.Length > 1 Then
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
                    If g.MeasureString(strLine & " " & words(i), Me.Font).ToSize.Width >= Me.Width Then
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
    Private Sub GPAddPie(ByRef gp As GraphicsPath, ByVal x As Double, ByVal y As Double, ByVal width As Double, ByVal height As Double, ByVal startangle As Single, ByVal sweepangle As Single)
        gp.AddPie(Convert.ToSingle(x), Convert.ToSingle(y), Convert.ToSingle(width), Convert.ToSingle(height), startangle, sweepangle)
    End Sub
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub GArc(ByRef g As Graphics, ByVal p As Pen, ByVal x As Double, ByVal y As Double, ByVal width As Double, ByVal height As Double, ByVal startangle As Single, ByVal sweepangle As Single)
        g.DrawArc(p, Convert.ToSingle(x), Convert.ToSingle(y), Convert.ToSingle(width), Convert.ToSingle(height), startangle, sweepangle)
    End Sub
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub GLine(ByRef g As Graphics, ByVal p As Pen, ByVal x1 As Double, ByVal y1 As Double, ByVal x2 As Double, ByVal y2 As Double)
        g.DrawLine(p, Convert.ToSingle(x1), Convert.ToSingle(y1), Convert.ToSingle(x2), Convert.ToSingle(y2))
    End Sub
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub GPArc(ByRef gp As GraphicsPath, ByVal x As Double, ByVal y As Double, ByVal width As Double, ByVal height As Double, ByVal startangle As Single, ByVal sweepangle As Single)
        gp.AddArc(Convert.ToSingle(x), Convert.ToSingle(y), Convert.ToSingle(width), Convert.ToSingle(height), startangle, sweepangle)
    End Sub
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub GPLine(ByRef gp As GraphicsPath, ByVal x1 As Double, ByVal y1 As Double, ByVal x2 As Double, ByVal y2 As Double)
        gp.AddLine(Convert.ToSingle(x1), Convert.ToSingle(y1), Convert.ToSingle(x2), Convert.ToSingle(y2))
    End Sub
#End Region
End Class
