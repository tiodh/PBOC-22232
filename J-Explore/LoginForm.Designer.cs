namespace penjualan_laptop.lib.dataProduct
{
    partial class LoginForm
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
            username = new TextBox();
            LoginBTN = new Button();
            alert = new Label();
            panel1 = new Panel();
            resetPassword = new LinkLabel();
            label1 = new Label();
            password = new TextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // username
            // 
            username.Anchor = AnchorStyles.None;
            username.Location = new Point(49, 141);
            username.Margin = new Padding(12);
            username.Name = "username";
            username.Size = new Size(428, 27);
            username.TabIndex = 7;
            // 
            // LoginBTN
            // 
            LoginBTN.Anchor = AnchorStyles.None;
            LoginBTN.BackColor = Color.FromArgb(63, 130, 109);
            LoginBTN.FlatAppearance.BorderSize = 2;
            LoginBTN.FlatStyle = FlatStyle.Flat;
            LoginBTN.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LoginBTN.ForeColor = SystemColors.Control;
            LoginBTN.Location = new Point(49, 246);
            LoginBTN.Name = "LoginBTN";
            LoginBTN.Size = new Size(430, 42);
            LoginBTN.TabIndex = 9;
            LoginBTN.Text = "LOGIN";
            LoginBTN.UseVisualStyleBackColor = false;
            LoginBTN.Click += LoginBTN_Click;
            // 
            // alert
            // 
            alert.Anchor = AnchorStyles.None;
            alert.AutoSize = true;
            alert.Font = new Font("Segoe UI", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point);
            alert.ForeColor = Color.Red;
            alert.Location = new Point(160, 292);
            alert.Name = "alert";
            alert.Size = new Size(112, 17);
            alert.TabIndex = 12;
            alert.Text = "Lupa Kata Sandi ?";
            // 
            // panel1
            // 
            panel1.Controls.Add(resetPassword);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(password);
            panel1.Controls.Add(alert);
            panel1.Controls.Add(LoginBTN);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(username);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(528, 450);
            panel1.TabIndex = 11;
            // 
            // resetPassword
            // 
            resetPassword.AutoSize = true;
            resetPassword.LinkColor = Color.Black;
            resetPassword.Location = new Point(278, 289);
            resetPassword.Name = "resetPassword";
            resetPassword.Size = new Size(74, 20);
            resetPassword.TabIndex = 15;
            resetPassword.TabStop = true;
            resetPassword.Text = "Klik Disini";
            resetPassword.LinkClicked += resetPassword_LinkClicked;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(50, 175);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 14;
            label1.Text = "PASSWORD";
            // 
            // password
            // 
            password.Anchor = AnchorStyles.None;
            password.Location = new Point(50, 203);
            password.Margin = new Padding(12);
            password.Name = "password";
            password.Size = new Size(428, 27);
            password.TabIndex = 13;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(49, 113);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 10;
            label2.Text = "USERNAME";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(528, 450);
            Controls.Add(panel1);
            MinimumSize = new Size(546, 497);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "DeleteData";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox username;
        private Button LoginBTN;
        private Label alert;
        private Panel panel1;
        private Label label1;
        private TextBox password;
        private Label label2;
        private LinkLabel resetPassword;
    }
}