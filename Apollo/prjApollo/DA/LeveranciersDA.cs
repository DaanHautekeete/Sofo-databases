using prjApollo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.CRUD;
using System.Data;
using prjApollo.Helper;

namespace prjApollo.DA
{
    public class LeveranciersDA
    {
        public static List<Leveranciers> OphalenLeveranciers()
        {
            //lege lijst maken van type leveranciers
            List<Leveranciers> leveranciers = new List<Leveranciers>();

            //nieuwe connectie aanmaken
            MySqlConnection conn = Helper.Database.Maakverbinding();

            //query aanmaken
            string query = "SELECT * FROM tblleveranciers";

            //commande maken
            MySqlCommand cmd = new MySqlCommand(query, conn);

            //reader aanmaken
            MySqlDataReader dataReader = cmd.ExecuteReader();

            //idatarecord gebruiken
            while (dataReader.Read())
            {
                leveranciers.Add(Create(dataReader));
            }

            dataReader.Close();
            conn.Close();

            return leveranciers;
        }

        public static Leveranciers Create(IDataRecord record)
        {
            return new Leveranciers()
            {
                Leveranciernummer = Convert.ToInt16(record["leveranciernummer"].ToString()),
                Firmanaam = record["firmanaam"].ToString(),
                Adres = record["adres"].ToString(),
                Postnr = record["postnr"].ToString(),
                Gemeente = record["gemeente"].ToString()
            };

        }


        public static void NewRecord(Leveranciers leverancier)
        {
            //connection maken met db
            MySqlConnection conn = Database.Maakverbinding();

            //query opmaken
            string query = "INSERT INTO `tblleveranciers`(`leveranciernummer`, `firmanaam`, `adres`, `postnr`, `gemeente`) VALUES (@leveranciernummer,@firmanaam, @adres, @postnr,@gemeente)";

            //commando opmaken
            MySqlCommand cmd = new MySqlCommand( query, conn);
            cmd.CommandType = System.Data.CommandType.Text;

            //parameters toevoegen
            cmd.Parameters.AddWithValue("@leveranciernummer", leverancier.Leveranciernummer);
            cmd.Parameters.AddWithValue("@firmanaam", leverancier.Firmanaam);
            cmd.Parameters.AddWithValue("@adres", leverancier.Adres);
            cmd.Parameters.AddWithValue("@postnr", leverancier.Postnr);
            cmd.Parameters.AddWithValue("@gemeente", leverancier.Gemeente);

            //commando uitvoeren
            cmd.ExecuteNonQuery();

            conn.Close();

        }

        public static void RemoveRecord(Leveranciers leveranciers)
        {
            //connectie maken 
            MySqlConnection conn = Database.Maakverbinding();

            //query opstellen
            string query = "DELETE FROM `tblleveranciers` WHERE leveranciernummer = @leveranciernummer";

            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.CommandType = System.Data.CommandType.Text;

            cmd.Parameters.AddWithValue("@leveranciernummer", leveranciers.Leveranciernummer);

            //commando uitvoeren
            cmd.ExecuteNonQuery ();

            conn.Close();
        }

        public static void EditRecord(Leveranciers leveranciers, string oudLeveranciersnummer)
        {
            //connectie maken 
            MySqlConnection conn = Database.Maakverbinding();

            //query opstellen
            string query = "UPDATE `tblleveranciers` SET `leveranciernummer`=@leveranciersnummer,`firmanaam`=@firmaNaam,`adres`=@adres,`postnr`=@postnr,`gemeente`=@gemeente WHERE leveranciernummer = @oudleveranciersnummer";

            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.CommandType = System.Data.CommandType.Text;

            cmd.Parameters.AddWithValue("@leveranciersnummer", leveranciers.Leveranciernummer);
            cmd.Parameters.AddWithValue("@firmaNaam", leveranciers.Firmanaam);
            cmd.Parameters.AddWithValue("@adres", leveranciers.Adres);
            cmd.Parameters.AddWithValue("@postnr", leveranciers.Postnr);
            cmd.Parameters.AddWithValue("@gemeente", leveranciers.Gemeente);
            cmd.Parameters.AddWithValue("@oudleveranciersnummer", oudLeveranciersnummer);

            //commando uitvoeren
            cmd.ExecuteNonQuery();

            conn.Close();
        }
    }
}
