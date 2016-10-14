<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmScansion
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Disasm1 = New GFO.RoundedButton()
        Me.Decrypt1 = New GFO.RoundedButton()
        Me.Demap1 = New GFO.RoundedButton()
        Me.Unknown1 = New GFO.RoundedButton()
        Me.Menage1 = New GFO.RoundedButton()
        Me.Size1 = New System.Windows.Forms.TextBox()
        Me.MD51 = New System.Windows.Forms.TextBox()
        Me.Magic1 = New System.Windows.Forms.TextBox()
        Me.Name1 = New System.Windows.Forms.TextBox()
        Me.Type1 = New System.Windows.Forms.TextBox()
        Me.Extension1 = New System.Windows.Forms.TextBox()
        Me.Path1 = New System.Windows.Forms.TextBox()
        Me.BW1 = New System.ComponentModel.BackgroundWorker()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.Label1.Size = New System.Drawing.Size(62, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Extension"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(336, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Padding = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.Label2.Size = New System.Drawing.Size(40, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Type"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 140)
        Me.Label3.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.Label3.Name = "Label3"
        Me.Label3.Padding = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.Label3.Size = New System.Drawing.Size(35, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Path"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(180, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Padding = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.Label4.Size = New System.Drawing.Size(43, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(177, 83)
        Me.Label5.Name = "Label5"
        Me.Label5.Padding = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.Label5.Size = New System.Drawing.Size(46, 16)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Magic"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(336, 20)
        Me.Label7.Name = "Label7"
        Me.Label7.Padding = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.Label7.Size = New System.Drawing.Size(40, 16)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "MD5"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(9, 83)
        Me.Label8.Name = "Label8"
        Me.Label8.Padding = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.Label8.Size = New System.Drawing.Size(36, 16)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Size"
        '
        'Disasm1
        '
        Me.Disasm1.BackColor = System.Drawing.Color.Transparent
        Me.Disasm1.BorderColor = System.Drawing.Color.Black
        Me.Disasm1.Color1 = System.Drawing.Color.Gainsboro
        Me.Disasm1.Color2 = System.Drawing.Color.DarkGray
        Me.Disasm1.Enabled = False
        Me.Disasm1.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Disasm1.ForeColor = System.Drawing.Color.Red
        Me.Disasm1.HighlighColor1 = System.Drawing.Color.LightCyan
        Me.Disasm1.HighlightColor2 = System.Drawing.Color.CadetBlue
        Me.Disasm1.Location = New System.Drawing.Point(336, 162)
        Me.Disasm1.Margin = New System.Windows.Forms.Padding(3, 3, 3, 8)
        Me.Disasm1.Name = "Disasm1"
        Me.Disasm1.Shiny = True
        Me.Disasm1.Size = New System.Drawing.Size(121, 20)
        Me.Disasm1.TabIndex = 73
        Me.Disasm1.Text = "Disassemblation"
        Me.Disasm1.TraceRadius = 2
        Me.Disasm1.Visible = False
        '
        'Decrypt1
        '
        Me.Decrypt1.BackColor = System.Drawing.Color.Transparent
        Me.Decrypt1.BorderColor = System.Drawing.Color.Black
        Me.Decrypt1.Color1 = System.Drawing.Color.Gainsboro
        Me.Decrypt1.Color2 = System.Drawing.Color.DarkGray
        Me.Decrypt1.Enabled = False
        Me.Decrypt1.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Decrypt1.ForeColor = System.Drawing.Color.Blue
        Me.Decrypt1.HighlighColor1 = System.Drawing.Color.LightCyan
        Me.Decrypt1.HighlightColor2 = System.Drawing.Color.CadetBlue
        Me.Decrypt1.Location = New System.Drawing.Point(336, 162)
        Me.Decrypt1.Name = "Decrypt1"
        Me.Decrypt1.Shiny = True
        Me.Decrypt1.Size = New System.Drawing.Size(81, 20)
        Me.Decrypt1.TabIndex = 72
        Me.Decrypt1.Text = "Decryption"
        Me.Decrypt1.TraceRadius = 2
        Me.Decrypt1.Visible = False
        '
        'Demap1
        '
        Me.Demap1.BackColor = System.Drawing.Color.Transparent
        Me.Demap1.BorderColor = System.Drawing.Color.Black
        Me.Demap1.Color1 = System.Drawing.Color.Gainsboro
        Me.Demap1.Color2 = System.Drawing.Color.DarkGray
        Me.Demap1.Enabled = False
        Me.Demap1.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Demap1.ForeColor = System.Drawing.Color.Blue
        Me.Demap1.HighlighColor1 = System.Drawing.Color.LightCyan
        Me.Demap1.HighlightColor2 = System.Drawing.Color.CadetBlue
        Me.Demap1.Location = New System.Drawing.Point(336, 162)
        Me.Demap1.Name = "Demap1"
        Me.Demap1.Shiny = True
        Me.Demap1.Size = New System.Drawing.Size(99, 20)
        Me.Demap1.TabIndex = 71
        Me.Demap1.Text = "Demappation"
        Me.Demap1.TraceRadius = 2
        Me.Demap1.Visible = False
        '
        'Unknown1
        '
        Me.Unknown1.BackColor = System.Drawing.Color.Transparent
        Me.Unknown1.BorderColor = System.Drawing.Color.Black
        Me.Unknown1.Color1 = System.Drawing.Color.Gainsboro
        Me.Unknown1.Color2 = System.Drawing.Color.DarkGray
        Me.Unknown1.Enabled = False
        Me.Unknown1.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Unknown1.ForeColor = System.Drawing.Color.Red
        Me.Unknown1.HighlighColor1 = System.Drawing.Color.LightCyan
        Me.Unknown1.HighlightColor2 = System.Drawing.Color.CadetBlue
        Me.Unknown1.Location = New System.Drawing.Point(336, 162)
        Me.Unknown1.Margin = New System.Windows.Forms.Padding(3, 3, 3, 8)
        Me.Unknown1.Name = "Unknown1"
        Me.Unknown1.Shiny = True
        Me.Unknown1.Size = New System.Drawing.Size(78, 20)
        Me.Unknown1.TabIndex = 74
        Me.Unknown1.Text = "Unknown"
        Me.Unknown1.TraceRadius = 2
        Me.Unknown1.Visible = False
        '
        'Menage1
        '
        Me.Menage1.BackColor = System.Drawing.Color.Transparent
        Me.Menage1.BorderColor = System.Drawing.Color.Black
        Me.Menage1.Color1 = System.Drawing.Color.Gainsboro
        Me.Menage1.Color2 = System.Drawing.Color.DarkGray
        Me.Menage1.Enabled = False
        Me.Menage1.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Menage1.ForeColor = System.Drawing.Color.Blue
        Me.Menage1.HighlighColor1 = System.Drawing.Color.LightCyan
        Me.Menage1.HighlightColor2 = System.Drawing.Color.CadetBlue
        Me.Menage1.Location = New System.Drawing.Point(336, 162)
        Me.Menage1.Name = "Menage1"
        Me.Menage1.Shiny = True
        Me.Menage1.Size = New System.Drawing.Size(65, 20)
        Me.Menage1.TabIndex = 75
        Me.Menage1.Text = "Menage"
        Me.Menage1.TraceRadius = 2
        Me.Menage1.Visible = False
        '
        'Size1
        '
        Me.Size1.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Size1.Location = New System.Drawing.Point(12, 102)
        Me.Size1.Name = "Size1"
        Me.Size1.ReadOnly = True
        Me.Size1.Size = New System.Drawing.Size(100, 22)
        Me.Size1.TabIndex = 81
        '
        'MD51
        '
        Me.MD51.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MD51.Location = New System.Drawing.Point(336, 39)
        Me.MD51.Name = "MD51"
        Me.MD51.ReadOnly = True
        Me.MD51.Size = New System.Drawing.Size(214, 22)
        Me.MD51.TabIndex = 80
        '
        'Magic1
        '
        Me.Magic1.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Magic1.Location = New System.Drawing.Point(180, 102)
        Me.Magic1.Name = "Magic1"
        Me.Magic1.ReadOnly = True
        Me.Magic1.Size = New System.Drawing.Size(100, 22)
        Me.Magic1.TabIndex = 79
        '
        'Name1
        '
        Me.Name1.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name1.Location = New System.Drawing.Point(183, 39)
        Me.Name1.Name = "Name1"
        Me.Name1.ReadOnly = True
        Me.Name1.Size = New System.Drawing.Size(100, 22)
        Me.Name1.TabIndex = 78
        '
        'Type1
        '
        Me.Type1.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Type1.Location = New System.Drawing.Point(336, 102)
        Me.Type1.Name = "Type1"
        Me.Type1.ReadOnly = True
        Me.Type1.Size = New System.Drawing.Size(214, 22)
        Me.Type1.TabIndex = 77
        '
        'Extension1
        '
        Me.Extension1.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Extension1.Location = New System.Drawing.Point(12, 39)
        Me.Extension1.Name = "Extension1"
        Me.Extension1.ReadOnly = True
        Me.Extension1.Size = New System.Drawing.Size(100, 22)
        Me.Extension1.TabIndex = 76
        '
        'Path1
        '
        Me.Path1.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Path1.Location = New System.Drawing.Point(12, 162)
        Me.Path1.Name = "Path1"
        Me.Path1.ReadOnly = True
        Me.Path1.Size = New System.Drawing.Size(291, 22)
        Me.Path1.TabIndex = 82
        '
        'BW1
        '
        Me.BW1.WorkerReportsProgress = True
        '
        'frmScansion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(574, 193)
        Me.Controls.Add(Me.Path1)
        Me.Controls.Add(Me.Size1)
        Me.Controls.Add(Me.MD51)
        Me.Controls.Add(Me.Magic1)
        Me.Controls.Add(Me.Name1)
        Me.Controls.Add(Me.Type1)
        Me.Controls.Add(Me.Extension1)
        Me.Controls.Add(Me.Menage1)
        Me.Controls.Add(Me.Unknown1)
        Me.Controls.Add(Me.Disasm1)
        Me.Controls.Add(Me.Decrypt1)
        Me.Controls.Add(Me.Demap1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmScansion"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Scansion file"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label

    Friend WithEvents Label3 As System.Windows.Forms.Label

    Friend WithEvents Label4 As System.Windows.Forms.Label

    Friend WithEvents Label5 As System.Windows.Forms.Label



    Friend WithEvents Label7 As System.Windows.Forms.Label

    Friend WithEvents Label8 As System.Windows.Forms.Label

    Friend WithEvents Disasm1 As GFO.RoundedButton
    Friend WithEvents Decrypt1 As GFO.RoundedButton
    Friend WithEvents Demap1 As GFO.RoundedButton
    Friend WithEvents Unknown1 As GFO.RoundedButton
    Friend WithEvents Menage1 As GFO.RoundedButton
    Friend WithEvents Size1 As System.Windows.Forms.TextBox
    Friend WithEvents MD51 As System.Windows.Forms.TextBox
    Friend WithEvents Magic1 As System.Windows.Forms.TextBox
    Friend WithEvents Name1 As System.Windows.Forms.TextBox
    Friend WithEvents Type1 As System.Windows.Forms.TextBox
    Friend WithEvents Extension1 As System.Windows.Forms.TextBox
    Friend WithEvents Path1 As System.Windows.Forms.TextBox
    Friend WithEvents BW1 As System.ComponentModel.BackgroundWorker


End Class
