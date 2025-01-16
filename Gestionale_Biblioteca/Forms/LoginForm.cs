using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gestionale_Biblioteca.Classes;
using MySql.Data.MySqlClient;

namespace Gestionale_Biblioteca.Forms
{
    public partial class LoginForm : Form
    {
        private Database db = new Database();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            if (db.TestConnection())
            {
                MessageBox.Show("Connessione al database riuscita!");
            }
            else
            {
                MessageBox.Show("Connessione al database fallita!");
            }
        }

        private void login_Click(object sender, EventArgs e)
        {
            string username = loginEmail.Text;
            string password = loginPassword.Text;

            string query = "SELECT * FROM filmDB_Users WHERE Username = @username AND Password = @password";

            using (var conn = db.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            MessageBox.Show("Login effettuato con successo!");
                            // Passa alla finestra principale
                            MainForm mainForm = new MainForm();
                            this.Hide();
                            mainForm.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Credenziali errate!");
                        }
                    }
                }
            }
        }

        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.ShowDialog();
        }
    }
}
