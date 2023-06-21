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
            pendapatanBulan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            pendapatanBulan.BackgroundColor = Color.White;
            pendapatanBulan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            pendapatanBulan.Location = new Point(33, 416);
            pendapatanBulan.Margin = new Padding(2, 2, 2, 2);
            pendapatanBulan.Name = "pendapatanBulan";
            pendapatanBulan.RowHeadersWidth = 62;
            pendapatanBulan.RowTemplate.Height = 33;
            pendapatanBulan.Size = new Size(1082, 237);
            pendapatanBulan.TabIndex = 8;
            pendapatanBulan.CellContentClick += pendapatanBulan_CellContentClick;
            // 
            // pendapatanMinggu
            // 
            pendapatanMinggu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            pendapatanMinggu.BackgroundColor = Color.White;
            pendapatanMinggu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            pendapatanMinggu.Location = new Point(635, 86);
            pendapatanMinggu.Margin = new Padding(2, 2, 2, 2);
            pendapatanMinggu.Name = "pendapatanMinggu";
            pendapatanMinggu.RowHeadersWidth = 62;
            pendapatanMinggu.RowTemplate.Height = 33;
            pendapatanMinggu.Size = new Size(479, 226);
            pendapatanMinggu.TabIndex = 7;
            pendapatanMinggu.CellContentClick += pendataanMinggu_CellContentClick;
            // 
            // pendapatanHari
            // 
            pendapatanHari.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            pendapatanHari.BackgroundColor = Color.White;
            pendapatanHari.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            pendapatanHari.Location = new Point(33, 86);
            pendapatanHari.Margin = new Padding(2, 2, 2, 2);
            pendapatanHari.Name = "pendapatanHari";
            pendapatanHari.RowHeadersWidth = 62;
            pendapatanHari.RowTemplate.Height = 33;
            pendapatanHari.Size = new Size(479, 226);
            pendapatanHari.TabIndex = 6;
            // 
            // button5
            // 
            button5.ForeColor = Color.Black;
            button5.Location = new Point(994, 372);
            button5.Name = "button5";
            button5.Size = new Size(125, 29);
            button5.TabIndex = 41;
            button5.Text = "Cari";
            button5.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(38, 372);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(929, 27);
            textBox3.TabIndex = 40;
            // 
            // searchDataharian
            // 
            searchDataharian.ForeColor = Color.Black;
            searchDataharian.Location = new Point(254, 56);
            searchDataharian.Name = "searchDataharian";
            searchDataharian.Size = new Size(94, 29);
            searchDataharian.TabIndex = 39;
            searchDataharian.Text = "Cari";
            searchDataharian.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(659, 56);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(359, 27);
            textBox2.TabIndex = 38;
            // 
            // button2
            // 
            button2.ForeColor = Color.Black;
            button2.Location = new Point(354, 54);
            button2.Name = "button2";
            button2.Size = new Size(75, 29);
            button2.TabIndex = 37;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.ForeColor = Color.Black;
            button1.Location = new Point(1043, 53);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 36;
            button1.Text = "Cari";
            button1.UseVisualStyleBackColor = true;
            // 
            // tb_pendataanHari
            // 
            tb_pendataanHari.Location = new Point(56, 54);
            tb_pendataanHari.Name = "tb_pendataanHari";
            tb_pendataanHari.Size = new Size(185, 27);
            tb_pendataanHari.TabIndex = 35;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(519, 330);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(107, 24);
            label3.TabIndex = 34;
            label3.Text = "BULAN INI";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(659, 18);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(122, 24);
            label2.TabIndex = 33;
            label2.Text = "MINGGU INI";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(56, 18);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(86, 24);
            label1.TabIndex = 32;
            label1.Text = "HARI INI";
            // 
            // pendapatan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1149, 682);
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
            Margin = new Padding(2, 2, 2, 2);
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