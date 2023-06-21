namespace J_Explore.Fitur
{
    partial class Harga_Tiket
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
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            label4 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(229, 17);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(388, 30);
            label1.TabIndex = 0;
            label1.Text = "HARGA TIKET WISATA REMBANGAN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(95, 133);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(104, 21);
            label2.TabIndex = 1;
            label2.Text = "ANAK-ANAK";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(95, 232);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(74, 21);
            label3.TabIndex = 2;
            label3.Text = "DEWASA";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(253, 125);
            textBox1.Margin = new Padding(2);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(495, 38);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(253, 221);
            textBox2.Margin = new Padding(2);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(495, 38);
            textBox2.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(253, 300);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(130, 33);
            button1.TabIndex = 5;
            button1.Text = "Update Tiket Anak";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.FromArgb(192, 0, 0);
            label4.Location = new Point(9, 426);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(145, 45);
            label4.TabIndex = 6;
            label4.Text = "Keterangan Usia :\r\nAnak-Anak = 1 - 12 Tahun\r\nDewasa = 13 Tahun Keatas\r\n";
            // 
            // button2
            // 
            button2.Location = new Point(387, 300);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(130, 33);
            button2.TabIndex = 7;
            button2.Text = "Update Tiket Dewasa";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Harga_Tiket
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(738, 351);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "Harga_Tiket";
            Text = "Harga_Tiket";
            Load += Harga_Tiket_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Label label4;
        private Button button2;
    }
}