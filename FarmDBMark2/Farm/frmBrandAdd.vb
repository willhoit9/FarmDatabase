Imports FarmBLL
Imports FarmDataTypes

Public Class frmBrandAdd

    Private _myBrandManager As BrandManager

    Private Sub frmBrandAdd_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        _myBrandManager = New BrandManager

    End Sub

    Private Sub btnAccept_Click(sender As System.Object, e As System.EventArgs) Handles btnAccept.Click
        addBrand()
    End Sub

    Private Sub addBrand()
        Dim results As String = ""
        If inputIsValid() Then

            Dim newBrand As New Brand
            newBrand.BrandName = Me.txtBrandName.Text.Trim
            newBrand.BrandDealerName = Me.txtDealerName.Text.Trim

            results = _myBrandManager.addBrand(newBrand)

            Me.Tag = results
            Me.DialogResult = Windows.Forms.DialogResult.OK



        End If
    End Sub


    Private Function inputIsValid() As Boolean
        If valid.IsPresent(txtBrandName) AndAlso
            valid.hasLessCharsThan(50, txtBrandName) AndAlso
            valid.IsPresent(txtDealerName) AndAlso
            valid.hasLessCharsThan(50, txtDealerName) Then
            Return True
        Else
            Return False
        End If

    End Function



End Class