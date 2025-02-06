using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using prjBrouwerij.Helper;
using prjBrouwerij.Model;

namespace prjBrouwerij.DA
{
    //public maken
    public class BierDA
    {
        //list: object die je vult met andere objecten die uit je model komen: is meestal onzichtbaar
        //brouwerijen opaheln: tekst zien (brouwerijnamen als tekst) -> 1 veld --> string
        public static List<string> BrouwerijenOphalen()
        {
            //alle brouweren in de listbox steken
            List<string> brouwerijen = new List<string>();
            //in de list steken we alle UNIEKE brouwerijen

            //query maken
            string query = "SELECT DISTINCT brouwerij FROM bier ORDER by brouwerij ASC";

            //connectie maken
            MySqlConnection conn = Database.MaakVerbinding();

            //commando maken
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.CommandText = query;

            //commando uitvoeren
            //execute reader: lezen van meerdere waarden => datareader nodig hebben
            //execute non query: insert, update, delete (=gegevens aanpassen)
            //execute scalar: 1 waarde teruggeven

            MySqlDataReader dataReader = cmd.ExecuteReader();

            //vanuit reader in list steken
            while (dataReader.Read())
            {
                brouwerijen.Add(dataReader["brouwerij"].ToString());
            }

            dataReader.Close();
            Database.SluitVerbinding(conn);

            return brouwerijen;
        }


        public static List<Bier> ophalenBieren (string Brouwerij)
        {
            //je geeft een parameter mee om de bieren van die geselecteerde brouwerij op te vragen
            List<Bier> Bieren = new List<Bier>();

            //welke sql code hebben we nodig om de gegevens op te vragen
            string query = "SELECT * FROM bier WHERE brouwerij = @brouwerij";

            //connectie maken
            MySqlConnection conn = Database.MaakVerbinding();

            //commando opmaken 
            MySqlCommand cmd = new MySqlCommand(query, conn);

            //parameter toevoegen
            cmd.Parameters.AddWithValue("@brouwerij", Brouwerij);
            cmd.CommandType = System.Data.CommandType.Text;

            //Reader nodig om de gegevens te lezen want het zijn meerdere gegevens
            MySqlDataReader reader = cmd.ExecuteReader();


            //reader in onze list steken --> ieder item als een object
            //IDatarecord gebruiken
            while (reader.Read())
            {
                Bieren.Add(Create(reader));
            }

            reader.Close();
            conn.Close();

            return Bieren;

        }

        public static Bier Create(IDataRecord record)
        {
            return new Bier()
            {
                Biernaam = record["biernaam"].ToString(),
                Brouwerij = record["brouwerij"].ToString(),
                Kleur = record["kleur"].ToString(),
                Alcohol = Convert.ToDecimal(record["alcohol"])
            }; 
        }

        //bier kunnen verwijderen
        public static void VerwijderBier(Bier bier)
        {
            //verbinding maken
            MySqlConnection conn = Database.MaakVerbinding();

            //query aanmaken
            string query = "Delete from bier where biernaam = @biernaam";

            //commando opmaken
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.CommandType= System.Data.CommandType.Text;


            //parameters toevoegen
            cmd.Parameters.AddWithValue("@biernaam", bier.Biernaam);

            //commando uitvoeren
            cmd.ExecuteNonQuery();

            conn.Close();

        }

        public static void VoegBierToe(Bier bier)
        {
            //verbinding maken
            MySqlConnection conn = Database.MaakVerbinding();

            //query aanmaken
            string query = "INSERT INTO `bier` ( `biernaam` , `brouwerij` , `kleur` , `alcohol` ) VALUES (@biernaam, @brouwerij, @kleur, @alcohol)";

            //commando opmaken
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.CommandType = System.Data.CommandType.Text;


            //parameters toevoegen
            cmd.Parameters.AddWithValue("@biernaam", bier.Biernaam);
            cmd.Parameters.AddWithValue("@brouwerij", bier.Brouwerij);
            cmd.Parameters.AddWithValue("@kleur", bier.Kleur);
            cmd.Parameters.AddWithValue("@alcohol", bier.Alcohol);

            //commando uitvoeren
            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public static void PasBierAan(Bier bier, string strOudeBiernaam)
        {
            //verbinding maken
            MySqlConnection conn = Database.MaakVerbinding();

            //query aanmaken
            string query = "UPDATE `bier` SET `biernaam` = @biernaam, `brouwerij` = @brouwerij, `kleur` = @kleur, `alcohol` = @alcohol  WHERE `biernaam` = @OudeBiernaam";

            //commando opmaken
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.CommandType = System.Data.CommandType.Text;

            //parameters toevoegen
            cmd.Parameters.AddWithValue("@biernaam", bier.Biernaam);
            cmd.Parameters.AddWithValue("@brouwerij", bier.Brouwerij);
            cmd.Parameters.AddWithValue("@kleur", bier.Kleur);
            cmd.Parameters.AddWithValue("@alcohol", bier.Alcohol);
            cmd.Parameters.AddWithValue("@OudeBiernaam", strOudeBiernaam);

            //commando uitvoeren
            cmd.ExecuteNonQuery();

            conn.Close();
        }
    }
}
