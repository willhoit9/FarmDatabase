<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductionEditSearch
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
        Me.lblYield = New System.Windows.Forms.Label()
        Me.cboYield = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtProductionEditHDate = New System.Windows.Forms.DateTimePicker()
        Me.dtProductionEditPDate = New System.Windows.Forms.DateTimePicker()
        Me.lblProductionYear = New System.Windows.Forms.Label()
        Me.cboProductionYear = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblFieldName = New System.Windows.Forms.Label()
        Me.cboSeedVarieties = New System.Windows.Forms.ComboBox()
        Me.cboFieldNames = New System.Windows.Forms.ComboBox()
        Me.btnEditProduction = New System.Windows.Forms.Button()
        Me.btnCancelEditProduction = New System.Windows.Forms.Button()
        Me.lblInstruction = New System.Windows.Forms.Label()
        Me.chbxProductionSearchEdit = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'lblYield
        '
        Me.lblYield.AutoSize = True
        Me.lblYield.Location = New System.Drawing.Point(470, 43)
        Me.lblYield.Name = "lblYield"
        Me.lblYield.Size = New System.Drawing.Size(33, 13)
        Me.lblYield.TabIndex = 25
        Me.lblYield.Text = "Yield:"
        '
        'cboYield
        '
        Me.cboYield.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboYield.FormattingEnabled = True
        Me.cboYield.Location = New System.Drawing.Point(468, 61)
        Me.cboYield.Name = "cboYield"
        Me.cboYield.Size = New System.Drawing.Size(56, 21)
        Me.cboYield.TabIndex = 24
        Me.cboYield.Tag = "Yield"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(376, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Harvest Date:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(285, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Plant Date:"
        '
        'dtProductionEditHDate
        '
        Me.dtProductionEditHDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtProductionEditHDate.Location = New System.Drawing.Point(378, 62)
        Me.dtProductionEditHDate.Name = "dtProductionEditHDate"
        Me.dtProductionEditHDate.Size = New System.Drawing.Size(84, 20)
        Me.dtProductionEditHDate.TabIndex = 21
        Me.dtProductionEditHDate.Tag = "Harvest Date"
        '
        'dtProductionEditPDate
        '
        Me.dtProductionEditPDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtProductionEditPDate.Location = New System.Drawing.Point(288, 61)
        Me.dtProductionEditPDate.Name = "dtProductionEditPDate"
        Me.dtProductionEditPDate.Size = New System.Drawing.Size(84, 20)
        Me.dtProductionEditPDate.TabIndex = 20
        Me.dtProductionEditPDate.Tag = "Plant Date"
        '
        'lblProductionYear
        '
        Me.lblProductionYear.AutoSize = True
        Me.lblProductionYear.Location = New System.Drawing.Point(18, 42)
        Me.lblProductionYear.Name = "lblProductionYear"
        Me.lblProductionYear.Size = New System.Drawing.Size(86, 13)
        Me.lblProductionYear.TabIndex = 19
        Me.lblProductionYear.Text = "Production Year:"
        '
        'cboProductionYear
        '
        Me.cboProductionYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboProductionYear.FormattingEnabled = True
        Me.cboProductionYear.Location = New System.Drawing.Point(50, 61)
        Me.cboProductionYear.Name = "cboProductionYear"
        Me.cboProductionYear.Size = New System.Drawing.Size(56, 21)
        Me.cboProductionYear.TabIndex = 18
        Me.cboProductionYear.Tag = "Production Year"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(197, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Seed Variety:"
        '
        'lblFieldName
        '
        Me.lblFieldName.AutoSize = True
        Me.lblFieldName.Location = New System.Drawing.Point(114, 42)
        Me.lblFieldName.Name = "lblFieldName"
        Me.lblFieldName.Size = New System.Drawing.Size(63, 13)
        Me.lblFieldName.TabIndex = 16
        Me.lblFieldName.Text = "Field Name:"
        '
        'cboSeedVarieties
        '
        Me.cboSeedVarieties.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSeedVarieties.FormattingEnabled = True
        Me.cboSeedVarieties.Location = New System.Drawing.Point(200, 61)
        Me.cboSeedVarieties.Name = "cboSeedVarieties"
        Me.cboSeedVarieties.Size = New System.Drawing.Size(82, 21)
        Me.cboSeedVarieties.TabIndex = 15
        Me.cboSeedVarieties.Tag = "Seed Variety"
        '
        'cboFieldNames
        '
        Me.cboFieldNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFieldNames.FormattingEnabled = True
        Me.cboFieldNames.Location = New System.Drawing.Point(112, 61)
        Me.cboFieldNames.Name = "cboFieldNames"
        Me.cboFieldNames.Size = New System.Drawing.Size(82, 21)
        Me.cboFieldNames.TabIndex = 14
        Me.cboFieldNames.Tag = "Field Name"
        '
        'btnEditProduction
        '
        Me.btnEditProduction.Location = New System.Drawing.Point(297, 110)
        Me.btnEditProduction.Name = "btnEditProduction"
        Me.btnEditProduction.Size = New System.Drawing.Size(75, 23)
        Me.btnEditProduction.TabIndex = 26
        Me.btnEditProduction.Text = "Edit"
        Me.btnEditProduction.UseVisualStyleBackColor = True
        '
        'btnCancelEditProduction
        '
        Me.btnCancelEditProduction.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelEditProduction.Location = New System.Drawing.Point(206, 110)
        Me.btnCancelEditProduction.Name = "btnCancelEditProduction"
        Me.btnCancelEditProduction.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelEditProduction.TabIndex = 27
        Me.btnCancelEditProduction.Text = "Cancel"
        Me.btnCancelEditProduction.UseVisualStyleBackColor = True
        '
        'lblInstruction
        '
        Me.lblInstruction.AutoSize = True
        Me.lblInstruction.Location = New System.Drawing.Point(50, 13)
        Me.lblInstruction.Name = "lblInstruction"
        Me.lblInstruction.Size = New System.Drawing.Size(239, 13)
        Me.lblInstruction.TabIndex = 28
        Me.lblInstruction.Text = "Choose what you wish to change, then click edit."
        '
        'chbxProductionSearchEdit
        '
        Me.chbxProductionSearchEdit.AutoSize = True
        Me.chbxProductionSearchEdit.Location = New System.Drawing.Point(65, 110)
        Me.chbxProductionSearchEdit.Name = "chbxProductionSearchEdit"
        Me.chbxProductionSearchEdit.Size = New System.Drawing.Size(97, 17)
        Me.chbxProductionSearchEdit.TabIndex = 29
        Me.chbxProductionSearchEdit.Text = "Make changes"
        Me.chbxProductionSearchEdit.UseVisualStyleBackColor = True
        '
        'frmProductionEditSearch
        '
        Me.AcceptButton = Me.btnEditProduction
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancelEditProduction
        Me.ClientSize = New System.Drawing.Size(619, 157)
        Me.ControlBox = False
        Me.Controls.Add(Me.chbxProductionSearchEdit)
        Me.Controls.Add(Me.lblInstruction)
        Me.Controls.Add(Me.btnCancelEditProduction)
        Me.Controls.Add(Me.btnEditProduction)
        Me.Controls.Add(Me.lblYield)
        Me.Controls.Add(Me.cboYield)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtProductionEditHDate)
        Me.Controls.Add(Me.dtProductionEditPDate)
        Me.Controls.Add(Me.lblProductionYear)
        Me.Controls.Add(Me.cboProductionYear)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblFieldName)
        Me.Controls.Add(Me.cboSeedVarieties)
        Me.Controls.Add(Me.cboFieldNames)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmProductionEditSearch"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmProductionEdit"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblYield As System.Windows.Forms.Label
    Friend WithEvents cboYield As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtProductionEditHDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtProductionEditPDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblProductionYear As System.Windows.Forms.Label
    Friend WithEvents cboProductionYear As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblFieldName As System.Windows.Forms.Label
    Friend WithEvents cboSeedVarieties As System.Windows.Forms.ComboBox
    Friend WithEvents cboFieldNames As System.Windows.Forms.ComboBox
    Friend WithEvents btnEditProduction As System.Windows.Forms.Button
    Friend WithEvents btnCancelEditProduction As System.Windows.Forms.Button
    Friend WithEvents lblInstruction As System.Windows.Forms.Label
    Friend WithEvents chbxProductionSearchEdit As System.Windows.Forms.CheckBox
End Class
