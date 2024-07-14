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
        Me.btnAddToBill = New System.Windows.Forms.Button()
        Me.dgvBilling = New System.Windows.Forms.DataGridView()
        Me.CustomerNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnitPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BillingSystemBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ForgetpasswordvbDataSet5 = New POSProject.forgetpasswordvbDataSet5()
        Me.BillingSystemTableAdapter = New POSProject.forgetpasswordvbDataSet5TableAdapters.BillingSystemTableAdapter()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbCustomers = New System.Windows.Forms.ComboBox()
        Me.CustomersBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ForgetpasswordvbDataSet7 = New POSProject.forgetpasswordvbDataSet7()
        Me.CustomersTableAdapter1 = New POSProject.forgetpasswordvbDataSet7TableAdapters.CustomersTableAdapter()
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ForgetpasswordvbDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ForgetpasswordvbDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ForgetpasswordvbDataSet4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvBilling, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BillingSystemBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ForgetpasswordvbDataSet5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomersBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ForgetpasswordvbDataSet7, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'btnAddToBill
        '
        Me.btnAddToBill.FlatAppearance.BorderSize = 0
        Me.btnAddToBill.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddToBill.ForeColor = System.Drawing.Color.MediumPurple
        Me.btnAddToBill.Location = New System.Drawing.Point(366, 270)
        Me.btnAddToBill.Name = "btnAddToBill"
        Me.btnAddToBill.Size = New System.Drawing.Size(163, 42)
        Me.btnAddToBill.TabIndex = 10
        Me.btnAddToBill.Text = "AddToBill"
        Me.btnAddToBill.UseVisualStyleBackColor = True
        '
        'dgvBilling
        '
        Me.dgvBilling.AllowUserToOrderColumns = True
        Me.dgvBilling.AutoGenerateColumns = False
        Me.dgvBilling.BackgroundColor = System.Drawing.Color.Lavender
        Me.dgvBilling.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBilling.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CustomerNameDataGridViewTextBoxColumn, Me.ProductIDDataGridViewTextBoxColumn, Me.ProductNameDataGridViewTextBoxColumn, Me.UnitPriceDataGridViewTextBoxColumn, Me.TotalPriceDataGridViewTextBoxColumn})
        Me.dgvBilling.DataSource = Me.BillingSystemBindingSource
        Me.dgvBilling.Location = New System.Drawing.Point(99, 34)
        Me.dgvBilling.Name = "dgvBilling"
        Me.dgvBilling.RowHeadersWidth = 51
        Me.dgvBilling.RowTemplate.Height = 24
        Me.dgvBilling.Size = New System.Drawing.Size(680, 150)
        Me.dgvBilling.TabIndex = 8
        '
        'CustomerNameDataGridViewTextBoxColumn
        '
        Me.CustomerNameDataGridViewTextBoxColumn.DataPropertyName = "CustomerName"
        Me.CustomerNameDataGridViewTextBoxColumn.HeaderText = "CustomerName"
        Me.CustomerNameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CustomerNameDataGridViewTextBoxColumn.Name = "CustomerNameDataGridViewTextBoxColumn"
        Me.CustomerNameDataGridViewTextBoxColumn.Width = 125
        '
        'ProductIDDataGridViewTextBoxColumn
        '
        Me.ProductIDDataGridViewTextBoxColumn.DataPropertyName = "ProductID"
        Me.ProductIDDataGridViewTextBoxColumn.HeaderText = "ProductID"
        Me.ProductIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ProductIDDataGridViewTextBoxColumn.Name = "ProductIDDataGridViewTextBoxColumn"
        Me.ProductIDDataGridViewTextBoxColumn.Width = 125
        '
        'ProductNameDataGridViewTextBoxColumn
        '
        Me.ProductNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName"
        Me.ProductNameDataGridViewTextBoxColumn.HeaderText = "ProductName"
        Me.ProductNameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ProductNameDataGridViewTextBoxColumn.Name = "ProductNameDataGridViewTextBoxColumn"
        Me.ProductNameDataGridViewTextBoxColumn.Width = 125
        '
        'UnitPriceDataGridViewTextBoxColumn
        '
        Me.UnitPriceDataGridViewTextBoxColumn.DataPropertyName = "UnitPrice"
        Me.UnitPriceDataGridViewTextBoxColumn.HeaderText = "UnitPrice"
        Me.UnitPriceDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.UnitPriceDataGridViewTextBoxColumn.Name = "UnitPriceDataGridViewTextBoxColumn"
        Me.UnitPriceDataGridViewTextBoxColumn.Width = 125
        '
        'TotalPriceDataGridViewTextBoxColumn
        '
        Me.TotalPriceDataGridViewTextBoxColumn.DataPropertyName = "TotalPrice"
        Me.TotalPriceDataGridViewTextBoxColumn.HeaderText = "TotalPrice"
        Me.TotalPriceDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TotalPriceDataGridViewTextBoxColumn.Name = "TotalPriceDataGridViewTextBoxColumn"
        Me.TotalPriceDataGridViewTextBoxColumn.Width = 125
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 211)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 16)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "CustomerName"
        '
        'cmbCustomers
        '
        Me.cmbCustomers.DataSource = Me.CustomersBindingSource1
        Me.cmbCustomers.FormattingEnabled = True
        Me.cmbCustomers.Location = New System.Drawing.Point(161, 208)
        Me.cmbCustomers.Name = "cmbCustomers"
        Me.cmbCustomers.Size = New System.Drawing.Size(121, 24)
        Me.cmbCustomers.TabIndex = 12
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
        'BillingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.cmbCustomers)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgvBilling)
        Me.Controls.Add(Me.btnAddToBill)
        Me.Controls.Add(Me.Label1)
        Me.Name = "BillingForm"
        Me.Text = "BillingForm"
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ForgetpasswordvbDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ForgetpasswordvbDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ForgetpasswordvbDataSet4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvBilling, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BillingSystemBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ForgetpasswordvbDataSet5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomersBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ForgetpasswordvbDataSet7, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents btnAddToBill As Button
    Friend WithEvents dgvBilling As DataGridView
    Friend WithEvents ForgetpasswordvbDataSet5 As forgetpasswordvbDataSet5
    Friend WithEvents BillingSystemBindingSource As BindingSource
    Friend WithEvents BillingSystemTableAdapter As forgetpasswordvbDataSet5TableAdapters.BillingSystemTableAdapter
    Friend WithEvents CustomerNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UnitPriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalPriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbCustomers As ComboBox
    Friend WithEvents ForgetpasswordvbDataSet7 As forgetpasswordvbDataSet7
    Friend WithEvents CustomersBindingSource1 As BindingSource
    Friend WithEvents CustomersTableAdapter1 As forgetpasswordvbDataSet7TableAdapters.CustomersTableAdapter
End Class
