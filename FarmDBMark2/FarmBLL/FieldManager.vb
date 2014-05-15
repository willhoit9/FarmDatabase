Imports FarmDAL
Imports FarmDataTypes



Public Class FieldManager

    'add a field
    Public Function addAField(ByVal fieldName As String, ByVal acres As Integer, ByVal owner As String)

        Dim Success As Boolean = False

        Success = FieldData.AddField(fieldName, acres, owner)

        Return Success
    End Function


    Public Function addField(ByVal newF As Field)

        Dim newField As New Field
        newField = newF
        Dim Success As Boolean = False

        Success = FieldData.AddField(newField.FieldName, newField.Acres, newField.Owner)

        Dim fieldaddresults As String = ""

        If Success = True Then
            fieldaddresults = "The Field """ & newField.FieldName & """ was added to the Fields Table."
        Else
            fieldaddresults = "No Field was added."
        End If


        Return fieldaddresults

    End Function


    Public Function getFieldByID(ByVal searchFieldID As Integer)
        Dim searchField As New Field

        searchField = FieldData.fetchFieldByID(searchFieldID)


        Return searchField
    End Function

    Public Function getFieldNames()
        Dim fieldNameList As List(Of String)

        fieldNameList = FieldData.fetchFieldNameList()


        Return fieldNameList
    End Function

    ' fetch a list fields
    Public Function getFieldList(Optional ByVal blSelectedIndex As Integer = 0, Optional ByVal active As Boolean = True, Optional ByVal forcedAscension As Boolean = False) 'As List(Of Field)


        Dim blQuery As String = "SELECT * FROM Field"

        Dim fieldList As List(Of Field)



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
                blQuery = blQuery & blActive & " ORDER BY FieldID"
            Case 1
                blQuery = blQuery & blActive & " ORDER BY FieldName"
            Case 2
                blQuery = blQuery & blActive & " ORDER BY Acres"
            Case 3
                blQuery = blQuery & blActive & " ORDER BY Owner"
            Case 4
                blQuery = blQuery & blActive & " ORDER BY Active"

        End Select

        If forcedAscension = False Then
            blQuery = blQuery & " " & sortDirection
        Else
            blQuery = blQuery & " ASC"
        End If

        fieldList = FieldData.fetchFieldList(blQuery)


        Return fieldList
    End Function


    ' fetch all active fields
    Public Function getFieldActiveList()
        Dim fieldList As List(Of Field)

        fieldList = FieldData.fetchActiveFieldList

        Return fieldList
    End Function


    'change a field
    Public Function editField(ByVal oldF As Field, ByVal newF As Field)

        Dim oldField As New Field
        oldField = oldF

        Dim newField As New Field
        newField = newF

        Dim nameChange As Boolean = False
        Dim acreChange As Boolean = False
        Dim ownerChange As Boolean = False



        If oldField.FieldName <> newField.FieldName Then

            nameChange = FieldData.UpdateFieldName(newField.FieldName, oldField.FieldName, oldField.FieldID)

        End If

        If oldField.Acres <> newField.Acres Then

            acreChange = FieldData.UpdateFieldAcres(newField.Acres, oldField.FieldID, oldField.Acres)

        End If

        If oldField.Owner <> newField.Owner Then

            ownerChange = FieldData.UpdateFieldOwner(newField.Owner, oldField.FieldID, oldField.Owner)

        End If

        Dim FieldEditResults As String = ""

        If nameChange = True Then
            FieldEditResults = oldField.FieldName & " was changed to " & newField.FieldName & vbCrLf
        End If

        If acreChange = True Then
            FieldEditResults = FieldEditResults & oldField.FieldName & " acres was changed from " & oldField.Acres & " to " & newField.Acres & "." & vbCrLf
        End If

        If ownerChange = True Then
            FieldEditResults = FieldEditResults & oldField.FieldName & " owner was changed from " & oldField.Owner & " to " & newField.Owner & "." & vbCrLf
        End If

        If nameChange = False And acreChange = False And ownerChange = False Then
            FieldEditResults = "No Changes where made to " & oldField.FieldName & "."
        End If



        Return FieldEditResults
    End Function

    'deactivate a field

    Public Function removeField(ByVal oldF As Field, ByVal newF As Field)
        Dim fieldRemoveResults As String

        Dim oldField As New Field
        oldField = oldF

        Dim newField As New Field
        newField = newF

        Dim activeChange As Boolean = False

        If oldField.Active <> newField.Active Then

            activeChange = FieldData.UpdateFieldActive(newField.Active, oldField.FieldID, oldField.Active)

        End If

        If activeChange = True Then
            fieldRemoveResults = "The field """ & oldField.FieldName & """ was removed."
        Else
            fieldRemoveResults = "The field """ & oldField.FieldName & """ was unable to be removed."
        End If

        Return fieldRemoveResults
    End Function



    Public Function reactivateField(ByVal oldF As Field, ByVal newF As Field)
        Dim fieldReactivateResults As String

        Dim oldField As New Field
        oldField = oldF

        Dim newField As New Field
        newField = newF


        Dim activeChange As Boolean = False

        If oldField.Active <> newField.Active Then

            activeChange = FieldData.UpdateFieldActive(newField.Active, oldField.FieldID, oldField.Active)

        End If

        If activeChange = True Then
            fieldReactivateResults = "The field """ & oldField.FieldName & """ was reactivated."
        Else
            fieldReactivateResults = "The field """ & oldField.FieldName & """ was unable to be reactivated."
        End If


        Return fieldReactivateResults
    End Function

    Public Function maxID()
        Dim myID As Integer = FieldData.maxID

        Return myID
    End Function

End Class
