namespace Tugas_Akhir_Pbo_C.UserControls
{
    partial class Riwayat_Admin
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Riwayat_Admin));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonCheckButton2 = new ComponentFactory.Krypton.Toolkit.KryptonCheckButton();
            this.kryptonCheckButton1 = new ComponentFactory.Krypton.Toolkit.KryptonCheckButton();
            this.kryptonDataGridView1 = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Asal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jenis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tanggal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jenis_Kelamin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jumlah_Transaksi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nominal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.Username_Login = new ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(13, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(54, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(85, 18);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(129, 40);
            this.kryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Swis721 Hv BT", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 3;
            this.kryptonLabel1.Values.Text = "Riwayat";
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.pictureBox2);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(1676, 78);
            this.kryptonPanel1.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.kryptonPanel1.StateCommon.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.kryptonPanel1.TabIndex = 5;
            // 
            // kryptonCheckButton2
            // 
            this.kryptonCheckButton2.Location = new System.Drawing.Point(1260, 122);
            this.kryptonCheckButton2.Name = "kryptonCheckButton2";
            this.kryptonCheckButton2.Size = new System.Drawing.Size(304, 47);
            this.kryptonCheckButton2.StateCheckedNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonCheckButton2.StateCheckedNormal.Border.Rounding = 30;
            this.kryptonCheckButton2.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.kryptonCheckButton2.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.kryptonCheckButton2.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonCheckButton2.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.kryptonCheckButton2.TabIndex = 27;
            this.kryptonCheckButton2.Values.Text = "Hapus";
            // 
            // kryptonCheckButton1
            // 
            this.kryptonCheckButton1.Location = new System.Drawing.Point(950, 122);
            this.kryptonCheckButton1.Name = "kryptonCheckButton1";
            this.kryptonCheckButton1.Size = new System.Drawing.Size(304, 47);
            this.kryptonCheckButton1.StateCheckedNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonCheckButton1.StateCheckedNormal.Border.Rounding = 30;
            this.kryptonCheckButton1.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.kryptonCheckButton1.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.kryptonCheckButton1.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonCheckButton1.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.kryptonCheckButton1.TabIndex = 26;
            this.kryptonCheckButton1.Values.Text = "Cetak";
            // 
            // kryptonDataGridView1
            // 
            this.kryptonDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.kryptonDataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.kryptonDataGridView1.ColumnHeadersHeight = 34;
            this.kryptonDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nama,
            this.Asal,
            this.Jenis,
            this.Tanggal,
            this.Jenis_Kelamin,
            this.Jumlah_Transaksi,
            this.Nominal});
            this.kryptonDataGridView1.HideOuterBorders = true;
            this.kryptonDataGridView1.Location = new System.Drawing.Point(13, 202);
            this.kryptonDataGridView1.Name = "kryptonDataGridView1";
            this.kryptonDataGridView1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.kryptonDataGridView1.RowHeadersWidth = 62;
            this.kryptonDataGridView1.RowTemplate.Height = 28;
            this.kryptonDataGridView1.Size = new System.Drawing.Size(1551, 732);
            this.kryptonDataGridView1.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.kryptonDataGridView1.StateCommon.DataCell.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonDataGridView1.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.kryptonDataGridView1.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.kryptonDataGridView1.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.White;
            this.kryptonDataGridView1.TabIndex = 28;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 8;
            this.ID.Name = "ID";
            // 
            // Nama
            // 
            this.Nama.HeaderText = "Nama";
            this.Nama.MinimumWidth = 8;
            this.Nama.Name = "Nama";
            // 
            // Asal
            // 
            this.Asal.HeaderText = "Asal";
            this.Asal.MinimumWidth = 8;
            this.Asal.Name = "Asal";
            // 
            // Jenis
            // 
            this.Jenis.HeaderText = "Jenis";
            this.Jenis.MinimumWidth = 8;
            this.Jenis.Name = "Jenis";
            // 
            // Tanggal
            // 
            this.Tanggal.HeaderText = "Tanggal";
            this.Tanggal.MinimumWidth = 8;
            this.Tanggal.Name = "Tanggal";
            // 
            // Jenis_Kelamin
            // 
            this.Jenis_Kelamin.HeaderText = "Jenis Kelamin";
            this.Jenis_Kelamin.MinimumWidth = 8;
            this.Jenis_Kelamin.Name = "Jenis_Kelamin";
            // 
            // Jumlah_Transaksi
            // 
            this.Jumlah_Transaksi.HeaderText = "Jumlah Transaksi";
            this.Jumlah_Transaksi.MinimumWidth = 8;
            this.Jumlah_Transaksi.Name = "Jumlah_Transaksi";
            // 
            // Nominal
            // 
            this.Nominal.HeaderText = "Nominal";
            this.Nominal.MinimumWidth = 8;
            this.Nominal.Name = "Nominal";
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Location = new System.Drawing.Point(459, 122);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Size = new System.Drawing.Size(175, 47);
            this.kryptonButton1.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.kryptonButton1.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.kryptonButton1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.StateCommon.Border.Rounding = 20;
            this.kryptonButton1.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButton1.TabIndex = 53;
            this.kryptonButton1.Values.Text = "Cari";
            // 
            // Username_Login
            // 
            this.Username_Login.Location = new System.Drawing.Point(13, 122);
            this.Username_Login.Name = "Username_Login";
            this.Username_Login.Size = new System.Drawing.Size(428, 47);
            this.Username_Login.StateCommon.Border.Color1 = System.Drawing.Color.DimGray;
            this.Username_Login.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Username_Login.StateCommon.Border.Rounding = 30;
            this.Username_Login.StateCommon.Content.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username_Login.StateCommon.Content.Padding = new System.Windows.Forms.Padding(0);
            this.Username_Login.TabIndex = 52;
            this.Username_Login.Text = "Cari";
            this.Username_Login.UseWaitCursor = true;
            // 
            // Riwayat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.kryptonButton1);
            this.Controls.Add(this.Username_Login);
            this.Controls.Add(this.kryptonCheckButton2);
            this.Controls.Add(this.kryptonCheckButton1);
            this.Controls.Add(this.kryptonPanel1);
            this.Controls.Add(this.kryptonDataGridView1);
            this.Name = "Riwayat";
            this.Size = new System.Drawing.Size(1581, 952);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckButton kryptonCheckButton2;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckButton kryptonCheckButton1;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView kryptonDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nama;
        private System.Windows.Forms.DataGridViewTextBoxColumn Asal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jenis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tanggal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jenis_Kelamin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jumlah_Transaksi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nominal;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
        private ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox Username_Login;
    }
}
