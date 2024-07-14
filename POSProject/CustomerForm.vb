Imports System.Data.SqlClient

Public Class CustomerForm

    Dim connectionString As String = "Data Source=LADYBUG;Initial Catalog=forgetpasswordvb;Integrated Security=True;Persist Security Info=False;Encrypt=True;TrustServerCertificate=True"

    Private Sub CustomerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCustomerData()
    End Sub

    Private Sub LoadCustomerData()
        dgvCustomers.DataSource = Nothing ' Clear the DataGridView
        Using conn As New SqlConnection(connectionString)
            Dim query As String = "SELECT CustomerID, CustomerName, Address, ContactNo FROM Customers"
            Using cmd As New SqlCommand(query, conn)
                Dim adapter As New SqlDataAdapter(cmd)
                Dim table As New DataTable()
                adapter.Fill(table)
                dgvCustomers.DataSource = table
            End Using
        End Using
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            Dim CustomerID As Integer = Integer.Parse(txtCustomerID.Text)
            Dim customerName As String = txtCustomerName.Text
            Dim address As String = txtAddress.Text
            Dim ContactNo As String = txtContactNo.Text

            Using conn As New SqlConnection(connectionString)
                Dim query As String = "INSERT INTO Customers (CustomerID, CustomerName, Address, ContactNo) VALUES (@CustomerID, @CustomerName, @Address, @ContactNo)"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@CustomerID", CustomerID)
                    cmd.Parameters.AddWithValue("@CustomerName", customerName)
                    cmd.Parameters.AddWithValue("@Address", address)
                    cmd.Parameters.AddWithValue("@ContactNo", ContactNo)
                    conn.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            txtCustomerID.Clear()
            txtCustomerName.Clear()
            txtAddress.Clear()
            txtContactNo.Clear()

            LoadCustomerData() ' Reload data in DataGridView after adding new customer
        Catch ex As Exception
            MessageBox.Show($"Error adding customer: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
