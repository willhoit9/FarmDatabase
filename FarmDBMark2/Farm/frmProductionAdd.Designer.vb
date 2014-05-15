<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductionAdd
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
        Me.cboFieldNames = New System.Windows.Forms.ComboBox()
        Me.btnAddProduction = New System.Windows.Forms.Button()
        Me.btnCancelAddProduction = New System.Windows.Forms.Button()
        Me.cboSeedVarieties = New System.Windows.Forms.ComboBox()
        Me.lblFieldName = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboProductionYear = New System.Windows.Forms.ComboBox()
        Me.lblProductionYear = New System.Windows.Forms.Label()
        Me.dtProductionPlantDate = New System.Windows.Forms.DateTimePicker()
        Me.dtProductionHarvestDate = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblYield = New System.Windows.Forms.Label()
        Me.cboYield = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'cboFieldNames
        '
        Me.cboFieldNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFieldNames.FormattingEnabled = True
        Me.cboFieldNames.Location = New System.Drawing.Point(112, 59)
        Me.cboFieldNames.Name = "cboFieldNames"
        Me.cboFieldNames.Size = New System.Drawing.Size(82, 21)
        Me.cboFieldNames.TabIndex = 0
        Me.cboFieldNames.Tag = "Field Name"
        '
        'btnAddProduction
        '
        Me.btnAddProduction.Location = New System.Drawing.Point(297, 112)
        Me.btnAddProduction.Name = "btnAddProduction"
        Me.btnAddProduction.Size = New System.Drawing.Size(75, 23)
        Me.btnAddProduction.TabIndex = 1
        Me.btnAddProduction.Text = "Add"
        Me.btnAddProduction.UseVisualStyleBackColor = True
        '
        'btnCancelAddProduction
        '
        Me.btnCancelAddProduction.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelAddProduction.Location = New System.Drawing.Point(207, 112)
        Me.btnCancelAddProduction.Name = "btnCancelAddProduction"
        Me.btnCancelAddProduction.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelAddProduction.TabIndex = 2
        Me.btnCancelAddProduction.Text = "Cancel"
        Me.btnCancelAddProduction.UseVisualStyleBackColor = True
        '
        'cboSeedVarieties
        '
        Me.cboSeedVarieties.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSeedVarieties.FormattingEnabled = True
        Me.cboSeedVarieties.Location = New System.Drawing.Point(200, 59)
        Me.cboSeedVarieties.Name = "cboSeedVarieties"
        Me.cboSeedVarieties.Size = New System.Drawing.Size(82, 21)
        Me.cboSeedVarieties.TabIndex = 3
        Me.cboSeedVarieties.Tag = "Seed Variety"
        '
        'lblFieldName
        '
        Me.lblFieldName.AutoSize = True
        Me.lblFieldName.Location = New System.Drawing.Point(110, 43)
        Me.lblFieldName.Name = "lblFieldName"
        Me.lblFieldName.Size = New System.Drawing.Size(63, 13)
        Me.lblFieldName.TabIndex = 4
        Me.lblFieldName.Text = "Field Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(197, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Seed Variety:"
        '
        'cboProductionYear
        '
        Me.cboProductionYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboProductionYear.FormattingEnabled = True
        Me.cboProductionYear.Location = New System.Drawing.Point(50, 59)
        Me.cboProductionYear.Name = "cboProductionYear"
        Me.cboProductionYear.Size = New System.Drawing.Size(56, 21)
        Me.cboProductionYear.TabIndex = 6
        Me.cboProductionYear.Tag = "Production Year"
        '
        'lblProductionYear
        '
        Me.lblProductionYear.AutoSize = True
        Me.lblProductionYear.Location = New System.Drawing.Point(20, 43)
        Me.lblProductionYear.Name = "lblProductionYear"
        Me.lblProductionYear.Size = New System.Drawing.Size(86, 13)
        Me.lblProductionYear.TabIndex = 7
        Me.lblProductionYear.Text = "Production Year:"
        '
        'dtProductionPlantDate
        '
        Me.dtProductionPlantDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtProductionPlantDate.Location = New System.Drawing.Point(288, 59)
        Me.dtProductionPlantDate.Name = "dtProductionPlantDate"
        Me.dtProductionPlantDate.Size = New System.Drawing.Size(84, 20)
        Me.dtProductionPlantDate.TabIndex = 8
        Me.dtProductionPlantDate.Tag = "Plant Date"
        '
        'dtProductionHarvestDate
        '
        Me.dtProductionHarvestDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtProductionHarvestDate.Location = New System.Drawing.Point(378, 60)
        Me.dtProductionHarvestDate.Name = "dtProductionHarvestDate"
        Me.dtProductionHarvestDate.Size = New System.Drawing.Size(84, 20)
        Me.dtProductionHarvestDate.TabIndex = 9
        Me.dtProductionHarvestDate.Tag = "Harvest Date"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(285, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Plant Date:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(375, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Harvest Date:"
        '
        'lblYield
        '
        Me.lblYield.AutoSize = True
        Me.lblYield.Location = New System.Drawing.Point(465, 44)
        Me.lblYield.Name = "lblYield"
        Me.lblYield.Size = New System.Drawing.Size(33, 13)
        Me.lblYield.TabIndex = 13
        Me.lblYield.Text = "Yield:"
        '
        'cboYield
        '
        Me.cboYield.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboYield.FormattingEnabled = True
        Me.cboYield.Location = New System.Drawing.Point(468, 60)
        Me.cboYield.Name = "cboYield"
        Me.cboYield.Size = New System.Drawing.Size(56, 21)
        Me.cboYield.TabIndex = 12
        Me.cboYield.Tag = "Yield"
        '
        'frmProductionAdd
        '
        Me.AcceptButton = Me.btnAddProduction
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancelAddProduction
        Me.ClientSize = New System.Drawing.Size(616, 158)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblYield)
        Me.Controls.Add(Me.cboYield)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtProductionHarvestDate)
        Me.Controls.Add(Me.dtProductionPlantDate)
        Me.Controls.Add(Me.lblProductionYear)
        Me.Controls.Add(Me.cboProductionYear)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblFieldName)
        Me.Controls.Add(Me.cboSeedVarieties)
        Me.Controls.Add(Me.btnCancelAddProduction)
        Me.Controls.Add(Me.btnAddProduction)
        Me.Controls.Add(Me.cboFieldNames)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmProductionAdd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Add A Production Year Record"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboFieldNames As System.Windows.Forms.ComboBox
    Friend WithEvents btnAddProduction As System.Windows.Forms.Button
    Friend WithEvents btnCancelAddProduction As System.Windows.Forms.Button
    Friend WithEvents cboSeedVarieties As System.Windows.Forms.ComboBox
    Friend WithEvents lblFieldName As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboProductionYear As System.Windows.Forms.ComboBox
    Friend WithEvents lblProductionYear As System.Windows.Forms.Label
    Friend WithEvents dtProductionPlantDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtProductionHarvestDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblYield As System.Windows.Forms.Label
    Friend WithEvents cboYield As System.Windows.Forms.ComboBox
End Class
