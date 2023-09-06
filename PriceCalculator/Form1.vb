Public Class Form1
    Private Sub btnTotalforCustomer_Click(sender As Object, e As EventArgs) Handles btnTotalforCustomer.Click
        Dim dPrice As Decimal
        Dim dQuantity As Integer
        Dim dTotal As Decimal
        Dim CustomerName As String

        dPrice = txtTextBox1.Text
        dQuantity = txtTextBox2.Text
        CustomerName = txtTextBox3.Text

        dTotal = dPrice * dQuantity

        MsgBox("The total for Customer " & CustomerName & " is " & dTotal)

    End Sub
End Class
