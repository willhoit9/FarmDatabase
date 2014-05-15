Imports System.Data.SqlClient
Imports FarmDataTypes

Public Class ChemData

    Public Shared Function fetchChemList(Optional ByVal Query As String = "SELECT * FROM Chemical")
        Dim myChemList As New List(Of Chemical)
        Dim connection As SqlConnection = DatabaseConnection.GetFarmDBConnection

        Try
            connection.Open()

            Dim mySqlCommand As New SqlCommand(Query, connection)
            Dim reader As SqlDataReader = mySqlCommand.ExecuteReader

            If reader.HasRows Then

                Dim myChemical As Chemical

                Do While reader.Read
                    myChemical = New Chemical

                    myChemical.ChemicalID = CInt(reader("ChemicalID"))
                    myChemical.ChemicalName = reader("ChemicalName").ToString
                    myChemical.ChemicalBrand = reader("ChemicalBrand").ToString
                    myChemical.ChemicalType = reader("ChemicalType").ToString
                    myChemical.Active = CBool(reader("Active"))

                    myChemList.Add(myChemical)

                    myChemical = Nothing
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

        Return myChemList
    End Function


    Public Shared Function fetchByChemID(ByVal ChemicalID As Integer)
        Dim myChem As New Chemical
        Dim myConn As SqlConnection = DatabaseConnection.GetFarmDBConnection

        Try
            Dim mySqlCommand As New SqlCommand("spChemicalGetByID", myConn)
            mySqlCommand.CommandType = CommandType.StoredProcedure

            mySqlCommand.Parameters.AddWithValue("@ChemicalID", ChemicalID)
            myConn.Open()

            Dim myReader = mySqlCommand.ExecuteReader
            If myReader.HasRows Then

                Do While myReader.Read
                    myChem.ChemicalID = CInt(myReader("ChemicalID"))
                    myChem.ChemicalName = myReader("ChemicalName").ToString
                    myChem.ChemicalBrand = myReader("ChemicalBrand").ToString
                    myChem.ChemicalType = myReader("ChemicalType").ToString
                    myChem.Active = CBool(myReader("Active"))
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
        Return myChem
    End Function


    Public Shared Function AddChem(ByVal ChemicalName As String, ByVal ChemicalBrand As String, ByVal ChemicalType As String)

        Dim Success As Boolean = False
        Dim myConn As SqlConnection = DatabaseConnection.GetFarmDBConnection
        Dim number As Integer

        Try
            'myConn()
            Dim mySqlCommand As New SqlCommand("spChemicalAdd", myConn)
            mySqlCommand.CommandType = CommandType.StoredProcedure

            mySqlCommand.Parameters.AddWithValue("@ChemicalName", ChemicalName)
            mySqlCommand.Parameters.AddWithValue("@ChemicalBrand", ChemicalBrand)
            mySqlCommand.Parameters.AddWithValue("@ChemicalType", ChemicalType)
            myConn.Open()

            number = mySqlCommand.ExecuteNonQuery

            If number = 1 Then
                Success = True
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

        Return Success
    End Function


    Public Shared Function updateChemName(ByVal ChemicalName As String, ByVal original_ChemicalID As Integer, ByVal original_ChemicalName As String)
        Dim success As Boolean
        Dim myConn As SqlConnection = DatabaseConnection.GetFarmDBConnection
        Dim number As Integer

        Try
            'myConn()
            Dim mySqlCommand As New SqlCommand("spChemicalUpdateName", myConn)
            mySqlCommand.CommandType = CommandType.StoredProcedure

            mySqlCommand.Parameters.AddWithValue("@ChemicalName", ChemicalName)
            mySqlCommand.Parameters.AddWithValue("@original_ChemicalID", original_ChemicalID)
            mySqlCommand.Parameters.AddWithValue("@original_ChemicalName", original_ChemicalName)
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


    Public Shared Function updateChemBrand(ByVal ChemicalBrand As String, ByVal original_ChemicalID As Integer, ByVal original_ChemicalBrand As String)
        Dim success As Boolean
        Dim myConn As SqlConnection = DatabaseConnection.GetFarmDBConnection
        Dim number As Integer

        Try
            'myConn()
            Dim mySqlCommand As New SqlCommand("spChemicalUpdateBrand", myConn)
            mySqlCommand.CommandType = CommandType.StoredProcedure

            mySqlCommand.Parameters.AddWithValue("@ChemicalBrand", ChemicalBrand)
            mySqlCommand.Parameters.AddWithValue("@original_ChemicalID", original_ChemicalID)
            mySqlCommand.Parameters.AddWithValue("@original_ChemicalBrand", original_ChemicalBrand)
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

    Public Shared Function updateChemType(ByVal ChemicalType As String, ByVal original_ChemicalID As Integer, ByVal original_ChemicalType As String)
        Dim success As Boolean
        Dim myConn As SqlConnection = DatabaseConnection.GetFarmDBConnection
        Dim number As Integer

        Try
            'myConn()
            Dim mySqlCommand As New SqlCommand("spChemicalUpdateType", myConn)
            mySqlCommand.CommandType = CommandType.StoredProcedure

            mySqlCommand.Parameters.AddWithValue("@ChemicalType", ChemicalType)
            mySqlCommand.Parameters.AddWithValue("@original_ChemicalID", original_ChemicalID)
            mySqlCommand.Parameters.AddWithValue("@original_ChemicalType", original_ChemicalType)
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


    Public Shared Function updateActive(ByVal Active As Boolean, ByVal original_ChemicalID As Integer, ByVal original_Active As String)
        Dim success As Boolean
        Dim myConn As SqlConnection = DatabaseConnection.GetFarmDBConnection
        Dim number As Integer

        Try
            Dim mySqlCommand As New SqlCommand("spChemicalUpdateActive", myConn)
            mySqlCommand.CommandType = CommandType.StoredProcedure

            mySqlCommand.Parameters.AddWithValue("@Active", Active)
            mySqlCommand.Parameters.AddWithValue("@original_ChemicalID", original_ChemicalID)
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
            Dim mySqlCommand As New SqlCommand("spChemicalMaxID", myConn)
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
