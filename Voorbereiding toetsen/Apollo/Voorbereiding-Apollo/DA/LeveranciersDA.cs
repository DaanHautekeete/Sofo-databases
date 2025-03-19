using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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


        //methode om een leverancier te wijzigen
        public static void WijzigLeverenancier(string OudLeveranciersnummer, Model.Leverancier leverancier)
        {
            //connectie maken met DB
            MySqlConnection conn = Helper.Database.Maakverbinding();

            //query opstellen
            string query = "UPDATE `tblleveranciers` SET `leveranciernummer`=@leveranciersnummer,`firmanaam`=@firmanaam,`adres`=@adres,`postnr`=@postnr,`gemeente`=@gemeente WHERE leveranciernummer = @oudLeveranciersnummer";

            //commando opstellen
            MySqlCommand cmd = new MySqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@leveranciersnummer", leverancier.LeverancierNummer);
            cmd.Parameters.AddWithValue("@firmanaam", leverancier.FirmaNaam);
            cmd.Parameters.AddWithValue("@adres", leverancier.Adres);
            cmd.Parameters.AddWithValue("@postnr", leverancier.Postnr);
            cmd.Parameters.AddWithValue("@gemeente", leverancier.Gemeente);
            cmd.Parameters.AddWithValue("@oudLeveranciersnummer", OudLeveranciersnummer);

            //commando uitvoeren
            cmd.ExecuteNonQuery();
        }

        //methode om een leverancier toe te voegen
        public static void VoegLeverancierToe(Model.Leverancier leverancier)
        {
            //connectie maken met DB
            MySqlConnection conn = Helper.Database.Maakverbinding();

            //query opstellen
            string query = "INSERT INTO `tblleveranciers`(`leveranciernummer`, `firmanaam`, `adres`, `postnr`, `gemeente`) VALUES (@leveranciersnummer,@firmanaam,@adres,@postnr,@gemeente)";

            //commando opstellen
            MySqlCommand cmd = new MySqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@leveranciersnummer", leverancier.LeverancierNummer);
            cmd.Parameters.AddWithValue("@firmanaam", leverancier.FirmaNaam);
            cmd.Parameters.AddWithValue("@adres", leverancier.Adres);
            cmd.Parameters.AddWithValue("@postnr", leverancier.Postnr);
            cmd.Parameters.AddWithValue("@gemeente", leverancier.Gemeente);

            //commando uitvoeren
            cmd.ExecuteNonQuery();
        }

        public static void VerwijderLeverancier(string leveranciersnummer)
        {
            //connectie maken met DB
            MySqlConnection conn = Helper.Database.Maakverbinding();
            
            //query opstellen
            string query = "DELETE FROM `tblleveranciers` WHERE leveranciernummer = @leveranciernummer";
            
            //commando opstellen
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@leveranciernummer", leveranciersnummer);
            
            //commando uitvoeren
            cmd.ExecuteNonQuery();
        }
    }
}
