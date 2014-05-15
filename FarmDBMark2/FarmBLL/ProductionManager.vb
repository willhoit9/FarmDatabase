Imports FarmDAL
Imports FarmDataTypes


Public Class ProductionManager

    'FETCH LIST OF PRODUCTION - ACTIVE? ORDER BY? & FORCED ASCENSION?
    Public Function getProductionList(Optional ByVal blSelectedIndex As Integer = 0, Optional ByVal active As Boolean = True, Optional ByVal forcedAscension As Boolean = False) 'As List(Of Field)


        Dim blQuery As String = "SELECT p.ProductionID, p.Year, p.PlantDate, p.HarvestDate, p.Yield, p.FieldID, f.FieldName, b.BrandName, p.SeedID, s.Variety, p.Active FROM Brand b Join Seed s on b.BrandID = s.BrandID JOIN Production p ON s.SeedID = p.SeedID JOIN Field f ON p.FieldID = f.FieldID"

        Dim productionList As List(Of ProductionVB)


        Dim blActive As String = " WHERE p.Active = 1 "
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
                blQuery = blQuery & blActive & " ORDER BY p.ProductionID"
            Case 1
                blQuery = blQuery & blActive & " ORDER BY p.Year"
            Case 2
                blQuery = blQuery & blActive & " ORDER BY f.FieldName"
            Case 3
                blQuery = blQuery & blActive & " ORDER BY b.BrandName"
            Case 4
                blQuery = blQuery & blActive & " ORDER BY s.Variety"
            Case 5
                blQuery = blQuery & blActive & " ORDER BY p.PlantDate"
            Case 6
                blQuery = blQuery & blActive & " ORDER BY p.HarvestDate"
            Case 7
                blQuery = blQuery & blActive & " ORDER BY p.Yield"
            Case 8
                blQuery = blQuery & blActive & " ORDER BY p.Active"
        End Select



        If forcedAscension = False Then
            blQuery = blQuery & " " & sortDirection
        Else
            blQuery = blQuery & " ASC"
        End If

        ' MsgBox(blQuery)

        productionList = ProductionData.fetchProductionVBList(blQuery)


        Return productionList
    End Function



    'FETCH SINGLE PRODUCTION BY ID
    Public Function getProductionVB(ByVal productionID As Integer)
        Dim myProductionVB As New ProductionVB

        Dim blQuery As String = "SELECT p.ProductionID, p.Year, p.PlantDate, p.HarvestDate, p.Yield, p.FieldID, f.FieldName, b.BrandName, p.SeedID, s.Variety, p.Active FROM Brand b Join Seed s on b.BrandID = s.BrandID JOIN Production p ON s.SeedID = p.SeedID JOIN Field f ON p.FieldID = f.FieldID WHERE ProductionID = " & productionID

        myProductionVB = ProductionData.fetchProductionVB(blQuery)


        Return myProductionVB
    End Function


    'ADD PRODUCTION
    Public Function addProductionVB(ByVal productionVB As ProductionVB)
        Dim Success As Boolean = False
        Dim result As String = ""


        Success = ProductionData.addProduction(productionVB.Year, productionVB.PlantDate, productionVB.HarvestDate, productionVB.Yield, productionVB.FieldID, productionVB.SeedID)

        If Success = True Then
            result = "The Production: " & productionVB.Year & " " & productionVB.FieldName & " was entered."
        Else
            result = "The Production: " & productionVB.Year & " " & productionVB.FieldName & " was not entered."
        End If


        Return result
    End Function


    'EDIT PRODUCTION
    Public Function editProduction(ByVal oldProduction As ProductionVB, ByVal newProduction As ProductionVB)

        'Dim oldProduction As New Field
        'oldProduction = oldProduction

        'Dim newProduction As New Field
        'newProduction = newProduction

        Dim results As String = ""

        'If oldProduction.Active = False Then
        '    results = "This Production is currently inactive. You can not edit it at this time"
        'End If


        Dim YearChange As Boolean = False
        Dim pDateChange As Boolean = False
        Dim hDateChange As Boolean = False
        Dim yieldChange As Boolean = False
        Dim fieldIDChange As Boolean = False
        Dim seedIDChange As Boolean = False


        'if oldField name != NewField name
        If oldProduction.Year <> newProduction.Year Then

            YearChange = ProductionData.updateYear(newProduction.Year, oldProduction.ID, oldProduction.Year)

        End If

        If oldProduction.PlantDate <> newProduction.PlantDate Then

            pDateChange = ProductionData.updatePlantDate(newProduction.PlantDate, oldProduction.ID, oldProduction.PlantDate)

        End If

        If oldProduction.HarvestDate <> newProduction.HarvestDate Then

            hDateChange = ProductionData.updateHarvestDate(newProduction.HarvestDate, oldProduction.ID, oldProduction.HarvestDate)

        End If

        If oldProduction.Yield <> newProduction.Yield Then

            yieldChange = ProductionData.updateYield(newProduction.Yield, oldProduction.ID, oldProduction.Yield)

        End If

        If oldProduction.FieldID <> newProduction.FieldID Then

            fieldIDChange = ProductionData.updateFieldID(newProduction.FieldID, oldProduction.ID, oldProduction.FieldID)

        End If

        If oldProduction.SeedID <> newProduction.SeedID Then

            seedIDChange = ProductionData.updateSeedID(newProduction.SeedID, oldProduction.ID, oldProduction.SeedID)

        End If





        If YearChange = True Then
            results = "ProductionID: " & oldProduction.ID & "'s year was changed from " & oldProduction.Year & " to " & newProduction.Year & vbCrLf
        End If

        If pDateChange = True Then
            results = results & "ProductionID: " & oldProduction.ID & "'s plant date was changed from " & oldProduction.PlantDate & " to " & newProduction.PlantDate & "." & vbCrLf
        End If

        If hDateChange = True Then
            results = results & "ProductionID: " & oldProduction.ID & "'s harvest date was changed from " & oldProduction.HarvestDate & " to " & newProduction.HarvestDate & "." & vbCrLf
        End If

        If yieldChange Then
            results = results & "ProductionID: " & oldProduction.ID & "'s yield was changed from " & oldProduction.Yield & " to " & newProduction.Yield & "." & vbCrLf
        End If

        If fieldIDChange Then
            results = results & "ProductionID: " & oldProduction.ID & "'s field was changed from " & oldProduction.FieldName & " to " & newProduction.FieldName & "." & vbCrLf
        End If

        If seedIDChange Then
            results = results & "ProductionID: " & oldProduction.ID & "'s seed was changed from " & oldProduction.SeedVariety & " to " & newProduction.SeedVariety & "." & vbCrLf
        End If

        If YearChange = False And pDateChange = False And hDateChange = False And yieldChange = False And fieldIDChange = False And seedIDChange = False Then
            results = "No Changes where made to the year " & oldProduction.Year & " Production in" & oldProduction.FieldName & " field."
        End If





        Return results
    End Function


    Public Function updateActive(ByVal ProductionID As Integer, ByVal remove As Boolean)
        Dim removeSuccess As Boolean
        Dim reactivateSuccess As Boolean
        Dim results As String = "no changes made"

        Dim myProductionVB As New ProductionVB
        myProductionVB = getProductionVB(ProductionID)

        If myProductionVB.Active And remove = False Then
            results = "Produciton " & myProductionVB.ID & " is already active!"
        ElseIf myProductionVB.Active = False And remove = True Then
            results = "Produciton " & myProductionVB.ID & " has already been removed!"
        Else

            If remove = True Then
                removeSuccess = ProductionData.updateActive(False, ProductionID, True)
            End If
            If remove = False Then
                reactivateSuccess = ProductionData.updateActive(True, ProductionID, False)
            End If

        End If

        If removeSuccess = True Then
            results = "Production " & myProductionVB.ID & " was removed."
        End If
        If reactivateSuccess = True Then
            results = "Production " & myProductionVB.ID & " was reactivated."
        End If

        Return results
    End Function


    Public Function isActive(ByVal productionID As Integer)

        Dim myProduction As New ProductionVB

        myProduction = getProductionVB(productionID)




        Return myProduction.Active
    End Function


    Public Function maxID()
        Dim myID As Integer = ProductionData.maxID

        Return myID
    End Function

End Class
