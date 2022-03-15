Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim x As Char

        x = InputBox("Enter alphabet to check: ")

        Select Case x
            Case "A", "I", "E", "O", "U", "a", "e", "i", "o", "u"
                MsgBox("You entered a vowel !!")
            Case Else
                MsgBox("You didn't enter a vowel !!")
        End Select
    End Sub
End Class
