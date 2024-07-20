Imports System.Data.SqlClient

Public Class ProductForm
    Dim connectionString As String = "Data Source=LADYBUG;Initial Catalog=forgetpasswordvb;Integrated Security=True;Persist Security Info=False;Encrypt=True;TrustServerCertificate=True"

    Public Sub LoadProductData()
        Using conn As New SqlConnection(connectionString)
            Dim query As String = "SELECT ProductID, ProductName, Price, Quantity FROM Products"
            Using cmd As New SqlCommand(query, conn)
                Dim adapter As New SqlDataAdapter(cmd)
                Dim table As New DataTable()
                adapter.Fill(table)
                dgvProducts.DataSource = table
            End Using
        End Using
    End Sub

    Private Sub ProductForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadProductData()
    End Sub

    Private Function ValidateInputs() As Boolean
        ' Validate ProductID (numeric)
        Dim productId As Integer
        If Not Integer.TryParse(txtProductID.Text, productId) Then
            MessageBox.Show("Please enter a valid Product ID.", "Invalid Product ID", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        ' Validate ProductName (not empty)
        If String.IsNullOrWhiteSpace(txtProductName.Text) Then
            MessageBox.Show("Please enter a product name.", "Empty Product Name", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        ' Validate Price (numeric)
        Dim price As Decimal
        If Not Decimal.TryParse(txtPrice.Text, price) Then
            MessageBox.Show("Please enter a valid price.", "Invalid Price", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        ' Validate Quantity (numeric)
        Dim quantity As Integer
        If Not Integer.TryParse(txtQuantity.Text, quantity) Then
            MessageBox.Show("Please enter a valid quantity.", "Invalid Quantity", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        ' Additional validations can be added here based on your application requirements

        Return True
    End Function

    Private Sub btnAddProduct_Click(sender As Object, e As EventArgs) Handles btnAddProduct.Click
        ' Validate inputs before proceeding
        If Not ValidateInputs() Then
            Return
        End If

        ' If inputs are valid, proceed with insertion
        Dim ProductID As Integer = Integer.Parse(txtProductID.Text)
        Dim ProductName As String = txtProductName.Text
        Dim price As Decimal = Decimal.Parse(txtPrice.Text)
        Dim Quantity As Integer = Integer.Parse(txtQuantity.Text)

        Using conn As New SqlConnection(connectionString)
            Dim query As String = "INSERT INTO Products(ProductID, ProductName, Price, Quantity) VALUES(@ProductID, @ProductName, @Price, @Quantity)"
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@ProductID", ProductID)
                cmd.Parameters.AddWithValue("@ProductName", ProductName)
                cmd.Parameters.AddWithValue("@Price", price)
                cmd.Parameters.AddWithValue("@Quantity", Quantity)
                conn.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using

        ' Clear input fields and reload product data
        txtProductName.Clear()
        txtProductID.Clear()
        txtPrice.Clear()
        txtQuantity.Clear()
        LoadProductData()
    End Sub
End Class