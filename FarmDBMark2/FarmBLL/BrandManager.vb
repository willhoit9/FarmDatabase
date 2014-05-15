Imports FarmDAL
Imports FarmDataTypes


Public Class BrandManager

    Public Function addBrand(ByVal newBrand As Brand)
        Dim results As String = ""
        Dim success As Boolean = False

        success = BrandData.addBrand(newBrand.BrandName, newBrand.BrandDealerName)

        If success Then
            results = "The Brand, " & newBrand.BrandName & " was added to the Brand Table."
        Else
            results = "The Brand, " & newBrand.BrandName & " was not added to the Brand Table."
        End If

        Return results


    End Function

    Public Function getBrandByID(ByVal BrandID As Integer)
        Dim myBrand As New Brand

        myBrand = BrandData.fetchBrandByID(BrandID)

        Return myBrand
    End Function


    Public Function getBrands(Optional ByVal ActiveOnly As Boolean = False)
        Dim myBrandlist As New List(Of Brand)

        myBrandlist = BrandData.fetchBrandList(ActiveOnly)



        Return myBrandList
    End Function


    Public Function isActive(ByVal brandID As Integer)

        Dim myBrand As New Brand

        myBrand = getBrandByID(brandID)

        Return myBrand.Active

    End Function

    Public Function editBrand(ByVal oldBrand As Brand, ByVal newBrand As Brand)
        Dim results As String = ""
        Dim brandNameChange As Boolean = False
        Dim brandDealerChange As Boolean = False

        If oldBrand.BrandName <> newBrand.BrandName Then
            brandNameChange = BrandData.updateBrandName(newBrand.BrandName, oldBrand.BrandID, oldBrand.BrandName)
        End If

        If oldBrand.BrandDealerName <> newBrand.BrandDealerName Then
            brandDealerChange = BrandData.updateBrandDealerName(newBrand.BrandDealerName, oldBrand.BrandID, oldBrand.BrandDealerName)
        End If

        If brandNameChange Then
            results = "BrandID: " & oldBrand.BrandID & "'s name was changed from " & oldBrand.BrandName & " to " & newBrand.BrandName & "." & vbCrLf
        End If

        If brandDealerChange Then
            results = results & "BrandID: " & oldBrand.BrandID & "'s Dealer was changed from " & oldBrand.BrandDealerName & " to " & newBrand.BrandDealerName & "." & vbCrLf
        End If

        If brandNameChange = False And brandDealerChange = False Then
            results = "No changes were made to BrandID: " & oldBrand.BrandID
        End If

        Return results
    End Function


    Public Function updateActive(ByVal brandID As Integer, ByVal remove As Boolean)
        Dim removeSuccess As Boolean
        Dim reactivateSuccess As Boolean
        Dim results As String = "no changes made"

        If remove = True Then
            removeSuccess = BrandData.updateActive(False, brandID, True)
        End If
        If remove = False Then
            reactivateSuccess = BrandData.updateActive(True, brandID, False)
        End If

        If removeSuccess = True Then
            results = "Brand " & brandID & " was removed."
        End If
        If reactivateSuccess = True Then
            results = "Brand " & brandID & " was reactivated."
        End If

        Return results
    End Function

    Public Function maxID()
        Dim myID As Integer = BrandData.maxID

        Return myID
    End Function

End Class
