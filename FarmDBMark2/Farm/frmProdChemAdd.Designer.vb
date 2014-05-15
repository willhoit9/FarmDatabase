<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProdChemAdd
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
        Me.txtProdChemAddID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtProdChemAdd = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboProdChemAdd = New System.Windows.Forms.ComboBox()
        Me.btnAddProdChem = New System.Windows.Forms.Button()
        Me.btnProdAddCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtProdChemAddID
        '
        Me.txtProdChemAddID.BackColor = System.Drawing.SystemColors.Window
        Me.txtProdChemAddID.Location = New System.Drawing.Point(129, 46)
        Me.txtProdChemAddID.Name = "txtProdChemAddID"
        Me.txtProdChemAddID.ReadOnly = True
        Me.txtProdChemAddID.Size = New System.Drawing.Size(53, 20)
        Me.txtProdChemAddID.TabIndex = 0
        Me.txtProdChemAddID.TabStop = False
        Me.txtProdChemAddID.Tag = "Production ID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(37, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "ProductionID:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(37, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Chemical Name:"
        '
        'dtProdChemAdd
        '
        Me.dtProdChemAdd.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtProdChemAdd.Location = New System.Drawing.Point(127, 98)
        Me.dtProdChemAdd.Name = "dtProdChemAdd"
        Me.dtProdChemAdd.Size = New System.Drawing.Size(98, 20)
        Me.dtProdChemAdd.TabIndex = 1
        Me.dtProdChemAdd.Tag = "Application Date"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(33, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Application Date:"
        '
        'cboProdChemAdd
        '
        Me.cboProdChemAdd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboProdChemAdd.FormattingEnabled = True
        Me.cboProdChemAdd.Location = New System.Drawing.Point(128, 71)
        Me.cboProdChemAdd.Name = "cboProdChemAdd"
        Me.cboProdChemAdd.Size = New System.Drawing.Size(97, 21)
        Me.cboProdChemAdd.TabIndex = 0
        Me.cboProdChemAdd.Tag = "Chemical Name"
        '
        'btnAddProdChem
        '
        Me.btnAddProdChem.Location = New System.Drawing.Point(150, 173)
        Me.btnAddProdChem.Name = "btnAddProdChem"
        Me.btnAddProdChem.Size = New System.Drawing.Size(75, 23)
        Me.btnAddProdChem.TabIndex = 2
        Me.btnAddProdChem.Text = "Add"
        Me.btnAddProdChem.UseVisualStyleBackColor = True
        '
        'btnProdAddCancel
        '
        Me.btnProdAddCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnProdAddCancel.Location = New System.Drawing.Point(52, 173)
        Me.btnProdAddCancel.Name = "btnProdAddCancel"
        Me.btnProdAddCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnProdAddCancel.TabIndex = 8
        Me.btnProdAddCancel.Text = "Cancel"
        Me.btnProdAddCancel.UseVisualStyleBackColor = True
        '
        'frmProdChemAdd
        '
        Me.AcceptButton = Me.btnAddProdChem
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnProdAddCancel
        Me.ClientSize = New System.Drawing.Size(284, 230)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnProdAddCancel)
        Me.Controls.Add(Me.btnAddProdChem)
        Me.Controls.Add(Me.cboProdChemAdd)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dtProdChemAdd)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtProdChemAddID)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmProdChemAdd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ProdChemAdd"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtProdChemAddID As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtProdChemAdd As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboProdChemAdd As System.Windows.Forms.ComboBox
    Friend WithEvents btnAddProdChem As System.Windows.Forms.Button
    Friend WithEvents btnProdAddCancel As System.Windows.Forms.Button
End Class
