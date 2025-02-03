using System;
using System.Collections.Generic;
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
    }
}
