Imports FarmDAL
Imports FarmDataTypes

Public Class SeedManager





    Public Function getSeedVarieties()
        Dim seedVariteyList As List(Of String)

        seedVariteyList = SeedData.fetchSeedVarietyList()


        Return seedVariteyList
    End Function

    Public Function addSeed(ByVal newSeed As Seed)
        Dim success As Boolean = False
        Dim results As String = ""

        success = SeedData.addSeed(newSeed.Variety, newSeed.SeedName, newSeed.Crop, newSeed.BrandID)

        If success Then
            results = "The seed, " & newSeed.SeedName & ", was added to the Seed Table."
        Else
            results = "The seed, " & newSeed.SeedName & ", was not added to the Seed Table."
        End If

        Return results
    End Function


    ' fetch a list of seeds
    Public Function getSeedList(Optional ByVal blSelectedIndex As Integer = 0, Optional ByVal active As Boolean = True, Optional ByVal forcedAscension As Boolean = False) 'As List(Of Seed)


        Dim blQuery As String = "SELECT s.SeedID, s.Variety, s.SeedName, s.Crop, s.BrandID, b.BrandName, s.Active FROM Brand b JOIN Seed s ON b.BrandID = s.BrandID"

        Dim seedList As List(Of Seed)



        Dim blActive As String = " WHERE s.Active = 1 "
        If active = False Then
            blActive = ""
        End If


        Static Dim sortDirection As String = "DESC"
        If sortDirection = "DESC" Then
            sortDirection = "ASC"
        Else
            sortDirection = "DESC"
        End If

        ' hey, dummy! is this right? check later!
        Select Case blSelectedIndex
            Case 0
                blQuery = blQuery & blActive & " ORDER BY s.SeedID"
            Case 1
                blQuery = blQuery & blActive & " ORDER BY s.Variety"
            Case 2
                blQuery = blQuery & blActive & " ORDER BY s.SeedName"
            Case 3
                blQuery = blQuery & blActive & " ORDER BY s.Crop"
            Case 4
                blQuery = blQuery & blActive & " ORDER BY b.BrandName"
            Case 5
                blQuery = blQuery & blActive & " ORDER BY s.Active"

        End Select

        If forcedAscension = False Then
            blQuery = blQuery & " " & sortDirection
        Else
            blQuery = blQuery & " ASC"
        End If

        '  MsgBox(blQuery)

        seedList = SeedData.fetchSeedList(blQuery)

        Return seedList
    End Function

    Public Function getSeed(ByVal SeedID As Integer)
        Dim mySeed As New Seed
        mySeed = SeedData.fetchBySeedID(SeedID)

        Return mySeed
    End Function


    Public Function editSeed(ByVal oldSeed As Seed, ByVal newSeed As Seed)

        Dim results As String = ""

        Dim VarietyChange As Boolean = False
        Dim SeedNameChange As Boolean = False
        Dim CropChange As Boolean = False
        Dim BrandIDChange As Boolean = False

        If oldSeed.Variety <> newSeed.Variety Then

            VarietyChange = SeedData.updateVariety(newSeed.Variety, oldSeed.SeedID, oldSeed.Variety)

        End If

        If oldSeed.SeedName <> newSeed.SeedName Then

            SeedNameChange = SeedData.updateName(newSeed.SeedName, oldSeed.SeedID, oldSeed.SeedName)

        End If

        If oldSeed.Crop <> newSeed.Crop Then

            CropChange = SeedData.updateCrop(newSeed.Crop, oldSeed.SeedID, oldSeed.Crop)

        End If

        If oldSeed.BrandID <> newSeed.BrandID Then

            BrandIDChange = SeedData.updateBrandID(newSeed.BrandID, oldSeed.SeedID, oldSeed.BrandID)

        End If

        If BrandIDChange = True Then
            results = results & "SeedID: " & oldSeed.SeedID & "'s brand was changed from " & oldSeed.BrandName & " to " & newSeed.BrandName & "." & vbCrLf
        End If

        If SeedNameChange = True Then
            results = results & "SeedID: " & oldSeed.SeedID & "'s Name was changed from " & oldSeed.SeedName & " to " & newSeed.SeedName & "." & vbCrLf
        End If

        If VarietyChange = True Then
            results = "SeedID: " & oldSeed.SeedID & "'s variety was changed from " & oldSeed.Variety & " to " & newSeed.Variety & vbCrLf
        End If

        If CropChange = True Then
            results = results & "SeedID: " & oldSeed.SeedID & "'s Crop was changed from " & oldSeed.Crop & " to " & newSeed.Crop & "." & vbCrLf
        End If



        If VarietyChange = False And SeedNameChange = False And CropChange = False And BrandIDChange = False Then
            results = "No changes were made to the Seed: " & oldSeed.SeedName
        End If


        Return results
    End Function

    Public Function updateActive(ByVal seedID As Integer, ByVal remove As Boolean)
        Dim removeSuccess As Boolean
        Dim reactivateSuccess As Boolean
        Dim results As String = "no changes made"

        Dim mySeedVB As New Seed
        mySeedVB = SeedData.fetchBySeedID(seedID)

        'If mySeedVB.Active And remove = False Then
        '    results = "Seed " & mySeedVB.SeedID & " is already active!"
        'ElseIf mySeedVB.Active = False And remove = True Then
        '    results = "Seed " & mySeedVB.SeedID & " has already been removed!"
        'Else

        If remove = True Then
            removeSuccess = SeedData.updateActive(False, seedID, True)
        End If
        If remove = False Then
            reactivateSuccess = SeedData.updateActive(True, seedID, False)
        End If

        '     End If

        If removeSuccess = True Then
            results = "Seed " & mySeedVB.SeedID & " was removed."
        End If
        If reactivateSuccess = True Then
            results = "Seed " & mySeedVB.SeedID & " was reactivated."
        End If

        Return results
    End Function

    Public Function isActive(ByVal seedID As Integer)

        Dim mySeed As New Seed

        mySeed = getSeed(seedID)

        Return mySeed.Active

    End Function


    Public Function maxID()
        Dim myID As Integer = SeedData.maxID

        Return myID
    End Function

End Class
