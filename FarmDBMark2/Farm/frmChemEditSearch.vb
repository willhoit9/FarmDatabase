Imports FarmBLL
Imports FarmDataTypes

Public Class frmChemEditSearch

    Private _search As Boolean
    Private _myChemManager As ChemManager
    Private _oldChemID As Integer
    Private _oldChem As Chemical

    Public Sub New(ByVal chemID As Integer, Optional ByVal search As Boolean = False)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        If chemID < 0 Then
            Dim ex As New ApplicationException("No Chemical was selected.")
            Throw ex
        End If
        _oldChemID = chemID
        _search = search
    End Sub


    Private Sub frmChemEditSearch_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        _myChemManager = New ChemManager

        _oldChem = _myChemManager.getChem(_oldChemID)
        Me.Text = "Chemical ID: " & _oldChem.ChemicalID
        loadComboBoxes()
        setText()

        If _search Then
            searchLayout()
        Else
            chbxChemEdit.Hide()
        End If

    End Sub

    Private Sub btnAccept_Click(sender As System.Object, e As System.EventArgs) Handles btnAccept.Click
        If _search Then

            '     MsgBox(oldchem.Active & "hi")


            If chbxChemEdit.Checked = False Then
                Me.DialogResult = Windows.Forms.DialogResult.Cancel
                Exit Sub
            End If

            If _oldChem.Active = False Then
                '    MsgBox(_oldChem.Active & "bye")
                Me.Tag = "This Chemical is currently inactive and is not eligible for edit"
                Me.DialogResult = Windows.Forms.DialogResult.Abort
                Exit Sub
            End If


            If chbxChemEdit.Checked = True Then
                submitEdit()
            End If


        Else
            submitEdit()
        End If
    End Sub

    Private Sub chbxChemEdit_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chbxChemEdit.CheckedChanged
        If chbxChemEdit.Checked = True Then
            showFields()
        Else
            hideFields()
        End If
    End Sub


    Private Sub loadComboBoxes()

        'Brand ComboBoxes
        Dim brands() As String = _myChemManager.chemBrands
        For Each brand As String In brands
            cboBrand.Items.Add(brand)
        Next
        Me.cboBrand.SelectedItem = _oldChem.ChemicalBrand.ToString

        'Type ComboBoxes
        Dim types() As String = _myChemManager.chemTypes
        For Each type As String In types
            cboType.Items.Add(type)
        Next
        Me.cboType.SelectedItem = _oldChem.ChemicalType.ToString
    End Sub

    Private Sub setText()
        Me.txtID.Text = _oldChem.ChemicalID
        Me.txtName.Text = _oldChem.ChemicalName
    End Sub

    Private Sub searchLayout()

        Me.lblInstruction.Text = "Results from search for Chemical ID: " & _oldChem.ChemicalID &
            vbCrLf & "If you wish to make changes, click the checkbox."
        hideFields()

    End Sub

    Private Sub hideFields()
        Me.cboBrand.Enabled = False
        Me.cboType.Enabled = False
        Me.txtName.Enabled = False
        Me.btnAccept.Text = "Okay"
    End Sub

    Private Sub showFields()
        Me.cboBrand.Enabled = True
        Me.cboType.Enabled = True
        Me.txtName.Enabled = True
        Me.btnAccept.Text = "Edit"
    End Sub

    Private Sub submitEdit()
        If inputIsValid() Then

            Dim success As Boolean = False
            Dim result As String = ""

            Dim newChem As New Chemical
            newChem.ChemicalID = _oldChem.ChemicalID
            newChem.ChemicalName = Me.txtName.Text.Trim
            newChem.ChemicalBrand = Me.cboBrand.SelectedItem.Trim
            newChem.ChemicalType = Me.cboType.SelectedItem.Trim

            MsgBox(newChem.ChemicalID & newChem.ChemicalName & newChem.ChemicalBrand & newChem.ChemicalType)

            result = _myChemManager.editChemical(_oldChem, newChem)

            Me.Tag = result
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

