<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSettings
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Search1 = New GFO.RoundedButton()
        Me.Manual1 = New System.Windows.Forms.RadioButton()
        Me.Auto1 = New System.Windows.Forms.RadioButton()
        Me.Save1 = New GFO.RoundedButton()
        Me.Exit1 = New GFO.RoundedButton()
        Me.dll = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DeleteOpen1 = New System.Windows.Forms.RadioButton()
        Me.DeleteAction1 = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.LanguageBox = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Search1)
        Me.GroupBox1.Controls.Add(Me.Manual1)
        Me.GroupBox1.Controls.Add(Me.Auto1)
        Me.GroupBox1.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(283, 97)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Option Auto Patcher"
        '
        'Search1
        '
        Me.Search1.BorderColor = System.Drawing.Color.Black
        Me.Search1.Color1 = System.Drawing.Color.Gainsboro
        Me.Search1.Color2 = System.Drawing.Color.DarkGray
        Me.Search1.Enabled = False
        Me.Search1.ForeColor = System.Drawing.Color.Blue
        Me.Search1.HighlighColor1 = System.Drawing.Color.LightCyan
        Me.Search1.HighlightColor2 = System.Drawing.Color.CadetBlue
        Me.Search1.Location = New System.Drawing.Point(41, 68)
        Me.Search1.Name = "Search1"
        Me.Search1.Shiny = True
        Me.Search1.Size = New System.Drawing.Size(197, 20)
        Me.Search1.TabIndex = 10
        Me.Search1.Text = "Search a new version"
        Me.Search1.TraceRadius = 2
        '
        'Manual1
        '
        Me.Manual1.AutoSize = True
        Me.Manual1.ForeColor = System.Drawing.Color.Red
        Me.Manual1.Location = New System.Drawing.Point(6, 42)
        Me.Manual1.Name = "Manual1"
        Me.Manual1.Size = New System.Drawing.Size(172, 20)
        Me.Manual1.TabIndex = 9
        Me.Manual1.Text = "Search manually new version"
        Me.Manual1.UseVisualStyleBackColor = True
        '
        'Auto1
        '
        Me.Auto1.AutoSize = True
        Me.Auto1.ForeColor = System.Drawing.Color.Black
        Me.Auto1.Location = New System.Drawing.Point(6, 19)
        Me.Auto1.Name = "Auto1"
        Me.Auto1.Size = New System.Drawing.Size(193, 20)
        Me.Auto1.TabIndex = 8
        Me.Auto1.Text = "Search automatically new version"
        Me.Auto1.UseVisualStyleBackColor = True
        '
        'Save1
        '
        Me.Save1.BackColor = System.Drawing.Color.Transparent
        Me.Save1.BorderColor = System.Drawing.Color.Black
        Me.Save1.Color1 = System.Drawing.Color.Gainsboro
        Me.Save1.Color2 = System.Drawing.Color.DarkGray
        Me.Save1.Enabled = False
        Me.Save1.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Save1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Save1.HighlighColor1 = System.Drawing.Color.LightCyan
        Me.Save1.HighlightColor2 = System.Drawing.Color.CadetBlue
        Me.Save1.Location = New System.Drawing.Point(12, 251)
        Me.Save1.Name = "Save1"
        Me.Save1.Shiny = True
        Me.Save1.Size = New System.Drawing.Size(90, 20)
        Me.Save1.TabIndex = 1
        Me.Save1.Text = "Save"
        Me.Save1.TraceRadius = 2
        '
        'Exit1
        '
        Me.Exit1.BackColor = System.Drawing.Color.Transparent
        Me.Exit1.BorderColor = System.Drawing.Color.Black
        Me.Exit1.Color1 = System.Drawing.Color.Gainsboro
        Me.Exit1.Color2 = System.Drawing.Color.DarkGray
        Me.Exit1.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Exit1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Exit1.HighlighColor1 = System.Drawing.Color.LightCyan
        Me.Exit1.HighlightColor2 = System.Drawing.Color.CadetBlue
        Me.Exit1.Location = New System.Drawing.Point(205, 251)
        Me.Exit1.Name = "Exit1"
        Me.Exit1.Shiny = True
        Me.Exit1.Size = New System.Drawing.Size(90, 19)
        Me.Exit1.TabIndex = 2
        Me.Exit1.Text = "Exit"
        Me.Exit1.TraceRadius = 2
        '
        'dll
        '
        Me.dll.Location = New System.Drawing.Point(12, 390)
        Me.dll.Name = "dll"
        Me.dll.Size = New System.Drawing.Size(223, 20)
        Me.dll.TabIndex = 3
        Me.dll.Text = "0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.dll.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.DeleteOpen1)
        Me.GroupBox2.Controls.Add(Me.DeleteAction1)
        Me.GroupBox2.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(12, 115)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(283, 64)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Option delete file"
        '
        'DeleteOpen1
        '
        Me.DeleteOpen1.AutoSize = True
        Me.DeleteOpen1.ForeColor = System.Drawing.Color.Red
        Me.DeleteOpen1.Location = New System.Drawing.Point(6, 41)
        Me.DeleteOpen1.Name = "DeleteOpen1"
        Me.DeleteOpen1.Size = New System.Drawing.Size(200, 20)
        Me.DeleteOpen1.TabIndex = 1
        Me.DeleteOpen1.TabStop = True
        Me.DeleteOpen1.Text = "Delete files with each new opening"
        Me.DeleteOpen1.UseVisualStyleBackColor = True
        '
        'DeleteAction1
        '
        Me.DeleteAction1.AutoSize = True
        Me.DeleteAction1.ForeColor = System.Drawing.Color.Black
        Me.DeleteAction1.Location = New System.Drawing.Point(6, 18)
        Me.DeleteAction1.Name = "DeleteAction1"
        Me.DeleteAction1.Size = New System.Drawing.Size(144, 20)
        Me.DeleteAction1.TabIndex = 0
        Me.DeleteAction1.TabStop = True
        Me.DeleteAction1.Text = "Delete file to any action"
        Me.DeleteAction1.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.LanguageBox)
        Me.GroupBox3.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Black
        Me.GroupBox3.Location = New System.Drawing.Point(12, 185)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(128, 50)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Language"
        '
        'LanguageBox
        '
        Me.LanguageBox.ForeColor = System.Drawing.Color.Black
        Me.LanguageBox.FormattingEnabled = True
        Me.LanguageBox.Items.AddRange(New Object() {"English", "Italiano", "Français", "Deutsch", "Polska", "Other..."})
        Me.LanguageBox.Location = New System.Drawing.Point(6, 20)
        Me.LanguageBox.Name = "LanguageBox"
        Me.LanguageBox.Size = New System.Drawing.Size(114, 24)
        Me.LanguageBox.TabIndex = 0
        Me.LanguageBox.Text = "English"
        '
        'frmSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(307, 283)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.dll)
        Me.Controls.Add(Me.Exit1)
        Me.Controls.Add(Me.Save1)
        Me.Controls.Add(Me.GroupBox1)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "frmSettings"
        Me.Text = "General option"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Save1 As RoundedButton
    Friend WithEvents Exit1 As RoundedButton
    Friend WithEvents Search1 As RoundedButton
    Friend WithEvents Manual1 As System.Windows.Forms.RadioButton
    Friend WithEvents Auto1 As System.Windows.Forms.RadioButton
    Friend WithEvents dll As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DeleteOpen1 As System.Windows.Forms.RadioButton
    Friend WithEvents DeleteAction1 As System.Windows.Forms.RadioButton

    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents LanguageBox As System.Windows.Forms.ComboBox



End Class
