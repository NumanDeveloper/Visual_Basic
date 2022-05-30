Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n, sum As Integer
        sum = 0
        n = InputBox("Enter number: ")

        While n <> 0
            sum = sum + n Mod 10
            n = n \ 10
        End While

        MsgBox("Sum: " & sum)
    End Sub
End Class
