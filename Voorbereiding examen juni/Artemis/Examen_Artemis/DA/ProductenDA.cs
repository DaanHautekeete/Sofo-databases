using Examen_Artemis.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using Examen_Artemis.Helper;


namespace Examen_Artemis.DA
{
    public class ProductenDA
    {
        //Functie om alle producten van een leverancier op te halen
        public static List<Producten> ProductenOphalen(int leveranciersnummer)
        {
            //lijst maken
            List<Producten> producten = new List<Producten>();

            //connectie maken met DB
            MySqlConnection conn = Database.Maakverbinding();

            //string opstellen
            string query = "SELECT * FROM tblproducten WHERE Leveranciersnummer = @leveranciersnummer";

            //commando opmaken
            MySqlCommand cmd = new MySqlCommand(query, conn);

            //parameters instellen
            cmd.Parameters.AddWithValue("@leveranciersnummer", leveranciersnummer);

            //commando uitvoeren
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                producten.Add(Create(reader));
            }

            reader.Close();
            conn.Close();
            return producten;
        }

        public static Producten Create(IDataRecord record)
        {
            return new Producten
            {
                Productnummer = Convert.ToInt16(record["Productnummer"]),
                Leveranciersnummer = Convert.ToInt16(record["Leveranciersnummer"]),
                CategorieNummer = Convert.ToInt16(record["CategorieNummer"]),
                ProductNaam = record["ProductNaam"].ToString(),
                NederlandseNaam = record["NederlandseNaam"].ToString(),
                HoeveelheidPerEenheid = record["HoeveelheidPerEenheid"].ToString(),
                PrijsPerEenheid = Convert.ToDecimal(record["PrijsPerEenheid"]),
                Voorraad = Convert.ToInt16(record["Voorraad"]),
                BTWCode = Convert.ToInt16(record["BTWCode"]),
                InBestelling = Convert.ToInt16(record["InBestelling"]),
                Bestelpunt = Convert.ToInt16(record["Bestelpunt"]),
                UitAssortiment = Convert.ToInt16(record["UitAssortiment"])
            };
        }
    }
}
