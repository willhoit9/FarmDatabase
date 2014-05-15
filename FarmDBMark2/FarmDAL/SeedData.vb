Imports System.Data.SqlClient
Imports FarmDataTypes

Public Class SeedData

    Public Shared Function addSeed(ByVal Variety As String, ByVal SeedName As String, ByVal Crop As String, ByVal BrandID As Integer)
        Dim success As Boolean

        Dim myConn As SqlConnection = DatabaseConnection.GetFarmDBConnection
        Dim number As Integer

        Try
            'myConn()
            Dim mySqlCommand As New SqlCommand("spSeedAdd", myConn)
            mySqlCommand.CommandType = CommandType.StoredProcedure

            mySqlCommand.Parameters.AddWithValue("@Variety", Variety)
            mySqlCommand.Parameters.AddWithValue("@SeedName", SeedName)
            mySqlCommand.Parameters.AddWithValue("@Crop", Crop)
            mySqlCommand.Parameters.AddWithValue("@BrandID", BrandID)

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
        Catch ex As DataException
            MsgBox("There was an error returning data. " & vbCr & ex.Message)
        Catch ex As Exception
            MsgBox("There was an unknown exception. " & vbCr & ex.Message)
        Finally
            myConn.Close()
        End Try

        Return success
    End Function

    Public Shared Function fetchSeedVarietyList()
        Dim seedVarieties As New List(Of String)
        Dim myConn As SqlConnection = DatabaseConnection.GetFarmDBConnection

        Try
            Dim fieldCmd As New SqlCommand("spSeedGetVariety", myConn)
            fieldCmd.CommandType = CommandType.StoredProcedure

            myConn.Open()

            Dim myReader = fieldCmd.ExecuteReader
            If myReader.HasRows Then
                ' MsgBox("reader.hasrows is true")
                Do While myReader.Read
                    seedVarieties.Add(myReader("Variety").ToString)
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

        Return seedVarieties
    End Function



    Public Shared Function fetchSeedList(Optional ByVal Query As String = "SELECT s.SeedID, s.Variety, s.SeedName, s.Crop, s.BrandID, b.BrandName, s.Active FROM Brand b JOIN Seed s ON b.BrandID = s.BrandID")

        Dim mySeedList As New List(Of Seed)
        Dim connection As SqlConnection = DatabaseConnection.GetFarmDBConnection
        '   Dim selectStatement As String = Query

        Try
            connection.Open()

            Dim mySqlCommand As New SqlCommand(Query, connection)
            Dim reader As SqlDataReader = mySqlCommand.ExecuteReader

            If reader.HasRows Then
                ' MsgBox("reader.hasrows is true")

                Dim mySeed As Seed

                Do While reader.Read
                    mySeed = New Seed
                    mySeed.SeedID = CInt(reader("SeedID"))
                    mySeed.Variety = reader("Variety").ToString
                    mySeed.SeedName = reader("SeedName").ToString
                    mySeed.Crop = reader("Crop").ToString
                    mySeed.BrandID = CInt(reader("BrandID"))
                    mySeed.BrandName = reader("BrandName").ToString
                    mySeed.Active = CBool(reader("Active"))

                    mySeedList.Add(mySeed)
                    mySeed = Nothing
                Loop
            End If
            reader.Close()

        Catch ex As SqlException
            MsgBox("Database Server or Connection Error." & vbCr & ex.Message)
        Catch ex As DataException
            MsgBox("There was an error returning data. " & vbCr & ex.Message)
        Catch ex As Exception
            MsgBox("There was an unknown exception. " & vbCr & ex.Message)
        Finally
            connection.Close()
        End Try

        Return mySeedList
    End Function


    Public Shared Function fetchBySeedID(ByVal SeedID As Integer)
        Dim mySeed As New Seed
        Dim myConn As SqlConnection = DatabaseConnection.GetFarmDBConnection

        Try
            Dim mySqlCommand As New SqlCommand("spSeedVBGetByID", myConn)
            mySqlCommand.CommandType = CommandType.StoredProcedure

            mySqlCommand.Parameters.AddWithValue("@SeedID", SeedID)
            myConn.Open()

            Dim myReader = mySqlCommand.ExecuteReader
            If myReader.HasRows Then

                Do While myReader.Read
                    mySeed.SeedID = CInt(myReader("SeedID"))
                    mySeed.Variety = myReader("Variety").ToString
                    mySeed.SeedName = myReader("SeedName").ToString
                    mySeed.Crop = myReader("Crop").ToString
                    mySeed.BrandID = CInt(myReader("BrandID"))
                    mySeed.BrandName = myReader("BrandName").ToString
                    mySeed.Active = CBool(myReader("Active"))
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

        Return mySeed
    End Function


    Public Shared Function updateVariety(ByVal Variety As String, ByVal original_SeedID As Integer, ByVal original_Variety As String)
        Dim success As Boolean
        Dim myConn As SqlConnection = DatabaseConnection.GetFarmDBConnection
        Dim number As Integer

        Try
            'myConn()
            Dim mySqlCommand As New SqlCommand("spSeedUpdateVariety", myConn)
            mySqlCommand.CommandType = CommandType.StoredProcedure

            mySqlCommand.Parameters.AddWithValue("@Variety", Variety)
            mySqlCommand.Parameters.AddWithValue("@original_SeedID", original_SeedID)
            mySqlCommand.Parameters.AddWithValue("@original_Variety", original_Variety)
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


    Public Shared Function updateName(ByVal SeedName As String, ByVal original_SeedID As Integer, ByVal original_SeedName As String)
        Dim success As Boolean
        Dim myConn As SqlConnection = DatabaseConnection.GetFarmDBConnection
        Dim number As Integer

        Try
            'myConn()
            Dim mySqlCommand As New SqlCommand("spSeedUpdateSeedName", myConn)
            mySqlCommand.CommandType = CommandType.StoredProcedure

            mySqlCommand.Parameters.AddWithValue("@SeedName", SeedName)
            mySqlCommand.Parameters.AddWithValue("@original_SeedID", original_SeedID)
            mySqlCommand.Parameters.AddWithValue("@original_SeedName", original_SeedName)
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

    Public Shared Function updateCrop(ByVal Crop As String, ByVal original_SeedID As Integer, ByVal original_Crop As String)
        Dim success As Boolean
        Dim myConn As SqlConnection = DatabaseConnection.GetFarmDBConnection
        Dim number As Integer

        Try
            'myConn()
            Dim mySqlCommand As New SqlCommand("spSeedUpdateCrop", myConn)
            mySqlCommand.CommandType = CommandType.StoredProcedure

            mySqlCommand.Parameters.AddWithValue("@Crop", Crop)
            mySqlCommand.Parameters.AddWithValue("@original_SeedID", original_SeedID)
            mySqlCommand.Parameters.AddWithValue("@original_Crop", original_Crop)
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

    Public Shared Function updateBrandID(ByVal BrandId As Integer, ByVal original_SeedID As Integer, ByVal original_BrandID As Integer)
        Dim success As Boolean
        Dim myConn As SqlConnection = DatabaseConnection.GetFarmDBConnection
        Dim number As Integer

        Try
            'myConn()
            Dim mySqlCommand As New SqlCommand("spSeedUpdateBrandID", myConn)
            mySqlCommand.CommandType = CommandType.StoredProcedure

            mySqlCommand.Parameters.AddWithValue("@BrandId", BrandId)
            mySqlCommand.Parameters.AddWithValue("@original_SeedID", original_SeedID)
            mySqlCommand.Parameters.AddWithValue("@original_BrandID", original_BrandID)
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

    Public Shared Function updateActive(ByVal Active As Boolean, ByVal original_SeedID As Integer, ByVal original_Active As Boolean)
        Dim success As Boolean
        Dim myConn As SqlConnection = DatabaseConnection.GetFarmDBConnection
        Dim number As Integer

        Try
            Dim mySqlCommand As New SqlCommand("spSeedUpdateActive", myConn)
            mySqlCommand.CommandType = CommandType.StoredProcedure

            mySqlCommand.Parameters.AddWithValue("@Active", Active)
            mySqlCommand.Parameters.AddWithValue("@original_SeedID", original_SeedID)
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


    Public Shared Function maxID() As Integer
        Dim myID As Integer
        Dim myConn As SqlConnection = DatabaseConnection.GetFarmDBConnection

        Try
            Dim mySqlCommand As New SqlCommand("spSeedMaxID", myConn)
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


End Class
