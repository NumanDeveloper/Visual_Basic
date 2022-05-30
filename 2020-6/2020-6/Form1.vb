Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        REM declare an array of 5 elements
        Dim arr(4), sum, avg As Integer
        For i = 0 To 4
            arr(i) = i * 3
        Next

        For i = 0 To 4
            sum += arr(i)
        Next

        avg = sum / arr.Length

        TextBox1.Text = sum
        TextBox2.Text = avg
    End Sub
End Class
