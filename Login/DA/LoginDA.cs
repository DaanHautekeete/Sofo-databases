using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Login.Helper;
using Login.Model;
using MySql.Data.MySqlClient;



namespace Login.DA
{
    //public ipv internal
    public class LoginDA
    {
        //Model.login ipv Login
        public static bool LoginValidate(Model.Login L)
        {
            bool blnLogin = false;

            //controleren of de gebruikersnaam en wachtwoord die in de tabel zit
            //of die correct zijn --> boolean

            //eerst verbinding maken met de databank
            MySqlConnection conn = Database.MaakVerbinding();

            //we gaan tellen hoeveel records overeen komen met de gebruikersnaam
            //en wachtwoord --> als letterlijke tekst
            String query = "SELECT COUNT(1) from login.tbllogin WHERE Username=@Username and Password=@Password";
            //commando maken
            MySqlCommand sqlCmd = new MySqlCommand(query, conn);
            sqlCmd.CommandType = System.Data.CommandType.Text;
            sqlCmd.Parameters.AddWithValue("@Username", L.Username);
            sqlCmd.Parameters.AddWithValue("@Password", L.Password);

            //nu moeten we nog controleren of de gebruikersnaam en wachtwoord juist zin
            //ofdat als we tellen (zie query) ofdat dat 1 is
            int count  = Convert.ToInt32(sqlCmd.ExecuteScalar());
            //Excutescalar= om je commando uitvoeren als je 1 gegevens uit de databank wil halen
            //Executereader= om je commando uitvoeren als je meerdere gegevens uit de databank wil halen --> datareader
            //ExecuteNonquery= om je commando uitvoeren die aanpassingen doet aan je databank (vb. delete, update, insert,...)

            //controleren wat er zit in die count
            if(count == 1)
            {
                blnLogin = true;
            }
            else
            {
                MessageBox.Show("Gebruikersnaam of wachtwoord is foutief", "Foutieve gegevens");
                blnLogin = false;
            }

            conn.Close();
            return blnLogin;
        }

        public static void Register(Model.Login L)
        {
            //eerst verbinding maken met de databank
            MySqlConnection conn = Database.MaakVerbinding();

            String query = "INSERT INTO login.tbllogin(Username,Password) VALUES (@Username, @Password)";

            //commando maken
            MySqlCommand sqlCmd = new MySqlCommand(query, conn);
            sqlCmd.CommandType = System.Data.CommandType.Text;

            //parameters toevoegen!!!!!
            sqlCmd.Parameters.AddWithValue("@Username", L.Username);
            sqlCmd.Parameters.AddWithValue("@Password", L.Password);

            //commando uitvoeren
            sqlCmd.ExecuteNonQuery();

            MessageBox.Show("Registratie gelukt", "Registratie ok!");
            conn.Close();
        }

        public static void Remove(Model.Login L)
        {
            //eerst verbinding maken met de databank
            MySqlConnection conn = Database.MaakVerbinding();

            String query = "DELETE FROM login.tbllogin WHERE (Username = @Username AND Password = @Password)";

            //commando maken
            MySqlCommand sqlCmd = new MySqlCommand(query, conn);
            sqlCmd.CommandType = System.Data.CommandType.Text;

            //parameters toevoegen!!!!!
            sqlCmd.Parameters.AddWithValue("@Username", L.Username);
            sqlCmd.Parameters.AddWithValue("@Password", L.Password);

            //commando uitvoeren
            sqlCmd.ExecuteNonQuery();

            MessageBox.Show("Gebruiker verwijderd", "Succesvol verwijderd!");
            conn.Close();
        }
    }
}
