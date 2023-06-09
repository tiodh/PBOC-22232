﻿using J_Explore.Services;
using J_Explore.Utils;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace J_Explore.Fitur
{
    public partial class Contact_Darurat : Form
    {
        private string connectionString = $"Server = {Global.DbHost}; Port = {Global.DbPort}; User Id= {Global.DbUsername}; Password={Global.DbPassword}; Database = {Global.DbName};";
        public Contact_Darurat()
        {
            InitializeComponent();
            ReadKontakDarurat();
        }

        public void ReadKontakDarurat()
        {
            DataKontakDarurat.Rows.Clear();

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                string sql = "Select * from layanan_darurat";

                using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
                {
                    command.CommandText = sql;
                    NpgsqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        int id = Convert.ToInt32(reader[0]);
                        string name = reader.GetString(1);
                        string email = reader.GetString(2);
                        string phone = reader.GetString(3);
                        string deskripsi = reader.GetString(4);

                        DataKontakDarurat.Rows.Add(id, name, email, phone, deskripsi);
                    }
                }

                connection.Close();
            }
        }

        private void OnButtonHapusClick(object sender, EventArgs e)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                int selectedRow = DataKontakDarurat.SelectedCells[0].RowIndex;
                int id = Convert.ToInt32(DataKontakDarurat.Rows[selectedRow].Cells[0].Value);

                string sql = $"DELETE FROM layanan_darurat WHERE id_layanan_darurat = '{id}'";

                int affectedRows = new NpgsqlCommand(sql, connection).ExecuteNonQuery();

                if (affectedRows > 0)
                {
                    MessageBox.Show("Data berhasil dihapus");
                }

                ReadKontakDarurat();
            }
        }

        private void OnButtonUpdateClick(object sender, EventArgs e)
        {
            int selectedRow = DataKontakDarurat.SelectedCells[0].RowIndex;

            int id = Convert.ToInt32(DataKontakDarurat.Rows[selectedRow].Cells[0].Value);
            string nama = Convert.ToString(DataKontakDarurat.Rows[selectedRow].Cells[1].Value);
            string noHp = Convert.ToString(DataKontakDarurat.Rows[selectedRow].Cells[2].Value);
            string email = Convert.ToString(DataKontakDarurat.Rows[selectedRow].Cells[3].Value);
            string deskripsi = Convert.ToString(DataKontakDarurat.Rows[selectedRow].Cells[4].Value);

            int affectedRows = DbHelper.GetInstance().ExecuteNonQuery($"UPDATE layanan_darurat SET nama_layanan_darurat = '{nama}', email_layanan_daurat = '{email}', no_telp = '{noHp}', deskripsi_layanan_darurat = '{deskripsi}' WHERE id_layanan_darurat = '{id}'");

            if (affectedRows > 0)
            {
                MessageBox.Show("Data berhasil diupdate", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            MessageBox.Show("Data gagal diupdate", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void OnButtonTambahClick(object sender, EventArgs e)
        {
            string nama = textBoxNama.Text.Trim();
            string noHp = textBoxNoHp.Text.Trim();
            string email = textBoxEmail.Text.Trim();
            string deskripsi = textBoxDeskripsi.Text.Trim();

            int affectedRows = DbHelper.GetInstance().ExecuteNonQuery($"INSERT INTO layanan_darurat VALUES (DEFAULT, '{nama}', '{noHp}', '{email}', '{deskripsi}')");

            if (affectedRows > 0)
            {
                textBoxNama.Text = "";
                textBoxNoHp.Text = "";
                textBoxEmail.Text = "";
                textBoxDeskripsi.Text = "";
                ReadKontakDarurat();
                return;
            }

            MessageBox.Show("Data gagal ditambah", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
