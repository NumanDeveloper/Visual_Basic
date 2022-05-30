Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        REM * Find high and low digit in a number
        Dim d, n, high, low As Integer

        n = InputBox("Enter a number: ")

        high = n Mod 10
        low = n Mod 10
        n = n \ 10

        While (n > 0)
            d = n Mod 10
            If (d < low) Then
                low = d
            ElseIf (d > high) Then
                high = d
            End If
            n = n / 10
        End While

        MsgBox("High: " & high & vbNewLine & "Low: " & low)

    End Sub
End Class
