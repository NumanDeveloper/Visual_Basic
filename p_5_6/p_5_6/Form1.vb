Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim salary As Long, grade, bonus As Integer
        salary = CLng(TextBox1.Text)
        grade = CInt(TextBox2.Text)

        If grade > 15 Then
            bonus = salary * 50 / 100
        Else
            bonus = salary * 25 / 100
        End If

        salary = salary + bonus
        MsgBox("Salary: " & salary)

    End Sub
End Class
