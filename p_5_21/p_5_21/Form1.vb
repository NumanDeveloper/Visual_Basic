Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Movie As Char
        Movie = InputBox("Enter movie code A, C, F, H or S: ", "Movie Code")

        Select Case Movie
            Case "A"
                MsgBox("Adventure Movies")
            Case "C"
                MsgBox("Comedy Movies")
            Case "F"
                MsgBox("Family Movies")
            Case "H"
                MsgBox("Horror Movies")
            Case "S"
                MsgBox("Science Fiction Movies")
            Case Else
                MsgBox("Invalid Movie Category !!")
        End Select
    End Sub
End Class
