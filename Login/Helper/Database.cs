using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//stap 3: toevoegen!!!
using MySql.Data.MySqlClient;



namespace Login.Helper
{
    //eerste stap: klasse publiek maken (public ipv internal)
    //tweede stap: wij gaan moeten kunnen werken met sql
    //bibliotheek nodig om er te kunnen mee werken.
    //moet je toevoegen --> References (mysql.data.dll)
    //derde stap: bovenaan plaatsen die reference om hem makkelijk te 
    //kunnen gebruiken
    public class Database
    {
        //vierde stap: in de klasse Database gaan we verbinding leggen
        //met onze databank --> Mysqlconnection
        public static MySqlConnection MaakVerbinding()
        {
            //twee dingen voor nodig
            //1.connectionstringbuilder maken om alle eigenschappen
            //aan te geven
            //2.connection maken
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder
            {
                //eigenschappen instellen
                Server = "localhost",
                Database = "login",
                UserID = "root",
                Password = "usbw",
                Port = 3307,
                ConnectionTimeout = 60,
                AllowZeroDateTime = true
            };
            //eigenlijke connectie maken
            MySqlConnection conn = new MySqlConnection(builder.ConnectionString);
            conn.Open();
            return conn;

        }
    }
}
