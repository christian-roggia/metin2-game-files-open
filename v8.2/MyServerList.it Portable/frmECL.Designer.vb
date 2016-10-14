<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmECL
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
        Me.components = New System.ComponentModel.Container()
        Me.cmdRemove = New GFO.RoundedButton()
        Me.cmdAdd = New GFO.RoundedButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPath = New System.Windows.Forms.TextBox()
        Me.cmdSaveToList = New GFO.RoundedButton()
        Me.cmdEdit = New GFO.RoundedButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtClass = New System.Windows.Forms.TextBox()
        Me.txtPackage = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdSave = New GFO.RoundedButton()
        Me.cmdLoad = New GFO.RoundedButton()
        Me.lstPack = New System.Windows.Forms.ListView()
        Me.colPath = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colPackage = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colClass = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.dlgOpen = New System.Windows.Forms.OpenFileDialog()
        Me.lblStatus = New GFO.GlassLabel(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdRemove
        '
        Me.cmdRemove.BackColor = System.Drawing.Color.Transparent
        Me.cmdRemove.BorderColor = System.Drawing.Color.Black
        Me.cmdRemove.Color1 = System.Drawing.Color.Gainsboro
        Me.cmdRemove.Color2 = System.Drawing.Color.DarkGray
        Me.cmdRemove.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdRemove.HighlighColor1 = System.Drawing.Color.LightCyan
        Me.cmdRemove.HighlightColor2 = System.Drawing.Color.CadetBlue
        Me.cmdRemove.Location = New System.Drawing.Point(766, 282)
        Me.cmdRemove.Name = "cmdRemove"
        Me.cmdRemove.Shiny = True
        Me.cmdRemove.Size = New System.Drawing.Size(68, 36)
        Me.cmdRemove.TabIndex = 9
        Me.cmdRemove.Text = "Remove File"
        Me.cmdRemove.TraceRadius = 2
        '
        'cmdAdd
        '
        Me.cmdAdd.BackColor = System.Drawing.Color.Transparent
        Me.cmdAdd.BorderColor = System.Drawing.Color.Black
        Me.cmdAdd.Color1 = System.Drawing.Color.Gainsboro
        Me.cmdAdd.Color2 = System.Drawing.Color.DarkGray
        Me.cmdAdd.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAdd.HighlighColor1 = System.Drawing.Color.LightCyan
        Me.cmdAdd.HighlightColor2 = System.Drawing.Color.CadetBlue
        Me.cmdAdd.Location = New System.Drawing.Point(692, 282)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Shiny = True
        Me.cmdAdd.Size = New System.Drawing.Size(68, 36)
        Me.cmdAdd.TabIndex = 10
        Me.cmdAdd.Text = "New File"
        Me.cmdAdd.TraceRadius = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtPath)
        Me.GroupBox1.Controls.Add(Me.cmdSaveToList)
        Me.GroupBox1.Controls.Add(Me.cmdEdit)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtClass)
        Me.GroupBox1.Controls.Add(Me.txtPackage)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(692, 107)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(142, 169)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Edit"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(6, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Path:"
        '
        'txtPath
        '
        Me.txtPath.Enabled = False
        Me.txtPath.Location = New System.Drawing.Point(6, 115)
        Me.txtPath.Name = "txtPath"
        Me.txtPath.Size = New System.Drawing.Size(130, 22)
        Me.txtPath.TabIndex = 4
        '
        'cmdSaveToList
        '
        Me.cmdSaveToList.BorderColor = System.Drawing.Color.Black
        Me.cmdSaveToList.Color1 = System.Drawing.Color.Gainsboro
        Me.cmdSaveToList.Color2 = System.Drawing.Color.DarkGray
        Me.cmdSaveToList.Enabled = False
        Me.cmdSaveToList.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdSaveToList.HighlighColor1 = System.Drawing.Color.LightCyan
        Me.cmdSaveToList.HighlightColor2 = System.Drawing.Color.CadetBlue
        Me.cmdSaveToList.Location = New System.Drawing.Point(76, 141)
        Me.cmdSaveToList.Name = "cmdSaveToList"
        Me.cmdSaveToList.Shiny = True
        Me.cmdSaveToList.Size = New System.Drawing.Size(60, 22)
        Me.cmdSaveToList.TabIndex = 3
        Me.cmdSaveToList.Text = "Save"
        Me.cmdSaveToList.TraceRadius = 2
        '
        'cmdEdit
        '
        Me.cmdEdit.BorderColor = System.Drawing.Color.Black
        Me.cmdEdit.Color1 = System.Drawing.Color.Gainsboro
        Me.cmdEdit.Color2 = System.Drawing.Color.DarkGray
        Me.cmdEdit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdEdit.HighlighColor1 = System.Drawing.Color.LightCyan
        Me.cmdEdit.HighlightColor2 = System.Drawing.Color.CadetBlue
        Me.cmdEdit.Location = New System.Drawing.Point(6, 141)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Shiny = True
        Me.cmdEdit.Size = New System.Drawing.Size(60, 22)
        Me.cmdEdit.TabIndex = 3
        Me.cmdEdit.Text = "Edit"
        Me.cmdEdit.TraceRadius = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(6, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Class:"
        '
        'txtClass
        '
        Me.txtClass.Enabled = False
        Me.txtClass.Location = New System.Drawing.Point(6, 71)
        Me.txtClass.Name = "txtClass"
        Me.txtClass.Size = New System.Drawing.Size(130, 22)
        Me.txtClass.TabIndex = 1
        '
        'txtPackage
        '
        Me.txtPackage.Enabled = False
        Me.txtPackage.Location = New System.Drawing.Point(6, 32)
        Me.txtPackage.Name = "txtPackage"
        Me.txtPackage.Size = New System.Drawing.Size(130, 22)
        Me.txtPackage.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Package:"
        '
        'cmdSave
        '
        Me.cmdSave.BackColor = System.Drawing.Color.Transparent
        Me.cmdSave.BorderColor = System.Drawing.Color.Black
        Me.cmdSave.Color1 = System.Drawing.Color.Gainsboro
        Me.cmdSave.Color2 = System.Drawing.Color.DarkGray
        Me.cmdSave.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.HighlighColor1 = System.Drawing.Color.LightCyan
        Me.cmdSave.HighlightColor2 = System.Drawing.Color.CadetBlue
        Me.cmdSave.Location = New System.Drawing.Point(692, 74)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Shiny = True
        Me.cmdSave.Size = New System.Drawing.Size(142, 27)
        Me.cmdSave.TabIndex = 7
        Me.cmdSave.Text = "Save Modified EClass"
        Me.cmdSave.TraceRadius = 2
        '
        'cmdLoad
        '
        Me.cmdLoad.BackColor = System.Drawing.Color.Transparent
        Me.cmdLoad.BorderColor = System.Drawing.Color.Black
        Me.cmdLoad.Color1 = System.Drawing.Color.Gainsboro
        Me.cmdLoad.Color2 = System.Drawing.Color.DarkGray
        Me.cmdLoad.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLoad.HighlighColor1 = System.Drawing.Color.LightCyan
        Me.cmdLoad.HighlightColor2 = System.Drawing.Color.CadetBlue
        Me.cmdLoad.Location = New System.Drawing.Point(692, 41)
        Me.cmdLoad.Name = "cmdLoad"
        Me.cmdLoad.Shiny = True
        Me.cmdLoad.Size = New System.Drawing.Size(142, 27)
        Me.cmdLoad.TabIndex = 6
        Me.cmdLoad.Text = "Load EClass files"
        Me.cmdLoad.TraceRadius = 2
        '
        'lstPack
        '
        Me.lstPack.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colPath, Me.colPackage, Me.colClass})
        Me.lstPack.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstPack.FullRowSelect = True
        Me.lstPack.GridLines = True
        Me.lstPack.Location = New System.Drawing.Point(12, 35)
        Me.lstPack.MultiSelect = False
        Me.lstPack.Name = "lstPack"
        Me.lstPack.Size = New System.Drawing.Size(674, 294)
        Me.lstPack.TabIndex = 11
        Me.lstPack.UseCompatibleStateImageBehavior = False
        Me.lstPack.View = System.Windows.Forms.View.Details
        '
        'colPath
        '
        Me.colPath.Text = "Path"
        Me.colPath.Width = 164
        '
        'colPackage
        '
        Me.colPackage.Text = "Package"
        Me.colPackage.Width = 168
        '
        'colClass
        '
        Me.colClass.Text = "Class"
        Me.colClass.Width = 158
        '
        'dlgOpen
        '
        Me.dlgOpen.Filter = "EClasses files (.ecl)|*ecl"
        Me.dlgOpen.Multiselect = True
        '
        'lblStatus
        '
        Me.lblStatus.BackColor = System.Drawing.Color.Transparent
        Me.lblStatus.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblStatus.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.ForceRegularRendering = False
        Me.lblStatus.Location = New System.Drawing.Point(0, 353)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(846, 27)
        Me.lblStatus.TabIndex = 12
        Me.lblStatus.Text = "Status: Idle"
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmECL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(846, 380)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.lstPack)
        Me.Controls.Add(Me.cmdRemove)
        Me.Controls.Add(Me.cmdAdd)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.cmdLoad)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmECL"
        Me.ShowIcon = False
        Me.Text = "Menage EClass"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub


    Friend WithEvents cmdRemove As GFO.RoundedButton
    Friend WithEvents cmdAdd As GFO.RoundedButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdSaveToList As GFO.RoundedButton
    Friend WithEvents cmdEdit As GFO.RoundedButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtClass As System.Windows.Forms.TextBox
    Friend WithEvents txtPackage As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdSave As GFO.RoundedButton
    Friend WithEvents cmdLoad As GFO.RoundedButton
    Friend WithEvents lstPack As System.Windows.Forms.ListView
    Friend WithEvents colPackage As System.Windows.Forms.ColumnHeader
    Friend WithEvents colClass As System.Windows.Forms.ColumnHeader


    Friend WithEvents dlgOpen As System.Windows.Forms.OpenFileDialog
    Friend WithEvents colPath As System.Windows.Forms.ColumnHeader

    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtPath As System.Windows.Forms.TextBox
    Friend WithEvents lblStatus As GFO.GlassLabel



End Class
