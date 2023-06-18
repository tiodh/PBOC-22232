namespace Tugas_Akhir_Pbo_C.UserControls
{
    partial class Contact_Darurat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Contact_Darurat));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.nama_layanan_darurat = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.email_layanan_darurat = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.no_telp = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.deskripsi_layanan_darurat = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonCheckButton2 = new ComponentFactory.Krypton.Toolkit.KryptonCheckButton();
            this.kryptonCheckButton1 = new ComponentFactory.Krypton.Toolkit.KryptonCheckButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(9, 5);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(57, 12);
            this.kryptonLabel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(79, 26);
            this.kryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 3;
            this.kryptonLabel1.Values.Text = "Contact";
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.pictureBox2);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(1117, 51);
            this.kryptonPanel1.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.kryptonPanel1.StateCommon.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.kryptonPanel1.TabIndex = 7;
            // 
            // nama_layanan_darurat
            // 
            this.nama_layanan_darurat.Location = new System.Drawing.Point(23, 109);
            this.nama_layanan_darurat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nama_layanan_darurat.Name = "nama_layanan_darurat";
            this.nama_layanan_darurat.Size = new System.Drawing.Size(385, 38);
            this.nama_layanan_darurat.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10);
            this.nama_layanan_darurat.TabIndex = 30;
            this.nama_layanan_darurat.Text = "Nama";
            this.nama_layanan_darurat.TextChanged += new System.EventHandler(this.nama_layanan_darurat_TextChanged);
            // 
            // email_layanan_darurat
            // 
            this.email_layanan_darurat.Location = new System.Drawing.Point(23, 253);
            this.email_layanan_darurat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.email_layanan_darurat.Name = "email_layanan_darurat";
            this.email_layanan_darurat.Size = new System.Drawing.Size(385, 38);
            this.email_layanan_darurat.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10);
            this.email_layanan_darurat.TabIndex = 29;
            this.email_layanan_darurat.Text = "Email";
            // 
            // no_telp
            // 
            this.no_telp.Location = new System.Drawing.Point(23, 181);
            this.no_telp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.no_telp.Name = "no_telp";
            this.no_telp.Size = new System.Drawing.Size(385, 38);
            this.no_telp.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10);
            this.no_telp.TabIndex = 28;
            this.no_telp.Text = "No.telp";
            // 
            // deskripsi_layanan_darurat
            // 
            this.deskripsi_layanan_darurat.Location = new System.Drawing.Point(23, 330);
            this.deskripsi_layanan_darurat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.deskripsi_layanan_darurat.Name = "deskripsi_layanan_darurat";
            this.deskripsi_layanan_darurat.Size = new System.Drawing.Size(385, 38);
            this.deskripsi_layanan_darurat.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10);
            this.deskripsi_layanan_darurat.TabIndex = 31;
            this.deskripsi_layanan_darurat.Text = "Deskripsi";
            // 
            // kryptonCheckButton2
            // 
            this.kryptonCheckButton2.Location = new System.Drawing.Point(250, 435);
            this.kryptonCheckButton2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.kryptonCheckButton2.Name = "kryptonCheckButton2";
            this.kryptonCheckButton2.Size = new System.Drawing.Size(203, 42);
            this.kryptonCheckButton2.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.kryptonCheckButton2.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.kryptonCheckButton2.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonCheckButton2.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.kryptonCheckButton2.TabIndex = 33;
            this.kryptonCheckButton2.Values.Text = "Update";
            // 
            // kryptonCheckButton1
            // 
            this.kryptonCheckButton1.Location = new System.Drawing.Point(23, 435);
            this.kryptonCheckButton1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.kryptonCheckButton1.Name = "kryptonCheckButton1";
            this.kryptonCheckButton1.Size = new System.Drawing.Size(203, 42);
            this.kryptonCheckButton1.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.kryptonCheckButton1.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.kryptonCheckButton1.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonCheckButton1.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.kryptonCheckButton1.TabIndex = 32;
            this.kryptonCheckButton1.Values.Text = "Simpan";
            this.kryptonCheckButton1.Click += new System.EventHandler(this.kryptonCheckButton1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 88);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 34;
            this.label3.Text = "Nama";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 160);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 35;
            this.label1.Text = "No.telp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 232);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 36;
            this.label2.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 309);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 37;
            this.label4.Text = "Deskripsi";
            // 
            // Contact_Darurat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.kryptonCheckButton2);
            this.Controls.Add(this.kryptonCheckButton1);
            this.Controls.Add(this.deskripsi_layanan_darurat);
            this.Controls.Add(this.nama_layanan_darurat);
            this.Controls.Add(this.email_layanan_darurat);
            this.Controls.Add(this.no_telp);
            this.Controls.Add(this.kryptonPanel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Contact_Darurat";
            this.Size = new System.Drawing.Size(1054, 619);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox nama_layanan_darurat;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox email_layanan_darurat;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox no_telp;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox deskripsi_layanan_darurat;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckButton kryptonCheckButton2;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckButton kryptonCheckButton1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}
