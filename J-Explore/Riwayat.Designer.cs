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
            ((System.ComponentModel.ISupportInitialize)dataGridViewRiwayat).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(41, 47);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(429, 41);
            textBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(497, 47);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(114, 45);
            button1.TabIndex = 1;
            button1.Text = "Cari";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(1014, 47);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(114, 45);
            button2.TabIndex = 2;
            button2.Text = "Export Excel";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.Black;
            button3.Location = new Point(893, 47);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(114, 45);
            button3.TabIndex = 3;
            button3.Text = "Export PDF";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = Color.Black;
            button4.Location = new Point(771, 47);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(114, 45);
            button4.TabIndex = 4;
            button4.Text = "Cetak";
            button4.UseVisualStyleBackColor = true;
            // 
            // dataGridViewRiwayat
            // 
            dataGridViewRiwayat.AllowUserToAddRows = false;
            dataGridViewRiwayat.AllowUserToDeleteRows = false;
            dataGridViewRiwayat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewRiwayat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRiwayat.Columns.AddRange(new DataGridViewColumn[] { ColumnId, ColumnAdmin, ColumnTanggal, ColumnAnakAnak, ColumnDewasa, ColumnTotal });
            dataGridViewRiwayat.Location = new Point(41, 125);
            dataGridViewRiwayat.Margin = new Padding(3, 4, 3, 4);
            dataGridViewRiwayat.Name = "dataGridViewRiwayat";
            dataGridViewRiwayat.RowHeadersWidth = 51;
            dataGridViewRiwayat.RowTemplate.Height = 25;
            dataGridViewRiwayat.Size = new Size(1087, 573);
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
            // Riwayat
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1163, 756);
            Controls.Add(dataGridViewRiwayat);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Margin = new Padding(3, 4, 3, 4);
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
    }
}