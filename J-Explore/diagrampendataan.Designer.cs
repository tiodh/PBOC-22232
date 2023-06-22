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
            cartBulan = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
            cartMinggu = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
            cartHari = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // cartBulan
            // 
            cartBulan.Location = new Point(50, 446);
            cartBulan.Name = "cartBulan";
            cartBulan.Size = new Size(1337, 408);
            cartBulan.TabIndex = 14;
            // 
            // cartMinggu
            // 
            cartMinggu.Location = new Point(799, 83);
            cartMinggu.Name = "cartMinggu";
            cartMinggu.Size = new Size(588, 248);
            cartMinggu.TabIndex = 13;
            cartMinggu.Load += cartesianChart2_Load;
            // 
            // cartHari
            // 
            cartHari.Location = new Point(69, 83);
            cartHari.Name = "cartHari";
            cartHari.Size = new Size(588, 248);
            cartHari.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(314, 51);
            label1.Name = "label1";
            label1.Size = new Size(109, 29);
            label1.TabIndex = 15;
            label1.Text = "HARI INI";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(1037, 51);
            label2.Name = "label2";
            label2.Size = new Size(151, 29);
            label2.TabIndex = 16;
            label2.Text = "MINGGU INI";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(665, 394);
            label3.Name = "label3";
            label3.Size = new Size(134, 29);
            label3.TabIndex = 17;
            label3.Text = "BULAN INI";
            // 
            // diagrampendataan
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1436, 866);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cartBulan);
            Controls.Add(cartMinggu);
            Controls.Add(cartHari);
            ForeColor = Color.Black;
            Name = "diagrampendataan";
            Text = "DIAGRAM PENDATAAN";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart cartBulan;
        private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart cartMinggu;
        private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart cartHari;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}