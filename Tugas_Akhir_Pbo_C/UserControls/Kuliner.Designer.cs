namespace Tugas_Akhir_Pbo_C.UserControls
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kuliner));
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonDataGridView1 = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.Nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Asal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jenis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tanggal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jenis_Kelamin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username_Login = new ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.pictureBox2);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(1490, 62);
            this.kryptonPanel1.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.kryptonPanel1.StateCommon.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.kryptonPanel1.TabIndex = 47;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 6);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(76, 14);
            this.kryptonLabel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(101, 33);
            this.kryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Swis721 Hv BT", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 3;
            this.kryptonLabel1.Values.Text = "Kuliner";
            // 
            // kryptonDataGridView1
            // 
            this.kryptonDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.kryptonDataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.kryptonDataGridView1.ColumnHeadersHeight = 34;
            this.kryptonDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nama,
            this.Asal,
            this.Jenis,
            this.Tanggal,
            this.Jenis_Kelamin});
            this.kryptonDataGridView1.HideOuterBorders = true;
            this.kryptonDataGridView1.Location = new System.Drawing.Point(12, 163);
            this.kryptonDataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kryptonDataGridView1.Name = "kryptonDataGridView1";
            this.kryptonDataGridView1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.kryptonDataGridView1.RowHeadersWidth = 62;
            this.kryptonDataGridView1.RowTemplate.Height = 28;
            this.kryptonDataGridView1.Size = new System.Drawing.Size(1369, 586);
            this.kryptonDataGridView1.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.kryptonDataGridView1.StateCommon.DataCell.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonDataGridView1.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.kryptonDataGridView1.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.kryptonDataGridView1.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.White;
            this.kryptonDataGridView1.TabIndex = 48;
            // 
            // Nama
            // 
            this.Nama.HeaderText = "Nama Tempat";
            this.Nama.MinimumWidth = 8;
            this.Nama.Name = "Nama";
            // 
            // Asal
            // 
            this.Asal.HeaderText = "Jenis makanan";
            this.Asal.MinimumWidth = 8;
            this.Asal.Name = "Asal";
            // 
            // Jenis
            // 
            this.Jenis.HeaderText = "Nama makanan";
            this.Jenis.MinimumWidth = 8;
            this.Jenis.Name = "Jenis";
            // 
            // Tanggal
            // 
            this.Tanggal.HeaderText = "Harga";
            this.Tanggal.MinimumWidth = 8;
            this.Tanggal.Name = "Tanggal";
            // 
            // Jenis_Kelamin
            // 
            this.Jenis_Kelamin.HeaderText = "Foto";
            this.Jenis_Kelamin.MinimumWidth = 8;
            this.Jenis_Kelamin.Name = "Jenis_Kelamin";
            // 
            // Username_Login
            // 
            this.Username_Login.Location = new System.Drawing.Point(12, 97);
            this.Username_Login.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Username_Login.Name = "Username_Login";
            this.Username_Login.Size = new System.Drawing.Size(380, 42);
            this.Username_Login.StateCommon.Border.Color1 = System.Drawing.Color.DimGray;
            this.Username_Login.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Username_Login.StateCommon.Border.Rounding = 30;
            this.Username_Login.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username_Login.StateCommon.Content.Padding = new System.Windows.Forms.Padding(0);
            this.Username_Login.TabIndex = 50;
            this.Username_Login.Text = "Cari";
            this.Username_Login.UseWaitCursor = true;
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Location = new System.Drawing.Point(408, 97);
            this.kryptonButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Size = new System.Drawing.Size(156, 38);
            this.kryptonButton1.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.kryptonButton1.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.kryptonButton1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.StateCommon.Border.Rounding = 20;
            this.kryptonButton1.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButton1.TabIndex = 51;
            this.kryptonButton1.Values.Text = "Cari";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(586, 97);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(105, 42);
            this.btnDelete.TabIndex = 52;
            this.btnDelete.Text = "Hapus";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Kuliner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.kryptonButton1);
            this.Controls.Add(this.Username_Login);
            this.Controls.Add(this.kryptonDataGridView1);
            this.Controls.Add(this.kryptonPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Kuliner";
            this.Size = new System.Drawing.Size(1405, 762);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView kryptonDataGridView1;
        private ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox Username_Login;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nama;
        private System.Windows.Forms.DataGridViewTextBoxColumn Asal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jenis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tanggal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jenis_Kelamin;
        private System.Windows.Forms.Button btnDelete;
    }
}
