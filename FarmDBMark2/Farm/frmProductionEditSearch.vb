Imports FarmBLL
Imports FarmDataTypes

Public Class frmProductionEditSearch
    Private _search As Boolean
    Private _myFieldManager As FieldManager
    Private _mySeedManager As SeedManager
    Private _fieldList As List(Of Field)
    Private _seedList As List(Of Seed)
    Private _myProductionManager As ProductionManager

    Private _oldProductionID As Integer
    Private _oldProductionVB As ProductionVB

    Public Sub New(ByVal productionID As Integer, Optional ByVal search As Boolean = False)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        If productionID < 0 Then
            Dim ex As New ApplicationException("No Production was selected to Edit")
            Throw ex
        End If
        _oldProductionID = productionID
        _search = search
    End Sub

    Private Sub frmProductionEditSearch_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        _myFieldManager = New FieldManager
        _mySeedManager = New SeedManager
        _myProductionManager = New ProductionManager

        _oldProductionVB = _myProductionManager.getProductionVB(_oldProductionID)
        Me.Text = "Production ID: " & _oldProductionVB.ID
        loadComboBoxes()
        setClocks()

        If _search Then
            searchLayout()
        Else
            chbxProductionSearchEdit.Hide()
        End If

    End Sub



    Private Sub searchLayout()

        Me.lblInstruction.Text = "Results from search for Production ID: " & _oldProductionID & "     If you wish to make changes, click the checkbox below."
        hideFields()

    End Sub


    Private Sub hideFields()
        Me.cboFieldNames.Enabled = False
        Me.cboProductionYear.Enabled = False
        Me.cboSeedVarieties.Enabled = False
        Me.cboYield.Enabled = False
        Me.dtProductionEditPDate.Enabled = False
        Me.dtProductionEditHDate.Enabled = False
        Me.btnEditProduction.Text = "Okay"
    End Sub


    Private Sub showFields()
        Me.cboFieldNames.Enabled = True
        Me.cboProductionYear.Enabled = True
        Me.cboSeedVarieties.Enabled = True
        Me.cboYield.Enabled = True
        Me.dtProductionEditPDate.Enabled = True
        Me.dtProductionEditHDate.Enabled = True
        Me.btnEditProduction.Text = "Edit"
    End Sub

    Private Sub loadComboBoxes()

        'load field combo list
        _fieldList = _myFieldManager.getFieldList(0, True, True)
        For Each field As Field In _fieldList
            cboFieldNames.Items.Add(field.FieldName)
        Next
        '  cboFieldNames.SelectedIndex = _oldProductionVB.FieldID - 1
        cboFieldNames.SelectedItem = _oldProductionVB.FieldName.ToString

        'load seed combo list
        _seedList = _mySeedManager.getSeedList(0, True, True)
        For Each Seed As Seed In _seedList
            cboSeedVarieties.Items.Add(Seed.Variety)
        Next
        cboSeedVarieties.SelectedItem = _oldProductionVB.SeedVariety.ToString


        'load Production Year combo box

        Dim beginYear As Integer = 1970
        Dim endYear As Integer = DateTime.Today.Year
        Do While beginYear <= endYear
            cboProductionYear.Items.Add(beginYear)
            beginYear += 1
        Loop
        Me.cboProductionYear.SelectedIndex = Me.cboProductionYear.Items.IndexOf(_oldProductionVB.Year)

        'load Yield Production box

        Dim yield As Integer = 0
        Dim endYield As Integer = 200
        Do While yield <= endYield
            cboYield.Items.Add(yield)
            yield += 1
        Loop
        cboYield.SelectedValue = _oldProductionVB.Yield
        Me.cboYield.SelectedIndex = Me.cboYield.Items.IndexOf(_oldProductionVB.Yield)
    End Sub

    Private Sub setClocks()
        Me.dtProductionEditPDate.Value = _oldProductionVB.PlantDate
        Me.dtProductionEditHDate.Value = _oldProductionVB.HarvestDate
    End Sub


    Private Sub btnEditProduction_Click(sender As System.Object, e As System.EventArgs) Handles btnEditProduction.Click

        If _search Then

            If chbxProductionSearchEdit.Checked = False Then
                Me.DialogResult = Windows.Forms.DialogResult.Cancel
                Exit Sub
            End If

            If _oldProductionVB.Active = False Then

                Me.Tag = "This Production is currently inactive and is not eligible for edit"
                Me.DialogResult = Windows.Forms.DialogResult.Abort
                Exit Sub
            End If


            If chbxProductionSearchEdit.Checked = True Then
                submitEdit()
            End If

        Else
            submitEdit()
        End If

    End Sub


    Private Sub submitEdit()

        Dim success As Boolean = False
        Dim result As String = ""

        Dim newProductionVB As New ProductionVB
        newProductionVB.ID = _oldProductionVB.ID
        newProductionVB.Year = CInt(Me.cboProductionYear.SelectedItem.ToString)
        'newProductionVB.FieldID = CInt(Me.cboFieldNames.SelectedIndex + 1)
        newProductionVB.FieldID = fieldIdFinder()
        newProductionVB.FieldName = Me.cboFieldNames.SelectedItem.ToString
        'newProductionVB.SeedID = CInt(Me.cboSeedVarieties.SelectedIndex + 1)
        newProductionVB.SeedID = seedIdFinder()
        newProductionVB.SeedVariety = Me.cboSeedVarieties.SelectedItem.ToString
        newProductionVB.PlantDate = CDate(Me.dtProductionEditPDate.Value)
        newProductionVB.HarvestDate = CDate(Me.dtProductionEditHDate.Value)
        newProductionVB.Yield = CInt(Me.cboYield.SelectedItem)

        result = _myProductionManager.editProduction(_oldProductionVB, newProductionVB)

        Me.Tag = result

        Me.DialogResult = Windows.Forms.DialogResult.OK

    End Sub



    Private Function fieldIdFinder()
        Dim myFieldIdFinder As Integer
        myFieldIdFinder = cboFieldNames.SelectedIndex
        Dim myFieldID As Integer

        Try
            myFieldID = _fieldList(myFieldIdFinder).FieldID
        Catch ex As ArgumentOutOfRangeException
            MsgBox("Please choose a field" & vbCrLf & vbCrLf & ex.ToString)
            cboFieldNames.Focus()
        End Try

        Return myFieldID
    End Function



    Private Function seedIdFinder()
        Dim mySeedIdFinder As Integer
        mySeedIdFinder = cboSeedVarieties.SelectedIndex
        Dim mySeedID As Integer

        Try
            mySeedID = _seedList(mySeedIdFinder).SeedID
        Catch ex As ArgumentOutOfRangeException
            MsgBox("Please choose a seed variety" & vbCrLf & vbCrLf & ex.ToString)
            cboSeedVarieties.Focus()
        End Try

        Return mySeedID
    End Function


    Private Sub chbxProductionSearchEdit_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chbxProductionSearchEdit.CheckedChanged
        If chbxProductionSearchEdit.Checked = True Then
            showFields()
        Else
            hideFields()
        End If
    End Sub




End Class