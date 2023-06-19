namespace J_Explore.Properties
{
    partial class Riwayat
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
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            dataGridViewRiwayat = new DataGridView();
            ColumnId = new DataGridViewTextBoxColumn();
            ColumnAdmin = new DataGridViewTextBoxColumn();
            ColumnTanggal = new DataGridViewTextBoxColumn();
            ColumnAnakAnak = new DataGridViewTextBoxColumn();
            ColumnDewasa = new DataGridViewTextBoxColumn();
            ColumnTotal = new DataGridViewTextBoxColumn();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRiwayat).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(36, 35);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(376, 34);
            textBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(420, 35);
            button1.Name = "button1";
            button1.Size = new Size(100, 34);
            button1.TabIndex = 1;
            button1.Text = "Cari";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(887, 35);
            button2.Name = "button2";
            button2.Size = new Size(100, 34);
            button2.TabIndex = 2;
            button2.Text = "Export Excel";
            button2.UseVisualStyleBackColor = true;
            button2.Click += OnButtonExportExcelClick;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.Black;
            button3.Location = new Point(781, 35);
            button3.Name = "button3";
            button3.Size = new Size(100, 34);
            button3.TabIndex = 3;
            button3.Text = "Export PDF";
            button3.UseVisualStyleBackColor = true;
            button3.Click += OnButtonExportPdfClick;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = Color.Black;
            button4.Location = new Point(675, 35);
            button4.Name = "button4";
            button4.Size = new Size(100, 34);
            button4.TabIndex = 4;
            button4.Text = "Cetak";
            button4.UseVisualStyleBackColor = true;
            // 
            // dataGridViewRiwayat
            // 
            dataGridViewRiwayat.AllowUserToAddRows = false;
            dataGridViewRiwayat.AllowUserToDeleteRows = false;
            dataGridViewRiwayat.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewRiwayat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewRiwayat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRiwayat.Columns.AddRange(new DataGridViewColumn[] { ColumnId, ColumnAdmin, ColumnTanggal, ColumnAnakAnak, ColumnDewasa, ColumnTotal });
            dataGridViewRiwayat.Location = new Point(36, 94);
            dataGridViewRiwayat.Name = "dataGridViewRiwayat";
            dataGridViewRiwayat.ReadOnly = true;
            dataGridViewRiwayat.RowHeadersWidth = 51;
            dataGridViewRiwayat.RowTemplate.Height = 25;
            dataGridViewRiwayat.Size = new Size(951, 430);
            dataGridViewRiwayat.TabIndex = 5;
            // 
            // ColumnId
            // 
            ColumnId.HeaderText = "Id";
            ColumnId.MinimumWidth = 6;
            ColumnId.Name = "ColumnId";
            ColumnId.ReadOnly = true;
            // 
            // ColumnAdmin
            // 
            ColumnAdmin.HeaderText = "Admin";
            ColumnAdmin.MinimumWidth = 6;
            ColumnAdmin.Name = "ColumnAdmin";
            ColumnAdmin.ReadOnly = true;
            // 
            // ColumnTanggal
            // 
            ColumnTanggal.HeaderText = "Tanggal";
            ColumnTanggal.MinimumWidth = 6;
            ColumnTanggal.Name = "ColumnTanggal";
            ColumnTanggal.ReadOnly = true;
            // 
            // ColumnAnakAnak
            // 
            ColumnAnakAnak.HeaderText = "Anak-Anak";
            ColumnAnakAnak.MinimumWidth = 6;
            ColumnAnakAnak.Name = "ColumnAnakAnak";
            ColumnAnakAnak.ReadOnly = true;
            // 
            // ColumnDewasa
            // 
            ColumnDewasa.HeaderText = "Dewasa";
            ColumnDewasa.MinimumWidth = 6;
            ColumnDewasa.Name = "ColumnDewasa";
            ColumnDewasa.ReadOnly = true;
            // 
            // ColumnTotal
            // 
            ColumnTotal.HeaderText = "Total";
            ColumnTotal.MinimumWidth = 6;
            ColumnTotal.Name = "ColumnTotal";
            ColumnTotal.ReadOnly = true;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button5.ForeColor = Color.Black;
            button5.Location = new Point(526, 35);
            button5.Name = "button5";
            button5.Size = new Size(100, 34);
            button5.TabIndex = 6;
            button5.Text = "Delete";
            button5.UseVisualStyleBackColor = true;
            // 
            // Riwayat
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1018, 567);
            Controls.Add(button5);
            Controls.Add(dataGridViewRiwayat);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Name = "Riwayat";
            Text = "Riwayat";
            ((System.ComponentModel.ISupportInitialize)dataGridViewRiwayat).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private DataGridView dataGridViewRiwayat;
        private DataGridViewTextBoxColumn ColumnId;
        private DataGridViewTextBoxColumn ColumnAdmin;
        private DataGridViewTextBoxColumn ColumnTanggal;
        private DataGridViewTextBoxColumn ColumnAnakAnak;
        private DataGridViewTextBoxColumn ColumnDewasa;
        private DataGridViewTextBoxColumn ColumnTotal;
        private Button button5;
    }
}