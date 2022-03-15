Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a, b, c, d, f, min, max As Integer
        REM taking 5 integer values
        a = CInt(InputBox("Enter first integer: "))
        b = CInt(InputBox("Enter second integer: "))
        c = CInt(InputBox("Enter third integer: "))
        d = CInt(InputBox("Enter fourth integer: "))
        f = CInt(InputBox("Enter fifth integer: "))

        max = a
        min = a

        If b > max Then max = b
        If c > max Then max = c
        If d > max Then max = d
        If f > max Then max = f

        If b < min Then min = b
        If c < min Then min = c
        If d < min Then min = d
        If f < min Then min = f

        MsgBox("Max number: " & max & " Min number: " & min)
    End Sub
End Class
