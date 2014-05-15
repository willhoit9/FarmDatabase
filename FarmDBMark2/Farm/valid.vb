Public Class valid


    Private Shared _msg As String = "Entry Error"



    Public Shared Function isEmpty(ByVal obj As Object) As Boolean
        If obj.ToString() = "" Then
            Return True
        Else
            Return False
        End If
    End Function


    Public Shared Function IsPresent(ByVal control As Control) As Boolean
        If control.GetType.ToString = "System.Windows.Forms.TextBox" Then
            Dim textBox As TextBox = CType(control, TextBox)
            If textBox.Text.Trim = "" Then
                MessageBox.Show(textBox.Tag.ToString & " is a required field.", _msg)
                textBox.Select()
                Return False
            Else
                Return True
            End If
        ElseIf control.GetType.ToString = "System.Windows.Forms.ComboBox" Then
            Dim comboBox As ComboBox = CType(control, ComboBox)
            If comboBox.SelectedIndex = -1 Then
                MessageBox.Show(comboBox.Tag.ToString & " is a required field.", _msg)
                comboBox.Select()
                Return False
            Else
                Return True
            End If
        Else
            MsgBox("you can only use this Valid check on TextBoxes and ComboBoxes", , "Scram!")
            Return False
        End If

    End Function


    Public Shared Function IsInt(ByVal textBox As TextBox) As Boolean
        Try
            Convert.ToInt32(textBox.Text)
            Return True
        Catch ex As FormatException
            MessageBox.Show(textBox.Tag.ToString & " must be an integer value.", _msg)
            textBox.Select()
            textBox.SelectAll()
            Return False
        End Try
    End Function

    Public Shared Function hasLessCharsThan(ByVal limit As Integer, ByVal textBox As TextBox) As Boolean
        If textBox.Text.Trim.Length > limit Then
            MessageBox.Show(textBox.Tag.ToString & " cannot be over " & limit & " characters in length.", _msg)
            textBox.Select()
            textBox.SelectAll()
            Return False
        Else
            Return True
        End If

    End Function

    Public Shared Function isLessThan(ByVal max As Integer, ByVal textBox As TextBox) As Boolean
        If CInt(textBox.Text) > max Then
            MessageBox.Show(textBox.Tag.ToString & " cannot be over " & max & ".", _msg)
            textBox.Select()
            textBox.SelectAll()
            Return False
        Else
            Return True
        End If

    End Function

    Public Shared Function isGreaterThan(ByVal min As Integer, ByVal textBox As TextBox) As Boolean
        If CInt(textBox.Text) <= min Then
            MessageBox.Show(textBox.Tag.ToString & " must be over " & min & ".", _msg)
            textBox.Select()
            textBox.SelectAll()
            Return False
        Else
            Return True
        End If

    End Function

End Class
