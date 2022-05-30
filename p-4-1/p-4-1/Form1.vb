Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim strName As String = "Numan Iftikhar"
        Dim intMarks As Integer = 100

        MsgBox("Hello " & strName & ". Your marks are " & intMarks)
    End Sub
End Class
