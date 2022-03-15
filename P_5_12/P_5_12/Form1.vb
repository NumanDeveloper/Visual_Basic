Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a, b, c, u, l, r As Integer
        Dim x1, x2 As Double

        REM reading values of a, b and c
        a = CInt(TextBox1.Text)
        b = CInt(TextBox2.Text)
        c = CInt(TextBox3.Text)

        u = (b * b - (4 * a * c)) REM u reps under the root value
        l = 2 * a   REM reps denominator or lower value of quadratic formula

        REM check if a is zero
        If a = 0 Then
            MsgBox("Not a quadraric equation! A cannot be zero")
        Else
            r = Val(u ^ 0.5) REM r reps square rooted value of u
            x1 = (-b + r) / l
            x2 = (-b - r) / l
            MsgBox("The roots of equation are: " & x1 & ", " & x2 & ".")
        End If
    End Sub
End Class
