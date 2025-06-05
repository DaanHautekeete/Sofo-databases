using extraOefeningBrouwerij.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace extraOefeningBrouwerij.DA
{
    public class brouwerijDA
    {
        public static List<Model.brouwerij> OphalenBrouwerijen()
        {
            //lege lijst maken
            List<Model.brouwerij> brouwerijen = new List<Model.brouwerij>();

            MySqlConnection conn = Helper.database.Maakverbinding();

            //query aanmaken
            string query = "SELECT * FROM brouwerij";
            MySqlCommand cmd = new MySqlCommand(query, conn);

            //reader aanmaken
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                brouwerijen.Add(Create(reader));
            }

            //reader sluiten
            reader.Close();
            conn.Close();
            return brouwerijen;
        }

        public static brouwerij Create(IDataRecord record )
        {
            return new brouwerij()
            {
                id = Convert.ToInt16(record["id"]),
                Name = record["Name"].ToString(),
                Email = record["Email"].ToString(),
                Website = record["Website"].ToString(),
                Description_nl = record["Description_nl"].ToString(),
                Description_en = record["Description_en"].ToString(),
                ImagesURL = record["ImagesURL"].ToString()
            };
        }

        public static void UpdateDescriptions(string ID, string beschrijvingNL, string beschrijvingEN)
        {
            //verbinding maken met DB
            MySqlConnection conn = Helper.database.Maakverbinding();

            //query opstellen
            string query = "UPDATE brouwerij SET Description_nl = @descr_nl, Description_en = @descr_en WHERE id=@idBrouwerij";

            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@descr_nl", beschrijvingNL);
            cmd.Parameters.AddWithValue("@descr_en", beschrijvingEN);
            cmd.Parameters.AddWithValue("@idBrouwerij", ID);


            cmd.ExecuteNonQuery();

            conn.Close();
        }
    }
}
