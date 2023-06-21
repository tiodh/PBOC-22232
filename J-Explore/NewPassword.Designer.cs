namespace J_Explore
{
    partial class NewPassword
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
            password = new TextBox();
            LoginBTN = new Button();
            passwordconfirmation = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(166, 110);
            label1.Name = "label1";
            label1.Size = new Size(124, 20);
            label1.TabIndex = 20;
            label1.Text = "NEW PASSWORD";
            // 
            // password
            // 
            password.Anchor = AnchorStyles.None;
            password.Location = new Point(166, 138);
            password.Margin = new Padding(12);
            password.Name = "password";
            password.Size = new Size(428, 27);
            password.TabIndex = 19;
            // 
            // LoginBTN
            // 
            LoginBTN.Anchor = AnchorStyles.None;
            LoginBTN.BackColor = Color.FromArgb(63, 130, 109);
            LoginBTN.FlatAppearance.BorderSize = 2;
            LoginBTN.FlatStyle = FlatStyle.Flat;
            LoginBTN.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LoginBTN.ForeColor = SystemColors.Control;
            LoginBTN.Location = new Point(166, 275);
            LoginBTN.Name = "LoginBTN";
            LoginBTN.Size = new Size(430, 42);
            LoginBTN.TabIndex = 18;
            LoginBTN.Text = "CHECK";
            LoginBTN.UseVisualStyleBackColor = false;
            LoginBTN.Click += LoginBTN_Click;
            // 
            // passwordconfirmation
            // 
            passwordconfirmation.Anchor = AnchorStyles.None;
            passwordconfirmation.Location = new Point(166, 216);
            passwordconfirmation.Margin = new Padding(12);
            passwordconfirmation.Name = "passwordconfirmation";
            passwordconfirmation.Size = new Size(428, 27);
            passwordconfirmation.TabIndex = 21;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(166, 188);
            label2.Name = "label2";
            label2.Size = new Size(124, 20);
            label2.TabIndex = 22;
            label2.Text = "NEW PASSWORD";
            // 
            // NewPassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(763, 450);
            Controls.Add(passwordconfirmation);
            Controls.Add(label2);
            Controls.Add(password);
            Controls.Add(LoginBTN);
            Controls.Add(label1);
            Name = "NewPassword";
            Text = "NewPassword";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox password;
        private Button LoginBTN;
        private TextBox passwordconfirmation;
        private Label label2;
    }
}