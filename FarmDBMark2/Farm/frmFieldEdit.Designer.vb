<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFieldEdit
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
        Me.btnAcceptEdit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtEditFieldID = New System.Windows.Forms.TextBox()
        Me.txtEditFieldName = New System.Windows.Forms.TextBox()
        Me.txtEditAcre = New System.Windows.Forms.TextBox()
        Me.txtEditOwner = New System.Windows.Forms.TextBox()
        Me.btnCancelEdit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnAcceptEdit
        '
        Me.btnAcceptEdit.Location = New System.Drawing.Point(120, 155)
        Me.btnAcceptEdit.Name = "btnAcceptEdit"
        Me.btnAcceptEdit.Size = New System.Drawing.Size(75, 23)
        Me.btnAcceptEdit.TabIndex = 1
        Me.btnAcceptEdit.Text = "Accept"
        Me.btnAcceptEdit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Field ID:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Field Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Acres:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(31, 109)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Owner:"
        '
        'txtEditFieldID
        '
        Me.txtEditFieldID.BackColor = System.Drawing.SystemColors.Window
        Me.txtEditFieldID.Location = New System.Drawing.Point(95, 30)
        Me.txtEditFieldID.Name = "txtEditFieldID"
        Me.txtEditFieldID.ReadOnly = True
        Me.txtEditFieldID.Size = New System.Drawing.Size(48, 20)
        Me.txtEditFieldID.TabIndex = 7
        Me.txtEditFieldID.TabStop = False
        Me.txtEditFieldID.Tag = "Field ID"
        '
        'txtEditFieldName
        '
        Me.txtEditFieldName.Location = New System.Drawing.Point(95, 56)
        Me.txtEditFieldName.Name = "txtEditFieldName"
        Me.txtEditFieldName.Size = New System.Drawing.Size(100, 20)
        Me.txtEditFieldName.TabIndex = 8
        Me.txtEditFieldName.Tag = "Field Name"
        '
        'txtEditAcre
        '
        Me.txtEditAcre.Location = New System.Drawing.Point(95, 83)
        Me.txtEditAcre.Name = "txtEditAcre"
        Me.txtEditAcre.Size = New System.Drawing.Size(100, 20)
        Me.txtEditAcre.TabIndex = 9
        Me.txtEditAcre.Tag = "Field Acres"
        '
        'txtEditOwner
        '
        Me.txtEditOwner.Location = New System.Drawing.Point(95, 109)
        Me.txtEditOwner.Name = "txtEditOwner"
        Me.txtEditOwner.Size = New System.Drawing.Size(100, 20)
        Me.txtEditOwner.TabIndex = 10
        Me.txtEditOwner.Tag = "Field Owner"
        '
        'btnCancelEdit
        '
        Me.btnCancelEdit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelEdit.Location = New System.Drawing.Point(35, 155)
        Me.btnCancelEdit.Name = "btnCancelEdit"
        Me.btnCancelEdit.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelEdit.TabIndex = 2
        Me.btnCancelEdit.Text = "Cancel"
        Me.btnCancelEdit.UseVisualStyleBackColor = True
        '
        'frmFieldEdit
        '
        Me.AcceptButton = Me.btnAcceptEdit
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancelEdit
        Me.ClientSize = New System.Drawing.Size(229, 202)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtEditOwner)
        Me.Controls.Add(Me.txtEditAcre)
        Me.Controls.Add(Me.txtEditFieldName)
        Me.Controls.Add(Me.txtEditFieldID)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCancelEdit)
        Me.Controls.Add(Me.btnAcceptEdit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MinimizeBox = False
        Me.Name = "frmFieldEdit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Edit Field"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAcceptEdit As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtEditFieldID As System.Windows.Forms.TextBox
    Friend WithEvents txtEditFieldName As System.Windows.Forms.TextBox
    Friend WithEvents txtEditAcre As System.Windows.Forms.TextBox
    Friend WithEvents txtEditOwner As System.Windows.Forms.TextBox
    Friend WithEvents btnCancelEdit As System.Windows.Forms.Button
End Class
