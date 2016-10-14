<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Lato_Client2
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
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Sfoglia_txt1 = New System.Windows.Forms.TextBox
        Me.text_out1 = New System.Windows.Forms.TextBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Save1 = New System.Windows.Forms.Button
        Me.Close1 = New System.Windows.Forms.Button
        Me.Undo1 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.Enabled = False
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Chat - Normale", "Chat - Info", "Chat - Notizia", "Chat - Gruppo", "Chat - Gilda", "Chat - Comandi", "Chat - Shout", "Chat - Privata", "Nome - Mob", "Nome - NPC", "Nome - Player", "Nome - PK", "Nome - PvP", "Nome - Party", "Nome - Warp", "Nome - Waypoint", "Nome - Mob - Altro regno", "Nome - NPC - Altro regno", "Nome - Player - Shinsoo", "Nome - Player - Chunjo", "Nome - Player - Jinno", "Player - Cavaliere", "Player - Nobile", "Player - Buono", "Player - Gentile", "Player - Normale", "Player - Aggressivo", "Player - Perfido", "Player - Maligno", "Player - Crudele"})
        Me.ComboBox1.Location = New System.Drawing.Point(12, 12)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(192, 21)
        Me.ComboBox1.TabIndex = 0
        Me.ComboBox1.Text = "Chat - Normale"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(242, 51)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(69, 21)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Sfoglia"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Sfoglia_txt1
        '
        Me.Sfoglia_txt1.Enabled = False
        Me.Sfoglia_txt1.Location = New System.Drawing.Point(12, 51)
        Me.Sfoglia_txt1.Name = "Sfoglia_txt1"
        Me.Sfoglia_txt1.Size = New System.Drawing.Size(224, 20)
        Me.Sfoglia_txt1.TabIndex = 2
        '
        'text_out1
        '
        Me.text_out1.Location = New System.Drawing.Point(12, 462)
        Me.text_out1.Multiline = True
        Me.text_out1.Name = "text_out1"
        Me.text_out1.Size = New System.Drawing.Size(47, 20)
        Me.text_out1.TabIndex = 54
        Me.text_out1.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.text_out1.Visible = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(212, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(99, 21)
        Me.Button2.TabIndex = 55
        Me.Button2.Text = "Scegli colore"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ColorDialog1
        '
        Me.ColorDialog1.Color = System.Drawing.Color.Lime
        Me.ColorDialog1.FullOpen = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(12, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(16, 13)
        Me.Label1.TabIndex = 56
        Me.Label1.Text = "R"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Lime
        Me.Label2.Location = New System.Drawing.Point(99, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(16, 13)
        Me.Label2.TabIndex = 57
        Me.Label2.Text = "G"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(184, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(15, 13)
        Me.Label3.TabIndex = 58
        Me.Label3.Text = "B"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Blue
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(205, 81)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 18)
        Me.Label4.TabIndex = 61
        Me.Label4.Text = "Null"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Lime
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(120, 81)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 18)
        Me.Label5.TabIndex = 60
        Me.Label5.Text = "Null"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Red
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(33, 81)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 18)
        Me.Label6.TabIndex = 59
        Me.Label6.Text = "Null"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 115)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox1.Size = New System.Drawing.Size(299, 300)
        Me.TextBox1.TabIndex = 62
        '
        'Save1
        '
        Me.Save1.Enabled = False
        Me.Save1.Location = New System.Drawing.Point(15, 421)
        Me.Save1.Name = "Save1"
        Me.Save1.Size = New System.Drawing.Size(83, 21)
        Me.Save1.TabIndex = 63
        Me.Save1.Text = "Salva"
        Me.Save1.UseVisualStyleBackColor = True
        '
        'Close1
        '
        Me.Close1.Enabled = False
        Me.Close1.Location = New System.Drawing.Point(227, 421)
        Me.Close1.Name = "Close1"
        Me.Close1.Size = New System.Drawing.Size(84, 21)
        Me.Close1.TabIndex = 64
        Me.Close1.Text = "Chiudi"
        Me.Close1.UseVisualStyleBackColor = True
        '
        'Undo1
        '
        Me.Undo1.Enabled = False
        Me.Undo1.Location = New System.Drawing.Point(120, 421)
        Me.Undo1.Name = "Undo1"
        Me.Undo1.Size = New System.Drawing.Size(84, 21)
        Me.Undo1.TabIndex = 65
        Me.Undo1.Text = "Annulla"
        Me.Undo1.UseVisualStyleBackColor = True
        '
        'Lato_Client2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.background17
        Me.ClientSize = New System.Drawing.Size(326, 454)
        Me.Controls.Add(Me.Undo1)
        Me.Controls.Add(Me.Close1)
        Me.Controls.Add(Me.Save1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.text_out1)
        Me.Controls.Add(Me.Sfoglia_txt1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComboBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "Lato_Client2"
        Me.ShowIcon = False
        Me.Text = "Mod dei colori"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Sfoglia_txt1 As System.Windows.Forms.TextBox
    Friend WithEvents text_out1 As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Save1 As System.Windows.Forms.Button
    Friend WithEvents Close1 As System.Windows.Forms.Button
    Friend WithEvents Undo1 As System.Windows.Forms.Button
End Class
