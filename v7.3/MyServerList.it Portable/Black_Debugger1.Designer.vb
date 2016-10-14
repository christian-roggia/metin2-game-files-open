<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Black_Debugger1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Black_Debugger1))
        Me.Resolved1 = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Ripristino1 = New System.Windows.Forms.Button
        Me.Problem1 = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Lista_Bug1 = New System.Windows.Forms.ListBox
        Me.Scansione1 = New System.Windows.Forms.Button
        Me.Guida1 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Resolved1
        '
        Me.Resolved1.Location = New System.Drawing.Point(281, 320)
        Me.Resolved1.Name = "Resolved1"
        Me.Resolved1.ReadOnly = True
        Me.Resolved1.Size = New System.Drawing.Size(31, 20)
        Me.Resolved1.TabIndex = 16
        Me.Resolved1.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(194, 323)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Problemi Risolti:"
        '
        'Ripristino1
        '
        Me.Ripristino1.Location = New System.Drawing.Point(230, 211)
        Me.Ripristino1.Name = "Ripristino1"
        Me.Ripristino1.Size = New System.Drawing.Size(116, 21)
        Me.Ripristino1.TabIndex = 14
        Me.Ripristino1.Text = "Ripristina file"
        Me.Ripristino1.UseVisualStyleBackColor = True
        '
        'Problem1
        '
        Me.Problem1.Location = New System.Drawing.Point(124, 320)
        Me.Problem1.Name = "Problem1"
        Me.Problem1.ReadOnly = True
        Me.Problem1.Size = New System.Drawing.Size(32, 20)
        Me.Problem1.TabIndex = 13
        Me.Problem1.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 323)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Problemi Riscontrati:"
        '
        'Lista_Bug1
        '
        Me.Lista_Bug1.FormattingEnabled = True
        Me.Lista_Bug1.Items.AddRange(New Object() {"Avvia la scansione..."})
        Me.Lista_Bug1.Location = New System.Drawing.Point(15, 238)
        Me.Lista_Bug1.Name = "Lista_Bug1"
        Me.Lista_Bug1.Size = New System.Drawing.Size(331, 69)
        Me.Lista_Bug1.TabIndex = 11
        '
        'Scansione1
        '
        Me.Scansione1.Location = New System.Drawing.Point(15, 212)
        Me.Scansione1.Name = "Scansione1"
        Me.Scansione1.Size = New System.Drawing.Size(116, 20)
        Me.Scansione1.TabIndex = 10
        Me.Scansione1.Text = "Avvia scansione"
        Me.Scansione1.UseVisualStyleBackColor = True
        '
        'Guida1
        '
        Me.Guida1.AutoSize = True
        Me.Guida1.Location = New System.Drawing.Point(12, 9)
        Me.Guida1.Name = "Guida1"
        Me.Guida1.Size = New System.Drawing.Size(346, 143)
        Me.Guida1.TabIndex = 9
        Me.Guida1.Text = resources.GetString("Guida1.Text")
        '
        'Black_Debugger1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(357, 354)
        Me.Controls.Add(Me.Resolved1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Ripristino1)
        Me.Controls.Add(Me.Problem1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Lista_Bug1)
        Me.Controls.Add(Me.Scansione1)
        Me.Controls.Add(Me.Guida1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Black_Debugger1"
        Me.Text = "Black Debugger"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Resolved1 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Ripristino1 As System.Windows.Forms.Button
    Friend WithEvents Problem1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Lista_Bug1 As System.Windows.Forms.ListBox
    Friend WithEvents Scansione1 As System.Windows.Forms.Button
    Friend WithEvents Guida1 As System.Windows.Forms.Label
End Class
