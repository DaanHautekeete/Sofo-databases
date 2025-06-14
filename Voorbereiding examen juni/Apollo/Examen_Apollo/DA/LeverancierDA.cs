using Examen_Apollo.Helper;
using Examen_Apollo.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Apollo.DA
{
    public class LeverancierDA
    {
        public static List<Leverancier> OphalenLeveranciers()
        {
            //lijst aanmaken
            List<Leverancier> leveranciers = new List<Leverancier>();

            //connectie maken met DB
            MySqlConnection conn = Database.Maakverbinding();

            //query maken 
            string query = "SELECT * FROM tblleveranciers";

            //commando aanmaken
            MySqlCommand cmd = new MySqlCommand(query, conn);

            //commando uitvoeren
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                //item toevoegen aan lijst
                leveranciers.Add(Create(reader));
            }

            reader.Close();
            conn.Close();
            return leveranciers;

        }

        public static void LeverancierToevoegen(Leverancier leverancier)
        {
            //connectie maken met DB
            MySqlConnection conn = Database.Maakverbinding();

            //query opstellen
            string query = "INSERT INTO tblleveranciers(firmanaam, adres, postnr, gemeente) VALUES (@firmanaam,@adres,@postnr,@gemeente)";

            //commando aanmaken
            MySqlCommand cmd = new MySqlCommand(query, conn);

            //parameters instellen
            cmd.Parameters.AddWithValue("@firmanaam", leverancier.firmanaam);
            cmd.Parameters.AddWithValue("@adres", leverancier.adres);
            cmd.Parameters.AddWithValue("@postnr", leverancier.postnr);
            cmd.Parameters.AddWithValue("@gemeente", leverancier.gemeente);

            //commando uitvoeren
            cmd.ExecuteNonQuery();

            //verbinding sluiten
            conn.Close();
        }

        public static Leverancier Create(IDataRecord record)
        {
            return new Leverancier()
            {
                leveranciernummer = Convert.ToInt16(record["leveranciernummer"]),
                firmanaam = record["firmanaam"].ToString(),
                adres = record["adres"].ToString(),
                postnr = record["postnr"].ToString(),
                gemeente = record["gemeente"].ToString()
            };
        }
    }
}
