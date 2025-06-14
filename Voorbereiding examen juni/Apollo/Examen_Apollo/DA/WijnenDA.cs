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

        public static void VoegWijnToe(Wijnen wijn)
        {
            //connectie maken met DB
            MySqlConnection conn = Database.Maakverbinding();

            //query opmaken
            string query = "INSERT INTO `tblwijnen`(`Code`, `Jaar`, `Naam`, `Omschrijving`, `Groepsnummer`, `Inhoud`, `PrijsPerFles`, `HoeveelheidPerVerpakking`, `Voorraad`, `InBestelling`, `Bestelpunt`, `UitAssortiment`, `Leveranciersnummer`, `foto`) VALUES (@code,@jaar,@naam,@omschrijving,@groepsnummer,@inhoud,@ppf,@hoeveelheidPerVerpakking,@voorraad,@inBestelling,@bestelpunt,@uitAssortiment,@leveranciersnummer,@foto)";

            //commando opmaken
            MySqlCommand cmd = new MySqlCommand(query, conn);

            //parameters instellen
            cmd.Parameters.AddWithValue("@code", wijn.Code);
            cmd.Parameters.AddWithValue("@jaar", wijn.Jaar);
            cmd.Parameters.AddWithValue("@naam", wijn.Naam);
            cmd.Parameters.AddWithValue("@omschrijving", wijn.Omschrijving);
            cmd.Parameters.AddWithValue("@groepsnummer", wijn.Groepsnummer);
            cmd.Parameters.AddWithValue("@inhoud", wijn.Inhoud);
            cmd.Parameters.AddWithValue("@ppf", wijn.PrijsPerFles);
            cmd.Parameters.AddWithValue("@hoeveelheidPerVerpakking", wijn.HoeveelheidPerVerpakking);
            cmd.Parameters.AddWithValue("@voorraad", wijn.Voorraad);
            cmd.Parameters.AddWithValue("@inBestelling", wijn.InBestelling);
            cmd.Parameters.AddWithValue("@bestelpunt", wijn.Bestelpunt);
            cmd.Parameters.AddWithValue("@uitAssortiment", wijn.UitAssortiment);
            cmd.Parameters.AddWithValue("@leveranciersnummer", wijn.Leveranciersnummer);
            cmd.Parameters.AddWithValue("@foto", wijn.foto);

            //commando uitvoeren
            cmd.ExecuteNonQuery();

            //connectie sluiten
            conn.Close();
        }

        public static void VerwijderWijn(Wijnen wijn)
        {
            //connectie maken met DB
            MySqlConnection conn = Database.Maakverbinding();

            //query opmaken
            string query = "DELETE FROM tblwijnen WHERE Code = @code";

            //commando opmaken
            MySqlCommand cmd = new MySqlCommand(query, conn);

            //parameters instellen
            cmd.Parameters.AddWithValue("@code", wijn.Code);

            //commando uitvoeren
            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public static void WijzigWijn(Wijnen wijn, string oudeCode)
        {
            //connectie maken met DB
            MySqlConnection conn = Database.Maakverbinding();

            //query maken
            string query = "UPDATE `tblwijnen` SET `Code`=@nieuweCode,`Jaar`=@jaar,`Naam`=@naam,`Omschrijving`=@omschrijving,`Groepsnummer`=@groepsnummer,`Inhoud`=@inhoud,`PrijsPerFles`=@ppf,`HoeveelheidPerVerpakking`=@hoeveelheidPerverpakking,`Voorraad`=@voorraad,`InBestelling`=@inBestelling,`Bestelpunt`=@bestelpunt,`UitAssortiment`=@uitAssortiment,`Leveranciersnummer`=@leveranciersnummer,`foto`=@foto WHERE code = @oudeCode";

            //commando opmaken
            MySqlCommand cmd = new MySqlCommand(query, conn);

            //parameters instellen
            cmd.Parameters.AddWithValue("@nieuweCode", wijn.Code);
            cmd.Parameters.AddWithValue("@jaar", wijn.Jaar);
            cmd.Parameters.AddWithValue("@naam", wijn.Naam);
            cmd.Parameters.AddWithValue("@omschrijving", wijn.Omschrijving);
            cmd.Parameters.AddWithValue("@groepsnummer", wijn.Groepsnummer);
            cmd.Parameters.AddWithValue("@inhoud", wijn.Inhoud);
            cmd.Parameters.AddWithValue("@ppf", wijn.PrijsPerFles);
            cmd.Parameters.AddWithValue("@hoeveelheidPerverpakking", wijn.HoeveelheidPerVerpakking);
            cmd.Parameters.AddWithValue("@voorraad", wijn.Voorraad);
            cmd.Parameters.AddWithValue("@inBestelling", wijn.InBestelling);
            cmd.Parameters.AddWithValue("@bestelpunt", wijn.Bestelpunt);
            cmd.Parameters.AddWithValue("@uitAssortiment", wijn.UitAssortiment);
            cmd.Parameters.AddWithValue("@leveranciersnummer", wijn.Leveranciersnummer);
            cmd.Parameters.AddWithValue("@foto", wijn.foto);
            cmd.Parameters.AddWithValue("@oudeCode", oudeCode);

            //commando uitvoeren
            cmd.ExecuteNonQuery();

            conn.Close();
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
