Public Class frmFauxLogin

    Private Sub btnOwner_Click(sender As System.Object, e As System.EventArgs) Handles btnOwner.Click
        Me.DialogResult = Windows.Forms.DialogResult.Yes
    End Sub

    Private Sub btnWorker_Click(sender As System.Object, e As System.EventArgs) Handles btnWorker.Click
        Me.DialogResult = Windows.Forms.DialogResult.No
    End Sub

    Private Sub btnLeave_Click(sender As System.Object, e As System.EventArgs) Handles btnLeave.Click
        Me.DialogResult = Windows.Forms.DialogResult.Abort
    End Sub
End Class