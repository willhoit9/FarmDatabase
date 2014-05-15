Imports FarmBLL
Imports FarmDataTypes

Public Class frmBrandSwapActive
    Private _BrandID As Integer
    Private _remove As Boolean
    Private _myBrandManager As BrandManager

    Public Sub New(ByVal BrandID, ByVal Remove)
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        Me._BrandID = BrandID
        Me._remove = Remove
    End Sub

    Private Sub frmBrandSwapActive_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        _myBrandManager = New BrandManager
        setTextFields()
    End Sub

    Private Sub btnAccept_Click(sender As System.Object, e As System.EventArgs) Handles btnAccept.Click
        swapActive()
    End Sub


    Private Sub setTextFields()
        If _remove = False Then
            Me.Text = "Reactivate Brand?"
            Me.lblPrompt.Text = "Are you sure you wish to reactivate Brand " & _BrandID & "?"
            Me.btnAccept.Text = "Reactivate"
        Else
            Me.lblPrompt.Text = "Are you sure you wish to remove Brand " & _BrandID & "?"
        End If

        Dim myBrand As New Brand
        myBrand = _myBrandManager.getBrandByID(_BrandID)
        Me.txtBrandID.Text = myBrand.BrandID.ToString
        Me.txtBrandName.Text = myBrand.BrandName
        Me.txtDealerName.Text = myBrand.BrandDealerName

    End Sub

    Private Sub swapActive()
        Dim results As String = _myBrandManager.updateActive(_BrandID, _remove)
        Me.Tag = results
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub











End Class