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
using Org.BouncyCastle.Crypto.Generators;

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
            string email = loginEmail.Text;
            string password = loginPassword.Text;

            string query = "SELECT Password FROM filmDB_Users WHERE Email = @email";

            using (var conn = db.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@email", email);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string hashedPassword = reader["Password"].ToString();
                            //MessageBox.Show(email);
                            //MessageBox.Show(password);
                            //MessageBox.Show(hashedPassword);
                            if (BCrypt.Net.BCrypt.Verify(password, hashedPassword))
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
                                MessageBox.Show("Password errata!");
                            }
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
