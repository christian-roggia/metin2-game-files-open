<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Option1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Option1))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Search1 = New System.Windows.Forms.Button
        Me.Manual1 = New System.Windows.Forms.RadioButton
        Me.Auto1 = New System.Windows.Forms.RadioButton
        Me.Save1 = New System.Windows.Forms.Button
        Me.Exit1 = New System.Windows.Forms.Button
        Me.dll = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.DeleteOpen1 = New System.Windows.Forms.RadioButton
        Me.DeleteAction1 = New System.Windows.Forms.RadioButton
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Search1)
        Me.GroupBox1.Controls.Add(Me.Manual1)
        Me.GroupBox1.Controls.Add(Me.Auto1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(223, 97)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Opzioni Auto Patcher"
        '
        'Search1
        '
        Me.Search1.Enabled = False
        Me.Search1.Location = New System.Drawing.Point(27, 65)
        Me.Search1.Name = "Search1"
        Me.Search1.Size = New System.Drawing.Size(160, 20)
        Me.Search1.TabIndex = 10
        Me.Search1.Text = "Cerca una nuova versione"
        Me.Search1.UseVisualStyleBackColor = True
        '
        'Manual1
        '
        Me.Manual1.AutoSize = True
        Me.Manual1.Location = New System.Drawing.Point(6, 42)
        Me.Manual1.Name = "Manual1"
        Me.Manual1.Size = New System.Drawing.Size(191, 17)
        Me.Manual1.TabIndex = 9
        Me.Manual1.Text = "Cerca manualmente nuove versioni"
        Me.Manual1.UseVisualStyleBackColor = True
        '
        'Auto1
        '
        Me.Auto1.AutoSize = True
        Me.Auto1.Location = New System.Drawing.Point(6, 19)
        Me.Auto1.Name = "Auto1"
        Me.Auto1.Size = New System.Drawing.Size(209, 17)
        Me.Auto1.TabIndex = 8
        Me.Auto1.Text = "Cerca automaticamente nuove versioni"
        Me.Auto1.UseVisualStyleBackColor = True
        '
        'Save1
        '
        Me.Save1.Enabled = False
        Me.Save1.Location = New System.Drawing.Point(12, 229)
        Me.Save1.Name = "Save1"
        Me.Save1.Size = New System.Drawing.Size(90, 20)
        Me.Save1.TabIndex = 1
        Me.Save1.Text = "Salva"
        Me.Save1.UseVisualStyleBackColor = True
        '
        'Exit1
        '
        Me.Exit1.Location = New System.Drawing.Point(145, 230)
        Me.Exit1.Name = "Exit1"
        Me.Exit1.Size = New System.Drawing.Size(90, 19)
        Me.Exit1.TabIndex = 2
        Me.Exit1.Text = "Esci"
        Me.Exit1.UseVisualStyleBackColor = True
        '
        'dll
        '
        Me.dll.Location = New System.Drawing.Point(12, 304)
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
        Me.GroupBox2.Location = New System.Drawing.Point(12, 115)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(223, 64)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Opzioni Elimina File"
        '
        'DeleteOpen1
        '
        Me.DeleteOpen1.AutoSize = True
        Me.DeleteOpen1.Location = New System.Drawing.Point(6, 41)
        Me.DeleteOpen1.Name = "DeleteOpen1"
        Me.DeleteOpen1.Size = New System.Drawing.Size(181, 17)
        Me.DeleteOpen1.TabIndex = 1
        Me.DeleteOpen1.TabStop = True
        Me.DeleteOpen1.Text = "Elimina file a ogni nuova apertura"
        Me.DeleteOpen1.UseVisualStyleBackColor = True
        '
        'DeleteAction1
        '
        Me.DeleteAction1.AutoSize = True
        Me.DeleteAction1.Location = New System.Drawing.Point(6, 19)
        Me.DeleteAction1.Name = "DeleteAction1"
        Me.DeleteAction1.Size = New System.Drawing.Size(140, 17)
        Me.DeleteAction1.TabIndex = 0
        Me.DeleteAction1.TabStop = True
        Me.DeleteAction1.Text = "Elimina file a ogni azione"
        Me.DeleteAction1.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.Enabled = False
        Me.CheckBox1.Location = New System.Drawing.Point(12, 185)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(219, 30)
        Me.CheckBox1.TabIndex = 5
        Me.CheckBox1.Text = "Imposta programma come prefendito" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "per l'apertura dei file con estensione .epk"
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'Option1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(249, 261)
        Me.ControlBox = False
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.dll)
        Me.Controls.Add(Me.Exit1)
        Me.Controls.Add(Me.Save1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Option1"
        Me.Text = "Opzioni Varie"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Save1 As System.Windows.Forms.Button
    Friend WithEvents Exit1 As System.Windows.Forms.Button
    Friend WithEvents Search1 As System.Windows.Forms.Button
    Friend WithEvents Manual1 As System.Windows.Forms.RadioButton
    Friend WithEvents Auto1 As System.Windows.Forms.RadioButton
    Friend WithEvents dll As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DeleteOpen1 As System.Windows.Forms.RadioButton
    Friend WithEvents DeleteAction1 As System.Windows.Forms.RadioButton
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
End Class
