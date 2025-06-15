using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace Examen_login.Helper
{
    public class Database
    {
        public static MySqlConnection MaakVerbinding()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder()
            {
                Server = "localhost",
                UserID = "root",
                Password = "usbw",
                Port = 3307,
                Database = "login",
                AllowZeroDateTime = true,
                ConnectionTimeout = 60
            };

            MySqlConnection conn = new MySqlConnection(builder.ConnectionString);
            conn.Open();

            return conn;
        }
    }
}
