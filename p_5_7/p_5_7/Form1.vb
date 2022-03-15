Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim str, rev As String

        str = TextBox1.Text
        REM calling function to reverse string
        rev = StrReverse(str)

        If str = rev Then
            MsgBox("Palindrome")
        Else
            MsgBox("Not Palindrome")
        End If
    End Sub
End Class
