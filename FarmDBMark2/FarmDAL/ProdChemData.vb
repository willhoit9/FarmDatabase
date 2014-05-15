Imports System.Data.SqlClient
Imports FarmDataTypes

Public Class ProdChemData



    Public Shared Function fetchChemForProductionByID(ByVal ProductionID As Integer, Optional ByVal ActiveOnly As Boolean = False)

        Dim myProdChemList As New List(Of ProdChemVB)
        Dim myProdChem As ProdChemVB
        Dim myConn As SqlConnection = DatabaseConnection.GetFarmDBConnection
        Dim myStoredProcedure As String = ""

        If ActiveOnly = False Then
            myStoredProcedure = "spChemical_ProductionGetChemicalByProductionID"
        Else
            myStoredProcedure = "spChemical_ProductionGetChemicalByProductionIDActive"
        End If

        Try

            Dim fieldCmd As New SqlCommand(myStoredProcedure, myConn)
            fieldCmd.CommandType = CommandType.StoredProcedure

            fieldCmd.Parameters.AddWithValue("@ProductionID", ProductionID)
            myConn.Open()

            Dim myReader = fieldCmd.ExecuteReader
            If myReader.HasRows Then

                Do While myReader.Read
                    myProdChem = New ProdChemVB

                    myProdChem.ProductionID = CInt(myReader("ProductionID"))
                    myProdChem.ChemicalID = CInt(myReader("ChemicalID"))
                    myProdChem.ChemicalType = myReader("ChemicalType")
                    myProdChem.ChemicalBrand = myReader("ChemicalBrand")
                    myProdChem.ChemicalName = myReader("ChemicalName")
                    myProdChem.ApplicationDate = CDate(myReader("ApplicationDate"))
                    myProdChem.Active = CBool(myReader("Active"))

                    myProdChemList.Add(myProdChem)
                    myProdChem = Nothing

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


        Return myProdChemList
    End Function

    Public Shared Function addProdChemRelationship(ByVal ChemicalID As Integer, ByVal ProductionID As Integer, ByVal ApplicationDate As Date)
        Dim success As Boolean
        Dim myConn As SqlConnection = DatabaseConnection.GetFarmDBConnection
        Dim number As Integer

        Try

            Dim mySqlCommand As New SqlCommand("spChemical_ProductionAddRelationship", myConn)
            mySqlCommand.CommandType = CommandType.StoredProcedure

            mySqlCommand.Parameters.AddWithValue("@ChemicalID", ChemicalID)
            mySqlCommand.Parameters.AddWithValue("@ProductionID", ProductionID)
            mySqlCommand.Parameters.AddWithValue("@ApplicationDate", ApplicationDate)
            myConn.Open()

            number = mySqlCommand.ExecuteNonQuery

            If number = 1 Then
                success = True
            End If

        Catch ex As SqlException
            If ex.Number = 2627 Then
                MsgBox("The Chemical you have choosen, Chemical ID " & ChemicalID & ", has already been added to that production, " & vbCrLf &
                   "PLease choose another chemical or cancel. ", , "Primary Key Violation")
            Else
                MsgBox("An SQL Exception has occurred." & vbCrLf &
   "Here's the details... " & vbCrLf & vbCrLf &
   ex.ToString)
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


    Public Shared Function updateProdChemActive(ByVal oldPCProductionID As Integer, ByVal oldPCCHemicalID As Integer, ByVal oldPCActive As Boolean, ByVal newPCActive As Boolean)
        Dim Success As Boolean = False
        Dim number As Integer
        Dim myConn As SqlConnection = DatabaseConnection.GetFarmDBConnection

        Try
            'myConn()
            Dim mySqlCommand As New SqlCommand("spChemical_ProductionUpdateActive", myConn)
            mySqlCommand.CommandType = CommandType.StoredProcedure

            mySqlCommand.Parameters.AddWithValue("@original_ProductionID", oldPCProductionID)
            mySqlCommand.Parameters.AddWithValue("@original_ChemicalID", oldPCCHemicalID)
            mySqlCommand.Parameters.AddWithValue("@original_Active", oldPCActive)
            mySqlCommand.Parameters.AddWithValue("@Active", newPCActive)
 
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

        If number = 1 Then
            Success = True
        End If
        Return Success
    End Function


    Public Shared Function editProdChem(ByVal oldPCProductionID As Integer, ByVal oldPCCHemicalID As Integer, ByVal oldPCApplicationDate As Date, ByVal newPCApplicationDate As Date)
        Dim Success As Boolean = False
        Dim number As Integer
        Dim myConn As SqlConnection = DatabaseConnection.GetFarmDBConnection

        Try
            'myConn()
            Dim mySqlCommand As New SqlCommand("spChemical_ProductionEditApplicationDate", myConn)
            mySqlCommand.CommandType = CommandType.StoredProcedure

            mySqlCommand.Parameters.AddWithValue("@original_ProductionID", oldPCProductionID)
            mySqlCommand.Parameters.AddWithValue("@original_ChemicalID", oldPCCHemicalID)
            mySqlCommand.Parameters.AddWithValue("@original_ApplicationDate", oldPCApplicationDate)
            mySqlCommand.Parameters.AddWithValue("@new_ApplicationDate", newPCApplicationDate)

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

        If number = 1 Then
            Success = True
        End If

        Return Success
    End Function


End Class
