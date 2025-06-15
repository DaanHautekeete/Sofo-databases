using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Examen_Artemis.Helper
{
    public class Database
    {
        public static MySqlConnection Maakverbinding()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder()
            {
                Server = "localhost",
                UserID = "root",
                Password = "usbw", 
                Database = "artemissql",
                AllowZeroDateTime = true,
                ConnectionTimeout = 60,
                Port = 3307
            };
            MySqlConnection conn = new MySqlConnection(builder.ConnectionString);
            conn.Open();
            return conn;
        }
    }
}
