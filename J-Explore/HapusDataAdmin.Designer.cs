namespace J_Explore
{
    partial class HapusDataAdmin
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
            button1 = new Button();
            passwordInput = new RichTextBox();
            usernameInput = new RichTextBox();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(passwordInput);
            panel1.Controls.Add(usernameInput);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(30);
            panel1.Size = new Size(1305, 578);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(179, 64, 69);
            button1.Location = new Point(157, 145);
            button1.Name = "button1";
            button1.Size = new Size(577, 48);
            button1.TabIndex = 4;
            button1.Text = "Hapus Akun";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // passwordInput
            // 
            passwordInput.Location = new Point(157, 91);
            passwordInput.Multiline = false;
            passwordInput.Name = "passwordInput";
            passwordInput.Size = new Size(577, 39);
            passwordInput.TabIndex = 3;
            passwordInput.Text = "";
            // 
            // usernameInput
            // 
            usernameInput.Location = new Point(157, 33);
            usernameInput.Multiline = false;
            usernameInput.Name = "usernameInput";
            usernameInput.Size = new Size(577, 39);
            usernameInput.TabIndex = 2;
            usernameInput.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(33, 93);
            label2.Name = "label2";
            label2.Size = new Size(117, 28);
            label2.TabIndex = 1;
            label2.Text = "Password   : ";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(32, 35);
            label1.Name = "label1";
            label1.Size = new Size(118, 28);
            label1.TabIndex = 0;
            label1.Text = "Username  : ";
            // 
            // HapusDataAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1305, 578);
            Controls.Add(panel1);
            Name = "HapusDataAdmin";
            Text = "HapusDataAdmin";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private Button button1;
        private RichTextBox passwordInput;
        private RichTextBox usernameInput;
    }
}