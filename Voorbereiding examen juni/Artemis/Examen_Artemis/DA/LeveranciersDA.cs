using Examen_Artemis.Helper;
using Examen_Artemis.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_Artemis.DA
{
    public class LeveranciersDA
    {
        //functie om alle leveranciers op te halen
        public static List<Leveranciers> LeveranciersOphalen()
        {
            //lijst opstellen
            List<Leveranciers> leveranciers = new List<Leveranciers>();

            //connectie maken met DB 
            MySqlConnection conn = Database.Maakverbinding();

            //query opstellen
            string query = "SELECT * FROM tblleveranciers";

            //commando opstellen
            MySqlCommand cmd = new MySqlCommand(query, conn);

            //commando uitvoeren
            MySqlDataReader reader = cmd.ExecuteReader();

            while(reader.Read())
            {
                leveranciers.Add(Create(reader));
            }

            reader.Close();
            conn.Close();
            return leveranciers; 
        }

        //functie om een leverancier toe te voegen
        public static void LeverancierToevoegen(Leveranciers leverancier)
        {
            //connectie maken met DB
            MySqlConnection conn = Database.Maakverbinding();

            //query opstellen
            string query = "INSERT INTO tblleveranciers (Bedrijf, Adres, Plaats, Postcode, Land, URL) VALUES (@bedrijf, @adres, @plaats, @postcode, @land, @url)";

            //commando opstellen 
            MySqlCommand cmd = new MySqlCommand(query, conn);

            //parameters instellen

            cmd.Parameters.AddWithValue("@bedrijf", leverancier.Bedrijf);
            cmd.Parameters.AddWithValue("@adres", leverancier.Adres);
            cmd.Parameters.AddWithValue("@plaats", leverancier.Plaats);
            cmd.Parameters.AddWithValue("@postcode", leverancier.Postcode);
            cmd.Parameters.AddWithValue("@land", leverancier.Land);
            cmd.Parameters.AddWithValue("@url", leverancier.URL);

            //commando uitvoeren
            cmd.ExecuteNonQuery();

            //connectie sluiten
            conn.Close();
        }

        public static Leveranciers Create(IDataRecord record)
        {
            return new Leveranciers
            {
                Leveranciersnummer = Convert.ToInt16(record["Leveranciersnummer"]),
                Bedrijf = record["Bedrijf"].ToString(),
                Adres = record["Adres"].ToString(),
                Plaats = record["Plaats"].ToString(),
                Postcode = record["Postcode"].ToString(),
                Land = record["Land"].ToString(),
                URL = record["URL"].ToString()
            };
        }
    }
}
