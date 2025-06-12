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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            string nama = inputNama.Text;
            string email = inputEmail.Text;
            string nohp = inputNohp.Text;
            string password = inputPassword.Text;

            if (string.IsNullOrWhiteSpace(nama) || string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(nohp) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Harap isi semua data!");
                return;
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(DBConfig.ConsStr))
                {
                    conn.Open();
                    string query = "INSERT INTO pengguna (nama, email, no_hp, password) VALUES (@nama, @email, @nohp, @password)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nama", nama);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@nohp", nohp);
                        cmd.Parameters.AddWithValue("@password", password); // bisa dienkripsi jika perlu

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Registrasi berhasil!");
                        // Tampilkan form login
                        login loginForm = new login();
                        loginForm.Show();

                        // Tutup form register
                        this.Hide(); // Atau this.Close(); jika ingin menutup total
                    }
                }

                // kosongkan input
                inputNama.Text = "";
                inputEmail.Text = "";
                inputNohp.Text = "";
                inputPassword.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message);
            }

        }
    }
}
