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
            cartDataBulan = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
            cartDataMinggu = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
            cartDataHari = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(652, 392);
            label3.Name = "label3";
            label3.Size = new Size(134, 29);
            label3.TabIndex = 20;
            label3.Text = "BULAN INI";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(1024, 49);
            label2.Name = "label2";
            label2.Size = new Size(151, 29);
            label2.TabIndex = 19;
            label2.Text = "MINGGU INI";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(301, 49);
            label1.Name = "label1";
            label1.Size = new Size(109, 29);
            label1.TabIndex = 18;
            label1.Text = "HARI INI";
            // 
            // diagrampendapatan
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1436, 784);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cartDataBulan);
            Controls.Add(cartDataMinggu);
            Controls.Add(cartDataHari);
            Margin = new Padding(2);
            Name = "diagrampendapatan";
            Text = "DIAGRAM PENDAPATAN";
            Load += diagrampendapatan_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart cartDataBulan;
        private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart cartDataMinggu;
        private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart cartDataHari;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}