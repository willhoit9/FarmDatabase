<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBrandEditSearch
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
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnAccept = New System.Windows.Forms.Button()
        Me.txtDealerName = New System.Windows.Forms.TextBox()
        Me.txtBrandName = New System.Windows.Forms.TextBox()
        Me.txtBrandID = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblPrompt = New System.Windows.Forms.Label()
        Me.chbxBrandEdit = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(45, 171)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 54
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnAccept
        '
        Me.btnAccept.Location = New System.Drawing.Point(137, 171)
        Me.btnAccept.Name = "btnAccept"
        Me.btnAccept.Size = New System.Drawing.Size(75, 23)
        Me.btnAccept.TabIndex = 53
        Me.btnAccept.Text = "Edit"
        Me.btnAccept.UseVisualStyleBackColor = True
        '
        'txtDealerName
        '
        Me.txtDealerName.BackColor = System.Drawing.SystemColors.Window
        Me.txtDealerName.Location = New System.Drawing.Point(112, 106)
        Me.txtDealerName.Name = "txtDealerName"
        Me.txtDealerName.Size = New System.Drawing.Size(113, 20)
        Me.txtDealerName.TabIndex = 52
        Me.txtDealerName.Tag = "Dealer Name"
        '
        'txtBrandName
        '
        Me.txtBrandName.BackColor = System.Drawing.SystemColors.Window
        Me.txtBrandName.Location = New System.Drawing.Point(112, 76)
        Me.txtBrandName.Name = "txtBrandName"
        Me.txtBrandName.Size = New System.Drawing.Size(113, 20)
        Me.txtBrandName.TabIndex = 51
        Me.txtBrandName.Tag = "Brand Name"
        '
        'txtBrandID
        '
        Me.txtBrandID.BackColor = System.Drawing.SystemColors.Window
        Me.txtBrandID.Location = New System.Drawing.Point(112, 46)
        Me.txtBrandID.Name = "txtBrandID"
        Me.txtBrandID.ReadOnly = True
        Me.txtBrandID.Size = New System.Drawing.Size(29, 20)
        Me.txtBrandID.TabIndex = 50
        Me.txtBrandID.TabStop = False
        Me.txtBrandID.Tag = "Brand ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(34, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "Dealer Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(37, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "Brand Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(54, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "Brand ID:"
        '
        'lblPrompt
        '
        Me.lblPrompt.AutoSize = True
        Me.lblPrompt.Location = New System.Drawing.Point(12, 9)
        Me.lblPrompt.Name = "lblPrompt"
        Me.lblPrompt.Size = New System.Drawing.Size(239, 13)
        Me.lblPrompt.TabIndex = 46
        Me.lblPrompt.Text = "Choose what you wish to change, then click edit."
        '
        'chbxBrandEdit
        '
        Me.chbxBrandEdit.AutoSize = True
        Me.chbxBrandEdit.Location = New System.Drawing.Point(37, 139)
        Me.chbxBrandEdit.Name = "chbxBrandEdit"
        Me.chbxBrandEdit.Size = New System.Drawing.Size(134, 17)
        Me.chbxBrandEdit.TabIndex = 55
        Me.chbxBrandEdit.Text = "Click to make changes"
        Me.chbxBrandEdit.UseVisualStyleBackColor = True
        '
        'frmBrandEditSearch
        '
        Me.AcceptButton = Me.btnAccept
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(268, 262)
        Me.ControlBox = False
        Me.Controls.Add(Me.chbxBrandEdit)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnAccept)
        Me.Controls.Add(Me.txtDealerName)
        Me.Controls.Add(Me.txtBrandName)
        Me.Controls.Add(Me.txtBrandID)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblPrompt)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmBrandEditSearch"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Edit Brand"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnAccept As System.Windows.Forms.Button
    Friend WithEvents txtDealerName As System.Windows.Forms.TextBox
    Friend WithEvents txtBrandName As System.Windows.Forms.TextBox
    Friend WithEvents txtBrandID As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblPrompt As System.Windows.Forms.Label
    Friend WithEvents chbxBrandEdit As System.Windows.Forms.CheckBox
End Class
