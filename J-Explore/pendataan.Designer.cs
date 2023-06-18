namespace J_Explore
{
    partial class pendataan
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
            pendataanHari = new DataGridView();
            pendataanMinggu = new DataGridView();
            pendataanBulan = new DataGridView();
            dateTimeHari = new DateTimePicker();
            dateTimeMinggu = new DateTimePicker();
            dateTimeBulan = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)pendataanHari).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pendataanMinggu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pendataanBulan).BeginInit();
            SuspendLayout();
            // 
            // pendataanHari
            // 
            pendataanHari.BackgroundColor = Color.White;
            pendataanHari.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            pendataanHari.Location = new Point(35, 72);
            pendataanHari.Name = "pendataanHari";
            pendataanHari.RowHeadersWidth = 62;
            pendataanHari.RowTemplate.Height = 33;
            pendataanHari.Size = new Size(433, 175);
            pendataanHari.TabIndex = 0;
            // 
            // pendataanMinggu
            // 
            pendataanMinggu.BackgroundColor = Color.White;
            pendataanMinggu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            pendataanMinggu.Location = new Point(535, 72);
            pendataanMinggu.Name = "pendataanMinggu";
            pendataanMinggu.RowHeadersWidth = 62;
            pendataanMinggu.RowTemplate.Height = 33;
            pendataanMinggu.Size = new Size(433, 175);
            pendataanMinggu.TabIndex = 1;
            // 
            // pendataanBulan
            // 
            pendataanBulan.BackgroundColor = Color.White;
            pendataanBulan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            pendataanBulan.Location = new Point(35, 333);
            pendataanBulan.Name = "pendataanBulan";
            pendataanBulan.RowHeadersWidth = 62;
            pendataanBulan.RowTemplate.Height = 33;
            pendataanBulan.Size = new Size(933, 179);
            pendataanBulan.TabIndex = 2;
            // 
            // dateTimeHari
            // 
            dateTimeHari.Location = new Point(90, 20);
            dateTimeHari.Name = "dateTimeHari";
            dateTimeHari.Size = new Size(300, 31);
            dateTimeHari.TabIndex = 3;
            // 
            // dateTimeMinggu
            // 
            dateTimeMinggu.Location = new Point(604, 19);
            dateTimeMinggu.Name = "dateTimeMinggu";
            dateTimeMinggu.Size = new Size(300, 31);
            dateTimeMinggu.TabIndex = 4;
            // 
            // dateTimeBulan
            // 
            dateTimeBulan.Location = new Point(352, 275);
            dateTimeBulan.Name = "dateTimeBulan";
            dateTimeBulan.Size = new Size(300, 31);
            dateTimeBulan.TabIndex = 5;
            // 
            // pendataan
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1012, 550);
            Controls.Add(dateTimeBulan);
            Controls.Add(dateTimeMinggu);
            Controls.Add(dateTimeHari);
            Controls.Add(pendataanBulan);
            Controls.Add(pendataanMinggu);
            Controls.Add(pendataanHari);
            Name = "pendataan";
            Text = "pendataan";
            ((System.ComponentModel.ISupportInitialize)pendataanHari).EndInit();
            ((System.ComponentModel.ISupportInitialize)pendataanMinggu).EndInit();
            ((System.ComponentModel.ISupportInitialize)pendataanBulan).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView pendataanHari;
        private DataGridView pendataanMinggu;
        private DataGridView pendataanBulan;
        private DateTimePicker dateTimeHari;
        private DateTimePicker dateTimeMinggu;
        private DateTimePicker dateTimeBulan;
    }
}