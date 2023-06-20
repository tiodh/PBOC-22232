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
            cartDataMinggu = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
            cartDataHari = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
            label2 = new Label();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel2 = new Panel();
            panel1 = new Panel();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // cartDataMinggu
            // 
            cartDataMinggu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cartDataMinggu.Location = new Point(-3, 46);
            cartDataMinggu.Margin = new Padding(2);
            cartDataMinggu.Name = "cartDataMinggu";
            cartDataMinggu.Size = new Size(1149, 265);
            cartDataMinggu.TabIndex = 7;
            // 
            // cartDataHari
            // 
            cartDataHari.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cartDataHari.Location = new Point(2, 53);
            cartDataHari.Margin = new Padding(2);
            cartDataHari.Name = "cartDataHari";
            cartDataHari.Size = new Size(1139, 242);
            cartDataHari.TabIndex = 6;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(546, 7);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(77, 24);
            label2.TabIndex = 19;
            label2.Text = "TAHUN";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(546, 6);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(77, 24);
            label1.TabIndex = 18;
            label1.Text = "BULAN";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panel2, 0, 1);
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1149, 627);
            tableLayoutPanel1.TabIndex = 20;
            // 
            // panel2
            // 
            panel2.Controls.Add(cartDataMinggu);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 316);
            panel2.Name = "panel2";
            panel2.Size = new Size(1143, 308);
            panel2.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(cartDataHari);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1143, 307);
            panel1.TabIndex = 0;
            // 
            // diagrampendapatan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1149, 627);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(2);
            Name = "diagrampendapatan";
            Text = "DIAGRAM PENDAPATAN";
            Load += diagrampendapatan_Load;
            tableLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart cartDataMinggu;
        private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart cartDataHari;
        private Label label2;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel2;
        private Panel panel1;
    }
}