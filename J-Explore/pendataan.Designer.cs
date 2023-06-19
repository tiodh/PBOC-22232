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
            dateTimeBulan = new DateTimePicker();
            dateTimeMinggu = new DateTimePicker();
            dateTimeHari = new DateTimePicker();
            pendataanBulan = new DataGridView();
            pendataanMinggu = new DataGridView();
            pendataanHari = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pendataanBulan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pendataanMinggu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pendataanHari).BeginInit();
            SuspendLayout();
            // 
            // dateTimeBulan
            // 
            dateTimeBulan.Location = new Point(570, 396);
            dateTimeBulan.Name = "dateTimeBulan";
            dateTimeBulan.Size = new Size(300, 31);
            dateTimeBulan.TabIndex = 17;
            // 
            // dateTimeMinggu
            // 
            dateTimeMinggu.Location = new Point(958, 35);
            dateTimeMinggu.Name = "dateTimeMinggu";
            dateTimeMinggu.Size = new Size(300, 31);
            dateTimeMinggu.TabIndex = 16;
            // 
            // dateTimeHari
            // 
            dateTimeHari.Location = new Point(108, 35);
            dateTimeHari.Name = "dateTimeHari";
            dateTimeHari.Size = new Size(300, 31);
            dateTimeHari.TabIndex = 15;
            // 
            // pendataanBulan
            // 
            pendataanBulan.BackgroundColor = Color.White;
            pendataanBulan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            pendataanBulan.Location = new Point(42, 454);
            pendataanBulan.Name = "pendataanBulan";
            pendataanBulan.RowHeadersWidth = 62;
            pendataanBulan.RowTemplate.Height = 33;
            pendataanBulan.Size = new Size(1352, 296);
            pendataanBulan.TabIndex = 14;
            // 
            // pendataanMinggu
            // 
            pendataanMinggu.BackgroundColor = Color.White;
            pendataanMinggu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            pendataanMinggu.Location = new Point(795, 87);
            pendataanMinggu.Name = "pendataanMinggu";
            pendataanMinggu.RowHeadersWidth = 62;
            pendataanMinggu.RowTemplate.Height = 33;
            pendataanMinggu.Size = new Size(599, 283);
            pendataanMinggu.TabIndex = 13;
            // 
            // pendataanHari
            // 
            pendataanHari.BackgroundColor = Color.White;
            pendataanHari.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            pendataanHari.Location = new Point(42, 87);
            pendataanHari.Name = "pendataanHari";
            pendataanHari.RowHeadersWidth = 62;
            pendataanHari.RowTemplate.Height = 33;
            pendataanHari.Size = new Size(599, 283);
            pendataanHari.TabIndex = 12;
            // 
            // pendataan
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1436, 784);
            Controls.Add(dateTimeBulan);
            Controls.Add(dateTimeMinggu);
            Controls.Add(dateTimeHari);
            Controls.Add(pendataanBulan);
            Controls.Add(pendataanMinggu);
            Controls.Add(pendataanHari);
            Name = "pendataan";
            Text = "PENDATAAN";
            ((System.ComponentModel.ISupportInitialize)pendataanBulan).EndInit();
            ((System.ComponentModel.ISupportInitialize)pendataanMinggu).EndInit();
            ((System.ComponentModel.ISupportInitialize)pendataanHari).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DateTimePicker dateTimeBulan;
        private DateTimePicker dateTimeMinggu;
        private DateTimePicker dateTimeHari;
        private DataGridView pendataanBulan;
        private DataGridView pendataanMinggu;
        private DataGridView pendataanHari;
    }
}