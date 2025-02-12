using prjApollo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.CRUD;
using System.Data;

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


    }
}
