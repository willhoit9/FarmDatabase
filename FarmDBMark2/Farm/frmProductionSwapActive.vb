Imports FarmBLL
Imports FarmDataTypes

Public Class frmProductionSwapActive

    'Private _ProductionVB As ProductionVB
    Private _ProductionID As Integer
    Private _remove As Boolean
    Private myProductionManager As ProductionManager

    Public Sub New(ByVal ProductionID, ByVal Remove)
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        Me._ProductionID = ProductionID
        Me._remove = Remove
    End Sub


    Private Sub frmProductionSwapActive_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        myProductionManager = New ProductionManager
        setTextFields()
    End Sub

    Private Sub btnSwapProduction_Click(sender As System.Object, e As System.EventArgs) Handles btnSwapProduction.Click
        swapActive()
    End Sub

    Private Sub setTextFields()

        If _remove = False Then
            Me.Text = "Reactivate Production?"
            Me.txtMessage.Text = "Are you sure you wish to reactivate Production " & _ProductionID & "?"
            Me.btnSwapProduction.Text = "Reactivate"
        Else
            Me.txtMessage.Text = "Are you sure you wish to remove Production " & _ProductionID & "?"
        End If

        Dim myProductionVB As New ProductionVB
        myProductionVB = myProductionManager.getProductionVB(_ProductionID)

        Me.txtProductionSwapName.Text = myProductionVB.FieldName
        Me.txtProductionSwapVariety.Text = myProductionVB.SeedVariety
        Me.txtProductionSwapYear.Text = myProductionVB.Year
        Me.txtProductionSwapYield.Text = myProductionVB.Yield
        Me.txtSwapPDate.Text = myProductionVB.PlantDate.ToShortDateString
        Me.txtSwapHDate.Text = myProductionVB.HarvestDate.ToShortDateString

    End Sub





    Private Sub swapActive()
        Dim results As String = myProductionManager.updateActive(_ProductionID, _remove)
        Me.Tag = results

        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

End Class