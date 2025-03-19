using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voorbereiding_Apollo.DA
{
    public class WijnenDA
    {
        //methode om alle wijnen op te halen
        public static List<Model.Wijnen> OphalenWijnen(string LeveranciersNummer)
        {
            //nieuwe lijst aanmaken
            List<Model.Wijnen> wijnen = new List<Model.Wijnen>();

            //connection maken met DB
            MySqlConnection conn = Helper.Database.Maakverbinding();

            //query opstellen
            string query = "Select * from tblwijnen where leveranciersnummer = @leveranciersnummer";

            //commando opstellen
            MySqlCommand cmd = new MySqlCommand(query, conn);
            
            //parameter toevoegen
            cmd.Parameters.AddWithValue("@leveranciersnummer", LeveranciersNummer);

            //reader aanmaken
            MySqlDataReader reader = cmd.ExecuteReader();

            while(reader.Read())
            {
                wijnen.Add(createWijn(reader));
            }

            reader.Close();
            conn.Close();

            return wijnen;
        }

        //methode om een wijn toe te voegen
        public static Model.Wijnen createWijn(IDataRecord record)
        {
            return new Model.Wijnen()
            {
                Code = record["code"].ToString(),
                Jaar = record["jaar"].ToString(),
                Naam = record["naam"].ToString(),
                Omschrijving = record["omschrijving"].ToString(),
                Groepsnummer = Convert.ToInt16(record["groepsnummer"]),
                Inhoud = record["inhoud"].ToString(),
                PrijsPerFles = Convert.ToDouble(record["prijsperfles"]),
                HoeveelheidPerVerpakking = Convert.ToInt16(record["hoeveelheidperverpakking"]),
                Voorraad = Convert.ToInt16(record["voorraad"]),
                InBestelling = Convert.ToInt16(record["inbestelling"]),
                Bestelpunt = Convert.ToInt16(record["bestelpunt"]),
                UitAssortiment = Convert.ToInt16(record["uitassortiment"]),
                LeveranciersNummer = Convert.ToInt16(record["leveranciersnummer"]),
                Foto = record["foto"].ToString()
            };
        }
    }
}
