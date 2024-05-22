using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Transactions;

namespace Kel4_PBO.Model
{
    public class RepositoryTransaksi
    {
        private string connectionString = "Server=localhost;Port=5432;Database=kinkapp;User Id=postgres;password=lmj#191104";

        public List<Transaksi> GetAll()
        {
            var transaksi = new List<Transaksi>();
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                var command = new NpgsqlCommand("SELECT * FROM Transaksi", connection);
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    transaksi.Add(new Transaksi
                    {
                        id_transaksi= (string)reader["id_transaksi"],
                        id_karyawan = (string)reader["id_karyawan"],
                        total_transaksi = (int)reader["Date"],
                        tanggal = (DateTime)reader["Tanggal"]
                    });
                }
            }
            return transaksi;
        }

       public void Add(Transaksi transaksi)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                var command = new NpgsqlCommand(
                    "INSERT INTO Transaksi (id_karyawan, total_transaksi, tanggal) VALUES (@IdKaryawan, @TotalTransaksi, @Tanggal)",
                    connection);
                command.Parameters.AddWithValue("@IdKaryawan", transaksi.id_karyawan);
                command.Parameters.AddWithValue("@TotalTransaksi", transaksi.total_transaksi);
                command.Parameters.AddWithValue("@Tanggal", transaksi.tanggal);
                command.ExecuteNonQuery();
            }
        }

        public void Update(Transaksi transaksi)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                var command = new NpgsqlCommand(
                    "UPDATE Transaksi SET id_karyawan = @IdKaryawan,  = @Date, Description = @Description WHERE Id = @Id",
                    connection);
                command.Parameters.AddWithValue("@Id", transaction.Id);
                command.Parameters.AddWithValue("@Amount", transaction.Amount);
                command.Parameters.AddWithValue("@Date", transaction.Date);
                command.Parameters.AddWithValue("@Description", transaction.Description);
                command.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                var command = new NpgsqlCommand("DELETE FROM Transactions WHERE Id = @Id", connection);
                command.Parameters.AddWithValue("@Id", id);
                command.ExecuteNonQuery();
            }
        }
    } 
}
