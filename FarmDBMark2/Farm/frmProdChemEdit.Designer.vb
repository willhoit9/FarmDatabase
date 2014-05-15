<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProdChemEdit
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtProdChemEdit = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtProdChemEditID = New System.Windows.Forms.TextBox()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.txtChemName = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(47, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Application Date:"
        '
        'dtProdChemEdit
        '
        Me.dtProdChemEdit.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtProdChemEdit.Location = New System.Drawing.Point(141, 103)
        Me.dtProdChemEdit.Name = "dtProdChemEdit"
        Me.dtProdChemEdit.Size = New System.Drawing.Size(98, 20)
        Me.dtProdChemEdit.TabIndex = 1
        Me.dtProdChemEdit.Tag = "Application Date"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(51, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Chemical Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(51, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ProductionID:"
        '
        'txtProdChemEditID
        '
        Me.txtProdChemEditID.BackColor = System.Drawing.SystemColors.Window
        Me.txtProdChemEditID.Location = New System.Drawing.Point(143, 51)
        Me.txtProdChemEditID.Name = "txtProdChemEditID"
        Me.txtProdChemEditID.ReadOnly = True
        Me.txtProdChemEditID.Size = New System.Drawing.Size(53, 20)
        Me.txtProdChemEditID.TabIndex = 7
        Me.txtProdChemEditID.TabStop = False
        Me.txtProdChemEditID.Tag = "Production ID"
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(143, 171)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 23)
        Me.btnEdit.TabIndex = 0
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(50, 171)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'txtChemName
        '
        Me.txtChemName.BackColor = System.Drawing.SystemColors.Window
        Me.txtChemName.Location = New System.Drawing.Point(141, 78)
        Me.txtChemName.Name = "txtChemName"
        Me.txtChemName.ReadOnly = True
        Me.txtChemName.Size = New System.Drawing.Size(98, 20)
        Me.txtChemName.TabIndex = 16
        Me.txtChemName.TabStop = False
        Me.txtChemName.Tag = "Chemical Name"
        '
        'frmProdChemEdit
        '
        Me.AcceptButton = Me.btnEdit
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(284, 224)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtChemName)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dtProdChemEdit)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtProdChemEditID)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmProdChemEdit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Edit Chemical used in a Production"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtProdChemEdit As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtProdChemEditID As System.Windows.Forms.TextBox
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents txtChemName As System.Windows.Forms.TextBox
End Class
