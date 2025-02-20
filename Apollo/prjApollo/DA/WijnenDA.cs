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
            string query = "SELECT * FROM tblwijnen, tblleveranciers WHERE (@leveranciernummer = tblwijnen.leveranciersnummer = tblleveranciers.leveranciernummer)";

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
                Leveranciersnummer = Convert.ToInt16(record["leveranciersnummer"]),
                Foto = record["foto"].ToString()
            };
        }

        public static void ToevoegenWijn(Wijnen wijn)
        {
            //connectie maken
            MySqlConnection conn = Helper.Database.Maakverbinding();

            //query opstellen
            string query = "INSERT INTO `tblwijnen`(`Code`, `Jaar`, `Naam`, `Omschrijving`, `Groepsnummer`, `Inhoud`, `PrijsPerFles`, `HoeveelheidPerVerpakking`, `Voorraad`, `InBestelling`, `Bestelpunt`, `UitAssortiment`, `Leveranciersnummer`, `foto`) VALUES (@code,@jaar,@naam,@omschrijving,@groepsnummer,@inhoud,@prijsPerFles,@HoeveelheidPerVerpakking,@voorraad,@inbestelling,@bestelpunt,@uitAssortiment,@leveranciersNummer,@foto)";

            //commando maken
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.CommandType = CommandType.Text;

            //parameters toevoegen
            cmd.Parameters.AddWithValue("@code", wijn.Code);
            cmd.Parameters.AddWithValue("@jaar", wijn.Jaar);
            cmd.Parameters.AddWithValue("@naam", wijn.Naam);
            cmd.Parameters.AddWithValue("@omschrijving", wijn.Omschrijving);
            cmd.Parameters.AddWithValue("@groepsnummer", wijn.Groepsnummer);
            cmd.Parameters.AddWithValue("@inhoud", wijn.Inhoud);
            cmd.Parameters.AddWithValue("@prijsPerFles", wijn.PrijsPerFles);
            cmd.Parameters.AddWithValue("@HoeveelheidPerVerpakking", wijn.HoeveelheidPerVerpakking);
            cmd.Parameters.AddWithValue("@voorraad", wijn.Voorraad);
            cmd.Parameters.AddWithValue("@inbestelling", wijn.InBestelling);
            cmd.Parameters.AddWithValue("@bestelpunt", wijn.Bestelpunt);
            cmd.Parameters.AddWithValue("@uitAssortiment", wijn.UitAssortiment);
            cmd.Parameters.AddWithValue("@leveranciersNummer", wijn.Leveranciersnummer);
            cmd.Parameters.AddWithValue("@foto", wijn.Foto);

            //commando uitvoeren
            cmd.ExecuteNonQuery();

            //connectie sluiten
            conn.Close();

        }
    }
}
