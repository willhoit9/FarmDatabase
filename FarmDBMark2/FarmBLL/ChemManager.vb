Imports FarmDAL
Imports FarmDataTypes

Public Class ChemManager


    Public Function getChemList(Optional ByVal blSelectedIndex As Integer = 0, Optional ByVal active As Boolean = True, Optional ByVal forcedAscension As Boolean = False)


        Dim blQuery As String = "SELECT * FROM Chemical "

        Dim chemList As List(Of Chemical)

        Dim blActive As String = " WHERE Active = 1 "
        If active = False Then
            blActive = ""
        End If


        Static Dim sortDirection As String = "DESC"
        If sortDirection = "DESC" Then
            sortDirection = "ASC"
        Else
            sortDirection = "DESC"
        End If

        Select Case blSelectedIndex
            Case 0
                blQuery = blQuery & blActive & " ORDER BY ChemicalID"
            Case 1
                blQuery = blQuery & blActive & " ORDER BY ChemicalName"
            Case 2
                blQuery = blQuery & blActive & " ORDER BY ChemicalBrand"
            Case 3
                blQuery = blQuery & blActive & " ORDER BY ChemicalType"
            Case 4
                blQuery = blQuery & blActive & " ORDER BY Active"
        End Select



        If forcedAscension = False Then
            blQuery = blQuery & " " & sortDirection
        Else
            blQuery = blQuery & " ASC"
        End If

        ' MsgBox(blQuery)

        chemList = ChemData.fetchChemList(blQuery)


        Return chemList
    End Function

    Public Function getChem(ByVal ChemID As Integer)
        Dim myChem As New Chemical
        myChem = ChemData.fetchByChemID(ChemID)

        Return myChem
    End Function

    Public Function addChem(ByVal newChem As Chemical) As String
        Dim results As String = ""
        Dim success As Boolean = False

        success = ChemData.AddChem(newChem.ChemicalName, newChem.ChemicalBrand, newChem.ChemicalType)

        If success Then
            results = "The Chemical, " & newChem.ChemicalName & " was added to the Chemical Table."
        Else
            results = "The Chemical, " & newChem.ChemicalName & " was not added to the Chemical Table."
        End If

        Return results
    End Function

    Public Function editChemical(ByVal oldChemical As Chemical, ByVal newChemical As Chemical)

        Dim results As String = ""

        Dim NameChange As Boolean = False
        Dim BrandChange As Boolean = False
        Dim TypeChange As Boolean = False

        If oldChemical.ChemicalName <> newChemical.ChemicalName Then

            NameChange = ChemData.updateChemName(newChemical.ChemicalName, oldChemical.ChemicalID, oldChemical.ChemicalName)

        End If

        If oldChemical.ChemicalBrand <> newChemical.ChemicalBrand Then

            BrandChange = ChemData.updateChemBrand(newChemical.ChemicalBrand, oldChemical.ChemicalID, oldChemical.ChemicalBrand)

        End If

        If oldChemical.ChemicalType <> newChemical.ChemicalType Then

            TypeChange = ChemData.updateChemType(newChemical.ChemicalType, oldChemical.ChemicalID, oldChemical.ChemicalType)

        End If

        

        If NameChange = True Then
            results = "ChemicalID: " & oldChemical.ChemicalID & "'s name was changed from " & oldChemical.ChemicalName & " to " & newChemical.ChemicalName & vbCrLf
        End If

        If BrandChange = True Then
            results = results & "ChemicalID: " & oldChemical.ChemicalID & "'s Brand was changed from " & oldChemical.ChemicalBrand & " to " & newChemical.ChemicalBrand & "." & vbCrLf
        End If

        If TypeChange = True Then
            results = results & "ChemicalID: " & oldChemical.ChemicalID & "'s type was changed from " & oldChemical.ChemicalType & " to " & newChemical.ChemicalType & "." & vbCrLf
        End If


        If NameChange = False And BrandChange = False And TypeChange = False Then
            results = "No changes were made to the Chemical with the ID of: " & oldChemical.ChemicalID
        End If


        Return results
    End Function

    Public Function updateActive(ByVal chemID As Integer, ByVal remove As Boolean)
        Dim removeSuccess As Boolean
        Dim reactivateSuccess As Boolean
        Dim results As String = "no changes made"

        'Dim myChem As New Chemical
        'myChem = ChemData.fetchByChemID(chemID)

        'If myChem.Active And remove = False Then
        '    results = "Chemical " & myChem.ChemicalID & " is already active!"
        'ElseIf myChem.Active = False And remove = True Then
        '    results = "Chemical " & myChem.ChemicalID & " has already been removed!"
        'Else

        If remove = True Then
            removeSuccess = ChemData.updateActive(False, chemID, True)
        End If
        If remove = False Then
            reactivateSuccess = ChemData.updateActive(True, chemID, False)
        End If

        'End If

        If removeSuccess = True Then
            results = "Chemical " & chemID & " was removed."
        End If
        If reactivateSuccess = True Then
            results = "Chemical " & chemID & " was reactivated."
        End If

        Return results
    End Function


    Public Function isActive(ByVal chemID As Integer)

        Dim myChem As New Chemical

        myChem = getChem(chemID)

        Return myChem.Active

    End Function



    Public Function chemBrands()
        Dim brands() As String = {"Monsanto", "BASF", "Scotts", "Amvac", "Agricultural"}
        Return brands
    End Function



    Public Function chemTypes()
        Dim types() As String = {"Herbicide", "Fertilizer", "Insecticide", "Fungicide"}
        Return types
    End Function




    Public Function maxID()
        Dim myID As Integer = ChemData.maxID

        Return myID
    End Function







End Class
