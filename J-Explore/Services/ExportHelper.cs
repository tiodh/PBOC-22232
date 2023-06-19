using iText.IO.Font.Constants;
using iText.Kernel.Font;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using J_Explore.Utils;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using OfficeOpenXml;
using OfficeOpenXml.Style;

namespace J_Explore.Services
{
    public class ExportHelper
    {
        private static ExcelPackage GenerateExcel(List<PrintingArgumentsTransaction> data)
        {
            ExcelPackage excelPackage = new ExcelPackage();

            ExcelWorksheet reportSheet = excelPackage.Workbook.Worksheets.Add("Laporan");

            reportSheet.Cells[1, 1].Value = "Laporan Riwayat Transaksi";
            reportSheet.Cells[3, 1].Value = "Id";
            reportSheet.Cells[3, 2].Value = "Admin";
            reportSheet.Cells[3, 3].Value = "Tanggal";
            reportSheet.Cells[3, 4].Value = "Anak-Anak";
            reportSheet.Cells[3, 5].Value = "Dewasa";
            reportSheet.Cells[3, 6].Value = "Total";

            List<ExcelRange> mergedCells = new List<ExcelRange>()
            {
                reportSheet.Cells["A1:F2"]
            };

            foreach (ExcelRange mergedCell in mergedCells)
            {
                mergedCell.Merge = true;
                mergedCell.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                mergedCell.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
            }

            int i = 0;
            int additionalRow = 4;
            foreach (PrintingArgumentsTransaction transaction in data)
            {
                reportSheet.Cells[i + additionalRow, 1].Value = transaction.Id;
                reportSheet.Cells[i + additionalRow, 2].Value = transaction.UsernameAdmin;
                reportSheet.Cells[i + additionalRow, 3].Value = Global.GetFormattedDate(transaction.Tanggal, withDayOfWeek: true, withMonthName: true);
                reportSheet.Cells[i + additionalRow, 4].Value = transaction.AnakAnak.ToString("N0");
                reportSheet.Cells[i + additionalRow, 5].Value = transaction.Dewasa.ToString("N0");
                reportSheet.Cells[i + additionalRow, 6].Value = transaction.Total.ToString("N0");
                 
                i++;
            }
            return excelPackage;
        }

        private static string? OpenSaveAsDialog(bool isExcel = false)
        {
            SaveFileDialog saveAsDialog = new SaveFileDialog();

            string filter = "All files|*.*|";
            string defaultExt = "xlsx";
            if (isExcel)
            {
                filter += "Excel files (.xlsx)|*.xlsx";
                defaultExt = "xlsx";
            }
            else
            {
                filter += "Pdf files (.pdf)|*.pdf";
                defaultExt = "pdf";
            }

            saveAsDialog.Filter = filter;
            saveAsDialog.DefaultExt = defaultExt;
            DialogResult result = saveAsDialog.ShowDialog();

            if (result == DialogResult.Cancel)
            {
                return null;
            }
            return saveAsDialog.FileName;
        }

        public static void ExportReportToExcel(List<PrintingArgumentsTransaction> data)
        {
            string? filePath = OpenSaveAsDialog(true);

            if (filePath == null)
            {
                return;
            }

            ExcelPackage excelPackage = GenerateExcel(data);

            FileInfo fileInfo = new FileInfo(filePath);
            excelPackage.SaveAs(fileInfo);
        }

        public static void ExportReportToPdf(List<PrintingArgumentsTransaction> data)
        {
            string? filePath = OpenSaveAsDialog(true);

            if (filePath == null)
            {
                return;
            }

            using (ExcelPackage excelPackage = GenerateExcel(data))
            {
                ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets[0];
                using (PdfWriter writer = new PdfWriter(filePath))
                {
                    using (PdfDocument pdfDocument = new PdfDocument(writer))
                    {
                        pdfDocument.SetDefaultPageSize(PageSize.A4);

                        using (iText.Layout.Document document = new iText.Layout.Document(pdfDocument))
                        {
                            document.SetMargins(20, 20, 20, 20);

                            PdfFont titleFont = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);
                            PdfFont cellFont = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);

                            // Add title to the PDF
                            Paragraph title = new Paragraph("Laporan Riwayat Transaksi")
                                .SetFont(titleFont)
                                .SetFontSize(18)
                                .SetTextAlignment(TextAlignment.CENTER)
                                .SetMarginBottom(20);
                            document.Add(title);

                            // Create a table for the data
                            Table table = new Table(UnitValue.CreatePercentArray(6)).UseAllAvailableWidth();
                            table.SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.CENTER);

                            // Add table headers
                            table.AddCell(CreateCell("Id", cellFont, true));
                            table.AddCell(CreateCell("Admin", cellFont, true));
                            table.AddCell(CreateCell("Tanggal", cellFont, true));
                            table.AddCell(CreateCell("Anak-Anak", cellFont, true));
                            table.AddCell(CreateCell("Dewasa", cellFont, true));
                            table.AddCell(CreateCell("Total", cellFont, true));

                            // Populate table with data from Excel
                            for (int row = 5; row <= worksheet.Dimension.End.Row; row++)
                            {
                                table.AddCell(CreateCell(worksheet.Cells[row, 1].Value?.ToString() ?? "", cellFont));
                                table.AddCell(CreateCell(worksheet.Cells[row, 2].Value?.ToString() ?? "", cellFont));
                                table.AddCell(CreateCell(worksheet.Cells[row, 3].Value?.ToString() ?? "", cellFont));
                                table.AddCell(CreateCell(worksheet.Cells[row, 4].Value?.ToString() ?? "", cellFont));
                                table.AddCell(CreateCell(worksheet.Cells[row, 5].Value?.ToString() ?? "", cellFont));
                                table.AddCell(CreateCell(worksheet.Cells[row, 6].Value?.ToString() ?? "", cellFont));
                            }

                            document.Add(table);
                        }
                    }
                }
            }
        }

        private static Cell CreateCell(string cellValue, PdfFont font, bool isHeader = false)
        {
            Cell cell = new Cell().Add(new Paragraph(cellValue).SetFont(font));

            if (isHeader)
            {
                cell.SetBold();
            }

            return cell;
        }

    }
}
