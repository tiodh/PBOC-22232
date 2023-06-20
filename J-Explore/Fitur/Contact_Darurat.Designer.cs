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
            panel2 = new Panel();
            HapusButton = new Button();
            id = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            phone = new DataGridViewTextBoxColumn();
            deskripsi = new DataGridViewTextBoxColumn();
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
            panel1.Name = "panel1";
            panel1.Padding = new Padding(30);
            panel1.Size = new Size(1250, 792);
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
            tableLayoutPanel1.Location = new Point(30, 30);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1190, 732);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // DataKontakDarurat
            // 
            DataKontakDarurat.AllowUserToAddRows = false;
            DataKontakDarurat.AllowUserToDeleteRows = false;
            DataKontakDarurat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataKontakDarurat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataKontakDarurat.Columns.AddRange(new DataGridViewColumn[] { id, name, email, phone, deskripsi });
            DataKontakDarurat.Dock = DockStyle.Fill;
            DataKontakDarurat.Location = new Point(3, 3);
            DataKontakDarurat.Name = "DataKontakDarurat";
            DataKontakDarurat.ReadOnly = true;
            DataKontakDarurat.RowHeadersWidth = 51;
            DataKontakDarurat.Size = new Size(953, 726);
            DataKontakDarurat.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.Controls.Add(HapusButton);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(962, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(225, 726);
            panel2.TabIndex = 5;
            // 
            // HapusButton
            // 
            HapusButton.BackColor = Color.FromArgb(179, 64, 69);
            HapusButton.Dock = DockStyle.Top;
            HapusButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            HapusButton.ForeColor = Color.Black;
            HapusButton.Location = new Point(0, 0);
            HapusButton.Name = "HapusButton";
            HapusButton.Size = new Size(225, 44);
            HapusButton.TabIndex = 2;
            HapusButton.Text = "HAPUS";
            HapusButton.UseVisualStyleBackColor = false;
            // 
            // id
            // 
            id.HeaderText = "ID";
            id.MinimumWidth = 6;
            id.Name = "id";
            id.ReadOnly = true;
            // 
            // name
            // 
            name.HeaderText = "NAMA";
            name.MinimumWidth = 6;
            name.Name = "name";
            name.ReadOnly = true;
            // 
            // email
            // 
            email.HeaderText = "EMAIL";
            email.MinimumWidth = 6;
            email.Name = "email";
            email.ReadOnly = true;
            // 
            // phone
            // 
            phone.HeaderText = "NO HP";
            phone.MinimumWidth = 6;
            phone.Name = "phone";
            phone.ReadOnly = true;
            // 
            // deskripsi
            // 
            deskripsi.HeaderText = "DESKRIPSI";
            deskripsi.MinimumWidth = 6;
            deskripsi.Name = "deskripsi";
            deskripsi.ReadOnly = true;
            // 
            // Contact_Darurat
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1250, 792);
            Controls.Add(panel1);
            Margin = new Padding(2);
            Name = "Contact_Darurat";
            Text = "Contact_Darurat";
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DataKontakDarurat).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView DataKontakDarurat;
        private Panel panel2;
        private Button HapusButton;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn phone;
        private DataGridViewTextBoxColumn deskripsi;
    }
}