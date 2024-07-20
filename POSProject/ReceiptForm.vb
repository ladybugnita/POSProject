Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO

Public Class ReceiptForm
    Public Property CustomerNameProperty As String
    Public Property ProductNameProperty As String
    Public Property PriceProperty As Decimal ' Changed to Decimal for proper numeric handling
    Public Property VATProperty As Decimal ' Changed to Decimal for proper numeric handling
    Public Property DiscountProperty As Decimal ' Changed to Decimal for proper numeric handling
    Public Property TotalAmountProperty As Decimal ' Changed to Decimal for proper numeric handling
    Public Property QuantityProperty As Integer

    Private Sub ReceiptForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RichTextBoxReceipt.Text = $"Customer Name: {CustomerNameProperty}" & Environment.NewLine &
                                  $"Product Name: {ProductNameProperty}" & Environment.NewLine &
                                  $"Price: {PriceProperty.ToString("F2")}" & Environment.NewLine &
                                  $"Quantity: {QuantityProperty}" & Environment.NewLine &
                                  $"VAT: {VATProperty}%" & Environment.NewLine &
                                  $"Discount: {DiscountProperty}%" & Environment.NewLine &
                                  $"Total Amount: {TotalAmountProperty.ToString("F2")}"
    End Sub

    Private Sub ButtonSavePDF_Click(sender As Object, e As EventArgs) Handles ButtonSavePDF.Click
        Using saveFileDialog As New SaveFileDialog()
            saveFileDialog.Filter = "PDF files (.pdf)|.pdf"
            saveFileDialog.Title = "Save Receipt as PDF"
            saveFileDialog.FileName = $"Receipt_{DateTime.Now.Ticks}.pdf"

            If saveFileDialog.ShowDialog() = DialogResult.OK Then
                Dim pdfPath As String = saveFileDialog.FileName

                Dim doc As New Document(PageSize.A4, 50, 50, 25, 25)
                Dim writer As PdfWriter = PdfWriter.GetInstance(doc, New FileStream(pdfPath, FileMode.Create))

                Try
                    doc.Open()

                    ' Add header
                    doc.Add(New Paragraph("Receipt", FontFactory.GetFont("Helvetica", BaseFont.IDENTITY_H, 18)))
                    doc.Add(New Paragraph($"Date: {DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}", FontFactory.GetFont("Helvetica", BaseFont.IDENTITY_H, 12)))
                    doc.Add(New Paragraph($"Customer Name: {CustomerNameProperty}", FontFactory.GetFont("Helvetica", BaseFont.IDENTITY_H, 12)))
                    doc.Add(New Paragraph(" "))

                    ' Create table
                    Dim table As New PdfPTable(4)
                    table.WidthPercentage = 100
                    table.SetWidths(New Single() {2.5F, 1.0F, 1.0F, 1.0F}) ' Adjusted column widths

                    ' Add table headers
                    table.AddCell(New PdfPCell(New Phrase("Description", FontFactory.GetFont("Helvetica", BaseFont.IDENTITY_H, 12))) With {.HorizontalAlignment = Element.ALIGN_CENTER})
                    table.AddCell(New PdfPCell(New Phrase("Quantity", FontFactory.GetFont("Helvetica", BaseFont.IDENTITY_H, 12))) With {.HorizontalAlignment = Element.ALIGN_CENTER})
                    table.AddCell(New PdfPCell(New Phrase("Price", FontFactory.GetFont("Helvetica", BaseFont.IDENTITY_H, 12))) With {.HorizontalAlignment = Element.ALIGN_CENTER})
                    table.AddCell(New PdfPCell(New Phrase("Total", FontFactory.GetFont("Helvetica", BaseFont.IDENTITY_H, 12))) With {.HorizontalAlignment = Element.ALIGN_CENTER})

                    ' Add rows
                    table.AddCell(ProductNameProperty)
                    table.AddCell(QuantityProperty.ToString())
                    table.AddCell(PriceProperty.ToString("F2"))
                    table.AddCell(TotalAmountProperty.ToString("F2"))

                    ' Add table to document
                    doc.Add(table)
                    doc.Close()
                    writer.Close()

                    MessageBox.Show("Receipt saved as PDF successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show("Error saving PDF: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End Using
    End Sub
End Class

