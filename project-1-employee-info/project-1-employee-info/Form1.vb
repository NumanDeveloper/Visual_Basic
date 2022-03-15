Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        REM for storing regular hours of six days
        Dim h1, h2, h3, h4, h5, h6 As Integer
        REM for storing over hours of six days
        Dim o1, o2, o3, o4, o5, o6 As Integer
        Dim hourSalary As Integer
        hourSalary = CInt(txtHSal.Text)

        h1 = CInt(txtMRH.Text)
        h2 = CInt(txtTRH.Text)
        h3 = CInt(txtWRH.Text)
        h4 = CInt(txtThRH.Text)
        h5 = CInt(txtFRH.Text)
        h6 = CInt(txtSRH.Text)

        Dim totalRegHours As Integer
        totalRegHours = h1 + h2 + h3 + h4 + h5 + h6

        o1 = CInt(txtMOH.Text)
        o2 = CInt(txtTOH.Text)
        o3 = CInt(txtWOH.Text)
        o4 = CInt(txtThOH.Text)
        o5 = CInt(txtFOH.Text)
        o6 = CInt(txtSOH.Text)

        Dim totalOverHours As Integer
        totalOverHours = o1 + o2 + o3 + o4 + o5 + o6

        Dim totalRegSalary As Integer
        totalRegSalary = totalRegHours * hourSalary

        Dim totalOverSalary As Integer
        REM the rate of over time is twice as regular hours
        totalOverSalary = totalOverHours * (hourSalary * 2)

        Dim totalSalary As Integer
        totalSalary = totalRegSalary + totalOverSalary

        Dim bonus As Integer
        bonus = totalSalary * 15 / 100

        Dim netSalary As Integer
        netSalary = totalSalary + bonus

        REM displaying total regular and over hours in respective text fields
        txtTotRH.Text = totalRegHours
        txtTotOH.Text = totalOverHours

        REM displaying total regular and over salary in respective text fields
        txtTotRS.Text = totalRegSalary
        txtTotOS.Text = totalOverSalary

        REM displaying total salary
        txtTotSal.Text = totalSalary

        txtTotB.Text = bonus

        txtNetSal.Text = netSalary


    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        REM for exit
        End
    End Sub
End Class
