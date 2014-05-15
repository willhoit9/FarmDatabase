Imports FarmBLL
Imports FarmDataTypes


Public Class frmFieldEdit

    Private _oldField As Field
    Private _newField As Field
    Private _myFieldManager As FieldManager


    Private Sub frmEditField_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        ' this method is different from the rest of the program,
        ' i tried at least 3 differnt methods of passing the data around
        ' frmFieldSearch is a different from this and all of the others as well

        _myFieldManager = New FieldManager
        _oldField = New Field
        _oldField.FieldID = frmFarm.myField.FieldID
        _oldField.FieldName = frmFarm.myField.FieldName
        _oldField.Acres = frmFarm.myField.Acres
        _oldField.Owner = frmFarm.myField.Owner

        Me.txtEditFieldID.Text = frmFarm.myField.FieldID
        Me.txtEditFieldName.Text = frmFarm.myField.FieldName
        Me.txtEditAcre.Text = frmFarm.myField.Acres
        Me.txtEditOwner.Text = frmFarm.myField.Owner

    End Sub

    Private Sub btnAcceptEdit_Click(sender As System.Object, e As System.EventArgs) Handles btnAcceptEdit.Click
        editCall()
    End Sub



    Private Sub editCall()
        If fieldEditIsValid() Then
            Dim results As String = ""
            _newField = New Field

            ' _newField.FieldID = CInt(txtEditFieldID.Text)
            _newField.FieldID = frmFarm.myField.FieldID
            _newField.FieldName = txtEditFieldName.Text
            _newField.Acres = CInt(txtEditAcre.Text)
            _newField.Owner = txtEditOwner.Text

            results = _myFieldManager.editField(_oldField, _newField)

            Me.Tag = results
            Me.DialogResult = DialogResult.OK

        End If

    End Sub

    Private Function fieldEditIsValid() As Boolean
        If valid.IsPresent(txtEditFieldName) AndAlso
            valid.hasLessCharsThan(50, txtEditFieldName) AndAlso
            valid.IsPresent(txtEditAcre) AndAlso
            valid.IsInt(txtEditAcre) AndAlso
            valid.IsPresent(txtEditOwner) AndAlso
            valid.hasLessCharsThan(50, txtEditOwner) Then
            Return True
        Else
            Return False
        End If
    End Function


End Class