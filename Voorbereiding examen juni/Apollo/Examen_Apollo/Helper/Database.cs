using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Examen_Apollo.Helper
{
    public class Database
    {
        public static MySqlConnection Maakverbinding()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Password = "usbw";
            builder.Database = "apollosql";
            builder.AllowZeroDateTime = true;
            builder.ConnectionTimeout = 60;
            builder.Port = 3307;
            MySqlConnection conn = new MySqlConnection(builder.ToString());

            conn.Open();
            return conn;
        }
    }
}
