using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace prjApollo.Helper
{
    public class Database
    {
        public static MySqlConnection Maakverbinding()
        {
            //string voor de builde rmaken
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();

            //alle eigenschappen van db instellen
            builder.Server = "localhost";
            builder.Database = "apollosql";
            builder.UserID = "root";
            builder.Password = "usbw";
            builder.Port = 3307;
            builder.ConnectionTimeout = 60;
            builder.AllowZeroDateTime = true;

            //nieuwe connectie maken
            MySqlConnection conn = new MySqlConnection(builder.ToString());

            //connectie openen
            conn.Open();

            //connectie teruggeven
            return conn;
        }
    }
}
