namespace J_Explore
{
    partial class ResetPassword
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
            label1 = new Label();
            usernameVerification = new TextBox();
            LoginBTN = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(79, 236);
            label1.Name = "label1";
            label1.Size = new Size(86, 20);
            label1.TabIndex = 17;
            label1.Text = "USERNAME";
            // 
            // usernameVerification
            // 
            usernameVerification.Anchor = AnchorStyles.None;
            usernameVerification.Location = new Point(79, 264);
            usernameVerification.Margin = new Padding(12);
            usernameVerification.Name = "usernameVerification";
            usernameVerification.Size = new Size(428, 27);
            usernameVerification.TabIndex = 16;
            // 
            // LoginBTN
            // 
            LoginBTN.Anchor = AnchorStyles.None;
            LoginBTN.BackColor = Color.FromArgb(63, 130, 109);
            LoginBTN.FlatAppearance.BorderSize = 2;
            LoginBTN.FlatStyle = FlatStyle.Flat;
            LoginBTN.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LoginBTN.ForeColor = SystemColors.Control;
            LoginBTN.Location = new Point(78, 307);
            LoginBTN.Name = "LoginBTN";
            LoginBTN.Size = new Size(430, 42);
            LoginBTN.TabIndex = 15;
            LoginBTN.Text = "CHECK";
            LoginBTN.UseVisualStyleBackColor = false;
            LoginBTN.Click += LoginBTN_Click;
            // 
            // ResetPassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(593, 610);
            Controls.Add(label1);
            Controls.Add(usernameVerification);
            Controls.Add(LoginBTN);
            Name = "ResetPassword";
            Text = "ResetPassword";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox password;
        private Button LoginBTN;
        private TextBox usernameVerification;
    }
}