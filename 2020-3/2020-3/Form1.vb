Public Class Form1

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If txtAge.Text < 16 And (txtFare.Text > 1 And txtFare.Text < 300) Then
            MsgBox("Thank you")
        Else
            MsgBox("You don't have enought fare amount")
        End If

        If (txtAge.Text >= 16 And txtAge.Text <= 50) And (txtFare.Text > 300) Then
            MsgBox("Thank you")
        Else
            MsgBox("You don't have enought fare amount")
        End If

        If txtAge.Text > 60 And (txtFare.Text > 100) Then
            MsgBox("Thank you")
        Else
            MsgBox("You don't have enought fare amount")
        End If
    End Sub
End Class
