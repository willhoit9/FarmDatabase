<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFieldSwapActive
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
        Me.btnAcceptFieldRemove = New System.Windows.Forms.Button()
        Me.btnCancelFieldRemove = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtRemoveFieldAcres = New System.Windows.Forms.TextBox()
        Me.txtRemoveFieldID = New System.Windows.Forms.TextBox()
        Me.txtRemoveFieldName = New System.Windows.Forms.TextBox()
        Me.txtRemoveFieldOwner = New System.Windows.Forms.TextBox()
        Me.lblFieldActive = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnAcceptFieldRemove
        '
        Me.btnAcceptFieldRemove.Location = New System.Drawing.Point(127, 156)
        Me.btnAcceptFieldRemove.Name = "btnAcceptFieldRemove"
        Me.btnAcceptFieldRemove.Size = New System.Drawing.Size(75, 23)
        Me.btnAcceptFieldRemove.TabIndex = 0
        Me.btnAcceptFieldRemove.Text = "Delete"
        Me.btnAcceptFieldRemove.UseVisualStyleBackColor = True
        '
        'btnCancelFieldRemove
        '
        Me.btnCancelFieldRemove.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelFieldRemove.Location = New System.Drawing.Point(41, 156)
        Me.btnCancelFieldRemove.Name = "btnCancelFieldRemove"
        Me.btnCancelFieldRemove.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelFieldRemove.TabIndex = 1
        Me.btnCancelFieldRemove.Text = "Cancel"
        Me.btnCancelFieldRemove.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Field ID:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(38, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Field Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(38, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Acres:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(38, 123)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Owner"
        '
        'txtRemoveFieldAcres
        '
        Me.txtRemoveFieldAcres.BackColor = System.Drawing.SystemColors.Window
        Me.txtRemoveFieldAcres.Location = New System.Drawing.Point(102, 90)
        Me.txtRemoveFieldAcres.Name = "txtRemoveFieldAcres"
        Me.txtRemoveFieldAcres.ReadOnly = True
        Me.txtRemoveFieldAcres.Size = New System.Drawing.Size(100, 20)
        Me.txtRemoveFieldAcres.TabIndex = 6
        Me.txtRemoveFieldAcres.TabStop = False
        Me.txtRemoveFieldAcres.Tag = "Field Acres"
        '
        'txtRemoveFieldID
        '
        Me.txtRemoveFieldID.BackColor = System.Drawing.SystemColors.Window
        Me.txtRemoveFieldID.Location = New System.Drawing.Point(102, 38)
        Me.txtRemoveFieldID.Name = "txtRemoveFieldID"
        Me.txtRemoveFieldID.ReadOnly = True
        Me.txtRemoveFieldID.Size = New System.Drawing.Size(36, 20)
        Me.txtRemoveFieldID.TabIndex = 7
        Me.txtRemoveFieldID.TabStop = False
        Me.txtRemoveFieldID.Tag = "Field ID"
        '
        'txtRemoveFieldName
        '
        Me.txtRemoveFieldName.BackColor = System.Drawing.SystemColors.Window
        Me.txtRemoveFieldName.Location = New System.Drawing.Point(102, 64)
        Me.txtRemoveFieldName.Name = "txtRemoveFieldName"
        Me.txtRemoveFieldName.ReadOnly = True
        Me.txtRemoveFieldName.Size = New System.Drawing.Size(100, 20)
        Me.txtRemoveFieldName.TabIndex = 8
        Me.txtRemoveFieldName.TabStop = False
        Me.txtRemoveFieldName.Tag = "Field Name"
        '
        'txtRemoveFieldOwner
        '
        Me.txtRemoveFieldOwner.BackColor = System.Drawing.SystemColors.Window
        Me.txtRemoveFieldOwner.Location = New System.Drawing.Point(102, 116)
        Me.txtRemoveFieldOwner.Name = "txtRemoveFieldOwner"
        Me.txtRemoveFieldOwner.ReadOnly = True
        Me.txtRemoveFieldOwner.Size = New System.Drawing.Size(100, 20)
        Me.txtRemoveFieldOwner.TabIndex = 9
        Me.txtRemoveFieldOwner.TabStop = False
        Me.txtRemoveFieldOwner.Tag = "Field Owner"
        '
        'lblFieldActive
        '
        Me.lblFieldActive.AutoSize = True
        Me.lblFieldActive.Location = New System.Drawing.Point(6, 13)
        Me.lblFieldActive.Name = "lblFieldActive"
        Me.lblFieldActive.Size = New System.Drawing.Size(201, 13)
        Me.lblFieldActive.TabIndex = 10
        Me.lblFieldActive.Text = "Are you sure you wish to delete this field?"
        '
        'frmFieldSwapActive
        '
        Me.AcceptButton = Me.btnAcceptFieldRemove
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancelFieldRemove
        Me.ClientSize = New System.Drawing.Size(219, 192)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblFieldActive)
        Me.Controls.Add(Me.txtRemoveFieldOwner)
        Me.Controls.Add(Me.txtRemoveFieldName)
        Me.Controls.Add(Me.txtRemoveFieldID)
        Me.Controls.Add(Me.txtRemoveFieldAcres)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCancelFieldRemove)
        Me.Controls.Add(Me.btnAcceptFieldRemove)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFieldSwapActive"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Delete Confirm?"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAcceptFieldRemove As System.Windows.Forms.Button
    Friend WithEvents btnCancelFieldRemove As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtRemoveFieldAcres As System.Windows.Forms.TextBox
    Friend WithEvents txtRemoveFieldID As System.Windows.Forms.TextBox
    Friend WithEvents txtRemoveFieldName As System.Windows.Forms.TextBox
    Friend WithEvents txtRemoveFieldOwner As System.Windows.Forms.TextBox
    Friend WithEvents lblFieldActive As System.Windows.Forms.Label
End Class
