using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace kafekikir
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string nama = inputNama.Text;
            string password = inputPassword.Text;

            if (string.IsNullOrWhiteSpace(nama) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Harap isi nama dan password!");
                return;
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(DBConfig.ConsStr))
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM pengguna WHERE nama = @nama AND password = @password";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nama", nama);
                        cmd.Parameters.AddWithValue("@password", password);

                        int count = Convert.ToInt32(cmd.ExecuteScalar());

                        if (count > 0)
                        {
                            MessageBox.Show("Login berhasil!");
                            new dashboard().Show();
                            this.Hide();
                            // new MainForm().Show();
                            // this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Username/password salah!");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message);
            }
        }
    }
}
