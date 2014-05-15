Imports FarmDAL
Imports FarmDataTypes


Public Class ProdChemManager




    Public Function getProdChemList(ByVal productionID As Integer, Optional ByVal activeOnly As Boolean = False)
        Dim myProdChemList As List(Of ProdChemVB)


        myProdChemList = FarmDAL.ProdChemData.fetchChemForProductionByID(productionID, activeOnly)
      
        Return myProdChemList
    End Function



    Public Function addProdChemRelationship(ByVal ChemicalID As Integer, ByVal ProductionID As Integer, ByVal ApplicationDate As Date)

        Dim success As Boolean


        success = ProdChemData.addProdChemRelationship(ChemicalID, ProductionID, ApplicationDate)

        Return success
    End Function



    Public Function swapProdChem(ByVal oldPC As ProdChemVB, ByVal newPC As ProdChemVB)
        Dim prodChemSwapResults As String = "No Changes were made"

        Dim oldProdChem As New ProdChemVB
        oldProdChem = oldPC

        Dim newProdChem As New ProdChemVB
        newProdChem = newPC

        Dim activeChange As Boolean = False

        If oldProdChem.Active <> newProdChem.Active Then

            activeChange = ProdChemData.UpdateProdChemActive(oldProdChem.ProductionID, oldProdChem.ChemicalID, oldProdChem.Active, newProdChem.Active)

        End If


        If oldProdChem.Active = False Then
            If activeChange = True Then
                prodChemSwapResults = "The Chemical """ & oldProdChem.ChemicalName & """ was reactivated."
            Else
                prodChemSwapResults = "The Chemical """ & oldProdChem.ChemicalName & """ was unable to be reactivated."
            End If
        End If

        If oldProdChem.Active = True Then
            If activeChange = True Then
                prodChemSwapResults = "The Chemical """ & oldProdChem.ChemicalName & """ was removed."
            Else
                prodChemSwapResults = "The Chemical """ & oldProdChem.ChemicalName & """ was unable to be removed."
            End If
        End If


        Return prodChemSwapResults
    End Function




    Public Function editProdChem(ByVal oldPC As ProdChemVB, ByVal newPC As ProdChemVB)

        Dim oldProdChem As New ProdChemVB
        oldProdChem = oldPC

        Dim newProdChem As New ProdChemVB
        newProdChem = newPC

        Dim ApplicationChange As Boolean = False


        'killed:
        'Dim ChemChange As Boolean = False
        'If oldProdChem.ChemicalID <> newProdChem.ChemicalID Then
        '    ChemChange = 
        'End If


        If oldProdChem.ApplicationDate <> newProdChem.ApplicationDate Then

            ApplicationChange = FarmDAL.ProdChemData.editProdChem(oldProdChem.ProductionID, oldProdChem.ChemicalID, oldProdChem.ApplicationDate, newProdChem.ApplicationDate)


        End If





        Dim ProdChemEditResults As String = ""

        'If ChemChange = True Then
        '    ProdChemEditResults = oldProdChem.ChemicalName & " was changed to " & newProdChem.ChemicalName & vbCrLf
        'End If

        If ApplicationChange = True Then
            ProdChemEditResults = ProdChemEditResults & "Application Date was changed from " & oldProdChem.ApplicationDate & " to " & newProdChem.ApplicationDate & "." & vbCrLf
        End If


        If ApplicationChange = False Then ' And ChemChange = False Then
            ProdChemEditResults = "No Changes where made the chemical in Production: " & oldProdChem.ProductionID & "."
        End If


        Return ProdChemEditResults
    End Function





End Class
