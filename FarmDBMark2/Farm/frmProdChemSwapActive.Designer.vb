<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProdChemSwapActive
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSwapProdID = New System.Windows.Forms.TextBox()
        Me.txtSwapProdChemName = New System.Windows.Forms.TextBox()
        Me.txtSwapProdChemDate = New System.Windows.Forms.TextBox()
        Me.lblProdChemActive = New System.Windows.Forms.Label()
        Me.btnSwapActive = New System.Windows.Forms.Button()
        Me.btnCancelSwap = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Application Date:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Chemical Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "ProductionID:"
        '
        'txtSwapProdID
        '
        Me.txtSwapProdID.BackColor = System.Drawing.SystemColors.Window
        Me.txtSwapProdID.Location = New System.Drawing.Point(115, 63)
        Me.txtSwapProdID.Name = "txtSwapProdID"
        Me.txtSwapProdID.ReadOnly = True
        Me.txtSwapProdID.Size = New System.Drawing.Size(56, 20)
        Me.txtSwapProdID.TabIndex = 9
        Me.txtSwapProdID.TabStop = False
        Me.txtSwapProdID.Tag = "Production ID"
        '
        'txtSwapProdChemName
        '
        Me.txtSwapProdChemName.BackColor = System.Drawing.SystemColors.Window
        Me.txtSwapProdChemName.Location = New System.Drawing.Point(115, 92)
        Me.txtSwapProdChemName.Name = "txtSwapProdChemName"
        Me.txtSwapProdChemName.ReadOnly = True
        Me.txtSwapProdChemName.Size = New System.Drawing.Size(96, 20)
        Me.txtSwapProdChemName.TabIndex = 10
        Me.txtSwapProdChemName.TabStop = False
        Me.txtSwapProdChemName.Tag = "Chemcial Name"
        '
        'txtSwapProdChemDate
        '
        Me.txtSwapProdChemDate.BackColor = System.Drawing.SystemColors.Window
        Me.txtSwapProdChemDate.Location = New System.Drawing.Point(115, 118)
        Me.txtSwapProdChemDate.Name = "txtSwapProdChemDate"
        Me.txtSwapProdChemDate.ReadOnly = True
        Me.txtSwapProdChemDate.Size = New System.Drawing.Size(96, 20)
        Me.txtSwapProdChemDate.TabIndex = 11
        Me.txtSwapProdChemDate.TabStop = False
        Me.txtSwapProdChemDate.Tag = "Application Date"
        '
        'lblProdChemActive
        '
        Me.lblProdChemActive.Location = New System.Drawing.Point(18, 16)
        Me.lblProdChemActive.Name = "lblProdChemActive"
        Me.lblProdChemActive.Size = New System.Drawing.Size(201, 32)
        Me.lblProdChemActive.TabIndex = 12
        Me.lblProdChemActive.Text = "Are you sure you wish to delete this Chemical from this Production?"
        '
        'btnSwapActive
        '
        Me.btnSwapActive.Location = New System.Drawing.Point(118, 168)
        Me.btnSwapActive.Name = "btnSwapActive"
        Me.btnSwapActive.Size = New System.Drawing.Size(75, 23)
        Me.btnSwapActive.TabIndex = 13
        Me.btnSwapActive.Text = "Remove"
        Me.btnSwapActive.UseVisualStyleBackColor = True
        '
        'btnCancelSwap
        '
        Me.btnCancelSwap.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelSwap.Location = New System.Drawing.Point(28, 168)
        Me.btnCancelSwap.Name = "btnCancelSwap"
        Me.btnCancelSwap.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelSwap.TabIndex = 14
        Me.btnCancelSwap.Text = "Cancel"
        Me.btnCancelSwap.UseVisualStyleBackColor = True
        '
        'frmProdChemSwapActive
        '
        Me.AcceptButton = Me.btnSwapActive
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancelSwap
        Me.ClientSize = New System.Drawing.Size(233, 212)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnCancelSwap)
        Me.Controls.Add(Me.btnSwapActive)
        Me.Controls.Add(Me.lblProdChemActive)
        Me.Controls.Add(Me.txtSwapProdChemDate)
        Me.Controls.Add(Me.txtSwapProdChemName)
        Me.Controls.Add(Me.txtSwapProdID)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmProdChemSwapActive"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Delete?"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtSwapProdID As System.Windows.Forms.TextBox
    Friend WithEvents txtSwapProdChemName As System.Windows.Forms.TextBox
    Friend WithEvents txtSwapProdChemDate As System.Windows.Forms.TextBox
    Friend WithEvents lblProdChemActive As System.Windows.Forms.Label
    Friend WithEvents btnSwapActive As System.Windows.Forms.Button
    Friend WithEvents btnCancelSwap As System.Windows.Forms.Button
End Class
