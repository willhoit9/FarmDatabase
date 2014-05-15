Imports FarmBLL
Imports FarmDataTypes

Public Class frmSeedAdd

    Private _mySeedManager As SeedManager
    Private _myBrandList As List(Of Brand)

    '  Private myBrandManager As BrandManager

    Private Sub frmSeedAdd_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        _mySeedManager = New SeedManager

        loadComboBoxes()


    End Sub

    Private Sub btnAdd1_Click(sender As Object, e As System.EventArgs) Handles btnAdd1.Click
        addSeed()
    End Sub


    Private Sub loadComboBoxes()
        Dim myBrandManager As New BrandManager
        '     myBrandManager = New BrandManager

        'Brand ComboBoxes
        _myBrandList = myBrandManager.getBrands(True)

        For Each Brand As Brand In _myBrandList
            cboBrand.Items.Add(Brand.BrandName)
        Next

        'Crop ComboBoxes
        Dim crops() As String = {"Corn", "Soybeans", "Alfalfa", "Wheat", "Hay", "Oats", "Clover"}
        For Each crop As String In crops
            cboCrop.Items.Add(crop)
        Next

    End Sub


    Private Sub addSeed()
        Dim result As String = ""
        If inputIsValid() Then

            Dim newSeed As New Seed

            newSeed.BrandID = brandIDFinder()
            newSeed.SeedName = Me.txtName.Text.ToString.Trim
            newSeed.Variety = Me.txtVariety.Text.ToString.Trim
            newSeed.Crop = cropFinder()

            result = _mySeedManager.addSeed(newSeed)

            Me.Tag = result
            Me.DialogResult = Windows.Forms.DialogResult.OK

        End If

    End Sub


    Private Function inputIsValid() As Boolean
        If valid.IsPresent(Me.cboBrand) AndAlso
            valid.IsPresent(txtName) AndAlso
            valid.hasLessCharsThan(50, txtName) AndAlso
            valid.IsPresent(txtVariety) AndAlso
            valid.hasLessCharsThan(30, txtVariety) AndAlso
            valid.IsPresent(cboCrop) Then
            Return True
        Else
            Return False
        End If

    End Function



    Private Function brandIDFinder()
        Dim myBrandIDFinder As Integer
        myBrandIDFinder = cboBrand.SelectedIndex
        Dim myBrandID As Integer

        Try
            myBrandID = _myBrandList(myBrandIDFinder).BrandID
        Catch ex As ArgumentOutOfRangeException
            MsgBox("Please choose a brand" & vbCrLf & vbCrLf & ex.ToString)
        End Try

        Return myBrandID
    End Function

    Private Function cropFinder()
        Dim myCrop As String = ""

        Try
            myCrop = Me.cboCrop.SelectedItem.ToString.Trim
        Catch ex As NullReferenceException
            MsgBox("Please choose a Crop type" & vbCrLf & vbCrLf & ex.ToString)
        End Try

        Return myCrop
    End Function



End Class