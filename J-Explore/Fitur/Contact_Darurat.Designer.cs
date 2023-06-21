namespace J_Explore.Fitur
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            DataKontakDarurat = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            phone = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            deskripsi = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            buttonTambah = new Button();
            textBoxDeskripsi = new TextBox();
            labelDeskripsi = new Label();
            textBoxEmail = new TextBox();
            labelEmail = new Label();
            textBoxNoHp = new TextBox();
            labelNoHp = new Label();
            textBoxNama = new TextBox();
            labelNama = new Label();
            UpdateButton = new Button();
            HapusButton = new Button();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataKontakDarurat).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(26, 22, 26, 22);
            panel1.Size = new Size(1094, 562);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80.5882339F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.4117641F));
            tableLayoutPanel1.Controls.Add(DataKontakDarurat, 0, 0);
            tableLayoutPanel1.Controls.Add(panel2, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(26, 22);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1042, 518);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // DataKontakDarurat
            // 
            DataKontakDarurat.AllowUserToAddRows = false;
            DataKontakDarurat.AllowUserToDeleteRows = false;
            DataKontakDarurat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataKontakDarurat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataKontakDarurat.Columns.AddRange(new DataGridViewColumn[] { id, name, phone, email, deskripsi });
            DataKontakDarurat.Dock = DockStyle.Fill;
            DataKontakDarurat.Location = new Point(3, 2);
            DataKontakDarurat.Margin = new Padding(3, 2, 3, 2);
            DataKontakDarurat.Name = "DataKontakDarurat";
            DataKontakDarurat.RowHeadersWidth = 51;
            DataKontakDarurat.Size = new Size(833, 514);
            DataKontakDarurat.TabIndex = 4;
            // 
            // id
            // 
            id.HeaderText = "ID";
            id.MinimumWidth = 6;
            id.Name = "id";
            // 
            // name
            // 
            name.HeaderText = "NAMA";
            name.MinimumWidth = 6;
            name.Name = "name";
            // 
            // phone
            // 
            phone.HeaderText = "NO HP";
            phone.MinimumWidth = 6;
            phone.Name = "phone";
            // 
            // email
            // 
            email.HeaderText = "EMAIL";
            email.MinimumWidth = 6;
            email.Name = "email";
            // 
            // deskripsi
            // 
            deskripsi.HeaderText = "DESKRIPSI";
            deskripsi.MinimumWidth = 6;
            deskripsi.Name = "deskripsi";
            // 
            // panel2
            // 
            panel2.Controls.Add(buttonTambah);
            panel2.Controls.Add(textBoxDeskripsi);
            panel2.Controls.Add(labelDeskripsi);
            panel2.Controls.Add(textBoxEmail);
            panel2.Controls.Add(labelEmail);
            panel2.Controls.Add(textBoxNoHp);
            panel2.Controls.Add(labelNoHp);
            panel2.Controls.Add(textBoxNama);
            panel2.Controls.Add(labelNama);
            panel2.Controls.Add(UpdateButton);
            panel2.Controls.Add(HapusButton);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(842, 2);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(197, 514);
            panel2.TabIndex = 5;
            // 
            // buttonTambah
            // 
            buttonTambah.BackColor = Color.FromArgb(128, 255, 128);
            buttonTambah.Dock = DockStyle.Top;
            buttonTambah.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonTambah.ForeColor = Color.Black;
            buttonTambah.Location = new Point(0, 218);
            buttonTambah.Margin = new Padding(3, 2, 3, 2);
            buttonTambah.Name = "buttonTambah";
            buttonTambah.Size = new Size(197, 33);
            buttonTambah.TabIndex = 13;
            buttonTambah.Text = "TAMBAH";
            buttonTambah.UseVisualStyleBackColor = false;
            buttonTambah.Click += OnButtonTambahClick;
            // 
            // textBoxDeskripsi
            // 
            textBoxDeskripsi.Dock = DockStyle.Top;
            textBoxDeskripsi.Location = new Point(0, 195);
            textBoxDeskripsi.Margin = new Padding(3, 2, 3, 2);
            textBoxDeskripsi.Name = "textBoxDeskripsi";
            textBoxDeskripsi.Size = new Size(197, 23);
            textBoxDeskripsi.TabIndex = 12;
            // 
            // labelDeskripsi
            // 
            labelDeskripsi.AutoSize = true;
            labelDeskripsi.Dock = DockStyle.Top;
            labelDeskripsi.Location = new Point(0, 180);
            labelDeskripsi.Name = "labelDeskripsi";
            labelDeskripsi.Size = new Size(54, 15);
            labelDeskripsi.TabIndex = 11;
            labelDeskripsi.Text = "Deskripsi";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Dock = DockStyle.Top;
            textBoxEmail.Location = new Point(0, 157);
            textBoxEmail.Margin = new Padding(3, 2, 3, 2);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(197, 23);
            textBoxEmail.TabIndex = 10;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Dock = DockStyle.Top;
            labelEmail.Location = new Point(0, 142);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(36, 15);
            labelEmail.TabIndex = 9;
            labelEmail.Text = "Email";
            // 
            // textBoxNoHp
            // 
            textBoxNoHp.Dock = DockStyle.Top;
            textBoxNoHp.Location = new Point(0, 119);
            textBoxNoHp.Margin = new Padding(3, 2, 3, 2);
            textBoxNoHp.Name = "textBoxNoHp";
            textBoxNoHp.Size = new Size(197, 23);
            textBoxNoHp.TabIndex = 8;
            // 
            // labelNoHp
            // 
            labelNoHp.AutoSize = true;
            labelNoHp.Dock = DockStyle.Top;
            labelNoHp.Location = new Point(0, 104);
            labelNoHp.Name = "labelNoHp";
            labelNoHp.Size = new Size(42, 15);
            labelNoHp.TabIndex = 7;
            labelNoHp.Text = "No Hp";
            // 
            // textBoxNama
            // 
            textBoxNama.Dock = DockStyle.Top;
            textBoxNama.Location = new Point(0, 81);
            textBoxNama.Margin = new Padding(3, 2, 3, 2);
            textBoxNama.Name = "textBoxNama";
            textBoxNama.Size = new Size(197, 23);
            textBoxNama.TabIndex = 6;
            // 
            // labelNama
            // 
            labelNama.AutoSize = true;
            labelNama.Dock = DockStyle.Top;
            labelNama.Location = new Point(0, 66);
            labelNama.Name = "labelNama";
            labelNama.Size = new Size(39, 15);
            labelNama.TabIndex = 5;
            labelNama.Text = "Nama";
            // 
            // UpdateButton
            // 
            UpdateButton.BackColor = Color.FromArgb(255, 255, 128);
            UpdateButton.Dock = DockStyle.Top;
            UpdateButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            UpdateButton.ForeColor = Color.Black;
            UpdateButton.Location = new Point(0, 33);
            UpdateButton.Margin = new Padding(3, 2, 3, 2);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(197, 33);
            UpdateButton.TabIndex = 4;
            UpdateButton.Text = "UPDATE";
            UpdateButton.UseVisualStyleBackColor = false;
            UpdateButton.Click += OnButtonUpdateClick;
            // 
            // HapusButton
            // 
            HapusButton.BackColor = Color.FromArgb(179, 64, 69);
            HapusButton.Dock = DockStyle.Top;
            HapusButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            HapusButton.ForeColor = Color.Black;
            HapusButton.Location = new Point(0, 0);
            HapusButton.Margin = new Padding(3, 2, 3, 2);
            HapusButton.Name = "HapusButton";
            HapusButton.Size = new Size(197, 33);
            HapusButton.TabIndex = 2;
            HapusButton.Text = "HAPUS";
            HapusButton.UseVisualStyleBackColor = false;
            HapusButton.Click += OnButtonHapusClick;
            // 
            // Contact_Darurat
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1094, 562);
            Controls.Add(panel1);
            Margin = new Padding(2);
            Name = "Contact_Darurat";
            Text = "Contact_Darurat";
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DataKontakDarurat).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView DataKontakDarurat;
        private Panel panel2;
        private Button HapusButton;
        private Button UpdateButton;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn phone;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn deskripsi;
        private TextBox textBoxNama;
        private Label labelNama;
        private Label labelNoHp;
        private TextBox textBoxNoHp;
        private Label labelEmail;
        private TextBox textBoxEmail;
        private Label labelDeskripsi;
        private TextBox textBoxDeskripsi;
        private Button buttonTambah;
    }
}