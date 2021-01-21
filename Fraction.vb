Public Class Fraction
    Public Numerator, Denominator As Integer

    'Constructor
    Public Sub New(newNumerator As Integer, newDenominator As Integer)
        Numerator = newNumerator
        Denominator = newDenominator
    End Sub

    Public Shared Operator *(fraction1 As Fraction, fraction2 As Fraction) As Fraction
        Dim new_Numerator As Integer = fraction1.Numerator * fraction2.Numerator
        Dim new_Denominator As Integer = fraction1.Denominator * fraction2.Denominator
        Return New Fraction(new_Numerator, new_Denominator)
    End Operator

    Public Shared Operator /(fraction1 As Fraction, fraction2 As Fraction) As Fraction
        Dim new_Numerator As Integer = fraction1.Numerator * fraction2.Denominator
        Dim new_Denominator As Integer = fraction2.Numerator * fraction1.Denominator
        Return New Fraction(new_Numerator, new_Denominator)
    End Operator

    Public Shared Widening Operator CType(expression As String) As Fraction
        Dim values() As String
        values = expression.Split("/"c)
        Dim new_numerator As Integer = values(0)
        Dim new_denominator As Integer = values(1)
        Return New Fraction(new_numerator, new_denominator)
    End Operator

    Public Overrides Function ToString() As String
        Dim content As String = Numerator & "/" & Denominator
        Return content
    End Function

    'Public Shared Widening Operator CType(fraction1 As Fraction) As Single
    '    Return fraction1.Numerator / fraction1.Denominator
    'End Operator
End Class