Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        REM fibonacci sequence
        Dim n, a, b, nxt As Integer
        n = CInt(InputBox("Enter the last number: "))

        a = 0
        b = 1
        MsgBox("Fibonacci Sequence" & vbNewLine)
        While (nxt < n)
            MsgBox(nxt)
            a = b
            b = nxt
            nxt = a + b
        End While
    End Sub
End Class
