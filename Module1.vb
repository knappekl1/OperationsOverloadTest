Module Module1
    Public Function ValidateInput(tBox As TextBox) As Boolean
        Dim input As String = tBox.Text
        If Not System.Text.RegularExpressions.Regex.IsMatch(input.Trim, "\d+\/\d+") Then
            MessageBox.Show("Invalid Input")
            tBox.Clear()
            tBox.Focus()
            Return False
        Else
            Return True
        End If
    End Function
End Module
