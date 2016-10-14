<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SpecialFile
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SpecialFile))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.item_down1 = New System.Windows.Forms.Button
        Me.Label27 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.address1 = New System.Windows.Forms.Button
        Me.item_up1 = New System.Windows.Forms.Button
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Button3 = New System.Windows.Forms.Button
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.item_down1)
        Me.GroupBox2.Controls.Add(Me.Label27)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.address1)
        Me.GroupBox2.Controls.Add(Me.item_up1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(319, 253)
        Me.GroupBox2.TabIndex = 46
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "File Speciali"
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Location = New System.Drawing.Point(179, 73)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(129, 21)
        Me.Button1.TabIndex = 52
        Me.Button1.Text = "Ricompatta mob_proto"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Enabled = False
        Me.Button2.Location = New System.Drawing.Point(9, 73)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(129, 21)
        Me.Button2.TabIndex = 50
        Me.Button2.Text = "Scompatta mob_proto"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'item_down1
        '
        Me.item_down1.Location = New System.Drawing.Point(179, 46)
        Me.item_down1.Name = "item_down1"
        Me.item_down1.Size = New System.Drawing.Size(129, 21)
        Me.item_down1.TabIndex = 49
        Me.item_down1.Text = "Ricompatta item_proto"
        Me.item_down1.UseVisualStyleBackColor = True
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(6, 16)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(209, 13)
        Me.Label27.TabIndex = 48
        Me.Label27.Text = "Ricordati di scompilare prima il file locale_it!"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 146)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(264, 104)
        Me.Label10.TabIndex = 47
        Me.Label10.Text = resources.GetString("Label10.Text")
        '
        'address1
        '
        Me.address1.Location = New System.Drawing.Point(94, 113)
        Me.address1.Name = "address1"
        Me.address1.Size = New System.Drawing.Size(121, 21)
        Me.address1.TabIndex = 46
        Me.address1.Text = "Apri locale_it.addr"
        Me.address1.UseVisualStyleBackColor = True
        '
        'item_up1
        '
        Me.item_up1.Location = New System.Drawing.Point(9, 46)
        Me.item_up1.Name = "item_up1"
        Me.item_up1.Size = New System.Drawing.Size(130, 21)
        Me.item_up1.TabIndex = 45
        Me.item_up1.Text = "Scompatta item_proto"
        Me.item_up1.UseVisualStyleBackColor = True
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(100, 389)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(71, 20)
        Me.TextBox3.TabIndex = 51
        Me.TextBox3.Text = resources.GetString("TextBox3.Text")
        Me.TextBox3.Visible = False
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(22, 389)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(71, 20)
        Me.TextBox2.TabIndex = 50
        Me.TextBox2.Text = "<Buildfile version=""1.1"">" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "<Action type=""item_proto_create"" path=""Black\XML\item_" & _
            "proto.xml"" output=""Black\OutFile\locale_it\locale\it\item_proto"" /> " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "</Buildf" & _
            "ile>"
        Me.TextBox2.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(177, 389)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(70, 20)
        Me.TextBox1.TabIndex = 49
        Me.TextBox1.Text = resources.GetString("TextBox1.Text")
        Me.TextBox1.Visible = False
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(137, 271)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(60, 21)
        Me.Button3.TabIndex = 52
        Me.Button3.Text = "Esci"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'SpecialFile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(343, 298)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "SpecialFile"
        Me.Text = "File Speciali"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents item_down1 As System.Windows.Forms.Button
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents address1 As System.Windows.Forms.Button
    Friend WithEvents item_up1 As System.Windows.Forms.Button
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
