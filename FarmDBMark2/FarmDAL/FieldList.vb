'Imports System.Data.SqlClient
'Imports FarmDataTypes


'Public Class FieldList
'    Public _myFields As List(Of Field)

'    Public Sub New()
'        _myFields = New List(Of Field)
'    End Sub


'    Public Sub New(ByVal myQuery As String)

'        _myFields = New List(Of Field)

'        Dim connection As SqlConnection = DatabaseConnection.GetFarmDBConnection
'        Dim selectStatement As String = myQuery
'        '"SELECT FieldID, FieldName, Acres, Owner, Active" &
'        '"FROM Field" &
'        '"ORDER BY FieldName"
'        Dim selectCommand As New SqlCommand(selectStatement, connection)

'        Try
'            connection.Open()
'            Dim reader As SqlDataReader = selectCommand.ExecuteReader
'            Dim field As Field
'            Do While reader.Read
'                field = New Field
'                field.FieldID = CInt(reader("FieldID"))
'                field.FieldName = reader("FieldName").ToString
'                field.Acres = CInt(reader("Acres"))
'                field.Owner = reader("Owner").ToString
'                field.Active = CBool(reader("Active"))
'            Loop
'            reader.Close()
'        Catch ex As SqlException
'            Throw ex
'        Finally
'            connection.Close()
'        End Try

'    End Sub


'End Class
