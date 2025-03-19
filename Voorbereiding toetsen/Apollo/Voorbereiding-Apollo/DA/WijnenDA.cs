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

        public static void WijzigWijn(string OudCode, Model.Wijnen wijn)
        {
            //connection maken met DB
            MySqlConnection conn = Helper.Database.Maakverbinding();

            //query opstellen
            string query = "UPDATE `tblwijnen` SET `Code`=@code,`Jaar`=@jaar,`Naam`=@naam,`Omschrijving`=@omschrijving,`Groepsnummer`=@groepsnummer,`Inhoud`=@inhoud,`PrijsPerFles`= @ppf,`HoeveelheidPerVerpakking`=@hoeveelheidperverpakking,`Voorraad`=@voorraad,`InBestelling`=@inbestelling,`Bestelpunt`=@bestelpunt,`UitAssortiment`=@uitassortiment,`Leveranciersnummer`=@leveranciersnummer,`foto`=@foto WHERE `Code`=@oudeCode";

            //commando opstellen
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.CommandType = CommandType.Text;

            //parameters toevoegen
            cmd.Parameters.AddWithValue("@code", wijn.Code);
            cmd.Parameters.AddWithValue("@jaar", wijn.Jaar);
            cmd.Parameters.AddWithValue("@naam", wijn.Naam);
            cmd.Parameters.AddWithValue("@omschrijving", wijn.Omschrijving);
            cmd.Parameters.AddWithValue("@groepsnummer", wijn.Groepsnummer);
            cmd.Parameters.AddWithValue("@inhoud", wijn.Inhoud);
            cmd.Parameters.AddWithValue("@ppf", wijn.PrijsPerFles);
            cmd.Parameters.AddWithValue("@hoeveelheidperverpakking", wijn.HoeveelheidPerVerpakking);
            cmd.Parameters.AddWithValue("@voorraad", wijn.Voorraad);
            cmd.Parameters.AddWithValue("@inbestelling", wijn.InBestelling);
            cmd.Parameters.AddWithValue("@bestelpunt", wijn.Bestelpunt);
            cmd.Parameters.AddWithValue("@uitassortiment", wijn.UitAssortiment);
            cmd.Parameters.AddWithValue("@leveranciersnummer", wijn.LeveranciersNummer);
            cmd.Parameters.AddWithValue("@foto", wijn.Foto);
            cmd.Parameters.AddWithValue("@oudeCode", OudCode);

            //commando uitvoeren
            cmd.ExecuteNonQuery();

            //connectie sluiten
            conn.Close();
        }

        public static void VoegWijnToe(Model.Wijnen wijn)
        {
            //connection maken met DB
            MySqlConnection conn = Helper.Database.Maakverbinding();

            //query opstellen
            string query = "INSERT INTO `tblwijnen`(`Code`, `Jaar`, `Naam`, `Omschrijving`, `Groepsnummer`, `Inhoud`, `PrijsPerFles`, `HoeveelheidPerVerpakking`, `Voorraad`, `InBestelling`, `Bestelpunt`, `UitAssortiment`, `Leveranciersnummer`, `foto`) VALUES (@code,@jaar,@naam,@omschrijving,@groepsnummer,@inhoud,@ppf,@hoeveelheidperverpakking,@voorraad,@inbestelling,@bestelpunt,@uitassortiment,@leveranciersnummer,@foto)";

            //commando opstellen
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.CommandType = CommandType.Text;

            //parameters toevoegen
            cmd.Parameters.AddWithValue("@code", wijn.Code);
            cmd.Parameters.AddWithValue("@jaar", wijn.Jaar);
            cmd.Parameters.AddWithValue("@naam", wijn.Naam);
            cmd.Parameters.AddWithValue("@omschrijving", wijn.Omschrijving);
            cmd.Parameters.AddWithValue("@groepsnummer", wijn.Groepsnummer);
            cmd.Parameters.AddWithValue("@inhoud", wijn.Inhoud);
            cmd.Parameters.AddWithValue("@ppf", wijn.PrijsPerFles);
            cmd.Parameters.AddWithValue("@hoeveelheidperverpakking", wijn.HoeveelheidPerVerpakking);
            cmd.Parameters.AddWithValue("@voorraad", wijn.Voorraad);
            cmd.Parameters.AddWithValue("@inbestelling", wijn.InBestelling);
            cmd.Parameters.AddWithValue("@bestelpunt", wijn.Bestelpunt);
            cmd.Parameters.AddWithValue("@uitassortiment", wijn.UitAssortiment);
            cmd.Parameters.AddWithValue("@leveranciersnummer", wijn.LeveranciersNummer);
            cmd.Parameters.AddWithValue("@foto", wijn.Foto);

            //commando uitvoeren
            cmd.ExecuteNonQuery();

            //connectie sluiten
            conn.Close();
        }

        public static void VerwijderWijn(string code)
        {
            //connection maken met DB
            MySqlConnection conn = Helper.Database.Maakverbinding();

            //query opstellen
            string query = "DELETE FROM `tblwijnen` WHERE Code = @code";

            //commando opstellen
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.CommandType = CommandType.Text;

            //parameters toevoegen
            cmd.Parameters.AddWithValue("@code", code);

            //commando uitvoeren
            cmd.ExecuteNonQuery();

            //connectie sluiten
            conn.Close();
        }
    }
}
