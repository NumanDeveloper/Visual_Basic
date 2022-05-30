Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        REM prime and composite number checker
        Dim prime, num As Integer
        prime = 1
        num = TextBox1.Text
        For i = 2 To (num - 1)
            If num Mod i = 0 Then
                prime = 0
                Exit For REM break
            End If
        Next

        If prime = 1 Then
            MsgBox("Prime")
        Else
            MsgBox("Composite")
        End If

    End Sub
End Class
