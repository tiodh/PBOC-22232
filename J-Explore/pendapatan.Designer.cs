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
            pendapatanBulan = new DataGridView();
            pendapatanMinggu = new DataGridView();
            pendapatanHari = new DataGridView();
            button5 = new Button();
            textBox3 = new TextBox();
            searchDataharian = new Button();
            textBox2 = new TextBox();
            button2 = new Button();
            button1 = new Button();
            tb_pendataanHari = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pendapatanBulan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pendapatanMinggu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pendapatanHari).BeginInit();
            SuspendLayout();
            // 
            // pendapatanBulan
            // 
            pendapatanBulan.BackgroundColor = Color.White;
            pendapatanBulan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            pendapatanBulan.Location = new Point(41, 520);
            pendapatanBulan.Name = "pendapatanBulan";
            pendapatanBulan.RowHeadersWidth = 62;
            pendapatanBulan.RowTemplate.Height = 33;
            pendapatanBulan.Size = new Size(1352, 296);
            pendapatanBulan.TabIndex = 8;
            pendapatanBulan.CellContentClick += pendapatanBulan_CellContentClick;
            // 
            // pendapatanMinggu
            // 
            pendapatanMinggu.BackgroundColor = Color.White;
            pendapatanMinggu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            pendapatanMinggu.Location = new Point(794, 108);
            pendapatanMinggu.Name = "pendapatanMinggu";
            pendapatanMinggu.RowHeadersWidth = 62;
            pendapatanMinggu.RowTemplate.Height = 33;
            pendapatanMinggu.Size = new Size(599, 283);
            pendapatanMinggu.TabIndex = 7;
            pendapatanMinggu.CellContentClick += pendataanMinggu_CellContentClick;
            // 
            // pendapatanHari
            // 
            pendapatanHari.BackgroundColor = Color.White;
            pendapatanHari.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            pendapatanHari.Location = new Point(41, 108);
            pendapatanHari.Name = "pendapatanHari";
            pendapatanHari.RowHeadersWidth = 62;
            pendapatanHari.RowTemplate.Height = 33;
            pendapatanHari.Size = new Size(599, 283);
            pendapatanHari.TabIndex = 6;
            // 
            // button5
            // 
            button5.ForeColor = Color.Black;
            button5.Location = new Point(1243, 465);
            button5.Margin = new Padding(4);
            button5.Name = "button5";
            button5.Size = new Size(156, 36);
            button5.TabIndex = 41;
            button5.Text = "Cari";
            button5.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(47, 465);
            textBox3.Margin = new Padding(4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(1160, 31);
            textBox3.TabIndex = 40;
            // 
            // searchDataharian
            // 
            searchDataharian.ForeColor = Color.Black;
            searchDataharian.Location = new Point(317, 70);
            searchDataharian.Margin = new Padding(4);
            searchDataharian.Name = "searchDataharian";
            searchDataharian.Size = new Size(118, 36);
            searchDataharian.TabIndex = 39;
            searchDataharian.Text = "Cari";
            searchDataharian.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(824, 70);
            textBox2.Margin = new Padding(4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(448, 31);
            textBox2.TabIndex = 38;
            // 
            // button2
            // 
            button2.ForeColor = Color.Black;
            button2.Location = new Point(442, 67);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(94, 36);
            button2.TabIndex = 37;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.ForeColor = Color.Black;
            button1.Location = new Point(1304, 66);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(118, 36);
            button1.TabIndex = 36;
            button1.Text = "Cari";
            button1.UseVisualStyleBackColor = true;
            // 
            // tb_pendataanHari
            // 
            tb_pendataanHari.Location = new Point(70, 67);
            tb_pendataanHari.Margin = new Padding(4);
            tb_pendataanHari.Name = "tb_pendataanHari";
            tb_pendataanHari.Size = new Size(230, 31);
            tb_pendataanHari.TabIndex = 35;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(649, 412);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(134, 29);
            label3.TabIndex = 34;
            label3.Text = "BULAN INI";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(824, 22);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(151, 29);
            label2.TabIndex = 33;
            label2.Text = "MINGGU INI";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(70, 22);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(109, 29);
            label1.TabIndex = 32;
            label1.Text = "HARI INI";
            // 
            // pendapatan
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1436, 852);
            Controls.Add(button5);
            Controls.Add(textBox3);
            Controls.Add(searchDataharian);
            Controls.Add(textBox2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(tb_pendataanHari);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pendapatanBulan);
            Controls.Add(pendapatanMinggu);
            Controls.Add(pendapatanHari);
            ForeColor = Color.Black;
            Name = "pendapatan";
            Text = "PENDATAAN";
            Load += pendapatan_Load;
            ((System.ComponentModel.ISupportInitialize)pendapatanBulan).EndInit();
            ((System.ComponentModel.ISupportInitialize)pendapatanMinggu).EndInit();
            ((System.ComponentModel.ISupportInitialize)pendapatanHari).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView pendapatanBulan;
        private DataGridView pendapatanMinggu;
        private DataGridView pendapatanHari;
        private Button button5;
        private TextBox textBox3;
        private Button searchDataharian;
        private TextBox textBox2;
        private Button button2;
        private Button button1;
        private TextBox tb_pendataanHari;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}