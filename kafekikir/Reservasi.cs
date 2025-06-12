using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace kafekikir
{
    public partial class Reservasi : Form
    {
        private int selectedId = -1;

        public Reservasi()
        {
            InitializeComponent();
            LoadData();
        }


        private void LoadData()
        {
            using (MySqlConnection conn = new MySqlConnection(DBConfig.ConsStr))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM pemesanan";
                    MySqlDataAdapter adapted = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapted.Fill(dt);
                    dgvTabel.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error load data: " + ex.Message);
                }
            }

            dgvTabel.Columns["id_pemesanan"].HeaderText = "ID";
            dgvTabel.Columns["id_pemesanan"].Visible = false;

            dgvTabel.Columns["nama"].HeaderText = "Nama";
            dgvTabel.Columns["meja"].HeaderText = "Nomor Meja";
            dgvTabel.Columns["waktu"].HeaderText = "Waktu";

            

        }

        private void ClearForm()
        {
            txtNama.Clear();
            selectedId = -1;
            btnTambah.Enabled = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Reservasi_Load(object sender, EventArgs e)
        {

        }

        private void btnTambah_Click(object sender, EventArgs e)
        {

        }

        private void btnTambah_Click_1(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(DBConfig.ConsStr))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO pemesanan (nama,meja,waktu)" +
                        "VALUES(@nama,@meja,@waktu)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@nama", txtNama.Text);
                    cmd.Parameters.AddWithValue("@meja", cmbMeja.Text);
                    cmd.Parameters.AddWithValue("@waktu", cmbWaktu.Text);
                    cmd.ExecuteNonQuery();
                    LoadData();
                    ClearForm();
                    MessageBox.Show("Reservasi berhasil ditambahkan !!!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal Reservasi: " + ex.Message);
                }
            }
        }

        private void dgvTabel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvTabel.Rows[e.RowIndex];

                // Ambil nilai dari baris yang diklik
                selectedId = Convert.ToInt32(row.Cells["id_pemesanan"].Value);
                txtNama.Text = row.Cells["nama"].Value.ToString();
                cmbMeja.Text = row.Cells["meja"].Value.ToString();
                cmbWaktu.Text = row.Cells["waktu"].Value.ToString();

                btnTambah.Enabled = false;
            }
        }


        private void cmbMeja_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (selectedId == -1)
            {
                MessageBox.Show("Pilih data yang ingin diedit.");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(DBConfig.ConsStr))
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE pemesanan SET nama=@nama, meja=@meja, waktu=@waktu WHERE id_pemesanan=@id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@nama", txtNama.Text);
                    cmd.Parameters.AddWithValue("@meja", cmbMeja.Text);
                    cmd.Parameters.AddWithValue("@waktu", cmbWaktu.Text);
                    cmd.Parameters.AddWithValue("@id", selectedId);
                    cmd.ExecuteNonQuery();
                    LoadData();
                    ClearForm();
                    MessageBox.Show("Data berhasil diedit!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal edit: " + ex.Message);
                }
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (selectedId == -1)
            {
                MessageBox.Show("Pilih data terlebih dahulu dari tabel.");
                return;
            }

            DialogResult result = MessageBox.Show("Yakin ingin menghapus data ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                using (MySqlConnection conn = new MySqlConnection(DBConfig.ConsStr))
                {
                    try
                    {
                        conn.Open();
                        string query = "DELETE FROM pemesanan WHERE id_pemesanan = @id";
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@id", selectedId);
                        cmd.ExecuteNonQuery();

                        LoadData();
                        ClearForm();
                        MessageBox.Show("Data berhasil dihapus!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Gagal hapus data: " + ex.Message);
                    }
                }
            }
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            string kategori = cmbCariKategori.Text;
            string keyword = txtCari.Text.Trim();

            if (string.IsNullOrWhiteSpace(kategori) || string.IsNullOrWhiteSpace(keyword))
            {
                MessageBox.Show("Silakan pilih kategori dan isi keyword pencarian.");
                return;
            }

            string kolom = "";

            switch (kategori)
            {
                case "Nama":
                    kolom = "nama";
                    break;
                case "Meja":
                    kolom = "meja";
                    break;
                case "Waktu":
                    kolom = "waktu";
                    break;
                default:
                    MessageBox.Show("Kategori tidak valid.");
                    return;
            }

            using (MySqlConnection conn = new MySqlConnection(DBConfig.ConsStr))
            {
                try
                {
                    conn.Open();
                    string query = $"SELECT * FROM pemesanan WHERE {kolom} LIKE @keyword";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    adapter.SelectCommand.Parameters.AddWithValue("@keyword", "%" + keyword + "%");

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvTabel.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal mencari data: " + ex.Message);
                }
            }
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            if (selectedId == -1)
            {
                MessageBox.Show("Tidak ada data yang dipilih untuk diedit.");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(DBConfig.ConsStr))
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE pemesanan SET nama = @nama, meja = @meja, waktu = @waktu WHERE id_pemesanan = @id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@nama", txtNama.Text);
                    cmd.Parameters.AddWithValue("@meja", cmbMeja.Text);
                    cmd.Parameters.AddWithValue("@waktu", cmbWaktu.Text);
                    cmd.Parameters.AddWithValue("@id", selectedId);
                    cmd.ExecuteNonQuery();

                    LoadData();
                    ClearForm();
                    MessageBox.Show("Data berhasil diperbarui!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal update: " + ex.Message);
                }
            }
        }
    }
}
