Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n As Integer
        n = 1
        Label1.Text = ""
        While n <= 5
            Label1.Text = Label1.Text & "Hello World" & vbNewLine
            n += 1
        End While
    End Sub
End Class
