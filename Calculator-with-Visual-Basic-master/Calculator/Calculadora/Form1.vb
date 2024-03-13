Public Class Form1

    Dim Operation As String
    Dim ResultValue As Nullable(Of Double) = Nothing
    Dim Value2 As Nullable(Of Double) = Nothing
    Dim IsOperatorPressed As Boolean
    Dim MemoryValue As Double = 0 ' Declare and initialize MemoryValue variable

    Private WithEvents txtResultado As New TextBox()
    Public Sub EvaluateAndPerformOperation()
        IsOperatorPressed = True
        Value2 = Val(txtResultado.Text)

        Select Case Operation
            Case "+"
                ResultValue += Value2
            Case "-"
                ResultValue -= Value2
            Case "*"
                ResultValue *= Value2
            Case "/"
                ResultValue /= Value2
            Case "%"
                ResultValue = ResultValue Mod Value2
            Case "C"
                ' Clear the current value
                txtResultado.Text = "0"
                ResultValue = 0
                Exit Sub
            Case "CE"
                ' Clear the current entry
                txtResultado.Text = "0"
                Exit Sub
            Case "+/-"
                ' Change the sign of the current value
                ResultValue = -ResultValue
                txtResultado.Text = ResultValue
                Exit Sub
            Case "M+"
                ' Add the current value to memory
                MemoryValue += ResultValue
                Exit Sub
            Case "MR"
                ' Recall the value stored in memory
                ResultValue = MemoryValue
                txtResultado.Text = ResultValue
                Exit Sub
            Case "M"
                ' Store the current value in memory
                MemoryValue = ResultValue
                Exit Sub
            Case "Sqr"
                ' Square root of the current value
                ResultValue = Math.Sqrt(ResultValue)
                txtResultado.Text = ResultValue
                Exit Sub
            Case "Sin"
                ' Sine of the current value (assuming degrees)
                ResultValue = Math.Sin(ResultValue * Math.PI / 180)
                txtResultado.Text = ResultValue
                Exit Sub
            Case "Cos"
                ' Cosine of the current value (assuming degrees)
                ResultValue = Math.Cos(ResultValue * Math.PI / 180)
                txtResultado.Text = ResultValue
                Exit Sub
            Case "Tan"
                ' Tangent of the current value (assuming degrees)
                ResultValue = Math.Tan(ResultValue * Math.PI / 180)
                txtResultado.Text = ResultValue
                Exit Sub
            Case "Log"
                ' Logarithm of the current value
                ResultValue = Math.Log10(ResultValue)
                txtResultado.Text = ResultValue
                Exit Sub
            Case "Ln"
                ' Natural logarithm of the current value
                ResultValue = Math.Log(ResultValue)
                txtResultado.Text = ResultValue
                Exit Sub
        End Select

        txtResultado.Text = ResultValue
    End Sub

    Public Sub EvaluateRestrictionsForConcatenation()
        If IsOperatorPressed = True Then
            txtResultado.Text = ""
            IsOperatorPressed = False
        ElseIf txtResultado.Text = "0" Then
            txtResultado.Text = ""
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        EvaluateRestrictionsForConcatenation()
        txtResultado.Text &= "1"
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        EvaluateRestrictionsForConcatenation()
        txtResultado.Text &= "2"
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        EvaluateRestrictionsForConcatenation()
        txtResultado.Text &= "3"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        EvaluateRestrictionsForConcatenation()
        txtResultado.Text &= "4"
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        EvaluateRestrictionsForConcatenation()
        txtResultado.Text &= "5"
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        EvaluateRestrictionsForConcatenation()
        txtResultado.Text &= "6"
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        EvaluateRestrictionsForConcatenation()
        txtResultado.Text &= "7"
    End Sub
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        EvaluateRestrictionsForConcatenation()
        txtResultado.Text &= "8"
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        EvaluateRestrictionsForConcatenation()
        txtResultado.Text &= "9"
    End Sub
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        EvaluateAndPerformOperation()
        Operation = "*"
    End Sub
    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        EvaluateAndPerformOperation()
        Operation = "+"
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        EvaluateAndPerformOperation()
        txtResultado.Text &= "sqr"
    End Sub
    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        EvaluateAndPerformOperation()
        Operation = "-"
    End Sub
    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        EvaluateAndPerformOperation()
        Operation = "/"
    End Sub
    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        txtResultado.Text = "="
        Value2 = Nothing
        ResultValue = Nothing
    End Sub
    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        EvaluateAndPerformOperation()
        txtResultado.Text &= "%"
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        EvaluateRestrictionsForConcatenation()

        If InStr(txtResultado.Text, ".", CompareMethod.Text) = 0 Then
            txtResultado.Text &= "."
        End If
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        EvaluateAndPerformOperation()
        txtResultado.Text &= "M"
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        EvaluateAndPerformOperation()
        txtResultado.Text &= "C"
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        EvaluateAndPerformOperation()
        txtResultado.Text &= "CE"
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        EvaluateAndPerformOperation()
        txtResultado.Text &= "+/-"
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        EvaluateAndPerformOperation()
        txtResultado.Text &= "MR"
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        EvaluateAndPerformOperation()
        txtResultado.Text &= "MC"
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        EvaluateAndPerformOperation()
        txtResultado.Text &= "Ln"
    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        EvaluateAndPerformOperation()
        txtResultado.Text &= "Sin"
    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
        EvaluateAndPerformOperation()
        txtResultado.Text &= "Cos"
    End Sub

    Private Sub Button28_Click(sender As Object, e As EventArgs) Handles Button28.Click
        EvaluateAndPerformOperation()
        txtResultado.Text &= "Tan"
    End Sub

    Private Sub Button29_Click(sender As Object, e As EventArgs) Handles Button29.Click
        EvaluateAndPerformOperation()
        txtResultado.Text &= "Log"
    End Sub

    Private Sub Button30_Click(sender As Object, e As EventArgs) Handles Button30.Click
        EvaluateAndPerformOperation()
        txtResultado.Text &= "M+"
    End Sub
End Class
