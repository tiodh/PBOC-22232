using Npgsql;
using System;
using System.Collections.Generic;

public class DataContext
{
    private string connectionString = "Server=localhost;Port=5432;User Id=postgres;Password=Unumber1.;Database=pbo_project;";

    public List<DataPengunjung> GetDataPengunjung()
    {
        List<DataPengunjung> dataPengunjungList = new List<DataPengunjung>();

        using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
        {
            connection.Open();

            string query = "SELECT * FROM data_pengunjung";

            using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
            {
                using (NpgsqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        DataPengunjung dataPengunjung = new DataPengunjung()
                        {
                            IdDataPengunjung = Convert.ToInt32(reader["id_data_pengunjung"]),
                            NamaPengunjung = reader["nama_pengunjung"].ToString(),
                            AlamatPengunjung = reader["alamat_pengunjung"].ToString(),
                            JumlahPengunjung = Convert.ToInt32(reader["jumlah_pengunjung"]),
                            IdJenisPengunjung = Convert.ToInt32(reader["id_jenis_pengunjung"])
                        };

                        dataPengunjungList.Add(dataPengunjung);
                    }
                }
            }
        }

        return dataPengunjungList;
    }

    public bool UpdateDataPengunjung(int idDataPengunjung, string namaPengunjung, string alamatPengunjung, int jumlahPengunjung, int idJenisPengunjung)
    {
        using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
        {
            connection.Open();

            string query = "UPDATE data_pengunjung SET nama_pengunjung = @NamaPengunjung, alamat_pengunjung = @AlamatPengunjung, jumlah_pengunjung = @JumlahPengunjung, id_jenis_pengunjung = @IdJenisPengunjung WHERE id_data_pengunjung = @IdDataPengunjung";

            using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@NamaPengunjung", namaPengunjung);
                command.Parameters.AddWithValue("@AlamatPengunjung", alamatPengunjung);
                command.Parameters.AddWithValue("@JumlahPengunjung", jumlahPengunjung);
                command.Parameters.AddWithValue("@IdJenisPengunjung", idJenisPengunjung);
                command.Parameters.AddWithValue("@IdDataPengunjung", idDataPengunjung);

                int rowsAffected = command.ExecuteNonQuery();

                return rowsAffected > 0;
            }
        }
    }
}
