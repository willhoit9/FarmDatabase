Imports FarmDataTypes
Imports System.Data.SqlClient

Public Class ProductionData






    Public Shared Function fetchProductionVBList(Optional ByVal Query As String = "SELECT p.ProductionID, p.Year, p.PlantDate, p.HarvestDate, p.Yield, p.FieldID, f.FieldName, b.BrandName, p.SeedID, s.Variety, p.Active FROM Brand b Join Seed s on b.BrandID = s.BrandID JOIN Production p ON s.SeedID = p.SeedID JOIN Field f ON p.FieldID = f.FieldID")

        Dim myProductionVBList As New List(Of ProductionVB)

        Dim connection As SqlConnection = DatabaseConnection.GetFarmDBConnection
        '   Dim selectStatement As String = Query

        Try
            connection.Open()

            Dim mySqlCommand As New SqlCommand(Query, connection)
            Dim reader As SqlDataReader = mySqlCommand.ExecuteReader

            If reader.HasRows Then
                ' MsgBox("reader.hasrows is true")

                Dim myProductionVB As ProductionVB

                Do While reader.Read
                    myProductionVB = New ProductionVB

                    myProductionVB.ID = CInt(reader("ProductionID"))
                    myProductionVB.Year = CInt(reader("Year"))
                    myProductionVB.PlantDate = CDate(reader("PlantDate"))
                    myProductionVB.HarvestDate = CDate(reader("HarvestDate"))
                    myProductionVB.Yield = CInt(reader("Yield"))
                    myProductionVB.FieldID = CInt(reader("FieldID"))
                    myProductionVB.FieldName = reader("FieldName").ToString
                    myProductionVB.SeedBrand = reader("BrandName").ToString
                    myProductionVB.SeedID = CInt(reader("SeedID"))
                    myProductionVB.SeedVariety = reader("Variety").ToString
                    myProductionVB.Active = CBool(reader("Active"))

                    myProductionVBList.Add(myProductionVB)
                    myProductionVB = Nothing
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

        'MsgBox(myFieldList(1).FieldName)


        Return myProductionVBList
    End Function

    Public Shared Function maxID() As Integer
        Dim myID As Integer
        Dim myConn As SqlConnection = DatabaseConnection.GetFarmDBConnection

        Try
            Dim mySqlCommand As New SqlCommand("spProductionMaxID", myConn)
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

    Public Shared Function fetchProductionVB(ByVal Query As String)
        Dim myProductionVB As New ProductionVB
        Dim connection As SqlConnection = DatabaseConnection.GetFarmDBConnection

        Try
            connection.Open()

            Dim mySqlCommand As New SqlCommand(Query, connection)
            Dim reader As SqlDataReader = mySqlCommand.ExecuteReader

            If reader.HasRows Then
                ' MsgBox("reader.hasrows is true")



                Do While reader.Read
                    myProductionVB.ID = CInt(reader("ProductionID"))
                    myProductionVB.Year = CInt(reader("Year"))
                    myProductionVB.PlantDate = CDate(reader("PlantDate"))
                    myProductionVB.HarvestDate = CDate(reader("HarvestDate"))
                    myProductionVB.Yield = CInt(reader("Yield"))
                    myProductionVB.FieldID = CInt(reader("FieldID"))
                    myProductionVB.FieldName = reader("FieldName").ToString
                    myProductionVB.SeedBrand = reader("BrandName").ToString
                    myProductionVB.SeedID = CInt(reader("SeedID"))
                    myProductionVB.SeedVariety = reader("Variety").ToString
                    myProductionVB.Active = CBool(reader("Active"))

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

        Return myProductionVB
    End Function

    Public Shared Function addProduction(ByVal Year As Integer, ByVal PlantDate As Date, ByVal HarvestDate As Date, ByVal Yield As Integer, ByVal FieldID As Integer, ByVal SeedID As Integer)
        Dim success As Boolean

        Dim myConn As SqlConnection = DatabaseConnection.GetFarmDBConnection
        Dim number As Integer

        Try
            Dim mySqlCommand As New SqlCommand("spProductionAdd", myConn)
            mySqlCommand.CommandType = CommandType.StoredProcedure

            mySqlCommand.Parameters.AddWithValue("@Year", Year)
            mySqlCommand.Parameters.AddWithValue("@PlantDate", PlantDate)
            mySqlCommand.Parameters.AddWithValue("@HarvestDate", HarvestDate)
            mySqlCommand.Parameters.AddWithValue("@Yield", Yield)
            mySqlCommand.Parameters.AddWithValue("@FieldID", FieldID)
            mySqlCommand.Parameters.AddWithValue("@SeedID", SeedID)

            myConn.Open()

            number = mySqlCommand.ExecuteNonQuery

            If number = 1 Then
                success = True
            End If

        Catch ex As SqlException
            If ex.Number = 2627 Then
                MsgBox("There is already a Production in the table with the year " & Year & " and the Field you chose, Field " & FieldID & "." &
                       vbCrLf & "Please choose another Year or another Field Name.", , "Primary Key Violation")
            Else
                MsgBox("An SqlException has happened" & vbCrLf & "Here's the details..." & vbCrLf & ex.Message)
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


    Public Shared Function updateYear(ByVal Year As Integer, ByVal original_ProductionID As Integer, ByVal original_Year As Integer)
        Dim success As Boolean

        Dim myConn As SqlConnection = DatabaseConnection.GetFarmDBConnection
        Dim number As Integer

        Try
            'myConn()
            Dim mySqlCommand As New SqlCommand("spProductionUpdateYear", myConn)
            mySqlCommand.CommandType = CommandType.StoredProcedure

            mySqlCommand.Parameters.AddWithValue("@Year", Year)
            mySqlCommand.Parameters.AddWithValue("@original_ProductionID", original_ProductionID)
            mySqlCommand.Parameters.AddWithValue("@original_Year", original_Year)
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

    ' UPDATE FIELD ID IN A PRODUCTION
    Public Shared Function updateFieldID(ByVal FieldID As Integer, ByVal original_ProductionID As Integer, ByVal original_FieldID As Integer)
        Dim success As Boolean

        Dim myConn As SqlConnection = DatabaseConnection.GetFarmDBConnection
        Dim number As Integer

        Try
            'myConn()
            Dim mySqlCommand As New SqlCommand("spProductionUpdateFieldID", myConn)
            mySqlCommand.CommandType = CommandType.StoredProcedure

            mySqlCommand.Parameters.AddWithValue("@FieldID", FieldID)
            mySqlCommand.Parameters.AddWithValue("@original_ProductionID", original_ProductionID)
            mySqlCommand.Parameters.AddWithValue("@original_FieldID", original_FieldID)
            myConn.Open()

            number = mySqlCommand.ExecuteNonQuery

            If number = 1 Then
                success = True
            End If


        Catch ex As SqlException

            If ex.Number = 2627 Then
                MsgBox("There is already a Production in the table with this Year and Field combination. The Field you chose, was Field " & FieldID & "." & vbCrLf & "Please choose another Year or another Field Name.", , "Primary Key Violation")
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


    Public Shared Function updateSeedID(ByVal SeedID As Integer, ByVal original_ProductionID As Integer, ByVal original_SeedID As Integer)
        Dim success As Boolean

        Dim myConn As SqlConnection = DatabaseConnection.GetFarmDBConnection
        Dim number As Integer

        Try
            'myConn()
            Dim mySqlCommand As New SqlCommand("spProductionUpdateSeedID", myConn)
            mySqlCommand.CommandType = CommandType.StoredProcedure

            mySqlCommand.Parameters.AddWithValue("@SeedID", SeedID)
            mySqlCommand.Parameters.AddWithValue("@original_ProductionID", original_ProductionID)
            mySqlCommand.Parameters.AddWithValue("@original_SeedID", original_SeedID)
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


    Public Shared Function updatePlantDate(ByVal PlantDate As Date, ByVal original_ProductionID As Integer, ByVal original_PlantDate As Date)
        Dim success As Boolean

        Dim myConn As SqlConnection = DatabaseConnection.GetFarmDBConnection
        Dim number As Integer

        Try
            'myConn()
            Dim mySqlCommand As New SqlCommand("spProductionUpdatePlantDate", myConn)
            mySqlCommand.CommandType = CommandType.StoredProcedure

            mySqlCommand.Parameters.AddWithValue("@PlantDate", PlantDate)
            mySqlCommand.Parameters.AddWithValue("@original_ProductionID", original_ProductionID)
            mySqlCommand.Parameters.AddWithValue("@original_PlantDate", original_PlantDate)
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



    Public Shared Function updateHarvestDate(ByVal HarvestDate As Date, ByVal original_ProductionID As Integer, ByVal original_HarvestDate As Date)
        Dim success As Boolean

        Dim myConn As SqlConnection = DatabaseConnection.GetFarmDBConnection
        Dim number As Integer

        Try
            'myConn()
            Dim mySqlCommand As New SqlCommand("spProductionUpdateHarvestDate", myConn)
            mySqlCommand.CommandType = CommandType.StoredProcedure

            mySqlCommand.Parameters.AddWithValue("@HarvestDate", HarvestDate)
            mySqlCommand.Parameters.AddWithValue("@original_ProductionID", original_ProductionID)
            mySqlCommand.Parameters.AddWithValue("@original_HarvestDate", original_HarvestDate)
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


    Public Shared Function updateYield(ByVal Yield As Integer, ByVal original_ProductionID As Integer, ByVal original_Yield As Integer)
        Dim success As Boolean

        Dim myConn As SqlConnection = DatabaseConnection.GetFarmDBConnection
        Dim number As Integer

        Try
            'myConn()
            Dim mySqlCommand As New SqlCommand("spProductionUpdateYield", myConn)
            mySqlCommand.CommandType = CommandType.StoredProcedure

            mySqlCommand.Parameters.AddWithValue("@Yield", Yield)
            mySqlCommand.Parameters.AddWithValue("@original_ProductionID", original_ProductionID)
            mySqlCommand.Parameters.AddWithValue("@original_Yield", original_Yield)
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

    Public Shared Function updateActive(ByVal Active As Boolean, ByVal original_ProductionID As Integer, ByVal original_Active As Boolean)
        Dim success As Boolean

        Dim myConn As SqlConnection = DatabaseConnection.GetFarmDBConnection
        Dim number As Integer

        Try
            'myConn()
            Dim mySqlCommand As New SqlCommand("spProductionUpdateActive", myConn)
            mySqlCommand.CommandType = CommandType.StoredProcedure

            mySqlCommand.Parameters.AddWithValue("@Active", Active)
            mySqlCommand.Parameters.AddWithValue("@original_ProductionID", original_ProductionID)
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
