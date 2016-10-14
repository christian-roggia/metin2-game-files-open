<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Checker1
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
        Me.components = New System.ComponentModel.Container
        Me.List_Resolved1 = New System.Windows.Forms.ListBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.List_Unresolved1 = New System.Windows.Forms.ListBox
        Me.m2 = New System.ComponentModel.BackgroundWorker
        Me.DataDownLoad1 = New System.ComponentModel.BackgroundWorker
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.icona1 = New System.ComponentModel.BackgroundWorker
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'List_Resolved1
        '
        Me.List_Resolved1.FormattingEnabled = True
        Me.List_Resolved1.Location = New System.Drawing.Point(18, 119)
        Me.List_Resolved1.Name = "List_Resolved1"
        Me.List_Resolved1.Size = New System.Drawing.Size(333, 56)
        Me.List_Resolved1.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Problemi riscontrati"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Problemi risolti"
        '
        'List_Unresolved1
        '
        Me.List_Unresolved1.FormattingEnabled = True
        Me.List_Unresolved1.Location = New System.Drawing.Point(18, 22)
        Me.List_Unresolved1.Name = "List_Unresolved1"
        Me.List_Unresolved1.Size = New System.Drawing.Size(333, 56)
        Me.List_Unresolved1.TabIndex = 11
        '
        'm2
        '
        '
        'DataDownLoad1
        '
        '
        'Timer1
        '
        Me.Timer1.Interval = 500
        '
        'Timer2
        '
        '
        'Timer3
        '
        '
        'icona1
        '
        '
        'Timer4
        '
        '
        'Checker1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(363, 194)
        Me.ControlBox = False
        Me.Controls.Add(Me.List_Unresolved1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.List_Resolved1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Checker1"
        Me.Text = "Check file"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents List_Resolved1 As System.Windows.Forms.ListBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents List_Unresolved1 As System.Windows.Forms.ListBox
    Friend WithEvents m2 As System.ComponentModel.BackgroundWorker
    Friend WithEvents DataDownLoad1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents icona1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Timer4 As System.Windows.Forms.Timer
End Class
