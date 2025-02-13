using MySql.Data.MySqlClient;
using prjApollo.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjApollo.DA
{
    public class WijnenDA
    {
        public static List<Wijnen> OphalenWijnen(string Leveranciersnummer)
        {
            //nieuwe lijst aanmaken
            List<Wijnen> Wijnen = new List<Wijnen>();

            //nieuwe connectie aanmaken
            MySqlConnection conn = Helper.Database.Maakverbinding();

            //query aanmaken
            string query = "SELECT `Code` , `Jaar` , `Naam` , `Omschrijving` , `Inhoud` , `PrijsPerFles` , `HoeveelheidPerVerpakking` , `Voorraad`\r\nFROM tblwijnen, tblleveranciers WHERE (@leveranciernummer = tblwijnen.leveranciersnummer = tblleveranciers.leveranciernummer)";

            //commande maken
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@leveranciernummer", Leveranciersnummer);
            //reader aanmaken
            MySqlDataReader dataReader = cmd.ExecuteReader();

            //idatarecord gebruiken
            while (dataReader.Read())
            {
                Wijnen.Add(CreateWijnen(dataReader));
            }

            dataReader.Close();
            conn.Close();

            return Wijnen;
        }

        public static Wijnen CreateWijnen(IDataRecord record)
        {
            return new Wijnen()
            {
                Code = record["code"].ToString(),
                Jaar = record["jaar"].ToString(),
                Omschrijving = record["omschrijving"].ToString(),
                Inhoud = record["inhoud"].ToString(),
                PrijsPerFles = Convert.ToDouble(record["prijsperfles"]),
                HoeveelheidPerVerpakking = Convert.ToInt16(record["hoeveelheidperverpakking"]),
                Voorraad = Convert.ToInt16(record["voorraad"]),
            };
        }
    }
}
