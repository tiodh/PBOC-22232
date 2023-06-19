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
            dateTimeBulan.Location = new Point(462, 296);
            dateTimeBulan.Margin = new Padding(2);
            dateTimeBulan.Name = "dateTimeBulan";
            dateTimeBulan.Size = new Size(241, 27);
            dateTimeBulan.TabIndex = 11;
            // 
            // dateTimeMinggu
            // 
            dateTimeMinggu.Location = new Point(756, 29);
            dateTimeMinggu.Margin = new Padding(2);
            dateTimeMinggu.Name = "dateTimeMinggu";
            dateTimeMinggu.Size = new Size(241, 27);
            dateTimeMinggu.TabIndex = 10;
            // 
            // dateTimeHari
            // 
            dateTimeHari.Location = new Point(174, 29);
            dateTimeHari.Margin = new Padding(2);
            dateTimeHari.Name = "dateTimeHari";
            dateTimeHari.Size = new Size(241, 27);
            dateTimeHari.TabIndex = 9;
            // 
            // cartDataBulan
            // 
            cartDataBulan.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cartDataBulan.Location = new Point(26, 362);
            cartDataBulan.Margin = new Padding(2);
            cartDataBulan.Name = "cartDataBulan";
            cartDataBulan.Size = new Size(1070, 247);
            cartDataBulan.TabIndex = 8;
            // 
            // cartDataMinggu
            // 
            cartDataMinggu.Location = new Point(625, 71);
            cartDataMinggu.Margin = new Padding(2);
            cartDataMinggu.Name = "cartDataMinggu";
            cartDataMinggu.Size = new Size(470, 198);
            cartDataMinggu.TabIndex = 7;
            // 
            // cartDataHari
            // 
            cartDataHari.Location = new Point(41, 71);
            cartDataHari.Margin = new Padding(2);
            cartDataHari.Name = "cartDataHari";
            cartDataHari.Size = new Size(470, 198);
            cartDataHari.TabIndex = 6;
            // 
            // diagrampendapatan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1149, 627);
            Controls.Add(dateTimeBulan);
            Controls.Add(dateTimeMinggu);
            Controls.Add(dateTimeHari);
            Controls.Add(cartDataBulan);
            Controls.Add(cartDataMinggu);
            Controls.Add(cartDataHari);
            Margin = new Padding(2);
            Name = "diagrampendapatan";
            Text = "diagrampengunjung";
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