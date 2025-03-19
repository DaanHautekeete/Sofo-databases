using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voorbereiding_Apollo.DA
{
    public class LeveranciersDA
    {
        //methode om alle info op te halen van de leveranciers
        public static List<Model.Leverancier> OphalenLeveranciers()
        {
            //nieuwe lijst aanmaken
            List<Model.Leverancier> leveranciers = new List<Model.Leverancier>();

            //connectie aanmaken 
            MySqlConnection conn = Helper.Database.Maakverbinding();

            //query opstellen
            string query = "SELECT * FROM tblleveranciers";

            //commando opstellen
            MySqlCommand cmd = new MySqlCommand(query, conn);

            //reader aanmaken 
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                leveranciers.Add(createLeverancier(reader));
            }

            //reader sluiten
            reader.Close();

            //connectie sluiten
            conn.Close();

            //lijst teruggeven
            return leveranciers;
        }

        //methode om een leverancier toe te voegen
        public static Model.Leverancier createLeverancier(IDataRecord record)
        {
            return new Model.Leverancier()
            {
                LeverancierNummer = (int)record["leveranciernummer"],
                FirmaNaam = (string)record["firmanaam"],
                Adres = (string)record["adres"],
                Postnr = (string)record["postnr"],
                Gemeente = (string)record["gemeente"]
            };
        }
    }
}
