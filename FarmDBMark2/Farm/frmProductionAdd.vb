Imports FarmBLL
Imports FarmDataTypes


Public Class frmProductionAdd

    Private _myFieldManager As FieldManager
    Private _mySeedManager As SeedManager
    Private _myProductionManager As ProductionManager
    Private _fieldList As List(Of Field)
    Private _seedList As List(Of Seed)

    Private Sub frmProductionAdd_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        _myFieldManager = New FieldManager
        _mySeedManager = New SeedManager
        _myProductionManager = New ProductionManager

        loadComboBoxes()


    End Sub

    Private Sub btnAddProduction_Click(sender As System.Object, e As System.EventArgs) Handles btnAddProduction.Click
        addProduction()
    End Sub

    Private Sub loadComboBoxes()

        'load FieldList combo box
        _fieldList = _myFieldManager.getFieldList(0, True, True)
        For Each field As Field In _fieldList
            cboFieldNames.Items.Add(field.FieldName)
        Next

        'load SeedList combo box
        _seedList = _mySeedManager.getSeedList(0, True, True)
        For Each Seed As Seed In _seedList
            cboSeedVarieties.Items.Add(Seed.Variety)
        Next

        'load Production Year combo box

        Dim beginYear As Integer = 1970
        Dim endYear As Integer = DateTime.Today.Year
        Do While beginYear <= endYear
            cboProductionYear.Items.Add(beginYear)
            beginYear += 1
        Loop
        cboProductionYear.SelectedIndex = cboProductionYear.Items.Count - 1

        'load Yield Production box

        Dim yield As Integer = 0
        Dim endYield As Integer = 200
        Do While yield <= endYield
            cboYield.Items.Add(yield)
            yield += 1
        Loop
        cboYield.SelectedIndex = 0

    End Sub



    Private Sub addProduction()
        If productionDataIsValid() Then

            Dim result As String = ""

            Dim myProductionVB As New ProductionVB
            myProductionVB.Year = CInt(Me.cboProductionYear.SelectedItem.ToString)
            ' myProductionVB.FieldID = CInt(Me.cboFieldNames.SelectedIndex + 1)
            myProductionVB.FieldID = fieldIdFinder()
            myProductionVB.FieldName = Me.cboFieldNames.SelectedItem
            '     myProductionVB.SeedID = CInt(Me.cboSeedVarieties.SelectedIndex + 1)
            myProductionVB.SeedID = seedIdFinder()
            myProductionVB.PlantDate = CDate(Me.dtProductionPlantDate.Value)
            myProductionVB.HarvestDate = CDate(Me.dtProductionHarvestDate.Value)
            myProductionVB.Yield = CInt(Me.cboYield.SelectedItem)

            result = _myProductionManager.addProductionVB(myProductionVB)
            Me.Tag = result

            Me.DialogResult = Windows.Forms.DialogResult.OK

        End If

    End Sub


    Private Function productionDataIsValid() As Boolean
        If valid.IsPresent(cboProductionYear) AndAlso
            valid.IsPresent(cboFieldNames) AndAlso
            valid.IsPresent(cboSeedVarieties) AndAlso
            valid.IsPresent(cboYield) Then
            Return True
        Else
            Return False
        End If
    End Function


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


End Class