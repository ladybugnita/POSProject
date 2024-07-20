Imports System.Data.SqlClient

Public Class BillingForm
    Dim connectionString As String = "Data Source=LADYBUG;Initial Catalog=forgetpasswordvb;Integrated Security=True;Persist Security Info=False;Encrypt=True;TrustServerCertificate=True"
    Dim availableQuantity As Integer

    Private Sub BillingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCustomers()
        LoadProducts()
    End Sub

    Private Sub LoadCustomers()
        Using conn As New SqlConnection(connectionString)
            conn.Open()
            Dim query As String = "SELECT CustomerName FROM Customers"
            Dim cmd As New SqlCommand(query, conn)
            Dim reader As SqlDataReader = cmd.ExecuteReader()
            While reader.Read()
                ComboBoxCustomerName.Items.Add(reader("CustomerName").ToString())
            End While
        End Using
    End Sub

    Private Sub LoadProducts()
        Using conn As New SqlConnection(connectionString)
            conn.Open()
            Dim query As String = "SELECT ProductName FROM Products"
            Dim cmd As New SqlCommand(query, conn)
            Dim reader As SqlDataReader = cmd.ExecuteReader()
            While reader.Read()
                ComboBoxProductName.Items.Add(reader("ProductName").ToString())
            End While
        End Using
    End Sub

    Private Sub ComboBoxProductName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxProductName.SelectedIndexChanged
        Using conn As New SqlConnection(connectionString)
            conn.Open()
            Dim query As String = "SELECT Price, Quantity FROM Products WHERE ProductName=@ProductName"
            Dim cmd As New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@ProductName", ComboBoxProductName.SelectedItem.ToString())
            Dim reader As SqlDataReader = cmd.ExecuteReader()
            If reader.Read() Then
                TextBoxPrice.Text = reader("Price").ToString()
                availableQuantity = Integer.Parse(reader("Quantity").ToString())
            End If
        End Using
    End Sub

    Private Sub ButtonCalculate_Click(sender As Object, e As EventArgs) Handles ButtonCalculate.Click
        Dim price As Decimal = Decimal.Parse(TextBoxPrice.Text)
        Dim quantity As Integer = Integer.Parse(TextBoxQuantity.Text)

        ' Validate the quantity
        If quantity > availableQuantity Then
            MessageBox.Show("Quantity exceeds available stock.", "Invalid Quantity", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim vat As Decimal = Decimal.Parse(TextBoxVAT.Text) / 100
        Dim discount As Decimal = Decimal.Parse(TextBoxDiscount.Text) / 100

        Dim totalAmount As Decimal = quantity * price + (price * vat) - (price * discount)
        TextBoxTotalAmount.Text = totalAmount.ToString("F2")
    End Sub

    Private Sub ButtonGenerateReceipt_Click(sender As Object, e As EventArgs) Handles ButtonGenerateReceipt.Click
        ' Update the product quantity in the database
        Dim quantity As Integer = Integer.Parse(TextBoxQuantity.Text)
        Dim newQuantity As Integer = availableQuantity - quantity

        Using conn As New SqlConnection(connectionString)
            conn.Open()
            Dim query As String = "UPDATE Products SET Quantity = @Quantity WHERE ProductName = @ProductName"
            Dim cmd As New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@Quantity", newQuantity)
            cmd.Parameters.AddWithValue("@ProductName", ComboBoxProductName.SelectedItem.ToString())
            cmd.ExecuteNonQuery()
        End Using

        ' Pass data to the ReceiptForm and display it
        Dim receiptForm As New ReceiptForm()
        receiptForm.CustomerNameProperty = ComboBoxCustomerName.SelectedItem.ToString()
        receiptForm.ProductNameProperty = ComboBoxProductName.SelectedItem.ToString()
        receiptForm.PriceProperty = Decimal.Parse(TextBoxPrice.Text)
        receiptForm.QuantityProperty = quantity
        receiptForm.VATProperty = Decimal.Parse(TextBoxVAT.Text)
        receiptForm.DiscountProperty = Decimal.Parse(TextBoxDiscount.Text)
        receiptForm.TotalAmountProperty = Decimal.Parse(TextBoxTotalAmount.Text)
        receiptForm.ShowDialog()

        ' Refresh the product data in ProductForm
        Dim productForm As ProductForm = DirectCast(Application.OpenForms("ProductForm"), ProductForm)
        If productForm IsNot Nothing Then
            productForm.LoadProductData()
        End If
    End Sub
End Class