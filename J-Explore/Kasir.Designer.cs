namespace J_Explore
{
    partial class Kasir
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
            Transaksi = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            label5 = new Label();
            label6 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label8 = new Label();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            SuspendLayout();
            // 
            // Transaksi
            // 
            Transaksi.AutoSize = true;
            Transaksi.Font = new Font("Segoe UI", 25F, FontStyle.Bold, GraphicsUnit.Point);
            Transaksi.Location = new Point(25, 26);
            Transaksi.Name = "Transaksi";
            Transaksi.Size = new Size(167, 46);
            Transaksi.TabIndex = 4;
            Transaksi.Text = "Transaksi";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(52, 92);
            label1.Name = "label1";
            label1.Size = new Size(43, 37);
            label1.TabIndex = 5;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(52, 160);
            label2.Name = "label2";
            label2.Size = new Size(88, 37);
            label2.TabIndex = 6;
            label2.Text = "Nama";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(52, 233);
            label3.Name = "label3";
            label3.Size = new Size(66, 37);
            label3.TabIndex = 7;
            label3.Text = "Asal";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ImageAlign = ContentAlignment.MiddleLeft;
            label4.Location = new Point(534, 92);
            label4.Name = "label4";
            label4.Size = new Size(143, 74);
            label4.TabIndex = 8;
            label4.Text = "Jumlah\r\nAnak-anak";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(197, 92);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(320, 43);
            textBox1.TabIndex = 11;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(197, 157);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(320, 43);
            textBox2.TabIndex = 12;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(197, 230);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(320, 43);
            textBox3.TabIndex = 13;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.Location = new Point(679, 295);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(320, 43);
            textBox4.TabIndex = 22;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton3.Location = new Point(195, 299);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(134, 41);
            radioButton3.TabIndex = 19;
            radioButton3.TabStop = true;
            radioButton3.Text = "Laki-laki";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton4.Location = new Point(348, 299);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(169, 41);
            radioButton4.TabIndex = 18;
            radioButton4.TabStop = true;
            radioButton4.Text = "Perempuan";
            radioButton4.UseVisualStyleBackColor = true;
            radioButton4.CheckedChanged += radioButton4_CheckedChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(52, 297);
            label5.Name = "label5";
            label5.Size = new Size(113, 74);
            label5.TabIndex = 17;
            label5.Text = "Jenis\r\nKelamin";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(534, 301);
            label6.Name = "label6";
            label6.Size = new Size(119, 37);
            label6.TabIndex = 16;
            label6.Text = "Nominal";
            label6.Click += label6_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(621, 497);
            button1.Name = "button1";
            button1.Size = new Size(116, 43);
            button1.TabIndex = 24;
            button1.Text = "Cetak";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(743, 497);
            button2.Name = "button2";
            button2.Size = new Size(116, 43);
            button2.TabIndex = 25;
            button2.Text = "Simpan";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(865, 497);
            button3.Name = "button3";
            button3.Size = new Size(116, 43);
            button3.TabIndex = 26;
            button3.Text = "Hapus";
            button3.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ImageAlign = ContentAlignment.MiddleLeft;
            label8.Location = new Point(534, 187);
            label8.Name = "label8";
            label8.Size = new Size(109, 74);
            label8.TabIndex = 27;
            label8.Text = "Jumlah\r\nDewasa\r\n";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            textBox6.Location = new Point(679, 92);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(320, 43);
            textBox6.TabIndex = 28;
            // 
            // textBox7
            // 
            textBox7.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            textBox7.Location = new Point(679, 187);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(320, 43);
            textBox7.TabIndex = 29;
            // 
            // Kasir
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1018, 567);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(label8);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(radioButton3);
            Controls.Add(radioButton4);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Transaksi);
            Name = "Kasir";
            Text = "Kasir";
            Load += Kasir_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Transaksi;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private Label label5;
        private Label label6;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label8;
        private TextBox textBox6;
        private TextBox textBox7;
    }
}