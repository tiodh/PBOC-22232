namespace J_Explore
{
    partial class pendapatan
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
            dateTimeBulan.Location = new Point(568, 391);
            dateTimeBulan.Name = "dateTimeBulan";
            dateTimeBulan.Size = new Size(300, 31);
            dateTimeBulan.TabIndex = 11;
            // 
            // dateTimeMinggu
            // 
            dateTimeMinggu.Location = new Point(956, 30);
            dateTimeMinggu.Name = "dateTimeMinggu";
            dateTimeMinggu.Size = new Size(300, 31);
            dateTimeMinggu.TabIndex = 10;
            // 
            // dateTimeHari
            // 
            dateTimeHari.Location = new Point(106, 30);
            dateTimeHari.Name = "dateTimeHari";
            dateTimeHari.Size = new Size(300, 31);
            dateTimeHari.TabIndex = 9;
            // 
            // pendataanBulan
            // 
            pendataanBulan.BackgroundColor = Color.White;
            pendataanBulan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            pendataanBulan.Location = new Point(40, 449);
            pendataanBulan.Name = "pendataanBulan";
            pendataanBulan.RowHeadersWidth = 62;
            pendataanBulan.RowTemplate.Height = 33;
            pendataanBulan.Size = new Size(1352, 296);
            pendataanBulan.TabIndex = 8;
            // 
            // pendataanMinggu
            // 
            pendataanMinggu.BackgroundColor = Color.White;
            pendataanMinggu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            pendataanMinggu.Location = new Point(793, 82);
            pendataanMinggu.Name = "pendataanMinggu";
            pendataanMinggu.RowHeadersWidth = 62;
            pendataanMinggu.RowTemplate.Height = 33;
            pendataanMinggu.Size = new Size(599, 283);
            pendataanMinggu.TabIndex = 7;
            pendataanMinggu.CellContentClick += pendataanMinggu_CellContentClick;
            // 
            // pendataanHari
            // 
            pendataanHari.BackgroundColor = Color.White;
            pendataanHari.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            pendataanHari.Location = new Point(40, 82);
            pendataanHari.Name = "pendataanHari";
            pendataanHari.RowHeadersWidth = 62;
            pendataanHari.RowTemplate.Height = 33;
            pendataanHari.Size = new Size(599, 283);
            pendataanHari.TabIndex = 6;
            // 
            // pendapatan
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
            Name = "pendapatan";
            Text = "pengunjung";
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