Public Class Dashboard
    Public Sub Logout()
        Me.Close()
        Form1.Close()
    End Sub
    Public Sub validateLogout()
        Dim result As DialogResult
        result = MessageBox.Show("Do you want to exit?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Logout()
        Else
            MessageBox.Show("logout Cancelled!")

        End If

    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Logoutbtn.Click
        validateLogout()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Productbtn.Click
        ProductForm.Show()
    End Sub

    Private Sub Customerbtn_Click(sender As Object, e As EventArgs) Handles Customerbtn.Click
        CustomerForm.Show()
    End Sub

    Private Sub Billingbtn_Click(sender As Object, e As EventArgs) Handles Billingbtn.Click
        BillingForm.Show()
    End Sub

    Private Sub Receiptbtn_Click(sender As Object, e As EventArgs) Handles Receiptbtn.Click
        ReceiptForm.Show()
    End Sub
End Class