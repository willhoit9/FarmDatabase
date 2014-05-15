Imports System.Data.SqlClient
Imports FarmDataTypes

Public Class BrandData


    Public Shared Function addBrand(ByVal BrandName As String, ByVal BrandDealerName As String)
        Dim success As Boolean

        Dim myConn As SqlConnection = DatabaseConnection.GetFarmDBConnection
        Dim number As Integer

        Try
            'myConn()
            Dim mySqlCommand As New SqlCommand("spBrandAdd", myConn)
            mySqlCommand.CommandType = CommandType.StoredProcedure

            mySqlCommand.Parameters.AddWithValue("@BrandName", BrandName)
            mySqlCommand.Parameters.AddWithValue("@BrandDealerName", BrandDealerName)


            myConn.Open()

            number = mySqlCommand.ExecuteNonQuery

            If number = 1 Then
                success = True
            End If

        Catch ex As SqlException

            If ex.Number = 2627 Then
                MsgBox("A primary key Violation has happend. That should not have happend. What did you do?!", , "Primary Key Violation")
            Else
                MsgBox("An SqlException has happened" & vbCrLf & "Here's the details..." & vbCrLf & ex.ToString)
            End If
            'Throw ex
        Catch ex As DataException
            MsgBox("There was an error returning data. " & vbCr & ex.Message)
        Catch ex As Exception
            MsgBox("There was an unknown exception. " & vbCr & ex.Message)
        Finally
            myConn.Close()
        End Try

        Return success
    End Function

    Public Shared Function fetchBrandByID(ByVal BrandID As Integer)
        Dim myBrand As New Brand
        Dim myConn As SqlConnection = DatabaseConnection.GetFarmDBConnection

        Try
            Dim mySqlCommand As New SqlCommand("spBrandGetByID", myConn)
            mySqlCommand.CommandType = CommandType.StoredProcedure

            mySqlCommand.Parameters.AddWithValue("@BrandID", BrandID)
            myConn.Open()

            Dim myReader = mySqlCommand.ExecuteReader
            If myReader.HasRows Then

                Do While myReader.Read

                    myBrand.BrandID = CInt(myReader("BrandID"))
                    myBrand.BrandName = myReader("BrandName").ToString
                    myBrand.BrandDealerName = myReader("BrandDealerName").ToString
                    myBrand.Active = CBool(myReader("Active"))

                Loop

            End If
            myReader.Close()
        Catch ex As SqlException
            MsgBox("Database Server or Connection Error." & vbCr & ex.Message)
        Catch ex As DataException
            MsgBox("There was an error returning data. " & vbCr & ex.Message)
        Catch ex As Exception
            MsgBox("There was an unknown exception. " & vbCr & ex.Message)
        Finally
            myConn.Close()
        End Try
        ' MsgBox(myField.FieldName & myField.Owner & myField.Active)
        Return myBrand
    End Function


    Public Shared Function fetchBrandList(Optional ByVal ActiveOnly As Boolean = False)
        Dim myBrandList As New List(Of Brand)
        Dim myBrand As Brand
        Dim myConn As SqlConnection = DatabaseConnection.GetFarmDBConnection
        Dim sp As String = "spBrandGetAll"

        If ActiveOnly = True Then
            sp = "spBrandGetActive"
        End If

        Try

            Dim mySqlCommand As New SqlCommand(sp, myConn)
            mySqlCommand.CommandType = CommandType.StoredProcedure

            myConn.Open()

            Dim myReader = mySqlCommand.ExecuteReader
            If myReader.HasRows Then

                Do While myReader.Read
                    myBrand = New Brand

                    myBrand.BrandID = CInt(myReader("BrandID"))
                    myBrand.BrandName = myReader("BrandName").ToString
                    myBrand.BrandDealerName = myReader("BrandDealerName").ToString
                    myBrand.Active = CBool(myReader("Active"))

                    myBrandList.Add(myBrand)
                    myBrand = Nothing
                Loop

            End If
            myReader.Close()
        Catch ex As SqlException
            MsgBox("Database Server or Connection Error." & vbCr & ex.Message)
        Catch ex As DataException
            MsgBox("There was an error returning data. " & vbCr & ex.Message)
        Catch ex As Exception
            MsgBox("There was an unknown exception. " & vbCr & ex.Message)
        Finally
            myConn.Close()
        End Try



        Return myBrandList
    End Function


    Public Shared Function maxID() As Integer
        Dim myID As Integer
        Dim myConn As SqlConnection = DatabaseConnection.GetFarmDBConnection

        Try
            Dim mySqlCommand As New SqlCommand("spBrandMaxID", myConn)
            mySqlCommand.CommandType = CommandType.StoredProcedure
            myConn.Open()
            myID = mySqlCommand.ExecuteScalar
        Catch ex As SqlException
            MsgBox("Database Server or Connection Error." & vbCr & ex.Message)
        Catch ex As DataException
            MsgBox("There was an error returning data. " & vbCr & ex.Message)
        Catch ex As Exception
            MsgBox("There was an unknown exception. " & vbCr & ex.Message)
        Finally
            myConn.Close()
        End Try
        Return myID
    End Function

    Public Shared Function updateBrandName(ByVal BrandName As String, ByVal original_BrandID As Integer, ByVal original_BrandName As String)
        Dim success As Boolean
        Dim myConn As SqlConnection = DatabaseConnection.GetFarmDBConnection
        Dim number As Integer

        Try
            'myConn()
            Dim mySqlCommand As New SqlCommand("spBrandUpdateBrandName", myConn)
            mySqlCommand.CommandType = CommandType.StoredProcedure

            mySqlCommand.Parameters.AddWithValue("@BrandName", BrandName)
            mySqlCommand.Parameters.AddWithValue("@original_BrandID", original_BrandID)
            mySqlCommand.Parameters.AddWithValue("@original_BrandName", original_BrandName)
            myConn.Open()

            number = mySqlCommand.ExecuteNonQuery

            If number = 1 Then
                success = True
            End If

        Catch ex As SqlException
            MsgBox("Database Server or Connection Error." & vbCr & ex.Message)
        Catch ex As DataException
            MsgBox("There was an error returning data. " & vbCr & ex.Message)
        Catch ex As Exception
            MsgBox("There was an unknown exception. " & vbCr & ex.Message)
        Finally
            myConn.Close()
        End Try

        Return success
    End Function

    Public Shared Function updateBrandDealerName(ByVal BrandDealerName As String, ByVal original_BrandID As Integer, ByVal original_BrandDealerName As String)
        Dim success As Boolean

        Dim myConn As SqlConnection = DatabaseConnection.GetFarmDBConnection
        Dim number As Integer

        Try
            'myConn()
            Dim mySqlCommand As New SqlCommand("spBrandUpdateBrandDealerName", myConn)
            mySqlCommand.CommandType = CommandType.StoredProcedure

            mySqlCommand.Parameters.AddWithValue("@BrandDealerName", BrandDealerName)
            mySqlCommand.Parameters.AddWithValue("@original_BrandID", original_BrandID)
            mySqlCommand.Parameters.AddWithValue("@original_BrandDealerName", original_BrandDealerName)
            myConn.Open()

            number = mySqlCommand.ExecuteNonQuery

            If number = 1 Then
                success = True
            End If

        Catch ex As SqlException
            MsgBox("Database Server or Connection Error." & vbCr & ex.Message)
        Catch ex As DataException
            MsgBox("There was an error returning data. " & vbCr & ex.Message)
        Catch ex As Exception
            MsgBox("There was an unknown exception. " & vbCr & ex.Message)
        Finally
            myConn.Close()
        End Try

        Return success
    End Function

    Public Shared Function updateActive(ByVal Active As Boolean, ByVal original_BrandID As Integer, ByVal original_Active As Boolean)
        Dim success As Boolean

        Dim myConn As SqlConnection = DatabaseConnection.GetFarmDBConnection
        Dim number As Integer

        Try
            'myConn()
            Dim mySqlCommand As New SqlCommand("spBrandUpdateActive", myConn)
            mySqlCommand.CommandType = CommandType.StoredProcedure

            mySqlCommand.Parameters.AddWithValue("@Active", Active)
            mySqlCommand.Parameters.AddWithValue("@original_BrandID", original_BrandID)
            mySqlCommand.Parameters.AddWithValue("@original_Active", original_Active)
            myConn.Open()

            number = mySqlCommand.ExecuteNonQuery

            If number = 1 Then
                success = True
            End If

        Catch ex As SqlException
            MsgBox("Database Server or Connection Error." & vbCr & ex.Message)
        Catch ex As DataException
            MsgBox("There was an error returning data. " & vbCr & ex.Message)
        Catch ex As Exception
            MsgBox("There was an unknown exception. " & vbCr & ex.Message)
        Finally
            myConn.Close()
        End Try

        Return success
    End Function


End Class
