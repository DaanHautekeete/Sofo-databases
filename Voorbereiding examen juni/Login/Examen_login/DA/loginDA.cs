using Examen_login.Helper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_login.DA
{
    public class loginDA
    {
        //functie om te controleren of inloggegevens kloppen
        public static bool checkLogin(string username, string password)
        {
            //connectie maken met db
            MySqlConnection conn = Database.MaakVerbinding();

            //query opstellen
            string query = "SELECT COUNT(*) FROM tbllogin WHERE username = @username AND password = @password";

            //commando opstellen
            MySqlCommand cmd = new MySqlCommand(query, conn);

            //parameters toevoegen
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);

            //uitvoeren
            int aantal = Convert.ToInt16(cmd.ExecuteScalar());

            if(aantal == 1)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Er is geen account gevonden met deze gegevens", "foutieve gegevens", MessageBoxButtons.OK);
                return false;
            }
        }

        public static bool CheckUsername(string username)
        {
            MySqlConnection conn = Database.MaakVerbinding();
            string query = "SELECT COUNT(*) FROM tbllogin WHERE username = @username";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@username", username);
            int aantal = Convert.ToInt16(cmd.ExecuteScalar());
            if (aantal == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void AddUser(string username, string password)
        {
            MySqlConnection conn = Database.MaakVerbinding();
            string query = "INSERT INTO tbllogin (username, password) VALUES (@username, @password)";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);
            cmd.ExecuteNonQuery();
        }
    }
}
