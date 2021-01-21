Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim fraction1 As Fraction = New Fraction(2, 4) 'Original from the lesson
        'Dim fraction2 As Fraction = New Fraction(4, 6)
        'Dim result As Fraction = fraction1 * fraction2
        'Dim dbl As Single = result

        'tbA.Clear()
        'tbB.Clear()
        'tbAdividedB.Clear()
        'tbAtimesB.Clear()
        'tbA.Focus()
    End Sub

    Private Sub btnEvaluate_Click(sender As Object, e As EventArgs) Handles btnEvaluate.Click
        'Read and Validate Inputs

        If Not ValidateInput(tbA) Then Return
        Dim inputA As String = tbA.Text
        If Not ValidateInput(tbB) Then Return
        Dim inputB As String = tbB.Text

        'Convert to fraction
        Dim A As Fraction = Fraction.op_Implicit(inputA)
        Dim B As Fraction = Fraction.op_Implicit(inputB)

        'Calculate
        Dim multiple As Fraction = A * B
        Dim division As Fraction = A / B

        'Output
        tbAtimesB.Text = multiple.ToString()
        tbAdividedB.Text = division.ToString()

    End Sub
End Class
