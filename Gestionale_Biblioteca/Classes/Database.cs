using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Gestionale_Biblioteca.Classes
{
    public class Database
    {
        private MySqlConnection connection;
        private string connectionString = "Server=corsilg.mysql.altervista.org;Database=my_corsilg;Uid=corsilg;Pwd=;";

        public MySqlConnection GetConnection()
        {
            if (connection == null)
            {
                connection = new MySqlConnection(connectionString);
            }
            return connection;
        }
    }
}
