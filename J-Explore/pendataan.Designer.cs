﻿namespace J_Explore
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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            pendataanBulan = new DataGridView();
            pendataanMinggu = new DataGridView();
            ColumnHari = new DataGridViewTextBoxColumn();
            ColumnJumlah = new DataGridViewTextBoxColumn();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tb_pendataanHari = new TextBox();
            button1 = new Button();
            button2 = new Button();
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
            pendataanBulan.ColumnHeadersHeight = 29;
            pendataanBulan.Location = new Point(34, 407);
            pendataanBulan.Margin = new Padding(2, 1, 2, 1);
            pendataanBulan.Name = "pendataanBulan";
            pendataanBulan.ReadOnly = true;
            pendataanBulan.RowHeadersWidth = 62;
            pendataanBulan.RowTemplate.Height = 33;
            pendataanBulan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            pendataanBulan.Size = new Size(1082, 193);
            pendataanBulan.TabIndex = 14;
            pendataanBulan.CellContentClick += pendataanBulan_CellContentClick;
            // 
            // pendataanMinggu
            // 
            pendataanMinggu.AllowUserToAddRows = false;
            pendataanMinggu.AllowUserToDeleteRows = false;
            pendataanMinggu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            pendataanMinggu.BackgroundColor = Color.White;
            pendataanMinggu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            pendataanMinggu.Columns.AddRange(new DataGridViewColumn[] { ColumnHari, ColumnJumlah });
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Window;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            pendataanMinggu.DefaultCellStyle = dataGridViewCellStyle7;
            pendataanMinggu.Location = new Point(637, 97);
            pendataanMinggu.Margin = new Padding(2, 1, 2, 1);
            pendataanMinggu.Name = "pendataanMinggu";
            pendataanMinggu.ReadOnly = true;
            pendataanMinggu.RowHeadersWidth = 62;
            dataGridViewCellStyle8.ForeColor = Color.Black;
            pendataanMinggu.RowsDefaultCellStyle = dataGridViewCellStyle8;
            pendataanMinggu.RowTemplate.Height = 33;
            pendataanMinggu.Size = new Size(479, 199);
            pendataanMinggu.TabIndex = 13;
            // 
            // ColumnHari
            // 
            ColumnHari.HeaderText = "Hari";
            ColumnHari.MinimumWidth = 6;
            ColumnHari.Name = "ColumnHari";
            ColumnHari.ReadOnly = true;
            // 
            // ColumnJumlah
            // 
            ColumnJumlah.HeaderText = "Jumlah";
            ColumnJumlah.MinimumWidth = 6;
            ColumnJumlah.Name = "ColumnJumlah";
            ColumnJumlah.ReadOnly = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(515, 321);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(107, 24);
            label3.TabIndex = 23;
            label3.Text = "BULAN INI";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(637, 9);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(122, 24);
            label2.TabIndex = 22;
            label2.Text = "MINGGU INI";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(34, 9);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(86, 24);
            label1.TabIndex = 21;
            label1.Text = "HARI INI";
            // 
            // tb_pendataanHari
            // 
            tb_pendataanHari.Location = new Point(34, 45);
            tb_pendataanHari.Name = "tb_pendataanHari";
            tb_pendataanHari.Size = new Size(185, 27);
            tb_pendataanHari.TabIndex = 24;
            // 
            // button1
            // 
            button1.ForeColor = Color.Black;
            button1.Location = new Point(1021, 44);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 25;
            button1.Text = "Cari";
            button1.UseVisualStyleBackColor = true;
            button1.Click += OnButtonMingguIniClick;
            // 
            // button2
            // 
            button2.ForeColor = Color.Black;
            button2.Location = new Point(331, 45);
            button2.Name = "button2";
            button2.Size = new Size(75, 29);
            button2.TabIndex = 26;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(637, 47);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(359, 27);
            textBox2.TabIndex = 28;
            // 
            // searchDataharian
            // 
            searchDataharian.ForeColor = Color.Black;
            searchDataharian.Location = new Point(231, 47);
            searchDataharian.Name = "searchDataharian";
            searchDataharian.Size = new Size(94, 29);
            searchDataharian.TabIndex = 29;
            searchDataharian.Text = "Cari";
            searchDataharian.UseVisualStyleBackColor = true;
            searchDataharian.Click += searchDataharian_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(34, 363);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(929, 27);
            textBox3.TabIndex = 30;
            // 
            // button5
            // 
            button5.ForeColor = Color.Black;
            button5.Location = new Point(990, 363);
            button5.Name = "button5";
            button5.Size = new Size(125, 29);
            button5.TabIndex = 31;
            button5.Text = "Cari";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // pendataanHari
            // 
            pendataanHari.AllowUserToAddRows = false;
            pendataanHari.AllowUserToDeleteRows = false;
            dataGridViewCellStyle9.BackColor = Color.White;
            dataGridViewCellStyle9.ForeColor = Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = Color.White;
            dataGridViewCellStyle9.SelectionForeColor = Color.Black;
            pendataanHari.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            pendataanHari.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            pendataanHari.BackgroundColor = Color.White;
            pendataanHari.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = Color.White;
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = Color.White;
            dataGridViewCellStyle10.SelectionForeColor = Color.Black;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.False;
            pendataanHari.DefaultCellStyle = dataGridViewCellStyle10;
            pendataanHari.EnableHeadersVisualStyles = false;
            pendataanHari.GridColor = Color.Black;
            pendataanHari.Location = new Point(34, 107);
            pendataanHari.Name = "pendataanHari";
            pendataanHari.ReadOnly = true;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = SystemColors.Control;
            dataGridViewCellStyle11.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle11.ForeColor = Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
            pendataanHari.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            pendataanHari.RowHeadersVisible = false;
            pendataanHari.RowHeadersWidth = 51;
            dataGridViewCellStyle12.BackColor = Color.White;
            dataGridViewCellStyle12.ForeColor = Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = Color.White;
            dataGridViewCellStyle12.SelectionForeColor = Color.Black;
            pendataanHari.RowsDefaultCellStyle = dataGridViewCellStyle12;
            pendataanHari.RowTemplate.Height = 29;
            pendataanHari.Size = new Size(471, 189);
            pendataanHari.TabIndex = 32;
            // 
            // pendataan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1189, 643);
            Controls.Add(pendataanHari);
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
            Controls.Add(pendataanBulan);
            Controls.Add(pendataanMinggu);
            Margin = new Padding(2, 1, 2, 1);
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
        private TextBox textBox2;
        private Button searchDataharian;
        private TextBox textBox3;
        private Button button5;
        private DataGridView pendataanHari;
        private DataGridViewTextBoxColumn ColumnHari;
        private DataGridViewTextBoxColumn ColumnJumlah;
    }
}