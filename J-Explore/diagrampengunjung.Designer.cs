namespace J_Explore
{
    partial class diagrampengunjung
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
            dateTimeBulan.Location = new Point(354, 262);
            dateTimeBulan.Name = "dateTimeBulan";
            dateTimeBulan.Size = new Size(300, 31);
            dateTimeBulan.TabIndex = 11;
            // 
            // dateTimeMinggu
            // 
            dateTimeMinggu.Location = new Point(619, 35);
            dateTimeMinggu.Name = "dateTimeMinggu";
            dateTimeMinggu.Size = new Size(300, 31);
            dateTimeMinggu.TabIndex = 10;
            // 
            // dateTimeHari
            // 
            dateTimeHari.Location = new Point(124, 36);
            dateTimeHari.Name = "dateTimeHari";
            dateTimeHari.Size = new Size(300, 31);
            dateTimeHari.TabIndex = 9;
            // 
            // cartDataBulan
            // 
            cartDataBulan.Location = new Point(37, 317);
            cartDataBulan.Name = "cartDataBulan";
            cartDataBulan.Size = new Size(938, 198);
            cartDataBulan.TabIndex = 8;
            // 
            // cartDataMinggu
            // 
            cartDataMinggu.Location = new Point(542, 89);
            cartDataMinggu.Name = "cartDataMinggu";
            cartDataMinggu.Size = new Size(433, 167);
            cartDataMinggu.TabIndex = 7;
            // 
            // cartDataHari
            // 
            cartDataHari.Location = new Point(37, 89);
            cartDataHari.Name = "cartDataHari";
            cartDataHari.Size = new Size(433, 167);
            cartDataHari.TabIndex = 6;
            // 
            // diagrampengunjung
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1012, 550);
            Controls.Add(dateTimeBulan);
            Controls.Add(dateTimeMinggu);
            Controls.Add(dateTimeHari);
            Controls.Add(cartDataBulan);
            Controls.Add(cartDataMinggu);
            Controls.Add(cartDataHari);
            Name = "diagrampengunjung";
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