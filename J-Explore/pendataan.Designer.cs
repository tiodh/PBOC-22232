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
            pendataanBulan.AllowUserToAddRows = false;
            pendataanBulan.AllowUserToDeleteRows = false;
            pendataanBulan.AllowUserToOrderColumns = true;
            pendataanBulan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            pendataanBulan.BackgroundColor = Color.White;
            pendataanBulan.Location = new Point(30, 305);
            pendataanBulan.Margin = new Padding(2, 1, 2, 1);
            pendataanBulan.Name = "pendataanBulan";
            pendataanBulan.ReadOnly = true;
            pendataanBulan.RowHeadersWidth = 62;
            pendataanBulan.RowTemplate.Height = 33;
            pendataanBulan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            pendataanBulan.Size = new Size(947, 145);
            pendataanBulan.TabIndex = 14;
            pendataanBulan.CellContentClick += pendataanBulan_CellContentClick;
            // 
            // pendataanMinggu
            // 
            pendataanMinggu.BackgroundColor = Color.White;
            pendataanMinggu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            pendataanMinggu.Location = new Point(557, 73);
            pendataanMinggu.Margin = new Padding(2, 1, 2, 1);
            pendataanMinggu.Name = "pendataanMinggu";
            pendataanMinggu.RowHeadersWidth = 62;
            pendataanMinggu.RowTemplate.Height = 33;
            pendataanMinggu.Size = new Size(419, 149);
            pendataanMinggu.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(451, 241);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(90, 19);
            label3.TabIndex = 23;
            label3.Text = "BULAN INI";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(557, 7);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(98, 19);
            label2.TabIndex = 22;
            label2.Text = "MINGGU INI";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(30, 7);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(72, 19);
            label1.TabIndex = 21;
            label1.Text = "HARI INI";
            // 
            // tb_pendataanHari
            // 
            tb_pendataanHari.Location = new Point(30, 34);
            tb_pendataanHari.Margin = new Padding(3, 2, 3, 2);
            tb_pendataanHari.Name = "tb_pendataanHari";
            tb_pendataanHari.Size = new Size(162, 23);
            tb_pendataanHari.TabIndex = 24;
            // 
            // button1
            // 
            button1.ForeColor = Color.Black;
            button1.Location = new Point(893, 33);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 22);
            button1.TabIndex = 25;
            button1.Text = "Cari";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.ForeColor = Color.Black;
            button2.Location = new Point(290, 34);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(66, 22);
            button2.TabIndex = 26;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.ForeColor = Color.Black;
            button3.Location = new Point(368, 34);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(73, 22);
            button3.TabIndex = 27;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(557, 35);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(315, 23);
            textBox2.TabIndex = 28;
            // 
            // searchDataharian
            // 
            searchDataharian.ForeColor = Color.Black;
            searchDataharian.Location = new Point(202, 35);
            searchDataharian.Margin = new Padding(3, 2, 3, 2);
            searchDataharian.Name = "searchDataharian";
            searchDataharian.Size = new Size(82, 22);
            searchDataharian.TabIndex = 29;
            searchDataharian.Text = "Cari";
            searchDataharian.UseVisualStyleBackColor = true;
            searchDataharian.Click += searchDataharian_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(30, 272);
            textBox3.Margin = new Padding(3, 2, 3, 2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(813, 23);
            textBox3.TabIndex = 30;
            // 
            // button5
            // 
            button5.ForeColor = Color.Black;
            button5.Location = new Point(866, 272);
            button5.Margin = new Padding(3, 2, 3, 2);
            button5.Name = "button5";
            button5.Size = new Size(109, 22);
            button5.TabIndex = 31;
            button5.Text = "Cari";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
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
            pendataanHari.Location = new Point(30, 80);
            pendataanHari.Margin = new Padding(3, 2, 3, 2);
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
            pendataanHari.Size = new Size(412, 142);
            pendataanHari.TabIndex = 32;
            // 
            // pendataan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1040, 482);
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
            Margin = new Padding(2, 1, 2, 1);
            Name = "pendataan";
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