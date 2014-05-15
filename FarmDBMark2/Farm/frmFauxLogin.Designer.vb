<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFauxLogin
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
        Me.btnOwner = New System.Windows.Forms.Button()
        Me.btnWorker = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnLeave = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnOwner
        '
        Me.btnOwner.Location = New System.Drawing.Point(129, 88)
        Me.btnOwner.Name = "btnOwner"
        Me.btnOwner.Size = New System.Drawing.Size(75, 23)
        Me.btnOwner.TabIndex = 0
        Me.btnOwner.Text = "Owner"
        Me.btnOwner.UseVisualStyleBackColor = True
        '
        'btnWorker
        '
        Me.btnWorker.Location = New System.Drawing.Point(48, 88)
        Me.btnWorker.Name = "btnWorker"
        Me.btnWorker.Size = New System.Drawing.Size(75, 23)
        Me.btnWorker.TabIndex = 1
        Me.btnWorker.Text = "Worker"
        Me.btnWorker.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(48, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(156, 31)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Are you a worker or an owner? Please don't lie."
        '
        'btnLeave
        '
        Me.btnLeave.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnLeave.Location = New System.Drawing.Point(197, 7)
        Me.btnLeave.Name = "btnLeave"
        Me.btnLeave.Size = New System.Drawing.Size(54, 23)
        Me.btnLeave.TabIndex = 3
        Me.btnLeave.Text = "Leave"
        Me.btnLeave.UseVisualStyleBackColor = False
        '
        'frmFauxLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(258, 152)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnLeave)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnWorker)
        Me.Controls.Add(Me.btnOwner)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFauxLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Faux Login"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnOwner As System.Windows.Forms.Button
    Friend WithEvents btnWorker As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnLeave As System.Windows.Forms.Button
End Class
