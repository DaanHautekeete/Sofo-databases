using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace extraOefeningBrouwerij.Helper
{
    public class database
    {
        public static MySqlConnection Maakverbinding()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();

            builder.Server = "localhost";
            builder.Database = "brouwerijdb";
            builder.UserID = "root";
            builder.Password = "usbw";
            builder.Port = 3307;
            builder.AllowZeroDateTime = true;
            builder.ConnectionTimeout = 60;

            MySqlConnection conn = new MySqlConnection(builder.ConnectionString);
            conn.Open();
            return conn;

        }
    }
}
