namespace J_Explore
{
    partial class pendapatan
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
            pendataanBulan = new DataGridView();
            pendataanMinggu = new DataGridView();
            pendataanHari = new DataGridView();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pendataanBulan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pendataanMinggu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pendataanHari).BeginInit();
            SuspendLayout();
            // 
            // pendataanBulan
            // 
            pendataanBulan.BackgroundColor = Color.White;
            pendataanBulan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            pendataanBulan.Location = new Point(40, 449);
            pendataanBulan.Name = "pendataanBulan";
            pendataanBulan.RowHeadersWidth = 62;
            pendataanBulan.RowTemplate.Height = 33;
            pendataanBulan.Size = new Size(1352, 296);
            pendataanBulan.TabIndex = 8;
            // 
            // pendataanMinggu
            // 
            pendataanMinggu.BackgroundColor = Color.White;
            pendataanMinggu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            pendataanMinggu.Location = new Point(793, 82);
            pendataanMinggu.Name = "pendataanMinggu";
            pendataanMinggu.RowHeadersWidth = 62;
            pendataanMinggu.RowTemplate.Height = 33;
            pendataanMinggu.Size = new Size(599, 283);
            pendataanMinggu.TabIndex = 7;
            pendataanMinggu.CellContentClick += pendataanMinggu_CellContentClick;
            // 
            // pendataanHari
            // 
            pendataanHari.BackgroundColor = Color.White;
            pendataanHari.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            pendataanHari.Location = new Point(40, 82);
            pendataanHari.Name = "pendataanHari";
            pendataanHari.RowHeadersWidth = 62;
            pendataanHari.RowTemplate.Height = 33;
            pendataanHari.Size = new Size(599, 283);
            pendataanHari.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(644, 393);
            label3.Name = "label3";
            label3.Size = new Size(134, 29);
            label3.TabIndex = 20;
            label3.Text = "BULAN INI";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(1045, 33);
            label2.Name = "label2";
            label2.Size = new Size(151, 29);
            label2.TabIndex = 19;
            label2.Text = "MINGGU INI";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(278, 33);
            label1.Name = "label1";
            label1.Size = new Size(109, 29);
            label1.TabIndex = 18;
            label1.Text = "HARI INI";
            // 
            // pendapatan
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1436, 784);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pendataanBulan);
            Controls.Add(pendataanMinggu);
            Controls.Add(pendataanHari);
            ForeColor = Color.Black;
            Name = "pendapatan";
            Text = "PENDATAAN";
            ((System.ComponentModel.ISupportInitialize)pendataanBulan).EndInit();
            ((System.ComponentModel.ISupportInitialize)pendataanMinggu).EndInit();
            ((System.ComponentModel.ISupportInitialize)pendataanHari).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView pendataanBulan;
        private DataGridView pendataanMinggu;
        private DataGridView pendataanHari;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}