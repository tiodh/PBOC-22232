namespace J_Explore
{
    partial class pendataan
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            pendataanBulan = new DataGridView();
            pendataanMinggu = new DataGridView();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tb_pendataanHari = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            textBox2 = new TextBox();
            searchDataharian = new Button();
            textBox3 = new TextBox();
            button5 = new Button();
            pendataanHari = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pendataanBulan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pendataanMinggu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pendataanHari).BeginInit();
            SuspendLayout();
            // 
            // pendataanBulan
            // 
            pendataanBulan.BackgroundColor = Color.White;
            pendataanBulan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            pendataanBulan.Location = new Point(55, 650);
            pendataanBulan.Name = "pendataanBulan";
            pendataanBulan.RowHeadersWidth = 62;
            pendataanBulan.RowTemplate.Height = 33;
            pendataanBulan.Size = new Size(1758, 310);
            pendataanBulan.TabIndex = 14;
            // 
            // pendataanMinggu
            // 
            pendataanMinggu.BackgroundColor = Color.White;
            pendataanMinggu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            pendataanMinggu.Location = new Point(1034, 155);
            pendataanMinggu.Name = "pendataanMinggu";
            pendataanMinggu.RowHeadersWidth = 62;
            pendataanMinggu.RowTemplate.Height = 33;
            pendataanMinggu.Size = new Size(778, 318);
            pendataanMinggu.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(838, 515);
            label3.Name = "label3";
            label3.Size = new Size(173, 37);
            label3.TabIndex = 23;
            label3.Text = "BULAN INI";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(1034, 14);
            label2.Name = "label2";
            label2.Size = new Size(193, 37);
            label2.TabIndex = 22;
            label2.Text = "MINGGU INI";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(55, 14);
            label1.Name = "label1";
            label1.Size = new Size(139, 37);
            label1.TabIndex = 21;
            label1.Text = "HARI INI";
            // 
            // tb_pendataanHari
            // 
            tb_pendataanHari.Location = new Point(55, 72);
            tb_pendataanHari.Margin = new Padding(5, 5, 5, 5);
            tb_pendataanHari.Name = "tb_pendataanHari";
            tb_pendataanHari.Size = new Size(298, 39);
            tb_pendataanHari.TabIndex = 24;
            // 
            // button1
            // 
            button1.ForeColor = Color.Black;
            button1.Location = new Point(1659, 70);
            button1.Margin = new Padding(5, 5, 5, 5);
            button1.Name = "button1";
            button1.Size = new Size(153, 46);
            button1.TabIndex = 25;
            button1.Text = "Cari";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.ForeColor = Color.Black;
            button2.Location = new Point(538, 72);
            button2.Margin = new Padding(5, 5, 5, 5);
            button2.Name = "button2";
            button2.Size = new Size(122, 46);
            button2.TabIndex = 26;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.ForeColor = Color.Black;
            button3.Location = new Point(684, 72);
            button3.Margin = new Padding(5, 5, 5, 5);
            button3.Name = "button3";
            button3.Size = new Size(136, 46);
            button3.TabIndex = 27;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(1034, 75);
            textBox2.Margin = new Padding(5, 5, 5, 5);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(582, 39);
            textBox2.TabIndex = 28;
            // 
            // searchDataharian
            // 
            searchDataharian.ForeColor = Color.Black;
            searchDataharian.Location = new Point(375, 75);
            searchDataharian.Margin = new Padding(5, 5, 5, 5);
            searchDataharian.Name = "searchDataharian";
            searchDataharian.Size = new Size(153, 46);
            searchDataharian.TabIndex = 29;
            searchDataharian.Text = "Cari";
            searchDataharian.UseVisualStyleBackColor = true;
            searchDataharian.Click += searchDataharian_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(55, 581);
            textBox3.Margin = new Padding(5, 5, 5, 5);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(1507, 39);
            textBox3.TabIndex = 30;
            // 
            // button5
            // 
            button5.ForeColor = Color.Black;
            button5.Location = new Point(1609, 581);
            button5.Margin = new Padding(5, 5, 5, 5);
            button5.Name = "button5";
            button5.Size = new Size(203, 46);
            button5.TabIndex = 31;
            button5.Text = "Cari";
            button5.UseVisualStyleBackColor = true;
            // 
            // pendataanHari
            // 
            pendataanHari.AllowUserToAddRows = false;
            pendataanHari.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            pendataanHari.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            pendataanHari.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            pendataanHari.BackgroundColor = Color.White;
            pendataanHari.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            pendataanHari.DefaultCellStyle = dataGridViewCellStyle2;
            pendataanHari.EnableHeadersVisualStyles = false;
            pendataanHari.GridColor = Color.Black;
            pendataanHari.Location = new Point(55, 171);
            pendataanHari.Margin = new Padding(5, 5, 5, 5);
            pendataanHari.Name = "pendataanHari";
            pendataanHari.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            pendataanHari.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            pendataanHari.RowHeadersVisible = false;
            pendataanHari.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.White;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            pendataanHari.RowsDefaultCellStyle = dataGridViewCellStyle4;
            pendataanHari.RowTemplate.Height = 29;
            pendataanHari.Size = new Size(765, 302);
            pendataanHari.TabIndex = 32;
            // 
            // pendataan
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1867, 1003);
            Controls.Add(pendataanHari);
            Controls.Add(button5);
            Controls.Add(textBox3);
            Controls.Add(searchDataharian);
            Controls.Add(textBox2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(tb_pendataanHari);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pendataanBulan);
            Controls.Add(pendataanMinggu);
            Name = "pendataan";
            Text = "PENDATAAN";
            Load += pendataan_Load;
            ((System.ComponentModel.ISupportInitialize)pendataanBulan).EndInit();
            ((System.ComponentModel.ISupportInitialize)pendataanMinggu).EndInit();
            ((System.ComponentModel.ISupportInitialize)pendataanHari).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView pendataanBulan;
        private DataGridView pendataanMinggu;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox tb_pendataanHari;
        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox textBox2;
        private Button searchDataharian;
        private TextBox textBox3;
        private Button button5;
        private DataGridView pendataanHari;
    }
}