Public Class ForgetPassword
    Private Sub btnchk_Click(sender As Object, e As EventArgs) Handles btnchk.Click
        Dim ans As String
        ans = txtans.Text()
        If ans = "2024" Then
            MessageBox.Show("Correct Answer", "information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Dashboard.Show()
        Else
            MessageBox.Show("Error", "information", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtans.Clear()
        End If
    End Sub

End Class