namespace J_Explore
{
    partial class diagrampendapatan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dateTimeBulan = new DateTimePicker();
            dateTimeMinggu = new DateTimePicker();
            dateTimeHari = new DateTimePicker();
            cartDataBulan = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
            cartDataMinggu = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
            cartDataHari = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
            SuspendLayout();
            // 
            // dateTimeBulan
            // 
            dateTimeBulan.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            dateTimeBulan.Location = new Point(578, 370);
            dateTimeBulan.Margin = new Padding(2);
            dateTimeBulan.Name = "dateTimeBulan";
            dateTimeBulan.Size = new Size(300, 31);
            dateTimeBulan.TabIndex = 11;
            // 
            // dateTimeMinggu
            // 
            dateTimeMinggu.Location = new Point(945, 36);
            dateTimeMinggu.Margin = new Padding(2);
            dateTimeMinggu.Name = "dateTimeMinggu";
            dateTimeMinggu.Size = new Size(300, 31);
            dateTimeMinggu.TabIndex = 10;
            // 
            // dateTimeHari
            // 
            dateTimeHari.Location = new Point(218, 36);
            dateTimeHari.Margin = new Padding(2);
            dateTimeHari.Name = "dateTimeHari";
            dateTimeHari.Size = new Size(300, 31);
            dateTimeHari.TabIndex = 9;
            // 
            // cartDataBulan
            // 
            cartDataBulan.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cartDataBulan.Location = new Point(32, 452);
            cartDataBulan.Margin = new Padding(2);
            cartDataBulan.Name = "cartDataBulan";
            cartDataBulan.Size = new Size(1338, 309);
            cartDataBulan.TabIndex = 8;
            // 
            // cartDataMinggu
            // 
            cartDataMinggu.Location = new Point(781, 89);
            cartDataMinggu.Margin = new Padding(2);
            cartDataMinggu.Name = "cartDataMinggu";
            cartDataMinggu.Size = new Size(588, 248);
            cartDataMinggu.TabIndex = 7;
            // 
            // cartDataHari
            // 
            cartDataHari.Location = new Point(51, 89);
            cartDataHari.Margin = new Padding(2);
            cartDataHari.Name = "cartDataHari";
            cartDataHari.Size = new Size(588, 248);
            cartDataHari.TabIndex = 6;
            // 
            // diagrampendapatan
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1436, 784);
            Controls.Add(dateTimeBulan);
            Controls.Add(dateTimeMinggu);
            Controls.Add(dateTimeHari);
            Controls.Add(cartDataBulan);
            Controls.Add(cartDataMinggu);
            Controls.Add(cartDataHari);
            Margin = new Padding(2);
            Name = "diagrampendapatan";
            Text = "DIAGRAM PENDAPATAN";
            Load += diagrampendapatan_Load;
            ResumeLayout(false);
        }

        #endregion

        private DateTimePicker dateTimeBulan;
        private DateTimePicker dateTimeMinggu;
        private DateTimePicker dateTimeHari;
        private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart cartDataBulan;
        private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart cartDataMinggu;
        private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart cartDataHari;
    }
}