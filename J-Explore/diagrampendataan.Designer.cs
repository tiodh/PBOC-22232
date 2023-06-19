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
            dateTimeBulan = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker3 = new DateTimePicker();
            cartesianChart1 = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
            cartesianChart2 = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
            cartesianChart3 = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
            SuspendLayout();
            // 
            // cartDataHari
            // 
            cartDataHari.Location = new Point(36, 90);
            cartDataHari.Name = "cartDataHari";
            cartDataHari.Size = new Size(433, 167);
            cartDataHari.TabIndex = 0;
            // 
            // dateTimeBulan
            // 
            dateTimeBulan.Location = new Point(353, 263);
            dateTimeBulan.Name = "dateTimeBulan";
            dateTimeBulan.Size = new Size(300, 31);
            dateTimeBulan.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(595, 364);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(300, 31);
            dateTimePicker1.TabIndex = 17;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(963, 30);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(300, 31);
            dateTimePicker2.TabIndex = 16;
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Location = new Point(235, 30);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(300, 31);
            dateTimePicker3.TabIndex = 15;
            // 
            // cartesianChart1
            // 
            cartesianChart1.Location = new Point(50, 446);
            cartesianChart1.Name = "cartesianChart1";
            cartesianChart1.Size = new Size(1337, 309);
            cartesianChart1.TabIndex = 14;
            // 
            // cartesianChart2
            // 
            cartesianChart2.Location = new Point(799, 83);
            cartesianChart2.Name = "cartesianChart2";
            cartesianChart2.Size = new Size(588, 248);
            cartesianChart2.TabIndex = 13;
            // 
            // cartesianChart3
            // 
            cartesianChart3.Location = new Point(69, 83);
            cartesianChart3.Name = "cartesianChart3";
            cartesianChart3.Size = new Size(588, 248);
            cartesianChart3.TabIndex = 12;
            // 
            // diagrampendataan
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1436, 784);
            Controls.Add(dateTimePicker1);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker3);
            Controls.Add(cartesianChart1);
            Controls.Add(cartesianChart2);
            Controls.Add(cartesianChart3);
            Controls.Add(dateTimeBulan);
            Controls.Add(cartDataHari);
            Name = "diagrampendataan";
            Text = "DIAGRAM PENDATAAN";
            ResumeLayout(false);
        }

        #endregion

        private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart cartDataHari;
        private DateTimePicker dateTimeBulan;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker3;
        private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart cartesianChart1;
        private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart cartesianChart2;
        private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart cartesianChart3;
    }
}