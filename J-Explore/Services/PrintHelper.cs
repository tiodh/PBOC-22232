using J_Explore.Utils;
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
        private static readonly Font font = new Font("Consolas", 8);
        private static readonly Brush brush = Brushes.Black;

        public static void Print(PrintingArguments args, PrintPreviewDialog dialog)
        {
            PrintDocument printDocument = PrintProcess(args);

            dialog.Document = printDocument;

            dialog.ShowDialog();
        }

        public static void Print(PrintingArguments args)
        {
            PrintDocument printDocument = PrintProcess(args);

            printDocument.Print();
        }

        private static PrintDocument PrintProcess(PrintingArguments args)
        {
            PrintDocument printDocument = new PrintDocument();
            PrinterSettings printerSettings = new PrinterSettings();

            printerSettings.DefaultPageSettings.PaperSize = TranslateCurrentPaperSize();
            printerSettings.DefaultPageSettings.Margins = new Margins(0, 0, 4, 4);

            printDocument.PrinterSettings = printerSettings;

            printDocument.PrintPage += new PrintPageEventHandler((sender, e) => PrintEventHandler(sender, e, args));

            return printDocument;
        }

        private static void PrintEventHandler(object sender, PrintPageEventArgs e, PrintingArguments args)
        {
            
            float x = e.MarginBounds.Left;
            float y = e.MarginBounds.Top;

            float spacing = 0;
            float spacingBetweenItem = 10;
            int maxLength = 28;
            char separator = '=';

            if (args is PrintingArgumentsMessage)
            {
                PrintingArgumentsMessage messageArgs = (PrintingArgumentsMessage)args;

                e.Graphics!.DrawString(messageArgs.Message, font, brush, GetCenterX(e, messageArgs.Message), y);
            }
            else if (args is PrintingArgumentsTransaction)
            {
                PrintingArgumentsTransaction transactionArgs = (PrintingArgumentsTransaction)args;

                AddText("Rembangan", e, ref y, spacing);
                AddText($"{transactionArgs.Id}/{transactionArgs.UsernameAdmin}".PadRight(maxLength), e, ref y, spacing);
                AddText(Global.GetFormattedDate(transactionArgs.Tanggal, withDayOfWeek: true), e, ref y, spacing);
                AddText("".PadRight(maxLength, separator), e, ref y, spacing);
                AddText("Anak-Anak" + "".PadRight(maxLength - 9 - 2) + Global.PadLeft(transactionArgs.AnakAnak), e, ref y, spacing);
                AddText("Dewasa" + "".PadRight(maxLength - 6 - 2) + Global.PadLeft(transactionArgs.Dewasa), e, ref y, spacing);
                AddText("".PadRight(maxLength, separator), e, ref y, spacing);
                AddText("Total" + "".PadRight(maxLength - 5 - transactionArgs.Total.ToString("N0").Length) + transactionArgs.Total.ToString("N0"), e, ref y, spacing);
            }
        }

        private static void AddText(string text, PrintPageEventArgs e, ref float y, float spacing)
        {
            e.Graphics!.DrawString(text, font, brush, GetCenterX(e, text), y);
            y += AddNewLine(e, spacing);
        }

        private static float GetCenterX(PrintPageEventArgs e, string text) => e.MarginBounds.Left + (e.MarginBounds.Width - e.Graphics.MeasureString(text, font).Width) / 2;

        private static float GetCenterY(PrintPageEventArgs e, string text) => e.MarginBounds.Top + (e.MarginBounds.Height - e.Graphics.MeasureString(text, font).Height) / 2;

        private static float AddNewLine(PrintPageEventArgs e, float spacing) => e.Graphics.MeasureString("A", font).Height + spacing;

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
        public int Id;
        public string UsernameAdmin;
        public DateTime Tanggal;
        public int AnakAnak;
        public int Dewasa;
        public int Total;

        public PrintingArgumentsTransaction(int id, string usernameAdmin, DateTime tanggal, int anakAnak, int dewasa, int total)
        {
            Id = id;
            UsernameAdmin = usernameAdmin;
            Tanggal = tanggal;
            AnakAnak = anakAnak;
            Dewasa = dewasa;
            Total = total;
        }
    }
}
