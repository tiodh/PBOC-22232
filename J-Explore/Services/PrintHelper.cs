using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace J_Explore.Services
{
    public class PrintHelper
    {
        public static void Print(PrintingArguments args)
        {
            PrintDocument printDocument = new PrintDocument();
            PrinterSettings printerSettings = new PrinterSettings();

            printerSettings.DefaultPageSettings.PaperSize = TranslateCurrentPaperSize();
            printerSettings.DefaultPageSettings.Margins = new Margins(0, 0, 4, 4);

            printDocument.PrinterSettings = printerSettings;

            printDocument.PrintPage += new PrintPageEventHandler((sender, e) => PrintEventHandler(sender, e, args));

            printDocument.Print();
        }

        private static void PrintEventHandler(object sender, PrintPageEventArgs e, PrintingArguments args)
        {
            Font font = new Font("Consolas", 10);
            Brush brush = Brushes.Black;
            float x = e.MarginBounds.Left;
            float y = e.MarginBounds.Top;

            float spacing = 0;
            float spacingBetweenItem = 10;
            int maxLength = 22;
            char separator = '=';

            if (args is PrintingArgumentsMessage)
            {
                PrintingArgumentsMessage messageArgs = (PrintingArgumentsMessage)args;

                e.Graphics.DrawString(messageArgs.Message, font, brush, GetCenterX(e, font, messageArgs.Message), y);
            }
            else if (args is PrintingArgumentsTransaction)
            {
                PrintingArgumentsTransaction transactionArgs = (PrintingArgumentsTransaction)args;
                int total = 0;

                e.Graphics.DrawString("Tokoku", font, brush, GetCenterX(e, font, "Tokoku"), y);
                y += AddNewLine(e, font, spacing);
                e.Graphics.DrawString("Jalan Antah Berantah", font, brush, GetCenterX(e, font, "Jalan Antah Berantah"), y);
                y += AddNewLine(e, font, spacing);
                e.Graphics.DrawString("".PadRight(maxLength, separator), font, brush, GetCenterX(e, font, "".PadRight(maxLength, separator)), y);
                y += AddNewLine(e, font, spacing);
                e.Graphics.DrawString($"1/kasir".PadRight(maxLength), font, brush, GetCenterX(e, font, "".PadRight(maxLength, separator)), y);
                y += AddNewLine(e, font, spacing);
                //e.Graphics.DrawString($"{Global.GetFormattedDate(transactionArgs.Transaction.Date)}".PadRight(maxLength), font, brush, GetCenterX(e, font, "".PadRight(maxLength, separator)), y);
                //y += AddNewLine(e, font, spacing);
                e.Graphics.DrawString("".PadRight(maxLength, separator), font, brush, GetCenterX(e, font, "".PadRight(maxLength, separator)), y);
                y += AddNewLine(e, font, spacing);
                //foreach (DetailTransaction detailTransaction in transactionArgs.DetailTransactions)
                //{
                //    total += detailTransaction.Laptop.Price * detailTransaction.Amount;

                //    foreach (string name in BreakStringByLength(detailTransaction.Laptop.Name, maxLength))
                //    {
                //        e.Graphics.DrawString($"{name.PadRight(maxLength)}", font, brush, GetCenterX(e, font, "".PadRight(maxLength, separator)), y);
                //        y += AddNewLine(e, font, spacing);
                //    }

                //    string temporaryPrice = $"{detailTransaction.Laptop.Price} * {detailTransaction.Amount}";
                //    string finalPrice = (detailTransaction.Laptop.Price * detailTransaction.Amount).ToString();

                //    int temporaryPriceLength = temporaryPrice.Length + 1;
                //    int priceLength = finalPrice.Length;

                //    if (temporaryPriceLength + priceLength <= maxLength)
                //    {
                //        temporaryPrice = temporaryPrice + "".PadRight(maxLength - temporaryPriceLength - priceLength) + finalPrice;
                //        e.Graphics.DrawString(temporaryPrice, font, brush, GetCenterX(e, font, "".PadRight(maxLength, separator)), y);
                //        y += AddNewLine(e, font, spacing + spacingBetweenItem);
                //    }
                //    else
                //    {
                //        e.Graphics.DrawString(temporaryPrice, font, brush, GetCenterX(e, font, "".PadRight(maxLength, separator)), y);
                //        y += AddNewLine(e, font, spacing);
                //        e.Graphics.DrawString(finalPrice, font, brush, GetCenterX(e, font, "".PadRight(maxLength, separator)), y);
                //        y += AddNewLine(e, font, spacing + spacingBetweenItem);
                //    }
                //}
                e.Graphics.DrawString("".PadRight(maxLength, separator), font, brush, GetCenterX(e, font, "".PadRight(maxLength, separator)), y);
                y += AddNewLine(e, font, spacing);
                e.Graphics.DrawString("Total" + "".PadRight(maxLength - 5 - total.ToString().Length) + total.ToString(), font, brush, GetCenterX(e, font, "".PadRight(maxLength, separator)), y);
                y += AddNewLine(e, font, spacing);
                //e.Graphics.DrawString("Bayar" + "".PadRight(maxLength - 5 - transactionArgs.Transaction.pay.ToString().Length) + transactionArgs.Transaction.pay.ToString(), font, brush, GetCenterX(e, font, "".PadRight(maxLength, separator)), y);
                //y += AddNewLine(e, font, spacing);
                //int change = transactionArgs.Transaction.pay - total;
                //e.Graphics.DrawString("Kembali" + "".PadRight(maxLength - 7 - change.ToString().Length) + change.ToString(), font, brush, GetCenterX(e, font, "".PadRight(maxLength, separator)), y);
            }
        }

        private static float GetCenterX(PrintPageEventArgs e, Font font, string text) => e.MarginBounds.Left + (e.MarginBounds.Width - e.Graphics.MeasureString(text, font).Width) / 2;

        private static float GetCenterY(PrintPageEventArgs e, Font font, string text) => e.MarginBounds.Top + (e.MarginBounds.Height - e.Graphics.MeasureString(text, font).Height) / 2;

        private static float AddNewLine(PrintPageEventArgs e, Font font, float spacing) => e.Graphics.MeasureString("A", font).Height + spacing;

        private static List<string> BreakStringByLength(string input, int length)
        {
            List<string> lines = new List<string>();
            int currentIndex = 0;

            while (currentIndex < input.Length)
            {
                if (currentIndex + length < input.Length)
                {
                    lines.Add(input.Substring(currentIndex, length));
                    currentIndex += length;
                }
                else
                {
                    lines.Add(input.Substring(currentIndex));
                    currentIndex = input.Length;
                }
            }

            return lines;
        }

        private static string GetLastLineByLength(string input, int length)
        {
            int startIndex = input.Length - length;
            if (startIndex < 0)
                startIndex = 0;

            return input.Substring(startIndex);
        }

        public static PrinterSettings.StringCollection GetAvailablePrinters() => PrinterSettings.InstalledPrinters;

        public static void SetCurrentPrinter(string printer)
        {
            Properties.Settings.Default.CurrentPrinter = printer;
            Properties.Settings.Default.Save();
        }

        public static string GetCurrentPrinter()
        {
            string currentPrinter = Properties.Settings.Default.CurrentPrinter;

            if (string.IsNullOrEmpty(currentPrinter))
            {
                return new PrinterSettings().PrinterName;
            }
            return currentPrinter;
        }
        public static List<string> GetAvailablePaperSizes() => new List<string>() { Global.PaperSize58mmName, Global.PaperSize80mmName };

        public static void SetCurrentPaperSize(string paperSize)
        {
            Properties.Settings.Default.CurrentPaperSize = paperSize;
            Properties.Settings.Default.Save();
        }

        public static string GetCurrentPaperSize()
        {
            string currentPaperSize = Properties.Settings.Default.CurrentPaperSize;

            if (string.IsNullOrEmpty(currentPaperSize))
            {
                return Global.PaperSize58mmName;
            }
            return currentPaperSize;
        }

        private static PaperSize TranslateCurrentPaperSize()
        {
            switch (GetCurrentPaperSize())
            {
                case Global.PaperSize80mmName:
                    return Global.PaperSize80mm;
                default:
                    return Global.PaperSize58mm;
            }
        }
    }

    public abstract class PrintingArguments { }

    public class PrintingArgumentsMessage : PrintingArguments
    {
        public string Message;

        public PrintingArgumentsMessage(string message)
        {
            Message = message;
        }
    }

    public class PrintingArgumentsTransaction : PrintingArguments
    {
        //public Transaction Transaction;
        //public List<DetailTransaction> DetailTransactions;

        //public PrintingArgumentsTransaction(Transaction transaction, List<DetailTransaction> detailTransactions)
        //{
        //    Transaction = transaction;
        //    DetailTransactions = detailTransactions;
        //}
    }
}
