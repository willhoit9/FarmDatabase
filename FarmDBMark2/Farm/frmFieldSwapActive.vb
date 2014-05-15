Imports FarmBLL
Imports FarmDataTypes

' This swap active for Fields is done in a differnt way that the rest of the table's swap active classes are done
' I did this one first and will keep it this way, to compare with the others

Public Class frmFieldSwapActive

    Private _oldField As Field
    Private _myFieldManager As FieldManager
    Private _newField As Field


    Private Sub frmSwapActiveField_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        _myFieldManager = New FieldManager

        _oldField = New Field
        _newField = New Field

        _oldField.FieldID = frmFarm.myField.FieldID
        _oldField.FieldName = frmFarm.myField.FieldName
        _oldField.Acres = frmFarm.myField.Acres
        _oldField.Owner = frmFarm.myField.Owner
        _oldField.Active = frmFarm.myField.Active

        Me.txtRemoveFieldID.Text = frmFarm.myField.FieldID
        Me.txtRemoveFieldName.Text = frmFarm.myField.FieldName
        Me.txtRemoveFieldAcres.Text = frmFarm.myField.Acres
        Me.txtRemoveFieldOwner.Text = frmFarm.myField.Owner


        If _oldField.Active = True Then
            Me.Text = "Delete Confirm?"
            Me.lblFieldActive.Text = "Are you sure you wish to delete this field?"
            Me.btnAcceptFieldRemove.Text = "Delete"
            _newField.Active = False
        End If

        If _oldField.Active = False Then
            Me.Text = "Add Confirm?"
            Me.lblFieldActive.Text = "Are you sure you wish to reactivate this field?"
            Me.btnAcceptFieldRemove.Text = "Add"
            _newField.Active = True
        End If

        _newField.FieldID = _oldField.FieldID
        _newField.FieldName = _oldField.FieldName
        _newField.Acres = _oldField.Acres
        _newField.Owner = _oldField.Owner

    End Sub


    Private Sub btnAcceptFieldRemove_Click(sender As System.Object, e As System.EventArgs) Handles btnAcceptFieldRemove.Click
        swapActive()
    End Sub




    Private Sub swapActive()

        Dim results As String = ""

        If _oldField.Active = True Then
            results = _myFieldManager.removeField(_oldField, _newField)
        End If

        If _oldField.Active = False Then
            results = _myFieldManager.reactivateField(_oldField, _newField)
        End If

        Me.Tag = results
        Me.DialogResult = Windows.Forms.DialogResult.OK

    End Sub





End Class