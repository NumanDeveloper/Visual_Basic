Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n, revNum, remainder As Integer

        n = InputBox("Enter a number: ")
        While n <> 0
            remainder = n Mod 10
            revNum = revNum * 10 + remainder
            n = n \ 10
        End While

        MsgBox("Reversed Number: " & revNum)
    End Sub
End Class
