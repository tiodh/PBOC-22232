namespace J_Explore
{
    partial class diagrampendataan
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
            cartDataHari = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
            cartDataMinggu = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
            cartDataBulan = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
            dateTimeHari = new DateTimePicker();
            dateTimeMinggu = new DateTimePicker();
            dateTimeBulan = new DateTimePicker();
            SuspendLayout();
            // 
            // cartDataHari
            // 
            cartDataHari.Location = new Point(36, 90);
            cartDataHari.Name = "cartDataHari";
            cartDataHari.Size = new Size(433, 167);
            cartDataHari.TabIndex = 0;
            // 
            // cartDataMinggu
            // 
            cartDataMinggu.Location = new Point(541, 90);
            cartDataMinggu.Name = "cartDataMinggu";
            cartDataMinggu.Size = new Size(433, 167);
            cartDataMinggu.TabIndex = 1;
            // 
            // cartDataBulan
            // 
            cartDataBulan.Location = new Point(36, 318);
            cartDataBulan.Name = "cartDataBulan";
            cartDataBulan.Size = new Size(938, 198);
            cartDataBulan.TabIndex = 2;
            // 
            // dateTimeHari
            // 
            dateTimeHari.Location = new Point(123, 37);
            dateTimeHari.Name = "dateTimeHari";
            dateTimeHari.Size = new Size(300, 31);
            dateTimeHari.TabIndex = 3;
            // 
            // dateTimeMinggu
            // 
            dateTimeMinggu.Location = new Point(618, 36);
            dateTimeMinggu.Name = "dateTimeMinggu";
            dateTimeMinggu.Size = new Size(300, 31);
            dateTimeMinggu.TabIndex = 4;
            // 
            // dateTimeBulan
            // 
            dateTimeBulan.Location = new Point(353, 263);
            dateTimeBulan.Name = "dateTimeBulan";
            dateTimeBulan.Size = new Size(300, 31);
            dateTimeBulan.TabIndex = 5;
            // 
            // diagrampendataan
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
            Name = "diagrampendataan";
            Text = "DIAGRAM PENDATAAN";
            ResumeLayout(false);
        }

        #endregion

        private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart cartDataHari;
        private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart cartDataMinggu;
        private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart cartDataBulan;
        private DateTimePicker dateTimeHari;
        private DateTimePicker dateTimeMinggu;
        private DateTimePicker dateTimeBulan;
    }
}