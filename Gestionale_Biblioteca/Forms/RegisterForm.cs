using Gestionale_Biblioteca.Classes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Gestionale_Biblioteca.Forms
{
    public partial class RegisterForm : Form
    {
        private Database db = new Database();
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void register_Click(object sender, EventArgs e)
        {
            string nome = nomeRegister.Text;
            string cognome = cognomeRegister.Text;
            string email = emailRegister.Text;
            string password = passwordRegister.Text;

            if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(cognome) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Compila tutti i campi!");
                return;
            }

            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);
            string query = "INSERT INTO filmDB_Users (Nome, Cognome, Email, Password) VALUES (@nome, @cognome, @email, @password)";

            using (var conn = db.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nome", nome);
                    cmd.Parameters.AddWithValue("@cognome", cognome);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@password", password);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Registrazione completata!");
                        this.Close(); // Chiude il form di registrazione
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Errore: " + ex.Message);
                    }
                }
            }
        }
    }
}
