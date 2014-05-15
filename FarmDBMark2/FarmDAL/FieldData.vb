Imports System.Data.SqlClient
Imports FarmDataTypes


Public Class FieldData

    Public Shared Function AddField(ByVal FieldName As String, ByVal Acres As Integer, ByVal Owner As String)

        Dim Success As Boolean = False
        Dim myConn As SqlConnection = DatabaseConnection.GetFarmDBConnection
        Dim number As Integer

        Try
            'myConn()
            Dim fieldCmd As New SqlCommand("spInsertField", myConn)
            fieldCmd.CommandType = CommandType.StoredProcedure

            fieldCmd.Parameters.AddWithValue("@FieldName", FieldName)
            fieldCmd.Parameters.AddWithValue("@Acres", Acres)
            fieldCmd.Parameters.AddWithValue("@Owner", Owner)
            myConn.Open()

            number = fieldCmd.ExecuteNonQuery

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

    Public Shared Function fetchFieldByID(ByVal searchFieldID As Integer)
        Dim myField As New Field
        Dim myConn As SqlConnection = DatabaseConnection.GetFarmDBConnection

        Try
            Dim fieldCmd As New SqlCommand("spFieldGetByID", myConn)
            fieldCmd.CommandType = CommandType.StoredProcedure

            fieldCmd.Parameters.AddWithValue("@FieldID", searchFieldID)
            myConn.Open()

            Dim myReader = fieldCmd.ExecuteReader
            If myReader.HasRows Then
                ' MsgBox("reader.hasrows is true")


                Do While myReader.Read

                    myField.FieldID = CInt(myReader("FieldID"))
                    myField.FieldName = myReader("FieldName").ToString
                    myField.Acres = CInt(myReader("Acres"))
                    myField.Owner = myReader("Owner").ToString
                    myField.Active = CBool(myReader("Active"))

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
        Return myField
    End Function

    Public Shared Function maxID() As Integer
        Dim myID As Integer
        Dim myConn As SqlConnection = DatabaseConnection.GetFarmDBConnection

        Try
            Dim mySqlCommand As New SqlCommand("spFieldMaxID", myConn)
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

    Public Shared Function fetchFieldNameList()
        Dim fieldNames As New List(Of String)


        Dim myConn As SqlConnection = DatabaseConnection.GetFarmDBConnection

        Try
            Dim fieldCmd As New SqlCommand("spFieldGetNames", myConn)
            fieldCmd.CommandType = CommandType.StoredProcedure

            myConn.Open()

            Dim myReader = fieldCmd.ExecuteReader
            If myReader.HasRows Then
                ' MsgBox("reader.hasrows is true")


                Do While myReader.Read

                    fieldNames.Add(myReader("FieldName").ToString)

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

        Return fieldNames
    End Function


    Public Shared Function UpdateFieldName(ByVal newFieldName As String, ByVal oldFieldName As String, ByVal oldfieldId As Integer)

        Dim Success As Boolean = False
        Dim myConn As SqlConnection = DatabaseConnection.GetFarmDBConnection
        Dim number As Integer

        Try
            'myConn()
            Dim fieldCmd As New SqlCommand("spFieldUpdateName", myConn)
            fieldCmd.CommandType = CommandType.StoredProcedure

            fieldCmd.Parameters.AddWithValue("@FieldName", newFieldName)
            fieldCmd.Parameters.AddWithValue("@original_FieldID", oldfieldId)
            fieldCmd.Parameters.AddWithValue("@original_FieldName", oldFieldName)
            myConn.Open()

            number = fieldCmd.ExecuteNonQuery

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

        '  MsgBox(Success & " in updateFieldName")

        Return Success
    End Function



    Public Shared Function UpdateFieldAcres(ByVal newFieldAcres As Integer, ByVal oldfieldId As Integer, ByVal oldFieldAcres As Integer)

        Dim Success As Boolean = False
        Dim myConn As SqlConnection = DatabaseConnection.GetFarmDBConnection
        Dim number As Integer

        Try
            'myConn()
            Dim fieldCmd As New SqlCommand("spFieldUpdateAcres", myConn)
            fieldCmd.CommandType = CommandType.StoredProcedure

            fieldCmd.Parameters.AddWithValue("@Acres", newFieldAcres)
            fieldCmd.Parameters.AddWithValue("@original_FieldID", oldfieldId)
            fieldCmd.Parameters.AddWithValue("@original_Acres", oldFieldAcres)
            myConn.Open()

            number = fieldCmd.ExecuteNonQuery

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

        ' MsgBox(Success & " in updateFieldAcres")

        Return Success
    End Function


    Public Shared Function UpdateFieldOwner(ByVal newFieldOwner As String, ByVal oldfieldId As Integer, ByVal oldFieldOwner As String)

        Dim Success As Boolean = False
        Dim myConn As SqlConnection = DatabaseConnection.GetFarmDBConnection
        Dim number As Integer

        Try
            'myConn()
            Dim fieldCmd As New SqlCommand("spFieldUpdateOwner", myConn)
            fieldCmd.CommandType = CommandType.StoredProcedure

            fieldCmd.Parameters.AddWithValue("@Owner", newFieldOwner)
            fieldCmd.Parameters.AddWithValue("@original_FieldID", oldfieldId)
            fieldCmd.Parameters.AddWithValue("@original_Owner", oldFieldOwner)
            myConn.Open()

            number = fieldCmd.ExecuteNonQuery

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

        '      MsgBox(Success & " in updateFieldOwner")

        Return Success
    End Function


    Public Shared Function UpdateFieldActive(ByVal newFieldActive As Boolean, ByVal oldfieldId As Integer, ByVal oldFieldActive As Boolean)

        Dim Success As Boolean = False
        Dim myConn As SqlConnection = DatabaseConnection.GetFarmDBConnection
        Dim number As Integer

        Try
            Dim fieldCmd As New SqlCommand("spFieldUpdateActive", myConn)
            fieldCmd.CommandType = CommandType.StoredProcedure

            fieldCmd.Parameters.AddWithValue("@Active", newFieldActive)
            fieldCmd.Parameters.AddWithValue("@original_FieldID", oldfieldId)
            fieldCmd.Parameters.AddWithValue("@original_Active", oldFieldActive)
            myConn.Open()

            number = fieldCmd.ExecuteNonQuery

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


    Public Shared Function fetchActiveFieldList()
        Dim myFieldList As New List(Of Field)
        Dim myConn As SqlConnection = DatabaseConnection.GetFarmDBConnection

        Try
            Dim fieldCmd As New SqlCommand("spGetActiveFields", myConn)
            fieldCmd.CommandType = CommandType.StoredProcedure

            Dim myReader = fieldCmd.ExecuteReader
            If myReader.HasRows Then

                Dim myfield As Field
                Do While myReader.Read
                    myfield = New Field
                    myfield.FieldID = CInt(myReader("FieldID"))
                    myfield.FieldName = myReader("FieldName").ToString
                    myfield.Acres = CInt(myReader("Acres"))
                    myfield.Owner = myReader("Owner").ToString
                    myfield.Active = CBool(myReader("Active"))

                    myFieldList.Add(myfield)
                    myfield = Nothing

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

        Return myFieldList
    End Function


    Public Shared Function fetchFieldList(Optional ByVal Query As String = "SELECT * FROM Field")

        Dim myFieldList As New List(Of Field)
        Dim connection As SqlConnection = DatabaseConnection.GetFarmDBConnection

        Try
            connection.Open()

            Dim mySqlCommand As New SqlCommand(Query, connection)
            Dim reader As SqlDataReader = mySqlCommand.ExecuteReader

            If reader.HasRows Then
                ' MsgBox("reader.hasrows is true")

                Dim myField As Field

                Do While reader.Read
                    myField = New Field
                    myField.FieldID = CInt(reader("FieldID"))
                    myField.FieldName = reader("FieldName").ToString
                    myField.Acres = CInt(reader("Acres"))
                    myField.Owner = reader("Owner").ToString
                    myField.Active = CBool(reader("Active"))

                    myFieldList.Add(myField)
                    myField = Nothing
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

        Return myFieldList
    End Function


End Class
