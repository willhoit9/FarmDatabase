Imports FarmBLL
Imports FarmDataTypes

Public Class frmFieldAdd


    Private _newField As Field
    Private _myFieldManager As FieldManager


    Private Sub frmAddField_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        _myFieldManager = New FieldManager
    End Sub

    Private Sub btnAcceptAdd_Click(sender As Object, e As System.EventArgs) Handles btnAcceptAdd.Click
        addCall()
    End Sub


    Private Sub addCall()
        If fieldAddIsValid() Then
            Dim results As String = ""
            _newField = New Field

            _newField.FieldName = txtAddFieldName.Text
            _newField.Acres = CInt(txtAddAcre.Text)
            _newField.Owner = txtAddOwner.Text

            results = _myFieldManager.addField(_newField)

            Me.Tag = results
            Me.DialogResult = Windows.Forms.DialogResult.OK

        End If

    End Sub


    Private Function fieldAddIsValid() As Boolean
        If valid.IsPresent(txtAddFieldName) AndAlso
            valid.hasLessCharsThan(50, txtAddFieldName) AndAlso
            valid.IsPresent(txtAddAcre) AndAlso
            valid.IsInt(txtAddAcre) AndAlso
            valid.IsPresent(txtAddOwner) AndAlso
            valid.hasLessCharsThan(50, txtAddOwner) Then
            Return True
        Else
            Return False
        End If
    End Function


End Class