Public Class Form1

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim hours, hoursBill, totalBill As Integer
        Dim AC_Bill As Integer = 0
        Dim driverBill As Integer = 0

        hours = txtHours.Text
        Dim carClass As String
        carClass = txtCarClass.Text

        If (carClass = "a") Then
            hoursBill = hours * 1000
        ElseIf (carClass = "b") Then
            hoursBill = hours * 500
        ElseIf (carClass = "c") Then
            hoursBill = hours * 300
        End If

        If (txtDriverReq.Text = "y") Then
            driverBill = hours * 100
            REM totalBill = totalBill + driverBill
        End If

        If (txtACReq.Text = "y") Then
            AC_Bill = hours * 100
            REM totalBill = AC_Bill + totalBill
        End If

        totalBill = hoursBill + driverBill + AC_Bill

        txtHoursBill.Text = hoursBill
        txtDriverBill.Text = driverBill
        txtACbill.Text = AC_Bill
        txtTotalBill.Text = totalBill
    End Sub
End Class
