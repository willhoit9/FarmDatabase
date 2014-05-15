<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFieldAdd
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
        Me.txtAddOwner = New System.Windows.Forms.TextBox()
        Me.txtAddAcre = New System.Windows.Forms.TextBox()
        Me.txtAddFieldName = New System.Windows.Forms.TextBox()
        Me.lblAddOwner = New System.Windows.Forms.Label()
        Me.lblAddAcre = New System.Windows.Forms.Label()
        Me.lblAddFieldName = New System.Windows.Forms.Label()
        Me.btnAcceptAdd = New System.Windows.Forms.Button()
        Me.btnCancelAdd = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtAddOwner
        '
        Me.txtAddOwner.Location = New System.Drawing.Point(104, 81)
        Me.txtAddOwner.Name = "txtAddOwner"
        Me.txtAddOwner.Size = New System.Drawing.Size(100, 20)
        Me.txtAddOwner.TabIndex = 18
        Me.txtAddOwner.Tag = "Field Owner"
        '
        'txtAddAcre
        '
        Me.txtAddAcre.Location = New System.Drawing.Point(104, 55)
        Me.txtAddAcre.Name = "txtAddAcre"
        Me.txtAddAcre.Size = New System.Drawing.Size(100, 20)
        Me.txtAddAcre.TabIndex = 17
        Me.txtAddAcre.Tag = "Field Acres"
        '
        'txtAddFieldName
        '
        Me.txtAddFieldName.Location = New System.Drawing.Point(104, 28)
        Me.txtAddFieldName.Name = "txtAddFieldName"
        Me.txtAddFieldName.Size = New System.Drawing.Size(100, 20)
        Me.txtAddFieldName.TabIndex = 16
        Me.txtAddFieldName.Tag = "Field Name"
        '
        'lblAddOwner
        '
        Me.lblAddOwner.AutoSize = True
        Me.lblAddOwner.Location = New System.Drawing.Point(40, 81)
        Me.lblAddOwner.Name = "lblAddOwner"
        Me.lblAddOwner.Size = New System.Drawing.Size(41, 13)
        Me.lblAddOwner.TabIndex = 14
        Me.lblAddOwner.Tag = "Field Owner"
        Me.lblAddOwner.Text = "Owner:"
        '
        'lblAddAcre
        '
        Me.lblAddAcre.AutoSize = True
        Me.lblAddAcre.Location = New System.Drawing.Point(40, 57)
        Me.lblAddAcre.Name = "lblAddAcre"
        Me.lblAddAcre.Size = New System.Drawing.Size(37, 13)
        Me.lblAddAcre.TabIndex = 13
        Me.lblAddAcre.Tag = "Field Acres"
        Me.lblAddAcre.Text = "Acres:"
        '
        'lblAddFieldName
        '
        Me.lblAddFieldName.AutoSize = True
        Me.lblAddFieldName.Location = New System.Drawing.Point(40, 31)
        Me.lblAddFieldName.Name = "lblAddFieldName"
        Me.lblAddFieldName.Size = New System.Drawing.Size(63, 13)
        Me.lblAddFieldName.TabIndex = 12
        Me.lblAddFieldName.Text = "Field Name:"
        '
        'btnAcceptAdd
        '
        Me.btnAcceptAdd.Location = New System.Drawing.Point(129, 128)
        Me.btnAcceptAdd.Name = "btnAcceptAdd"
        Me.btnAcceptAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAcceptAdd.TabIndex = 19
        Me.btnAcceptAdd.Text = "Accept"
        Me.btnAcceptAdd.UseVisualStyleBackColor = True
        '
        'btnCancelAdd
        '
        Me.btnCancelAdd.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelAdd.Location = New System.Drawing.Point(43, 128)
        Me.btnCancelAdd.Name = "btnCancelAdd"
        Me.btnCancelAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelAdd.TabIndex = 2
        Me.btnCancelAdd.Text = "Cancel"
        Me.btnCancelAdd.UseVisualStyleBackColor = True
        '
        'frmFieldAdd
        '
        Me.AcceptButton = Me.btnAcceptAdd
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancelAdd
        Me.ClientSize = New System.Drawing.Size(244, 181)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnAcceptAdd)
        Me.Controls.Add(Me.txtAddOwner)
        Me.Controls.Add(Me.txtAddAcre)
        Me.Controls.Add(Me.txtAddFieldName)
        Me.Controls.Add(Me.lblAddOwner)
        Me.Controls.Add(Me.lblAddAcre)
        Me.Controls.Add(Me.lblAddFieldName)
        Me.Controls.Add(Me.btnCancelAdd)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFieldAdd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Add Field"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtAddOwner As System.Windows.Forms.TextBox
    Friend WithEvents txtAddAcre As System.Windows.Forms.TextBox
    Friend WithEvents txtAddFieldName As System.Windows.Forms.TextBox
    Friend WithEvents lblAddOwner As System.Windows.Forms.Label
    Friend WithEvents lblAddAcre As System.Windows.Forms.Label
    Friend WithEvents lblAddFieldName As System.Windows.Forms.Label
    Friend WithEvents btnAcceptAdd As System.Windows.Forms.Button
    Friend WithEvents btnCancelAdd As System.Windows.Forms.Button
End Class
