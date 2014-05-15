Imports System.Data.SqlClient

Public Class DatabaseConnection
    Friend Shared Function GetFarmDBConnection() As SqlConnection
        Dim connectionString As String = "Data Source=localhost\SQLExpress;Initial Catalog=FarmDB;Integrated Security=True"

        Return New SqlConnection(connectionString)
    End Function
End Class


