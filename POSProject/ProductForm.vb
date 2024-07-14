Imports System.Data.SqlClient
Public Class ProductForm

    Private Sub LoadProductData()
        Using conn As New SqlConnection(connectionString)
            Dim query As String = "select ProductID, ProductName, Price, Quantity from Products"
            Using cmd As New SqlCommand(query, conn)
                Dim adapter As New SqlDataAdapter(cmd)
                Dim table As New DataTable()
                adapter.Fill(table)
                dgvProducts.DataSource = table

            End Using
        End Using

    End Sub

    Private Const V As String = "ProductID"
    Dim connectionString As String = "Data Source=LADYBUG;Initial Catalog=forgetpasswordvb;Integrated Security=True;Persist Security Info=False;Encrypt=True;TrustServerCertificate=True"
    Private Sub ProductForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadProductData()
    End Sub


    Private Sub btnAddProduct_Click(sender As Object, e As EventArgs) Handles btnAddProduct.Click
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

        txtProductID.Clear()
        txtProductName.Clear()
        txtPrice.Clear()
        txtQuantity.Clear()
        LoadProductData()
    End Sub
End Class



