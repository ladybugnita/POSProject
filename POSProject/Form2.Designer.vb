<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Dashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard))
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Logoutbtn = New System.Windows.Forms.Button()
        Me.Receiptbtn = New System.Windows.Forms.Button()
        Me.Billingbtn = New System.Windows.Forms.Button()
        Me.Customerbtn = New System.Windows.Forms.Button()
        Me.Productbtn = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.BackColor = System.Drawing.Color.MediumPurple
        Me.FlowLayoutPanel2.Controls.Add(Me.PictureBox1)
        Me.FlowLayoutPanel2.Controls.Add(Me.Label1)
        Me.FlowLayoutPanel2.Controls.Add(Me.Label2)
        Me.FlowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(3, 1)
        Me.FlowLayoutPanel2.Margin = New System.Windows.Forms.Padding(4)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(316, 554)
        Me.FlowLayoutPanel2.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(4, 4)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(241, 164)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Lavender
        Me.Label1.Location = New System.Drawing.Point(4, 172)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(287, 126)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Welcome to Standalone POS System!"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Lavender
        Me.Label2.Location = New System.Drawing.Point(4, 298)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(178, 38)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Dashboard"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Logoutbtn)
        Me.Panel1.Controls.Add(Me.Receiptbtn)
        Me.Panel1.Controls.Add(Me.Billingbtn)
        Me.Panel1.Controls.Add(Me.Customerbtn)
        Me.Panel1.Controls.Add(Me.Productbtn)
        Me.Panel1.Location = New System.Drawing.Point(316, 59)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(752, 50)
        Me.Panel1.TabIndex = 2
        '
        'Logoutbtn
        '
        Me.Logoutbtn.FlatAppearance.BorderSize = 0
        Me.Logoutbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Logoutbtn.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Logoutbtn.ForeColor = System.Drawing.Color.MediumPurple
        Me.Logoutbtn.Location = New System.Drawing.Point(628, 0)
        Me.Logoutbtn.Margin = New System.Windows.Forms.Padding(4)
        Me.Logoutbtn.Name = "Logoutbtn"
        Me.Logoutbtn.Size = New System.Drawing.Size(107, 50)
        Me.Logoutbtn.TabIndex = 5
        Me.Logoutbtn.Text = "Logout"
        Me.Logoutbtn.UseVisualStyleBackColor = True
        '
        'Receiptbtn
        '
        Me.Receiptbtn.FlatAppearance.BorderSize = 0
        Me.Receiptbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Receiptbtn.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Receiptbtn.ForeColor = System.Drawing.Color.MediumPurple
        Me.Receiptbtn.Location = New System.Drawing.Point(460, 0)
        Me.Receiptbtn.Margin = New System.Windows.Forms.Padding(4)
        Me.Receiptbtn.Name = "Receiptbtn"
        Me.Receiptbtn.Size = New System.Drawing.Size(120, 50)
        Me.Receiptbtn.TabIndex = 4
        Me.Receiptbtn.Text = "Receipt"
        Me.Receiptbtn.UseVisualStyleBackColor = True
        '
        'Billingbtn
        '
        Me.Billingbtn.FlatAppearance.BorderSize = 0
        Me.Billingbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Billingbtn.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Billingbtn.ForeColor = System.Drawing.Color.MediumPurple
        Me.Billingbtn.Location = New System.Drawing.Point(315, 0)
        Me.Billingbtn.Margin = New System.Windows.Forms.Padding(4)
        Me.Billingbtn.Name = "Billingbtn"
        Me.Billingbtn.Size = New System.Drawing.Size(111, 50)
        Me.Billingbtn.TabIndex = 3
        Me.Billingbtn.Text = "Billing"
        Me.Billingbtn.UseVisualStyleBackColor = True
        '
        'Customerbtn
        '
        Me.Customerbtn.FlatAppearance.BorderSize = 0
        Me.Customerbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Customerbtn.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Customerbtn.ForeColor = System.Drawing.Color.MediumPurple
        Me.Customerbtn.Location = New System.Drawing.Point(149, 0)
        Me.Customerbtn.Margin = New System.Windows.Forms.Padding(4)
        Me.Customerbtn.Name = "Customerbtn"
        Me.Customerbtn.Size = New System.Drawing.Size(135, 50)
        Me.Customerbtn.TabIndex = 1
        Me.Customerbtn.Text = "Customer"
        Me.Customerbtn.UseVisualStyleBackColor = True
        '
        'Productbtn
        '
        Me.Productbtn.FlatAppearance.BorderSize = 0
        Me.Productbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Productbtn.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Productbtn.ForeColor = System.Drawing.Color.MediumPurple
        Me.Productbtn.Location = New System.Drawing.Point(4, 0)
        Me.Productbtn.Margin = New System.Windows.Forms.Padding(4)
        Me.Productbtn.Name = "Productbtn"
        Me.Productbtn.Size = New System.Drawing.Size(116, 47)
        Me.Productbtn.TabIndex = 0
        Me.Productbtn.Text = "Product"
        Me.Productbtn.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Location = New System.Drawing.Point(316, 1)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(752, 50)
        Me.Panel2.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.MediumPurple
        Me.Label3.Location = New System.Drawing.Point(268, 10)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(184, 35)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Point Of Sale"
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.Controls.Add(Me.FlowLayoutPanel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Dashboard"
        Me.Text = "Form2"
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.FlowLayoutPanel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Productbtn As Button
    Friend WithEvents Receiptbtn As Button
    Friend WithEvents Billingbtn As Button
    Friend WithEvents Customerbtn As Button
    Friend WithEvents Logoutbtn As Button
End Class
