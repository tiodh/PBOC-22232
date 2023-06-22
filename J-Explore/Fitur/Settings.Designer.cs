namespace J_Explore.Fitur
{
    partial class Settings
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
            panel3 = new Panel();
            label2 = new Label();
            panel5 = new Panel();
            panel2 = new Panel();
            label1 = new Label();
            panel4 = new Panel();
            panel10 = new Panel();
            nameDatabase = new RichTextBox();
            panel9 = new Panel();
            port = new RichTextBox();
            panel7 = new Panel();
            password = new RichTextBox();
            panel8 = new Panel();
            username = new RichTextBox();
            label7 = new Label();
            label6 = new Label();
            label4 = new Label();
            label5 = new Label();
            panel6 = new Panel();
            hostName = new RichTextBox();
            label3 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            SaveDatabase = new Button();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel10.SuspendLayout();
            panel9.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(30);
            panel1.Size = new Size(1068, 649);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panel3, 1, 0);
            tableLayoutPanel1.Controls.Add(panel2, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(30, 30);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1008, 589);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(label2);
            panel3.Controls.Add(panel5);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(504, 0);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(504, 589);
            panel3.TabIndex = 1;
            panel3.Paint += panel3_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(40, 0);
            label2.Name = "label2";
            label2.Size = new Size(206, 31);
            label2.TabIndex = 2;
            label2.Text = "SETTING PRINTER";
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Location = new Point(10, 18);
            panel5.Margin = new Padding(0, 10, 0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(494, 571);
            panel5.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Controls.Add(panel4);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(504, 589);
            panel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(30, 0);
            label1.Name = "label1";
            label1.Size = new Size(226, 31);
            label1.TabIndex = 0;
            label1.Text = "SETTING DATABASE";
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel4.BackColor = SystemColors.Control;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(SaveDatabase);
            panel4.Controls.Add(panel10);
            panel4.Controls.Add(panel9);
            panel4.Controls.Add(panel7);
            panel4.Controls.Add(panel8);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(panel6);
            panel4.Controls.Add(label3);
            panel4.Location = new Point(0, 18);
            panel4.Margin = new Padding(0, 0, 10, 0);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(10);
            panel4.Size = new Size(494, 571);
            panel4.TabIndex = 1;
            // 
            // panel10
            // 
            panel10.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel10.BorderStyle = BorderStyle.FixedSingle;
            panel10.Controls.Add(nameDatabase);
            panel10.Location = new Point(19, 446);
            panel10.Name = "panel10";
            panel10.Size = new Size(460, 38);
            panel10.TabIndex = 3;
            // 
            // nameDatabase
            // 
            nameDatabase.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            nameDatabase.BackColor = SystemColors.Window;
            nameDatabase.BorderStyle = BorderStyle.None;
            nameDatabase.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            nameDatabase.Location = new Point(0, 0);
            nameDatabase.Multiline = false;
            nameDatabase.Name = "nameDatabase";
            nameDatabase.Size = new Size(458, 36);
            nameDatabase.TabIndex = 2;
            nameDatabase.Text = "";
            // 
            // panel9
            // 
            panel9.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel9.BorderStyle = BorderStyle.FixedSingle;
            panel9.Controls.Add(port);
            panel9.Location = new Point(19, 348);
            panel9.Name = "panel9";
            panel9.Size = new Size(460, 38);
            panel9.TabIndex = 3;
            // 
            // port
            // 
            port.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            port.BackColor = SystemColors.Window;
            port.BorderStyle = BorderStyle.None;
            port.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            port.Location = new Point(0, 0);
            port.Multiline = false;
            port.Name = "port";
            port.Size = new Size(458, 36);
            port.TabIndex = 2;
            port.Text = "";
            // 
            // panel7
            // 
            panel7.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(password);
            panel7.Location = new Point(19, 253);
            panel7.Name = "panel7";
            panel7.Size = new Size(460, 38);
            panel7.TabIndex = 3;
            // 
            // password
            // 
            password.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            password.BackColor = SystemColors.Window;
            password.BorderStyle = BorderStyle.None;
            password.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            password.Location = new Point(0, 0);
            password.Multiline = false;
            password.Name = "password";
            password.Size = new Size(458, 36);
            password.TabIndex = 2;
            password.Text = "";
            // 
            // panel8
            // 
            panel8.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel8.BorderStyle = BorderStyle.FixedSingle;
            panel8.Controls.Add(username);
            panel8.Location = new Point(19, 159);
            panel8.Name = "panel8";
            panel8.Size = new Size(460, 38);
            panel8.TabIndex = 3;
            // 
            // username
            // 
            username.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            username.BackColor = SystemColors.Window;
            username.BorderStyle = BorderStyle.None;
            username.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            username.Location = new Point(0, 0);
            username.Multiline = false;
            username.Name = "username";
            username.Size = new Size(458, 36);
            username.TabIndex = 2;
            username.Text = "";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(13, 410);
            label7.Name = "label7";
            label7.Size = new Size(177, 31);
            label7.TabIndex = 2;
            label7.Text = "Nama Database";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(13, 312);
            label6.Name = "label6";
            label6.Size = new Size(55, 31);
            label6.TabIndex = 2;
            label6.Text = "Port";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(13, 217);
            label4.Name = "label4";
            label4.Size = new Size(110, 31);
            label4.TabIndex = 2;
            label4.Text = "Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(13, 123);
            label5.Name = "label5";
            label5.Size = new Size(117, 31);
            label5.TabIndex = 2;
            label5.Text = "Username";
            // 
            // panel6
            // 
            panel6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(hostName);
            panel6.Location = new Point(19, 69);
            panel6.Name = "panel6";
            panel6.Size = new Size(460, 38);
            panel6.TabIndex = 1;
            // 
            // hostName
            // 
            hostName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            hostName.BackColor = SystemColors.Window;
            hostName.BorderStyle = BorderStyle.None;
            hostName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            hostName.Location = new Point(0, 0);
            hostName.Multiline = false;
            hostName.Name = "hostName";
            hostName.Size = new Size(458, 36);
            hostName.TabIndex = 2;
            hostName.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(13, 33);
            label3.Name = "label3";
            label3.Size = new Size(61, 31);
            label3.TabIndex = 0;
            label3.Text = "Host";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.Padding = new Padding(20);
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(200, 100);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // SaveDatabase
            // 
            SaveDatabase.ForeColor = Color.Black;
            SaveDatabase.Location = new Point(19, 508);
            SaveDatabase.Name = "SaveDatabase";
            SaveDatabase.Size = new Size(262, 39);
            SaveDatabase.TabIndex = 4;
            SaveDatabase.Text = "SAVE";
            SaveDatabase.UseVisualStyleBackColor = true;
            SaveDatabase.Click += SaveDatabase_Click;
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1068, 649);
            Controls.Add(panel1);
            Name = "Settings";
            Text = "Settings";
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel10.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel3;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
        private Label label2;
        private Panel panel5;
        private Panel panel4;
        private Label label3;
        private Panel panel6;
        private RichTextBox hostName;
        private Panel panel10;
        private RichTextBox nameDatabase;
        private Panel panel9;
        private RichTextBox port;
        private Panel panel7;
        private RichTextBox password;
        private Panel panel8;
        private RichTextBox username;
        private Label label7;
        private Label label6;
        private Label label4;
        private Label label5;
        private Button SaveDatabase;
    }
}