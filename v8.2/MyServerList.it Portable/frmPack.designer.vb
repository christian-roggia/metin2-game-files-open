<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPack
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPack))
        Me.lstPack = New System.Windows.Forms.ListView()
        Me.colName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colPath = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.dlgOpen = New System.Windows.Forms.OpenFileDialog()
        Me.dlgSave = New System.Windows.Forms.SaveFileDialog()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdSaveToList = New GFO.RoundedButton()
        Me.cmdEdit = New GFO.RoundedButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPath = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdRemove = New GFO.RoundedButton()
        Me.cmdAdd = New GFO.RoundedButton()
        Me.cmdSave = New GFO.RoundedButton()
        Me.cmdLoad = New GFO.RoundedButton()
        Me.lblStatus = New GFO.GlassLabel(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstPack
        '
        Me.lstPack.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colName, Me.colPath})
        Me.lstPack.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstPack.FullRowSelect = True
        Me.lstPack.GridLines = True
        Me.lstPack.Location = New System.Drawing.Point(12, 54)
        Me.lstPack.MultiSelect = False
        Me.lstPack.Name = "lstPack"
        Me.lstPack.Size = New System.Drawing.Size(372, 233)
        Me.lstPack.TabIndex = 0
        Me.lstPack.UseCompatibleStateImageBehavior = False
        Me.lstPack.View = System.Windows.Forms.View.Details
        '
        'colName
        '
        Me.colName.Text = "Pack Name"
        Me.colName.Width = 160
        '
        'colPath
        '
        Me.colPath.Text = "Simulated Path"
        Me.colPath.Width = 185
        '
        'dlgOpen
        '
        Me.dlgOpen.FileName = "Index"
        Me.dlgOpen.Filter = "Index files|Index"
        '
        'dlgSave
        '
        Me.dlgSave.FileName = "Index"
        Me.dlgSave.Filter = "Index files|Index"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.cmdSaveToList)
        Me.GroupBox1.Controls.Add(Me.cmdEdit)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtPath)
        Me.GroupBox1.Controls.Add(Me.txtName)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(390, 120)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(142, 125)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Edit"
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
        Me.cmdSaveToList.Location = New System.Drawing.Point(76, 97)
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
        Me.cmdEdit.Location = New System.Drawing.Point(6, 97)
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
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(6, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Path:"
        '
        'txtPath
        '
        Me.txtPath.Enabled = False
        Me.txtPath.Location = New System.Drawing.Point(6, 71)
        Me.txtPath.Name = "txtPath"
        Me.txtPath.Size = New System.Drawing.Size(130, 22)
        Me.txtPath.TabIndex = 1
        '
        'txtName
        '
        Me.txtName.Enabled = False
        Me.txtName.Location = New System.Drawing.Point(6, 32)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(130, 22)
        Me.txtName.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name:"
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
        Me.cmdRemove.Location = New System.Drawing.Point(464, 251)
        Me.cmdRemove.Name = "cmdRemove"
        Me.cmdRemove.Shiny = True
        Me.cmdRemove.Size = New System.Drawing.Size(68, 36)
        Me.cmdRemove.TabIndex = 5
        Me.cmdRemove.Text = "Remove Line"
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
        Me.cmdAdd.Location = New System.Drawing.Point(390, 251)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Shiny = True
        Me.cmdAdd.Size = New System.Drawing.Size(68, 36)
        Me.cmdAdd.TabIndex = 5
        Me.cmdAdd.Text = "Add Line"
        Me.cmdAdd.TraceRadius = 2
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
        Me.cmdSave.Location = New System.Drawing.Point(390, 87)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Shiny = True
        Me.cmdSave.Size = New System.Drawing.Size(142, 27)
        Me.cmdSave.TabIndex = 3
        Me.cmdSave.Text = "Save Modified Index"
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
        Me.cmdLoad.Location = New System.Drawing.Point(390, 54)
        Me.cmdLoad.Name = "cmdLoad"
        Me.cmdLoad.Shiny = True
        Me.cmdLoad.Size = New System.Drawing.Size(142, 27)
        Me.cmdLoad.TabIndex = 2
        Me.cmdLoad.Text = "Load Index file"
        Me.cmdLoad.TraceRadius = 2
        '
        'lblStatus
        '
        Me.lblStatus.BackColor = System.Drawing.Color.Transparent
        Me.lblStatus.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblStatus.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.ForceRegularRendering = False
        Me.lblStatus.Location = New System.Drawing.Point(0, 303)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(544, 27)
        Me.lblStatus.TabIndex = 1
        Me.lblStatus.Text = "Status: Idle"
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmPack
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(544, 330)
        Me.Controls.Add(Me.cmdRemove)
        Me.Controls.Add(Me.cmdAdd)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.cmdLoad)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.lstPack)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmPack"
        Me.ShowIcon = False
        Me.Text = "Pack Index Editor"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstPack As System.Windows.Forms.ListView
    Friend WithEvents colName As System.Windows.Forms.ColumnHeader
    Friend WithEvents colPath As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblStatus As GlassLabel
    Friend WithEvents cmdLoad As RoundedButton
    Friend WithEvents dlgOpen As System.Windows.Forms.OpenFileDialog
    Friend WithEvents dlgSave As System.Windows.Forms.SaveFileDialog
    Friend WithEvents cmdSave As RoundedButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdAdd As RoundedButton
    Friend WithEvents cmdRemove As RoundedButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtPath As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdSaveToList As RoundedButton
    Friend WithEvents cmdEdit As RoundedButton

End Class
