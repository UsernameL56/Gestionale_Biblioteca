using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Gestionale_Biblioteca.Classes
{
    public class Database
    {
        private MySqlConnection connection;
        private string connectionString = "Server=corsilg.altervista.org;Database=my_corsilg;Uid=corsilg;Pwd=;";

        public MySqlConnection GetConnection()
        {
            if (connection == null)
            {
                connection = new MySqlConnection(connectionString);
            }
            return connection;
        }

        public bool TestConnection()
        {
            try
            {
                var conn = GetConnection();
                conn.Open();
                conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore di connessione: " + ex.Message);
                return false;
            }
        }
    }
}
