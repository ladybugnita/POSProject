Public Class Form1


    Private Sub Login_Click(sender As Object, e As EventArgs) Handles Login.Click
        Dim username As String
        Dim password As String

        username = txtusername.Text()
        password = txtpassword.Text()
        If username = "" Then
            password_error.Visible = False
            username_error.Visible = True
        ElseIf password = "" Then
            username_error.Visible = False
            password_error.Visible = True
        ElseIf (username.Equals("admin") And password.Equals("@#45P")) Then
            MessageBox.Show("Login Success", "information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            password_error.Visible = False
            username_error.Visible = False
            Form2.Show()
        Else
            MessageBox.Show("Error", "information", MessageBoxButtons.OK, MessageBoxIcon.Error)
            username_error.Visible = False
            txtusername.Clear()
            txtpassword.Clear()
            password_error.Visible = False


        End If

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            txtpassword.UseSystemPasswordChar = True
        Else
            txtpassword.UseSystemPasswordChar = False
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Form3.Show()
    End Sub
End Class



