<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductionSwapActive
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
        Me.txtMessage = New System.Windows.Forms.Label()
        Me.btnCancelSwapProduction = New System.Windows.Forms.Button()
        Me.btnSwapProduction = New System.Windows.Forms.Button()
        Me.lblYield = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblProductionYear = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblFieldName = New System.Windows.Forms.Label()
        Me.txtProductionSwapYear = New System.Windows.Forms.TextBox()
        Me.txtProductionSwapVariety = New System.Windows.Forms.TextBox()
        Me.txtProductionSwapName = New System.Windows.Forms.TextBox()
        Me.txtProductionSwapYield = New System.Windows.Forms.TextBox()
        Me.txtSwapPDate = New System.Windows.Forms.TextBox()
        Me.txtSwapHDate = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtMessage
        '
        Me.txtMessage.AutoSize = True
        Me.txtMessage.Location = New System.Drawing.Point(50, 13)
        Me.txtMessage.Name = "txtMessage"
        Me.txtMessage.Size = New System.Drawing.Size(264, 13)
        Me.txtMessage.TabIndex = 43
        Me.txtMessage.Text = "Are you sure you wish to remove this Production Year?"
        '
        'btnCancelSwapProduction
        '
        Me.btnCancelSwapProduction.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelSwapProduction.Location = New System.Drawing.Point(206, 110)
        Me.btnCancelSwapProduction.Name = "btnCancelSwapProduction"
        Me.btnCancelSwapProduction.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelSwapProduction.TabIndex = 42
        Me.btnCancelSwapProduction.Text = "Cancel"
        Me.btnCancelSwapProduction.UseVisualStyleBackColor = True
        '
        'btnSwapProduction
        '
        Me.btnSwapProduction.Location = New System.Drawing.Point(297, 110)
        Me.btnSwapProduction.Name = "btnSwapProduction"
        Me.btnSwapProduction.Size = New System.Drawing.Size(75, 23)
        Me.btnSwapProduction.TabIndex = 41
        Me.btnSwapProduction.Text = "Remove"
        Me.btnSwapProduction.UseVisualStyleBackColor = True
        '
        'lblYield
        '
        Me.lblYield.AutoSize = True
        Me.lblYield.Location = New System.Drawing.Point(470, 43)
        Me.lblYield.Name = "lblYield"
        Me.lblYield.Size = New System.Drawing.Size(33, 13)
        Me.lblYield.TabIndex = 40
        Me.lblYield.Text = "Yield:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(376, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Harvest Date:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(285, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Plant Date:"
        '
        'lblProductionYear
        '
        Me.lblProductionYear.AutoSize = True
        Me.lblProductionYear.Location = New System.Drawing.Point(18, 42)
        Me.lblProductionYear.Name = "lblProductionYear"
        Me.lblProductionYear.Size = New System.Drawing.Size(86, 13)
        Me.lblProductionYear.TabIndex = 34
        Me.lblProductionYear.Text = "Production Year:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(197, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Seed Variety:"
        '
        'lblFieldName
        '
        Me.lblFieldName.AutoSize = True
        Me.lblFieldName.Location = New System.Drawing.Point(114, 42)
        Me.lblFieldName.Name = "lblFieldName"
        Me.lblFieldName.Size = New System.Drawing.Size(63, 13)
        Me.lblFieldName.TabIndex = 31
        Me.lblFieldName.Text = "Field Name:"
        '
        'txtProductionSwapYear
        '
        Me.txtProductionSwapYear.BackColor = System.Drawing.SystemColors.Window
        Me.txtProductionSwapYear.Location = New System.Drawing.Point(40, 61)
        Me.txtProductionSwapYear.Name = "txtProductionSwapYear"
        Me.txtProductionSwapYear.ReadOnly = True
        Me.txtProductionSwapYear.Size = New System.Drawing.Size(54, 20)
        Me.txtProductionSwapYear.TabIndex = 44
        Me.txtProductionSwapYear.TabStop = False
        Me.txtProductionSwapYear.Tag = "Production Year"
        '
        'txtProductionSwapVariety
        '
        Me.txtProductionSwapVariety.BackColor = System.Drawing.SystemColors.Window
        Me.txtProductionSwapVariety.Location = New System.Drawing.Point(200, 61)
        Me.txtProductionSwapVariety.Name = "txtProductionSwapVariety"
        Me.txtProductionSwapVariety.ReadOnly = True
        Me.txtProductionSwapVariety.Size = New System.Drawing.Size(77, 20)
        Me.txtProductionSwapVariety.TabIndex = 45
        Me.txtProductionSwapVariety.TabStop = False
        Me.txtProductionSwapVariety.Tag = "Seed Variety"
        '
        'txtProductionSwapName
        '
        Me.txtProductionSwapName.BackColor = System.Drawing.SystemColors.Window
        Me.txtProductionSwapName.Location = New System.Drawing.Point(109, 61)
        Me.txtProductionSwapName.Name = "txtProductionSwapName"
        Me.txtProductionSwapName.ReadOnly = True
        Me.txtProductionSwapName.Size = New System.Drawing.Size(77, 20)
        Me.txtProductionSwapName.TabIndex = 46
        Me.txtProductionSwapName.TabStop = False
        Me.txtProductionSwapName.Tag = "Field Name"
        '
        'txtProductionSwapYield
        '
        Me.txtProductionSwapYield.BackColor = System.Drawing.SystemColors.Window
        Me.txtProductionSwapYield.Location = New System.Drawing.Point(468, 62)
        Me.txtProductionSwapYield.Name = "txtProductionSwapYield"
        Me.txtProductionSwapYield.ReadOnly = True
        Me.txtProductionSwapYield.Size = New System.Drawing.Size(35, 20)
        Me.txtProductionSwapYield.TabIndex = 47
        Me.txtProductionSwapYield.TabStop = False
        Me.txtProductionSwapYield.Tag = "Yield"
        '
        'txtSwapPDate
        '
        Me.txtSwapPDate.BackColor = System.Drawing.SystemColors.Window
        Me.txtSwapPDate.Location = New System.Drawing.Point(288, 61)
        Me.txtSwapPDate.Name = "txtSwapPDate"
        Me.txtSwapPDate.ReadOnly = True
        Me.txtSwapPDate.Size = New System.Drawing.Size(77, 20)
        Me.txtSwapPDate.TabIndex = 48
        Me.txtSwapPDate.TabStop = False
        Me.txtSwapPDate.Tag = "Plant Date"
        '
        'txtSwapHDate
        '
        Me.txtSwapHDate.BackColor = System.Drawing.SystemColors.Window
        Me.txtSwapHDate.Location = New System.Drawing.Point(377, 61)
        Me.txtSwapHDate.Name = "txtSwapHDate"
        Me.txtSwapHDate.ReadOnly = True
        Me.txtSwapHDate.Size = New System.Drawing.Size(77, 20)
        Me.txtSwapHDate.TabIndex = 49
        Me.txtSwapHDate.TabStop = False
        Me.txtSwapHDate.Tag = "Harvest Date"
        '
        'frmProductionSwapActive
        '
        Me.AcceptButton = Me.btnSwapProduction
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancelSwapProduction
        Me.ClientSize = New System.Drawing.Size(619, 157)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtSwapHDate)
        Me.Controls.Add(Me.txtSwapPDate)
        Me.Controls.Add(Me.txtProductionSwapYield)
        Me.Controls.Add(Me.txtProductionSwapName)
        Me.Controls.Add(Me.txtProductionSwapVariety)
        Me.Controls.Add(Me.txtProductionSwapYear)
        Me.Controls.Add(Me.txtMessage)
        Me.Controls.Add(Me.btnCancelSwapProduction)
        Me.Controls.Add(Me.btnSwapProduction)
        Me.Controls.Add(Me.lblYield)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblProductionYear)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblFieldName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmProductionSwapActive"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Remove Production?"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtMessage As System.Windows.Forms.Label
    Friend WithEvents btnCancelSwapProduction As System.Windows.Forms.Button
    Friend WithEvents btnSwapProduction As System.Windows.Forms.Button
    Friend WithEvents lblYield As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblProductionYear As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblFieldName As System.Windows.Forms.Label
    Friend WithEvents txtProductionSwapYear As System.Windows.Forms.TextBox
    Friend WithEvents txtProductionSwapVariety As System.Windows.Forms.TextBox
    Friend WithEvents txtProductionSwapName As System.Windows.Forms.TextBox
    Friend WithEvents txtProductionSwapYield As System.Windows.Forms.TextBox
    Friend WithEvents txtSwapPDate As System.Windows.Forms.TextBox
    Friend WithEvents txtSwapHDate As System.Windows.Forms.TextBox
End Class
