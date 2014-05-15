Imports FarmBLL
Imports FarmDataTypes

Public Class frmProdChemEdit

    Private _oldProdChem As ProdChemVB
    Private _newProdChem As ProdChemVB
    Private _myProdChemManager As ProdChemManager
    Private _myChemManager As ChemManager

    Private _myChemList As List(Of Chemical)

    Public Sub New(ByVal oldProdChem As ProdChemVB)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        If IsNothing(oldProdChem) Then
            Dim ex As New ApplicationException("There is no Chemical to modify")
            Throw ex
        End If
        _oldProdChem = oldProdChem
    End Sub



    Private Sub frmProdChemEdit_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        _myChemManager = New ChemManager
        _myProdChemManager = New ProdChemManager

        Me.txtProdChemEditID.Text = _oldProdChem.ProductionID
        Me.txtChemName.Text = _oldProdChem.ChemicalName
        Me.dtProdChemEdit.Value = _oldProdChem.ApplicationDate


        ' killed:   because you cannot change part of a composite primary key, at least not in my house.
        '           If you want to change the chemical that was applied, you should delete this one and make a new one.
        '  loadComboBox()
        '    Me.cboProdChemEdit.SelectedIndex = _oldProdChem.ChemicalID - 1
    End Sub





    Private Sub btnEdit_Click(sender As System.Object, e As System.EventArgs) Handles btnEdit.Click

        submitEdit()


    End Sub




    Private Sub submitEdit()
        _newProdChem = New ProdChemVB
        _newProdChem.ProductionID = _oldProdChem.ProductionID
        _newProdChem.ChemicalID = _oldProdChem.ChemicalID
        _newProdChem.ApplicationDate = findApplicationDate()


        Dim result As String = _myProdChemManager.editProdChem(_oldProdChem, _newProdChem)
        Me.Tag = result

        Me.DialogResult = Windows.Forms.DialogResult.OK


        ' MsgBox(_newProdChem.ProductionID & _newProdChem.ChemicalID & _newProdChem.ApplicationDate)


    End Sub



    Private Function findApplicationDate()
        Dim myApplicationDate As Date = dtProdChemEdit.Value

        Return myApplicationDate
    End Function






    'killed:
    'Private Function findChemID()
    '    Dim myChemID As Integer
    '    Dim myChemIdFinder As Integer
    '    myChemIdFinder = cboProdChemEdit.SelectedIndex

    '    Try
    '        myChemID = CInt(_myChemList(myChemIdFinder).ChemicalID)
    '    Catch ex As ArgumentOutOfRangeException
    '        MsgBox("Please choose a Chemical" & vbCrLf & vbCrLf & ex.ToString)
    '    End Try
    '    Return myChemID
    'End Function

    ' killed:
    'Private Sub loadComboBox()

    '    _myChemList = New List(Of Chemical)
    '    _myChemList = _myChemManager.getChemList(0, True, True)

    '    For Each chem As Chemical In _myChemList
    '        cboProdChemEdit.Items.Add(chem.ChemicalName)
    '    Next

    'End Sub






End Class