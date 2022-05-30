Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        REM find if a number is in fibanacci sequence or not
        Dim n, a, b, nxt As Integer
        n = CInt(InputBox("Enter number: "))

        If (n = 0) Or (n = 1) Then
            MsgBox(n & " is a fibonacci number")
        Else
            a = 0
            b = 1
            nxt = a + b
            While (nxt < n)
                a = b
                b = nxt
                nxt = a + b
            End While

            If nxt = n Then
                MsgBox(n & " is a fibonacci number")
            Else
                MsgBox(n & " is not a fibonacci number")
            End If
        End If
    End Sub
End Class
