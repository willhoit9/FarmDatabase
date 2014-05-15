Imports FarmBLL
Imports FarmDataTypes


Public Class frmFieldSearch

    Public searchField As Field
    Private _myFieldManager As FieldManager


    ' this method is different from the rest of the program,
    ' i tried at least 3 differnt methods of passing the data around
    ' frmFieldEdit is a different from this and all of the others as well
    Private Sub frmFieldSearch_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        hideTextFields()

        searchField = New Field
        _myFieldManager = New FieldManager

        Dim searchID As Integer = CInt(txtSearchFieldID.Text)

        searchField = _myFieldManager.getFieldByID(searchID)

        txtSearchFieldName.Text = searchField.FieldName
        txtSearchFieldAcre.Text = searchField.Acres
        txtSearchFieldOwner.Text = searchField.Owner
        '     txtSearchFieldActive.Text = searchField.Active

    End Sub

    Private Sub btnSearchFieldEdit_Click(sender As System.Object, e As System.EventArgs) Handles btnSearchFieldEdit.Click
        editField()
    End Sub

    Private Sub hideTextFields()
        txtSearchFieldID.Enabled = False
        txtSearchFieldName.Enabled = False
        txtSearchFieldAcre.Enabled = False
        txtSearchFieldOwner.Enabled = False
        '   txtSearchFieldActive.Enabled = False
    End Sub

    Private Sub showTextFields()
        txtSearchFieldName.Enabled = True
        txtSearchFieldAcre.Enabled = True
        txtSearchFieldOwner.Enabled = True
    End Sub



    Private Sub editField()
        If fieldEditIsValid() Then
            Dim results As String = ""
            Dim newField As New Field

            newField.FieldID = searchField.FieldID
            newField.FieldName = txtSearchFieldName.Text
            newField.Acres = txtSearchFieldAcre.Text
            newField.Owner = txtSearchFieldOwner.Text

            results = _myFieldManager.editField(searchField, newField)
            Me.Tag = results
            Me.DialogResult = Windows.Forms.DialogResult.OK

        End If
    End Sub


    Private Function fieldEditIsValid() As Boolean
        If valid.IsPresent(txtSearchFieldName) AndAlso
            valid.hasLessCharsThan(50, txtSearchFieldName) AndAlso
            valid.IsPresent(txtSearchFieldAcre) AndAlso
            valid.IsInt(txtSearchFieldAcre) AndAlso
            valid.IsPresent(txtSearchFieldOwner) AndAlso
            valid.hasLessCharsThan(50, txtSearchFieldOwner) Then
            Return True
        Else
            Return False
        End If
    End Function


    Private Sub chbxFieldSearchEdit_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chbxFieldSearchEdit.CheckedChanged
        If chbxFieldSearchEdit.Checked = True Then
            showTextFields()
        Else
            hideTextFields()
        End If
    End Sub



End Class