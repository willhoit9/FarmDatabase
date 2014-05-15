<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFieldSearch
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
        Me.txtSearchFieldOwner = New System.Windows.Forms.TextBox()
        Me.txtSearchFieldAcre = New System.Windows.Forms.TextBox()
        Me.txtSearchFieldName = New System.Windows.Forms.TextBox()
        Me.txtSearchFieldID = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSearchFieldEdit = New System.Windows.Forms.Button()
        Me.btnSearchFieldCancel = New System.Windows.Forms.Button()
        Me.chbxFieldSearchEdit = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'txtSearchFieldOwner
        '
        Me.txtSearchFieldOwner.Location = New System.Drawing.Point(111, 115)
        Me.txtSearchFieldOwner.Name = "txtSearchFieldOwner"
        Me.txtSearchFieldOwner.Size = New System.Drawing.Size(100, 20)
        Me.txtSearchFieldOwner.TabIndex = 20
        Me.txtSearchFieldOwner.Tag = "Field Owner"
        '
        'txtSearchFieldAcre
        '
        Me.txtSearchFieldAcre.Location = New System.Drawing.Point(111, 89)
        Me.txtSearchFieldAcre.Name = "txtSearchFieldAcre"
        Me.txtSearchFieldAcre.Size = New System.Drawing.Size(100, 20)
        Me.txtSearchFieldAcre.TabIndex = 19
        Me.txtSearchFieldAcre.Tag = "Field Acres"
        '
        'txtSearchFieldName
        '
        Me.txtSearchFieldName.Location = New System.Drawing.Point(111, 62)
        Me.txtSearchFieldName.Name = "txtSearchFieldName"
        Me.txtSearchFieldName.Size = New System.Drawing.Size(100, 20)
        Me.txtSearchFieldName.TabIndex = 18
        Me.txtSearchFieldName.Tag = "Field Name"
        '
        'txtSearchFieldID
        '
        Me.txtSearchFieldID.BackColor = System.Drawing.SystemColors.Window
        Me.txtSearchFieldID.Location = New System.Drawing.Point(111, 36)
        Me.txtSearchFieldID.Name = "txtSearchFieldID"
        Me.txtSearchFieldID.ReadOnly = True
        Me.txtSearchFieldID.Size = New System.Drawing.Size(48, 20)
        Me.txtSearchFieldID.TabIndex = 17
        Me.txtSearchFieldID.TabStop = False
        Me.txtSearchFieldID.Tag = "Field ID"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(47, 115)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Owner:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(47, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Acres:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(47, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Field Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(47, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Field ID:"
        '
        'btnSearchFieldEdit
        '
        Me.btnSearchFieldEdit.Location = New System.Drawing.Point(126, 174)
        Me.btnSearchFieldEdit.Name = "btnSearchFieldEdit"
        Me.btnSearchFieldEdit.Size = New System.Drawing.Size(75, 23)
        Me.btnSearchFieldEdit.TabIndex = 23
        Me.btnSearchFieldEdit.Text = "Edit"
        Me.btnSearchFieldEdit.UseVisualStyleBackColor = True
        '
        'btnSearchFieldCancel
        '
        Me.btnSearchFieldCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSearchFieldCancel.Location = New System.Drawing.Point(45, 174)
        Me.btnSearchFieldCancel.Name = "btnSearchFieldCancel"
        Me.btnSearchFieldCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnSearchFieldCancel.TabIndex = 25
        Me.btnSearchFieldCancel.Text = "Cancel"
        Me.btnSearchFieldCancel.UseVisualStyleBackColor = True
        '
        'chbxFieldSearchEdit
        '
        Me.chbxFieldSearchEdit.AutoSize = True
        Me.chbxFieldSearchEdit.Location = New System.Drawing.Point(50, 151)
        Me.chbxFieldSearchEdit.Name = "chbxFieldSearchEdit"
        Me.chbxFieldSearchEdit.Size = New System.Drawing.Size(98, 17)
        Me.chbxFieldSearchEdit.TabIndex = 26
        Me.chbxFieldSearchEdit.Text = "Make Changes"
        Me.chbxFieldSearchEdit.UseVisualStyleBackColor = True
        '
        'frmFieldSearch
        '
        Me.AcceptButton = Me.btnSearchFieldEdit
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnSearchFieldCancel
        Me.ClientSize = New System.Drawing.Size(268, 228)
        Me.ControlBox = False
        Me.Controls.Add(Me.chbxFieldSearchEdit)
        Me.Controls.Add(Me.btnSearchFieldCancel)
        Me.Controls.Add(Me.btnSearchFieldEdit)
        Me.Controls.Add(Me.txtSearchFieldOwner)
        Me.Controls.Add(Me.txtSearchFieldAcre)
        Me.Controls.Add(Me.txtSearchFieldName)
        Me.Controls.Add(Me.txtSearchFieldID)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFieldSearch"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Tag = "Field Search"
        Me.Text = "Feild Search"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtSearchFieldOwner As System.Windows.Forms.TextBox
    Friend WithEvents txtSearchFieldAcre As System.Windows.Forms.TextBox
    Friend WithEvents txtSearchFieldName As System.Windows.Forms.TextBox
    Friend WithEvents txtSearchFieldID As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnSearchFieldEdit As System.Windows.Forms.Button
    Friend WithEvents btnSearchFieldCancel As System.Windows.Forms.Button
    Friend WithEvents chbxFieldSearchEdit As System.Windows.Forms.CheckBox
End Class
