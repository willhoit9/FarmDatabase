Imports FarmBLL
Imports FarmDataTypes

Public Class frmProdChemSwapActive


    Private _oldProdChem As ProdChemVB
    Private _newProdChem As ProdChemVB
    Private _myProdChemManager As ProdChemManager

    Public Sub New(ByVal oldProdChem As ProdChemVB)

        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.

        If IsNothing(oldProdChem) Then
            Dim ex As New ApplicationException("There is no Chemical to modify")
            Throw ex
        End If
        _oldProdChem = oldProdChem

    End Sub


    Private Sub frmProdChemSwapActive_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        _myProdChemManager = New ProdChemManager
        _newProdChem = New ProdChemVB


        Me.txtSwapProdID.Text = _oldProdChem.ProductionID
        Me.txtSwapProdChemName.Text = _oldProdChem.ChemicalName
        Me.txtSwapProdChemDate.Text = _oldProdChem.ApplicationDate.ToShortDateString


        If _oldProdChem.Active = True Then
            Me.Text = "Delete Confirm?"
            Me.lblProdChemActive.Text = "Are you sure you wish to delete this Chemical from this Production?"
            Me.btnSwapActive.Text = "Delete"
            _newProdChem.Active = False
        End If

        If _oldProdChem.Active = False Then
            Me.Text = "Reactivate Confirm?"
            Me.lblProdChemActive.Text = "Are you sure you wish to reactivate this Chemical in this Production?"
            Me.btnSwapActive.Text = "Reactivate"
            _newProdChem.Active = True
        End If




        _newProdChem.ChemicalID = _oldProdChem.ChemicalID
        _newProdChem.ProductionID = _oldProdChem.ProductionID

    End Sub




    Private Sub btnSwapActive_Click(sender As System.Object, e As System.EventArgs) Handles btnSwapActive.Click

        swapActive()

    End Sub




    Private Sub swapActive()

        Dim results As String

        results = _myProdChemManager.swapProdChem(_oldProdChem, _newProdChem)

        Me.Tag = results
        Me.DialogResult = DialogResult.OK



    End Sub



End Class