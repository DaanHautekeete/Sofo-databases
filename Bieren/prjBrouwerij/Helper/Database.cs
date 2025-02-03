using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
//toevoegen
using MySql.Data.MySqlClient;

namespace prjBrouwerij.Helper
{
    //klasse public maken
    public class Database
    {
        //methode schrijven om verbinding met databank te maken
        public static MySqlConnection MaakVerbinding()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();

            builder.Server = "localhost";
            builder.Database = "bierdb";
            builder.UserID = "root";
            builder.Password = "usbw";
            builder.ConnectionTimeout = 60;
            builder.Port = 3307;
            builder.AllowZeroDateTime = true;

            //connectie maken
            MySqlConnection conn = new MySqlConnection(builder.ToString());

            //connectie openen
            conn.Open();

            return conn;
        }

        //closeconnection --> connectie sluiten
        public static void SluitVerbinding(MySqlConnection conn)
        {
            if (conn != null)
            {
                conn.Close();
                conn = null;
            }
        }
    }
}
