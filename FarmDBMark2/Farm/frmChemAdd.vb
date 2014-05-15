Imports FarmBLL
Imports FarmDataTypes

Public Class frmChemAdd

    Private _myChemManager As ChemManager


    Private Sub frmChemAdd_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        _myChemManager = New ChemManager

        loadComboBoxes()

    End Sub

    Private Sub btnAccept_Click(sender As System.Object, e As System.EventArgs) Handles btnAccept.Click
        addChem()
    End Sub


    Private Sub loadComboBoxes()

        'Brand ComboBoxes
        'Dim brands() As String = {"Monsanto", "BASF", "Scotts", "Amvac", "Agricultural"}
        Dim brands() As String = _myChemManager.chemBrands
        For Each brand As String In brands
            cboBrand.Items.Add(brand)
        Next

        'Type ComboBoxes
        'Dim types() As String = {"Herbicide", "Fertilizer", "Insecticide", "Fungicide"}
        Dim types() As String = _myChemManager.chemTypes
        For Each type As String In types
            cboType.Items.Add(type)
        Next
    End Sub

    Private Sub addChem()
        Dim results As String = ""
        If inputIsValid() Then

            Dim newChem As New Chemical

            newChem.ChemicalBrand = Me.cboBrand.Text.ToString.Trim
            newChem.ChemicalName = Me.txtName.Text.ToString.Trim
            newChem.ChemicalType = Me.cboType.Text.ToString.Trim

            results = _myChemManager.addChem(newChem)

            Me.Tag = results
            Me.DialogResult = Windows.Forms.DialogResult.OK

        End If

    End Sub

    Private Function inputIsValid() As Boolean
        If valid.IsPresent(cboBrand) AndAlso
            valid.IsPresent(txtName) AndAlso
            valid.hasLessCharsThan(50, txtName) AndAlso
            valid.IsPresent(cboType) Then
            Return True
        Else
            Return False
        End If

    End Function





End Class