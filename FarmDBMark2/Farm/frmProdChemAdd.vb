Imports FarmBLL
Imports FarmDataTypes

Public Class frmProdChemAdd

    Private _myProdChemManager As ProdChemManager
    Private _myProdChemList As List(Of ProdChemVB)
    Private _myProdChemVB As ProdChemVB

    Private _myChemManager As ChemManager
    Private _myChemList As List(Of Chemical)

    Private _myProductionID As Integer
    Private _myChemID As Integer


    Private Sub frmProdChemAdd_Load(sender As Object, e As System.EventArgs) Handles Me.Load


        _myChemManager = New ChemManager
        _myProdChemManager = New ProdChemManager
        _myProductionID = CInt(txtProdChemAddID.Text)

        loadComboBox()

    End Sub


    Private Sub loadComboBox()

        _myChemList = _myChemManager.getChemList(0, True, True)

        For Each chem As Chemical In _myChemList
            cboProdChemAdd.Items.Add(chem.ChemicalName)
        Next

    End Sub



    Private Sub addProdChemRelationship(ByVal ChemicalID As Integer, ByVal ProductionID As Integer, ByVal ApplicationDate As Date)
        Dim success As Boolean
        Dim message As String

        success = _myProdChemManager.addProdChemRelationship(ChemicalID, ProductionID, ApplicationDate)

        If success Then
            message = "The Chemical was added to ProductionID: " & _myProductionID.ToString
        Else
            message = "The Chemical was not added to ProductionID: " & _myProductionID.ToString
        End If

        Me.Tag = message

        Me.DialogResult = DialogResult.OK


    End Sub


    Private Sub btnAddProdChem_Click(sender As System.Object, e As System.EventArgs) Handles btnAddProdChem.Click
        If prodChemDataIsValid() Then
            findChemID()
            Dim myApplicationDate As Date = findApplicationDate()

            addProdChemRelationship(_myChemID, _myProductionID, myApplicationDate)
        End If

    End Sub



    Private Sub findChemID()
        Dim myChemIdFinder As Integer
        myChemIdFinder = cboProdChemAdd.SelectedIndex

        Try
            _myChemID = CInt(_myChemList(myChemIdFinder).ChemicalID)
        Catch ex As ArgumentOutOfRangeException
            MsgBox("Please choose a Chemical" & vbCrLf & vbCrLf & ex.ToString)
        End Try
    End Sub


    Private Function findApplicationDate()
        Dim myApplicationDate As Date = dtProdChemAdd.Value

        Return myApplicationDate
    End Function

    Private Function prodChemDataIsValid() As Boolean
        If valid.IsPresent(cboProdChemAdd) Then
            Return True
        Else
            Return False
        End If
    End Function

End Class