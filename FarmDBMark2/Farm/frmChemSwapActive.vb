Imports FarmBLL
Imports FarmDataTypes

Public Class frmChemSwapActive
    Private _ChemID As Integer
    Private _remove As Boolean
    Private _myChemManager As ChemManager

    Public Sub New(ByVal ChemID, ByVal Remove)
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        Me._ChemID = ChemID
        Me._remove = Remove
    End Sub

    Private Sub frmChemSwapActive_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        _myChemManager = New ChemManager
        setTextFields()
    End Sub

    Private Sub btnAccept_Click(sender As System.Object, e As System.EventArgs) Handles btnAccept.Click
        swapActive()
    End Sub


    Private Sub setTextFields()
        If _remove = False Then
            Me.Text = "Reactivate Chemical?"
            Me.lblInstruction.Text = "Are you sure you wish to reactivate Chemical " & _ChemID & "?"
            Me.btnAccept.Text = "Reactivate"
        Else
            Me.lblInstruction.Text = "Are you sure you wish to remove Chemical " & _ChemID & "?"
        End If

        Dim myChem As New Chemical
        myChem = _myChemManager.getChem(_ChemID)

        Me.txtID.Text = myChem.ChemicalID.ToString
        Me.txtBrand.Text = myChem.ChemicalBrand
        Me.txtName.Text = myChem.ChemicalName.ToString
        Me.txtType.Text = myChem.ChemicalType
    End Sub

    Private Sub swapActive()
        Dim results As String = _myChemManager.updateActive(_ChemID, _remove)
        Me.Tag = results
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub









End Class