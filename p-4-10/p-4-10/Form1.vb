Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a, b, c, d As Integer, sum, product As Long, avg As Single

        a = InputBox("Enter a number: ")
        b = InputBox("Enter a number: ")
        c = InputBox("Enter a number: ")
        d = InputBox("Enter a number: ")

        sum = a + b + c + d
        product = a * b * c * d
        avg = sum / 4 REM integer division

        MsgBox("Sum = " & sum & vbNewLine & "product = " & product & vbNewLine & "Average = " & avg)
    End Sub
End Class
