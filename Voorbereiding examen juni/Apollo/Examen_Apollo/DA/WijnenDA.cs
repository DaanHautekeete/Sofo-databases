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
    public class WijnenDA
    {
        public static List<Wijnen> OphalenWijnen(int leveranciersnummer)
        {
            List<Wijnen> wijnen = new List<Wijnen>();

            //connectie maken met DB
            MySqlConnection conn = Database.Maakverbinding();
            //query opmaken
            string query = "Select * from tblwijnen where Leveranciersnummer = @leveranciersnummer";

            //commando opmaken
            MySqlCommand cmd = new MySqlCommand(query, conn);

            //parameters instellen
            cmd.Parameters.AddWithValue("@leveranciersnummer", leveranciersnummer);

            //commando uitvoeren
            MySqlDataReader reader = cmd.ExecuteReader();

            while(reader.Read()) {
                wijnen.Add(Create(reader));
            }

            reader.Close();
            conn.Close();
            return wijnen;
        }
        
        public static Wijnen Create(IDataRecord record)
        {
            return new Wijnen()
            {
                Code = record["Code"].ToString(),
                Jaar = record["Jaar"].ToString(),
                Naam = record["Naam"].ToString(),
                Omschrijving = record["Omschrijving"].ToString(),
                Groepsnummer = Convert.ToInt16(record["Groepsnummer"]),
                Inhoud = record["Inhoud"].ToString(),
                PrijsPerFles = Convert.ToDouble(record["PrijsPerFles"]),
                HoeveelheidPerVerpakking = Convert.ToInt16(record["HoeveelheidPerVerpakking"]),
                Voorraad = Convert.ToInt16(record["Voorraad"]),
                InBestelling = Convert.ToInt16(record["InBestelling"]),
                Bestelpunt = Convert.ToInt16(record["Bestelpunt"]),
                UitAssortiment = Convert.ToInt16(record["UitAssortiment"]),
                Leveranciersnummer = Convert.ToInt16(record["Leveranciersnummer"]),
                foto = record["foto"].ToString(),
            };
        }
    }
}
