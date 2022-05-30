Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim t, d, n, sum As Integer
        t = CInt(TextBox1.Text)
        n = t
        Do While t > 0
            d = t Mod 10
            sum = sum + (d ^ 3)
            t = t \ 10
        Loop

        If sum = n Then
            MsgBox("Armstrong")
        Else
            MsgBox("Not Armstrong")
        End If
    End Sub
End Class
