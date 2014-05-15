Imports FarmBLL
Imports FarmDataTypes

Public Class frmSeedEditSearch
    Private _search As Boolean
    Private _mySeedManager As SeedManager
    Private _oldSeedID As Integer
    Private _oldSeed As Seed
    Private _myBrandList As List(Of Brand)

    Public Sub New(ByVal seedId As Integer, Optional ByVal search As Boolean = False)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        If seedId < 0 Then
            Dim ex As New ApplicationException("No Seed was selected.")
            Throw ex
        End If
        _oldSeedID = seedId
        _search = search
    End Sub

    Private Sub frmSeedEditSearch_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        _mySeedManager = New SeedManager

        _oldSeed = _mySeedManager.getSeed(_oldSeedID)
        Me.Text = "Seed ID:" & _oldSeed.SeedID
        loadComboBoxes()
        setText()

        If _search Then
            searchLayout()
        Else
            chbxSeedEdit.Hide()
        End If

    End Sub


    Private Sub chbxSeedEdit_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chbxSeedEdit.CheckedChanged
        If chbxSeedEdit.Checked = True Then
            showFields()
        Else
            hideFields()
        End If
    End Sub

    Private Sub btnAccept_Click(sender As System.Object, e As System.EventArgs) Handles btnAccept.Click
        If _search Then

            If chbxSeedEdit.Checked = False Then
                Me.DialogResult = Windows.Forms.DialogResult.Cancel
                Exit Sub
            End If

            If _oldSeed.Active = False Then
                Me.Tag = "This Seed is currently inactive and is not eligible for edit"
                Me.DialogResult = Windows.Forms.DialogResult.Abort
                Exit Sub
            End If

            If chbxSeedEdit.Checked = True Then
                submitEdit()
            End If
        Else
            submitEdit()
        End If
    End Sub


    Private Sub loadComboBoxes()
        Dim myBrandManager As New BrandManager
        '     myBrandManager = New BrandManager

        'Brand ComboBoxes
        _myBrandList = myBrandManager.getBrands(True)
        For Each Brand As Brand In _myBrandList
            cboBrand.Items.Add(Brand.BrandName)
        Next
        Me.cboBrand.SelectedItem = _oldSeed.BrandName.ToString

        'Crop ComboBoxes
        Dim crops() As String = {"Corn", "Soybeans", "Alfalfa", "Wheat", "Hay", "Oats", "Clover"}
        For Each crop As String In crops
            cboCrop.Items.Add(crop)
        Next
        Me.cboCrop.SelectedItem = _oldSeed.Crop.ToString

    End Sub

    Private Sub setText()
        Me.txtID.Text = _oldSeed.SeedID.ToString
        Me.txtName.Text = _oldSeed.SeedName.ToString
        Me.txtVariety.Text = _oldSeed.Variety.ToString
    End Sub

    Private Sub searchLayout()
        Me.lblInstruction.Text = "Results from search for Seed ID: " & _oldSeed.SeedID &
            vbCrLf & "If you wish to make changes, click the checkbox."
        hideFields()
    End Sub

    Private Sub hideFields()
        Me.cboBrand.Enabled = False
        Me.txtName.Enabled = False
        Me.txtVariety.Enabled = False
        Me.cboCrop.Enabled = False
        Me.btnAccept.Text = "Okay"
    End Sub

    Private Sub showFields()
        Me.cboBrand.Enabled = True
        Me.txtName.Enabled = True
        Me.txtVariety.Enabled = True
        Me.cboCrop.Enabled = True
        Me.btnAccept.Text = "Edit"
    End Sub

    Private Sub submitEdit()
        If inputIsValid() Then

            Dim success As Boolean = False
            Dim result As String = ""

            Dim newSeed As New Seed
            newSeed.BrandID = brandIDFinder()
            newSeed.BrandName = Me.cboBrand.SelectedItem.ToString
            newSeed.SeedName = Me.txtName.Text.ToString.Trim
            newSeed.Variety = Me.txtVariety.Text.ToString.Trim
            newSeed.Crop = cropFinder()


            result = _mySeedManager.editSeed(_oldSeed, newSeed)

            Me.Tag = result
            Me.DialogResult = Windows.Forms.DialogResult.OK

        End If
    End Sub



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


    Private Function inputIsValid() As Boolean
        If valid.IsPresent(cboBrand) AndAlso
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



End Class