<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReceiptForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.RichTextBoxReceipt = New System.Windows.Forms.RichTextBox()
        Me.ButtonSavePDF = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'RichTextBoxReceipt
        '
        Me.RichTextBoxReceipt.BackColor = System.Drawing.Color.White
        Me.RichTextBoxReceipt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RichTextBoxReceipt.Location = New System.Drawing.Point(89, 0)
        Me.RichTextBoxReceipt.Name = "RichTextBoxReceipt"
        Me.RichTextBoxReceipt.ReadOnly = True
        Me.RichTextBoxReceipt.Size = New System.Drawing.Size(636, 334)
        Me.RichTextBoxReceipt.TabIndex = 0
        Me.RichTextBoxReceipt.Text = ""
        '
        'ButtonSavePDF
        '
        Me.ButtonSavePDF.BackColor = System.Drawing.Color.Lavender
        Me.ButtonSavePDF.FlatAppearance.BorderSize = 0
        Me.ButtonSavePDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonSavePDF.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSavePDF.ForeColor = System.Drawing.Color.MediumPurple
        Me.ButtonSavePDF.Location = New System.Drawing.Point(331, 377)
        Me.ButtonSavePDF.Name = "ButtonSavePDF"
        Me.ButtonSavePDF.Size = New System.Drawing.Size(224, 70)
        Me.ButtonSavePDF.TabIndex = 1
        Me.ButtonSavePDF.Text = "Save as PDF"
        Me.ButtonSavePDF.UseVisualStyleBackColor = False
        '
        'ReceiptForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ButtonSavePDF)
        Me.Controls.Add(Me.RichTextBoxReceipt)
        Me.Name = "ReceiptForm"
        Me.Text = "ReceiptForm"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RichTextBoxReceipt As RichTextBox
    Friend WithEvents ButtonSavePDF As Button
End Class
