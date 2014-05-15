
Imports FarmBLL
Imports FarmDataTypes

Public Class frmBrandEditSearch
    Private _search As Boolean
    Private _myBrandManager As BrandManager
    Private _oldBrandID As Integer
    Private _oldBrand As Brand

    Public Sub New(ByVal brandId As Integer, Optional ByVal search As Boolean = False)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        If brandId < 0 Then
            Dim ex As New ApplicationException("No Brand was selected.")
            Throw ex
        End If
        _oldBrandID = brandId
        _search = search
    End Sub

    Private Sub frmBrandEditSearch_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        _myBrandManager = New BrandManager

        _oldBrand = _myBrandManager.getBrandByID(_oldBrandID)
        Me.Text = "Brand ID: " & _oldBrand.BrandID
        setText()

        If _search Then
            searchLayout()
        Else
            chbxBrandEdit.Hide()
        End If

    End Sub

    Private Sub btnAccept_Click(sender As System.Object, e As System.EventArgs) Handles btnAccept.Click
        If _search Then

            If chbxBrandEdit.Checked = False Then
                Me.DialogResult = Windows.Forms.DialogResult.Cancel
                Exit Sub
            End If

            If _oldBrand.Active = False Then
                Me.Tag = "This Brand is currently inactive and is not eligible for edit"
                Me.DialogResult = Windows.Forms.DialogResult.Abort
                Exit Sub
            End If


            If chbxBrandEdit.Checked = True Then
                submitEdit()
            End If


        Else
            submitEdit()
        End If
    End Sub

    Private Sub chbxBrandEdit_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chbxBrandEdit.CheckedChanged
        If chbxBrandEdit.Checked = True Then
            showFields()
        Else
            hideFields()
        End If
    End Sub

    Private Sub setText()
        Me.txtBrandID.Text = _oldBrand.BrandID
        Me.txtBrandName.Text = _oldBrand.BrandName
        Me.txtDealerName.Text = _oldBrand.BrandDealerName
    End Sub

    Private Sub searchLayout()

        Me.lblPrompt.Text = "Results from search for Brand ID: " & _oldBrand.BrandID &
            vbCrLf & "If you wish to make changes, click the checkbox."
        hideFields()

    End Sub

    Private Sub hideFields()
        Me.txtBrandName.Enabled = False
        Me.txtDealerName.Enabled = False
        Me.btnAccept.Text = "Okay"
    End Sub

    Private Sub showFields()
        Me.txtBrandName.Enabled = True
        Me.txtDealerName.Enabled = True
        Me.btnAccept.Text = "Edit"
    End Sub


    Private Sub submitEdit()
        If inputIsValid() Then

            Dim success As Boolean = False
            Dim result As String = ""

            Dim newBrand As New Brand
            newBrand.BrandID = _oldBrand.BrandID
            newBrand.BrandName = Me.txtBrandName.Text.Trim
            newBrand.BrandDealerName = Me.txtDealerName.Text.Trim

            result = _myBrandManager.editBrand(_oldBrand, newBrand)

            Me.Tag = result
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