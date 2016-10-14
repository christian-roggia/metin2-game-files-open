Imports system.Runtime.InteropServices
Imports System.Drawing.Design
Imports System.Drawing.Imaging
Imports System.Drawing.Drawing2D
Imports System.Text
Imports System.Windows.Forms
Imports System.Diagnostics

Module GlassModule
    Private Const DTT_COMPOSITED As Integer = CInt((1 << 13))
    Private Const DTT_GLOWSIZE As Integer = CInt((1 << 11))
    Private Const DTT_TEXTCOLOR As Integer = 1

    'Text format consts
    Private Const DT_SINGLELINE As Integer = 32
    Private Const DT_CENTER As Integer = 1
    Private Const DT_VCENTER As Integer = 4
    Private Const DT_NOPREFIX As Integer = 2048

    'Const for BitBlt
    Private Const SRCCOPY As Integer = 13369376


    'Consts for CreateDIBSection
    Private Const BI_RGB As Integer = 0
    Private Const DIB_RGB_COLORS As Integer = 0
    'color table in RGBs

    Public Const WM_NCLBUTTONDOWN = &HA1
    Public Const HTCAPTION = 2

    Public Structure RECT
        Public Sub New(ByVal rect As Rectangle)
            MyClass.New(rect.Left, rect.Top, rect.Right, rect.Bottom)
        End Sub 'New

        <System.Diagnostics.DebuggerStepThrough()> _
        Public Sub New(ByVal left As Integer, ByVal top As Integer, ByVal right As Integer, ByVal bottom As Integer)
            Me.Left = left
            Me.Top = top
            Me.Right = right
            Me.Bottom = bottom
        End Sub 'New

        <System.Diagnostics.DebuggerStepThrough()> _
        Public Function ToRectangle() As Rectangle
            Return New Rectangle(Me.Left, Me.Top, Me.Right - Me.Left, Me.Bottom - Me.Top)
        End Function
        Public Left As Integer
        Public Top As Integer
        Public Right As Integer
        Public Bottom As Integer
    End Structure

    Public Structure Margins
        Dim Left As Integer
        Dim Right As Integer
        Dim Top As Integer
        Dim Bottom As Integer
        <System.Diagnostics.DebuggerStepThrough()> _
        Sub New(ByVal Left, ByVal Right, ByVal Top, ByVal Bottom)
            Me.Left = Left
            Me.Right = Right
            Me.Top = Top
            Me.Bottom = Bottom
        End Sub
    End Structure

    Private Structure DTTOPTS
        Public dwSize As UInteger
        Public dwFlags As UInteger
        Public crText As UInteger
        Public crBorder As UInteger
        Public crShadow As UInteger
        Public iTextShadowType As Integer
        Public ptShadowOffset As Point
        Public iBorderSize As Integer
        Public iFontPropId As Integer
        Public iColorPropId As Integer
        Public iStateId As Integer
        Public fApplyOverlay As Integer
        Public iGlowSize As Integer
        Public pfnDrawTextCallback As IntPtr
        Public lParam As Integer
    End Structure

    Public Structure BitmapInfo
        Public bmiHeader As BitmapInfoHeader
        Public bmiColors() As RGBQuad
    End Structure
    Public Structure RGBQuad
        Public rgbRed As Byte
        Public rgbGreen As Byte
        Public rgbBlue As Byte
        Public rgbReserved As Byte
    End Structure

    Public Structure BitmapInfoHeader
        Public biSize As Integer
        Public biWidth As Integer
        Public biHeight As Integer
        Public biPlanes As Short
        Public biBitCount As Short
        Public biCompression As Integer
        Public biSizeImage As Integer
        Public biXPelsPerMeter As Integer
        Public biYPelsPerMeter As Integer
        Public biClrUsed As Integer
        Public biClrImportant As Integer
    End Structure
    Private Declare Auto Function BitBlt Lib "GDI32.DLL" ( _
     ByVal hdcDest As IntPtr, _
     ByVal nXDest As Integer, _
     ByVal nYDest As Integer, _
     ByVal nWidth As Integer, _
     ByVal nHeight As Integer, _
     ByVal hdcSrc As IntPtr, _
     ByVal nXSrc As Integer, _
     ByVal nYSrc As Integer, _
     ByVal dwRop As Int32) As Boolean
    Public Declare Function SendMessage Lib "user32" Alias "SendMessageA" (ByVal hwnd As IntPtr, ByVal wMsg As UInteger, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As IntPtr
    Public Declare Function ReleaseCapture Lib "user32" () As IntPtr
    Private Declare Auto Function GetDC Lib "user32.dll" (ByVal hdc As IntPtr) As IntPtr
    Private Declare Unicode Function DrawThemeTextEx Lib "UxTheme.dll" (ByVal hTheme As IntPtr, ByVal hdc As IntPtr, ByVal iPartId As Integer, ByVal iStateId As Integer, ByVal text As String, ByVal iCharCount As Integer, _
     ByVal dwFlags As Integer, ByRef pRect As RECT, ByRef pOptions As DTTOPTS) As Integer
    Private Declare Auto Function DrawThemeText Lib "UxTheme.dll" (ByVal hTheme As IntPtr, ByVal hdc As IntPtr, ByVal iPartId As Integer, ByVal iStateId As Integer, ByVal text As String, ByVal iCharCount As Integer, _
     ByVal dwFlags1 As Integer, ByVal dwFlags2 As Integer, ByRef pRect As RECT) As Integer
    Private Declare Function ReleaseDC Lib "user32.dll" (ByVal hwnd As IntPtr, ByVal hdc As IntPtr) As IntPtr
    Private Declare Function DeleteDC Lib "gdi32" (ByVal hDC As Integer) As Integer
    Private Declare Function DeleteObject Lib "gdi32" (ByVal hObject As IntPtr) As Boolean
    Private Declare Function SelectObject Lib "gdi32" (ByVal hDC As Integer, ByVal hObject As Integer) As Integer
    Private Declare Function SaveDC Lib "gdi32.dll" (ByVal hdc As IntPtr) As Integer
    Private Declare Function CreateCompatibleDC Lib "gdi32.dll" (ByVal hdc As IntPtr) As IntPtr
    Private Declare Function CreateDIBSection Lib "gdi32" (ByVal hDC As Integer, ByRef pBitmapInfo As BitmapInfo, ByVal un As Integer, ByVal lplpVoid As Integer, ByVal handle As Integer, ByVal dw As Integer) As Integer
    <DllImport("dwmapi.dll", CharSet:=CharSet.Auto)> _
    Public Sub DwmIsCompositionEnabled(ByRef IsIt As Boolean)
    End Sub
    <DllImport("dwmapi.dll", CharSet:=CharSet.Auto)> _
    Public Function DwmExtendFrameIntoClientArea(ByVal hWnd As System.IntPtr, ByRef pMargins As Margins) As Integer
    End Function

    <System.Diagnostics.DebuggerHidden()> _
   Public Function ExtendGlass(ByVal form As Form, ByRef margins As Margins) As Integer
        Return DwmExtendFrameIntoClientArea(form.Handle, margins)
    End Function

    <System.Diagnostics.DebuggerHidden()> _
    Public Function ExtendGlass(ByVal form As Form, ByVal Left As Integer, ByVal Right As Integer, ByVal Top As Integer, ByVal Bottom As Integer) As Integer
        Return DwmExtendFrameIntoClientArea(form.Handle, New Margins(Left, Right, Top, Bottom))
    End Function

    <System.Diagnostics.DebuggerHidden()> _
    Public Sub FillBlackRegion(ByVal gph As Graphics, ByVal rgn As Rectangle)
        Dim rc As New Margins()
        rc.Left = rgn.Left
        rc.Right = rgn.Right
        rc.Top = rgn.Top
        rc.Bottom = rgn.Bottom

        Dim destdc As IntPtr = gph.GetHdc()
        'Just get the graphics' hdc and draw the bitmap on it
        Dim Memdc As IntPtr = CreateCompatibleDC(destdc)
        Dim bitmap As IntPtr
        Dim bitmapOld As IntPtr = IntPtr.Zero

        Dim dib As New BitmapInfo()
        dib.bmiHeader.biHeight = -(rc.Bottom - rc.Top)
        dib.bmiHeader.biWidth = rc.Right - rc.Left
        dib.bmiHeader.biPlanes = 1
        dib.bmiHeader.biSize = Marshal.SizeOf(GetType(BitmapInfoHeader))
        dib.bmiHeader.biBitCount = 32
        dib.bmiHeader.biCompression = 0
        If Not (SaveDC(Memdc) = 0) Then
            bitmap = CreateDIBSection(Memdc, dib, 0, 0, IntPtr.Zero, 0)
            If Not (bitmap = IntPtr.Zero) Then
                bitmapOld = SelectObject(Memdc, bitmap)



                BitBlt(destdc, rc.Left, rc.Top, rc.Right - rc.Left, rc.Bottom - rc.Top, Memdc, _
                 0, 0, &HCC0020)


                'Remember to clean up
                SelectObject(Memdc, bitmapOld)

                DeleteObject(bitmap)

                ReleaseDC(Memdc, -1)



                DeleteDC(Memdc)



            End If
        End If
        gph.ReleaseHdc()

    End Sub
    <System.Diagnostics.DebuggerHidden()> _
    Public Function CompositionEnabled() As Boolean
        'Return False
        If Environment.OSVersion.Version.Major < 6 Then
            Return False
        End If

        Dim bool As Boolean = False
        DwmIsCompositionEnabled(bool)
        Return bool


    End Function

    <System.Diagnostics.DebuggerHidden()> _
    Public Sub DrawGlowingText(ByVal Graphics As Graphics, ByVal text As String, ByVal fnt As Font, ByVal bounds As Rectangle, ByVal Clr As Color, ByVal iGlowSize As Integer, ByVal flags As TextFormatFlags)
        Dim primaryHdc As IntPtr = Graphics.GetHdc

        '


        '' Create a memory DC so we can work offscreen
        Dim memoryHdc As IntPtr = CreateCompatibleDC(primaryHdc)


        '' Create a device-independent bitmap and select it into our DC
        Dim info As BitmapInfo = New BitmapInfo
        info.bmiHeader.biSize = Marshal.SizeOf(info)
        info.bmiHeader.biWidth = bounds.Width
        info.bmiHeader.biHeight = -bounds.Height
        info.bmiHeader.biPlanes = 1
        info.bmiHeader.biBitCount = 32
        info.bmiHeader.biCompression = 0 '' BI_RGB
        Dim dib As IntPtr = CreateDIBSection(primaryHdc, info, 0, 0, IntPtr.Zero, 0)

        SelectObject(memoryHdc, dib)


        ' Create and select font
        Dim fontHandle As IntPtr = fnt.ToHfont
        SelectObject(memoryHdc, fontHandle)


        '' Draw glowing text
        Dim renderer As System.Windows.Forms.VisualStyles.VisualStyleRenderer = New System.Windows.Forms.VisualStyles.VisualStyleRenderer(System.Windows.Forms.VisualStyles.VisualStyleElement.Window.Caption.Active)

        Dim dttOpts As DTTOPTS = New DTTOPTS

        dttOpts.dwSize = Marshal.SizeOf(GetType(DTTOPTS))
        dttOpts.dwFlags = DTT_COMPOSITED Or DTT_GLOWSIZE Or DTT_TEXTCOLOR
        dttOpts.crText = ColorTranslator.ToWin32(Clr)
        dttOpts.iGlowSize = iGlowSize '' This is about the size Microsoft Word 2007 uses(15)
        Dim textBounds As RECT = New RECT(iGlowSize, iGlowSize, bounds.Right - bounds.Left, bounds.Bottom - bounds.Top)
        DrawThemeTextEx(renderer.Handle, memoryHdc, 0, 0, text, -1, flags, textBounds, dttOpts)
        'DrawThemeTextEx(renderer.Handle, memoryHdc, 0, 0, text, -1, (int)flags, ref textBounds, ref dttOpts);

        '' Copy to foreground
        Dim SRCCOPY As Integer = 13369376 ' old C# Value was: 0x00CC0020

        BitBlt(primaryHdc, bounds.Left, bounds.Top, bounds.Width, bounds.Height, memoryHdc, 0, 0, SRCCOPY)


        '' Clean up
        DeleteObject(fontHandle)
        DeleteObject(dib)
        DeleteDC(memoryHdc)

        Graphics.ReleaseHdc(primaryHdc)
    End Sub
End Module