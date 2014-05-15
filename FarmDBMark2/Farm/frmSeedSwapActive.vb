Imports FarmBLL
Imports FarmDataTypes

Public Class frmSeedSwapActive

    Private _SeedID As Integer
    Private _remove As Boolean
    Private _mySeedManager As SeedManager

    Public Sub New(ByVal SeedID, ByVal Remove)
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        Me._SeedID = SeedID
        Me._remove = Remove
    End Sub

    Private Sub frmSeedSwapActive_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        _mySeedManager = New SeedManager
        setTextFields()
    End Sub

    Private Sub btnAccept_Click(sender As System.Object, e As System.EventArgs) Handles btnAccept.Click
        swapActive()
    End Sub

    Private Sub setTextFields()
        If _remove = False Then
            Me.Text = "Reactivate Seed?"
            Me.lblInstruction.Text = "Are you sure you wish to reactivate Seed " & _SeedID & "?"
            Me.btnAccept.Text = "Reactivate"
        Else
            Me.lblInstruction.Text = "Are you sure you wish to remove Seed " & _SeedID & "?"
        End If

        Dim mySeed As New Seed
        mySeed = _mySeedManager.getSeed(_SeedID)

        Me.txtID.Text = mySeed.SeedID.ToString
        Me.txtName.Text = mySeed.SeedName
        Me.txtBrand.Text = mySeed.BrandName
        Me.txtVariety.Text = mySeed.Variety
        Me.txtCrop.Text = mySeed.Crop
    End Sub

    Private Sub swapActive()
        Dim results As String = _mySeedManager.updateActive(_SeedID, _remove)
        Me.Tag = results
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub



End Class