using Kel4_PBO.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kel4_PBO.View
{
    public partial class FormTransaksi : Form
    {
        public FormTransaksi()
        {
            InitializeComponent();
        }

        private void FormTransaksi_Load(object sender, EventArgs e)
        {

        }

        private void iconCurrentChildForm_Click(object sender, EventArgs e)
        {

        }

        private void labelChildForm_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panelLogo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Shapes1_Click(object sender, EventArgs e)
        {

        }

        private void IDBarang_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbHarga_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string idTransaksi = txtIdTransaksi.Text; 
                string namaBarang = NamaBarang.Text;
                int hargaJual = int.Parse(HargaJual.Text); 
                int jumlah = int.Parse(Jumlah.Text);
                int totalHarga = int.Parse(TotalHarga.Text); 

                var transaksi = new Transaksi
                {
                    id_transaksi = idTransaksi,
                    nama_barang = namaBarang,
                    harga_jual = hargaJual,
                    jumlah = jumlah,
                    total_harga = totalHarga
                };
                var repository = new TransaksiContext();
                repository.Add(transaksi);

                MessageBox.Show("Transaksi berhasil ditambahkan");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal: {ex.Message}");
            }
        }
    }
}
