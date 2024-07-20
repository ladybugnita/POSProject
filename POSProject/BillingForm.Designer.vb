<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BillingForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CustomersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ForgetpasswordvbDataSet3 = New POSProject.forgetpasswordvbDataSet3()
        Me.CustomersTableAdapter = New POSProject.forgetpasswordvbDataSet3TableAdapters.CustomersTableAdapter()
        Me.ForgetpasswordvbDataSet1 = New POSProject.forgetpasswordvbDataSet()
        Me.ProductsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ForgetpasswordvbDataSet4 = New POSProject.forgetpasswordvbDataSet4()
        Me.ProductsTableAdapter = New POSProject.forgetpasswordvbDataSet4TableAdapters.ProductsTableAdapter()
        Me.BillingSystemBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ForgetpasswordvbDataSet5 = New POSProject.forgetpasswordvbDataSet5()
        Me.BillingSystemTableAdapter = New POSProject.forgetpasswordvbDataSet5TableAdapters.BillingSystemTableAdapter()
        Me.CustomersBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ForgetpasswordvbDataSet7 = New POSProject.forgetpasswordvbDataSet7()
        Me.CustomersTableAdapter1 = New POSProject.forgetpasswordvbDataSet7TableAdapters.CustomersTableAdapter()
        Me.ForgetpasswordvbDataSet9 = New POSProject.forgetpasswordvbDataSet9()
        Me.CustomersBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomersTableAdapter2 = New POSProject.forgetpasswordvbDataSet9TableAdapters.CustomersTableAdapter()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBoxProductName = New System.Windows.Forms.ComboBox()
        Me.ProductsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ForgetpasswordvbDataSet14 = New POSProject.forgetpasswordvbDataSet14()
        Me.ComboBoxCustomerName = New System.Windows.Forms.ComboBox()
        Me.CustomersBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ForgetpasswordvbDataSet13 = New POSProject.forgetpasswordvbDataSet13()
        Me.CustomersTableAdapter3 = New POSProject.forgetpasswordvbDataSet13TableAdapters.CustomersTableAdapter()
        Me.ProductsTableAdapter1 = New POSProject.forgetpasswordvbDataSet14TableAdapters.ProductsTableAdapter()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxPrice = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBoxVAT = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBoxDiscount = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBoxTotalAmount = New System.Windows.Forms.TextBox()
        Me.ButtonCalculate = New System.Windows.Forms.Button()
        Me.ButtonGenerateReceipt = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBoxQuantity = New System.Windows.Forms.TextBox()
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ForgetpasswordvbDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ForgetpasswordvbDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ForgetpasswordvbDataSet4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BillingSystemBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ForgetpasswordvbDataSet5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomersBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ForgetpasswordvbDataSet7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ForgetpasswordvbDataSet9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomersBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ForgetpasswordvbDataSet14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomersBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ForgetpasswordvbDataSet13, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MediumPurple
        Me.Label1.Location = New System.Drawing.Point(315, -1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(187, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Billing System"
        '
        'CustomersBindingSource
        '
        Me.CustomersBindingSource.DataMember = "Customers"
        Me.CustomersBindingSource.DataSource = Me.ForgetpasswordvbDataSet3
        '
        'ForgetpasswordvbDataSet3
        '
        Me.ForgetpasswordvbDataSet3.DataSetName = "forgetpasswordvbDataSet3"
        Me.ForgetpasswordvbDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CustomersTableAdapter
        '
        Me.CustomersTableAdapter.ClearBeforeFill = True
        '
        'ForgetpasswordvbDataSet1
        '
        Me.ForgetpasswordvbDataSet1.DataSetName = "forgetpasswordvbDataSet"
        Me.ForgetpasswordvbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProductsBindingSource
        '
        Me.ProductsBindingSource.DataMember = "Products"
        Me.ProductsBindingSource.DataSource = Me.ForgetpasswordvbDataSet4
        '
        'ForgetpasswordvbDataSet4
        '
        Me.ForgetpasswordvbDataSet4.DataSetName = "forgetpasswordvbDataSet4"
        Me.ForgetpasswordvbDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProductsTableAdapter
        '
        Me.ProductsTableAdapter.ClearBeforeFill = True
        '
        'BillingSystemBindingSource
        '
        Me.BillingSystemBindingSource.DataMember = "BillingSystem"
        Me.BillingSystemBindingSource.DataSource = Me.ForgetpasswordvbDataSet5
        '
        'ForgetpasswordvbDataSet5
        '
        Me.ForgetpasswordvbDataSet5.DataSetName = "forgetpasswordvbDataSet5"
        Me.ForgetpasswordvbDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BillingSystemTableAdapter
        '
        Me.BillingSystemTableAdapter.ClearBeforeFill = True
        '
        'CustomersBindingSource1
        '
        Me.CustomersBindingSource1.DataMember = "Customers"
        Me.CustomersBindingSource1.DataSource = Me.ForgetpasswordvbDataSet7
        '
        'ForgetpasswordvbDataSet7
        '
        Me.ForgetpasswordvbDataSet7.DataSetName = "forgetpasswordvbDataSet7"
        Me.ForgetpasswordvbDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CustomersTableAdapter1
        '
        Me.CustomersTableAdapter1.ClearBeforeFill = True
        '
        'ForgetpasswordvbDataSet9
        '
        Me.ForgetpasswordvbDataSet9.DataSetName = "forgetpasswordvbDataSet9"
        Me.ForgetpasswordvbDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CustomersBindingSource2
        '
        Me.CustomersBindingSource2.DataMember = "Customers"
        Me.CustomersBindingSource2.DataSource = Me.ForgetpasswordvbDataSet9
        '
        'CustomersTableAdapter2
        '
        Me.CustomersTableAdapter2.ClearBeforeFill = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.MediumPurple
        Me.Label2.Location = New System.Drawing.Point(12, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Customer Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.MediumPurple
        Me.Label3.Location = New System.Drawing.Point(12, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Product Name"
        '
        'ComboBoxProductName
        '
        Me.ComboBoxProductName.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ProductsBindingSource1, "ProductID", True))
        Me.ComboBoxProductName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxProductName.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBoxProductName.FormattingEnabled = True
        Me.ComboBoxProductName.Location = New System.Drawing.Point(145, 123)
        Me.ComboBoxProductName.Name = "ComboBoxProductName"
        Me.ComboBoxProductName.Size = New System.Drawing.Size(121, 24)
        Me.ComboBoxProductName.TabIndex = 3
        '
        'ProductsBindingSource1
        '
        Me.ProductsBindingSource1.DataMember = "Products"
        Me.ProductsBindingSource1.DataSource = Me.ForgetpasswordvbDataSet14
        '
        'ForgetpasswordvbDataSet14
        '
        Me.ForgetpasswordvbDataSet14.DataSetName = "forgetpasswordvbDataSet14"
        Me.ForgetpasswordvbDataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ComboBoxCustomerName
        '
        Me.ComboBoxCustomerName.AllowDrop = True
        Me.ComboBoxCustomerName.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CustomersBindingSource3, "CustomerID", True))
        Me.ComboBoxCustomerName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxCustomerName.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBoxCustomerName.FormattingEnabled = True
        Me.ComboBoxCustomerName.Location = New System.Drawing.Point(145, 81)
        Me.ComboBoxCustomerName.Name = "ComboBoxCustomerName"
        Me.ComboBoxCustomerName.Size = New System.Drawing.Size(121, 24)
        Me.ComboBoxCustomerName.TabIndex = 4
        '
        'CustomersBindingSource3
        '
        Me.CustomersBindingSource3.DataMember = "Customers"
        Me.CustomersBindingSource3.DataSource = Me.ForgetpasswordvbDataSet13
        '
        'ForgetpasswordvbDataSet13
        '
        Me.ForgetpasswordvbDataSet13.DataSetName = "forgetpasswordvbDataSet13"
        Me.ForgetpasswordvbDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CustomersTableAdapter3
        '
        Me.CustomersTableAdapter3.ClearBeforeFill = True
        '
        'ProductsTableAdapter1
        '
        Me.ProductsTableAdapter1.ClearBeforeFill = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.MediumPurple
        Me.Label4.Location = New System.Drawing.Point(12, 166)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 19)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Price"
        '
        'TextBoxPrice
        '
        Me.TextBoxPrice.Location = New System.Drawing.Point(145, 166)
        Me.TextBoxPrice.Name = "TextBoxPrice"
        Me.TextBoxPrice.ReadOnly = True
        Me.TextBoxPrice.Size = New System.Drawing.Size(121, 22)
        Me.TextBoxPrice.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.MediumPurple
        Me.Label5.Location = New System.Drawing.Point(12, 245)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 19)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "VAT %"
        '
        'TextBoxVAT
        '
        Me.TextBoxVAT.Location = New System.Drawing.Point(145, 242)
        Me.TextBoxVAT.Name = "TextBoxVAT"
        Me.TextBoxVAT.Size = New System.Drawing.Size(121, 22)
        Me.TextBoxVAT.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.MediumPurple
        Me.Label6.Location = New System.Drawing.Point(12, 280)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 19)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Discount%"
        '
        'TextBoxDiscount
        '
        Me.TextBoxDiscount.Location = New System.Drawing.Point(145, 277)
        Me.TextBoxDiscount.Name = "TextBoxDiscount"
        Me.TextBoxDiscount.Size = New System.Drawing.Size(121, 22)
        Me.TextBoxDiscount.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.MediumPurple
        Me.Label7.Location = New System.Drawing.Point(12, 321)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(107, 19)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Total Amount"
        '
        'TextBoxTotalAmount
        '
        Me.TextBoxTotalAmount.Location = New System.Drawing.Point(145, 321)
        Me.TextBoxTotalAmount.Name = "TextBoxTotalAmount"
        Me.TextBoxTotalAmount.ReadOnly = True
        Me.TextBoxTotalAmount.Size = New System.Drawing.Size(121, 22)
        Me.TextBoxTotalAmount.TabIndex = 12
        '
        'ButtonCalculate
        '
        Me.ButtonCalculate.FlatAppearance.BorderSize = 0
        Me.ButtonCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonCalculate.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCalculate.ForeColor = System.Drawing.Color.MediumPurple
        Me.ButtonCalculate.Location = New System.Drawing.Point(2, 401)
        Me.ButtonCalculate.Name = "ButtonCalculate"
        Me.ButtonCalculate.Size = New System.Drawing.Size(163, 37)
        Me.ButtonCalculate.TabIndex = 13
        Me.ButtonCalculate.Text = "Calculate Amount"
        Me.ButtonCalculate.UseVisualStyleBackColor = True
        '
        'ButtonGenerateReceipt
        '
        Me.ButtonGenerateReceipt.FlatAppearance.BorderSize = 0
        Me.ButtonGenerateReceipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonGenerateReceipt.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonGenerateReceipt.ForeColor = System.Drawing.Color.MediumPurple
        Me.ButtonGenerateReceipt.Location = New System.Drawing.Point(289, 401)
        Me.ButtonGenerateReceipt.Name = "ButtonGenerateReceipt"
        Me.ButtonGenerateReceipt.Size = New System.Drawing.Size(163, 37)
        Me.ButtonGenerateReceipt.TabIndex = 14
        Me.ButtonGenerateReceipt.Text = "Generate Receipt"
        Me.ButtonGenerateReceipt.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.MediumPurple
        Me.Label8.Location = New System.Drawing.Point(12, 205)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 19)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Quantity"
        '
        'TextBoxQuantity
        '
        Me.TextBoxQuantity.Location = New System.Drawing.Point(145, 205)
        Me.TextBoxQuantity.Name = "TextBoxQuantity"
        Me.TextBoxQuantity.Size = New System.Drawing.Size(121, 22)
        Me.TextBoxQuantity.TabIndex = 16
        '
        'BillingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TextBoxQuantity)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.ButtonGenerateReceipt)
        Me.Controls.Add(Me.ButtonCalculate)
        Me.Controls.Add(Me.TextBoxTotalAmount)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TextBoxDiscount)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBoxVAT)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBoxPrice)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ComboBoxCustomerName)
        Me.Controls.Add(Me.ComboBoxProductName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "BillingForm"
        Me.Text = "BillingForm"
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ForgetpasswordvbDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ForgetpasswordvbDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ForgetpasswordvbDataSet4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BillingSystemBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ForgetpasswordvbDataSet5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomersBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ForgetpasswordvbDataSet7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ForgetpasswordvbDataSet9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomersBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ForgetpasswordvbDataSet14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomersBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ForgetpasswordvbDataSet13, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ForgetpasswordvbDataSet3 As forgetpasswordvbDataSet3
    Friend WithEvents CustomersBindingSource As BindingSource
    Friend WithEvents CustomersTableAdapter As forgetpasswordvbDataSet3TableAdapters.CustomersTableAdapter
    Friend WithEvents ForgetpasswordvbDataSet1 As forgetpasswordvbDataSet
    Friend WithEvents ForgetpasswordvbDataSet4 As forgetpasswordvbDataSet4
    Friend WithEvents ProductsBindingSource As BindingSource
    Friend WithEvents ProductsTableAdapter As forgetpasswordvbDataSet4TableAdapters.ProductsTableAdapter
    Friend WithEvents ForgetpasswordvbDataSet5 As forgetpasswordvbDataSet5
    Friend WithEvents BillingSystemBindingSource As BindingSource
    Friend WithEvents BillingSystemTableAdapter As forgetpasswordvbDataSet5TableAdapters.BillingSystemTableAdapter
    Friend WithEvents ForgetpasswordvbDataSet7 As forgetpasswordvbDataSet7
    Friend WithEvents CustomersBindingSource1 As BindingSource
    Friend WithEvents CustomersTableAdapter1 As forgetpasswordvbDataSet7TableAdapters.CustomersTableAdapter
    Friend WithEvents ForgetpasswordvbDataSet9 As forgetpasswordvbDataSet9
    Friend WithEvents CustomersBindingSource2 As BindingSource
    Friend WithEvents CustomersTableAdapter2 As forgetpasswordvbDataSet9TableAdapters.CustomersTableAdapter

    Friend WithEvents Label2 As Label

    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBoxProductName As ComboBox
    Friend WithEvents ComboBoxCustomerName As ComboBox
    Friend WithEvents ForgetpasswordvbDataSet13 As forgetpasswordvbDataSet13
    Friend WithEvents CustomersBindingSource3 As BindingSource
    Friend WithEvents CustomersTableAdapter3 As forgetpasswordvbDataSet13TableAdapters.CustomersTableAdapter
    Friend WithEvents ForgetpasswordvbDataSet14 As forgetpasswordvbDataSet14
    Friend WithEvents ProductsBindingSource1 As BindingSource
    Friend WithEvents ProductsTableAdapter1 As forgetpasswordvbDataSet14TableAdapters.ProductsTableAdapter
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBoxPrice As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBoxVAT As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBoxDiscount As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBoxTotalAmount As TextBox
    Friend WithEvents ButtonCalculate As Button
    Friend WithEvents ButtonGenerateReceipt As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBoxQuantity As TextBox
End Class
