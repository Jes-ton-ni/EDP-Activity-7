using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace activity3
{
    public class dbConnection
    {
        // Connection string for MySQL
        private static string connectionString = "server=127.0.0.1;uid=root;pwd=0511;database=canteen_db";

        // Method to create and return a new MySqlConnection object
        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}
