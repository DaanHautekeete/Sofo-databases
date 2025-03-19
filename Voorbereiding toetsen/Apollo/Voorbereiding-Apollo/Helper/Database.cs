using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Voorbereiding_Apollo.Helper
{
    public class Database
    {
        public static MySqlConnection Maakverbinding()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.Database = "apollosql";
            builder.UserID = "root";
            builder.Password = "usbw";
            builder.Port = 3307;
            builder.AllowZeroDateTime = true;
            builder.ConnectionTimeout = 60;

            MySqlConnection conn = new MySqlConnection(builder.ToString());

            conn.Open();

            return conn;
        }

        
    }
}
