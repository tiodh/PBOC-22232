﻿namespace J_Explore.Fitur
{
    partial class Kuliner
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
            textBox1 = new TextBox();
            button1 = new Button();
            dataGridViewKuliner = new DataGridView();
            ColumnId = new DataGridViewTextBoxColumn();
            ColumnNamaTempat = new DataGridViewTextBoxColumn();
            ColumnNamaMakanan = new DataGridViewTextBoxColumn();
            ColumnHarga = new DataGridViewTextBoxColumn();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            textBoxNamaTempat = new TextBox();
            labelNamaTempat = new Label();
            labelNamaMakanan = new Label();
            textBoxNamaMakanan = new TextBox();
            labelHarga = new Label();
            textBoxHarga = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewKuliner).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(14, 36);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(203, 34);
            textBox1.TabIndex = 0;
            textBox1.Text = "  Cari";
            // 
            // button1
            // 
            button1.Location = new Point(247, 36);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 34);
            button1.TabIndex = 1;
            button1.Text = "Cari";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridViewKuliner
            // 
            dataGridViewKuliner.AllowUserToOrderColumns = true;
            dataGridViewKuliner.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewKuliner.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewKuliner.Columns.AddRange(new DataGridViewColumn[] { ColumnId, ColumnNamaTempat, ColumnNamaMakanan, ColumnHarga });
            dataGridViewKuliner.Location = new Point(14, 100);
            dataGridViewKuliner.Margin = new Padding(3, 4, 3, 4);
            dataGridViewKuliner.Name = "dataGridViewKuliner";
            dataGridViewKuliner.RowHeadersWidth = 62;
            dataGridViewKuliner.RowTemplate.Height = 25;
            dataGridViewKuliner.Size = new Size(646, 358);
            dataGridViewKuliner.TabIndex = 2;
            // 
            // ColumnId
            // 
            ColumnId.HeaderText = "Id";
            ColumnId.MinimumWidth = 6;
            ColumnId.Name = "ColumnId";
            // 
            // ColumnNamaTempat
            // 
            ColumnNamaTempat.HeaderText = "Nama Tempat";
            ColumnNamaTempat.MinimumWidth = 6;
            ColumnNamaTempat.Name = "ColumnNamaTempat";
            // 
            // ColumnNamaMakanan
            // 
            ColumnNamaMakanan.HeaderText = "Nama Makanan";
            ColumnNamaMakanan.MinimumWidth = 6;
            ColumnNamaMakanan.Name = "ColumnNamaMakanan";
            // 
            // ColumnHarga
            // 
            ColumnHarga.HeaderText = "Harga";
            ColumnHarga.MinimumWidth = 6;
            ColumnHarga.Name = "ColumnHarga";
            // 
            // button2
            // 
            button2.Location = new Point(577, 625);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(86, 34);
            button2.TabIndex = 3;
            button2.Text = "Create";
            button2.UseVisualStyleBackColor = true;
            button2.Click += OnButtonCreateClick;
            // 
            // button3
            // 
            button3.Location = new Point(474, 36);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(86, 34);
            button3.TabIndex = 4;
            button3.Text = "Update";
            button3.UseVisualStyleBackColor = true;
            button3.Click += buttonUpdate_Click;
            // 
            // button4
            // 
            button4.Location = new Point(566, 36);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(86, 34);
            button4.TabIndex = 5;
            button4.Text = "Delete";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // textBoxNamaTempat
            // 
            textBoxNamaTempat.Location = new Point(486, 485);
            textBoxNamaTempat.Name = "textBoxNamaTempat";
            textBoxNamaTempat.Size = new Size(174, 27);
            textBoxNamaTempat.TabIndex = 6;
            // 
            // labelNamaTempat
            // 
            labelNamaTempat.AutoSize = true;
            labelNamaTempat.Location = new Point(486, 462);
            labelNamaTempat.Name = "labelNamaTempat";
            labelNamaTempat.Size = new Size(103, 20);
            labelNamaTempat.TabIndex = 7;
            labelNamaTempat.Text = "Nama Tempat";
            // 
            // labelNamaMakanan
            // 
            labelNamaMakanan.AutoSize = true;
            labelNamaMakanan.Location = new Point(486, 515);
            labelNamaMakanan.Name = "labelNamaMakanan";
            labelNamaMakanan.Size = new Size(113, 20);
            labelNamaMakanan.TabIndex = 8;
            labelNamaMakanan.Text = "Nama Makanan";
            // 
            // textBoxNamaMakanan
            // 
            textBoxNamaMakanan.Location = new Point(486, 538);
            textBoxNamaMakanan.Name = "textBoxNamaMakanan";
            textBoxNamaMakanan.Size = new Size(174, 27);
            textBoxNamaMakanan.TabIndex = 9;
            // 
            // labelHarga
            // 
            labelHarga.AutoSize = true;
            labelHarga.Location = new Point(486, 568);
            labelHarga.Name = "labelHarga";
            labelHarga.Size = new Size(50, 20);
            labelHarga.TabIndex = 10;
            labelHarga.Text = "Harga";
            // 
            // textBoxHarga
            // 
            textBoxHarga.Location = new Point(486, 591);
            textBoxHarga.Name = "textBoxHarga";
            textBoxHarga.Size = new Size(174, 27);
            textBoxHarga.TabIndex = 11;
            // 
            // Kuliner
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(675, 673);
            Controls.Add(textBoxHarga);
            Controls.Add(labelHarga);
            Controls.Add(textBoxNamaMakanan);
            Controls.Add(labelNamaMakanan);
            Controls.Add(labelNamaTempat);
            Controls.Add(textBoxNamaTempat);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(dataGridViewKuliner);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Margin = new Padding(2);
            Name = "Kuliner";
            Text = "Kuliner";
            Load += Kuliner_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewKuliner).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button button1;
        private DataGridView dataGridViewKuliner;
        private Button button2;
        private Button button3;
        private Button button4;
        private DataGridViewTextBoxColumn ColumnId;
        private DataGridViewTextBoxColumn ColumnNamaTempat;
        private DataGridViewTextBoxColumn ColumnNamaMakanan;
        private DataGridViewTextBoxColumn ColumnHarga;
        private TextBox textBoxNamaTempat;
        private Label labelNamaTempat;
        private Label labelNamaMakanan;
        private TextBox textBoxNamaMakanan;
        private Label labelHarga;
        private TextBox textBoxHarga;
    }
}