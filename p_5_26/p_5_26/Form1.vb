Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As Integer

start:  REM this is our label for goto statement
        a = CInt(InputBox("Enter a positive integer: "))

        Select Case a
            Case Is < 0
                GoTo start
        End Select

        MsgBox("You entered " & a)
    End Sub
End Class
