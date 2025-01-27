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

            //nu moeten we nog controleren of de gebruikersnaam en wachtwoord juist zijn
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

            //we gaan tellen hoeveel records overeen komen met de gebruikersnaam
            //en wachtwoord --> als letterlijke tekst
            String query = "SELECT COUNT(1) from login.tbllogin WHERE Username=@Username";

            //commando maken
            MySqlCommand sqlCmdCheckUsers = new MySqlCommand(query, conn);
            sqlCmdCheckUsers.CommandType = System.Data.CommandType.Text;
            sqlCmdCheckUsers.Parameters.AddWithValue("@Username", L.Username);


            int count = Convert.ToInt32(sqlCmdCheckUsers.ExecuteScalar());

            if(count != 1)
            {

                String queryInsert = "INSERT INTO login.tbllogin(Username,Password) VALUES (@Username, @Password)";

                //commando maken
                MySqlCommand sqlCmdInsert = new MySqlCommand(queryInsert, conn);
                sqlCmdInsert.CommandType = System.Data.CommandType.Text;

                //parameters toevoegen!!!!!
                sqlCmdInsert.Parameters.AddWithValue("@Username", L.Username);
                sqlCmdInsert.Parameters.AddWithValue("@Password", L.Password);

                //commando uitvoeren
                sqlCmdInsert.ExecuteNonQuery();

                MessageBox.Show("Registratie gelukt", "Registratie ok!");
            }
            else
            {
                MessageBox.Show("Gebruiker bestaat al", "Bestaande gebruiker");
            }
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

        public static void UpdatePassword(Model.Login L)
        {
            //verbinding maken met databank
            MySqlConnection conn = Database.MaakVerbinding();

            //query maken
            string query = "UPDATE login.tbllogin SET Password = @Password WHERE Username = @Username";

            //commando maken
            MySqlCommand mySqlCommand = new MySqlCommand(query, conn);
            mySqlCommand.CommandType = System.Data.CommandType.Text;

            //parameters toevoegen
            mySqlCommand.Parameters.AddWithValue("@Username", L.Username);
            mySqlCommand.Parameters.AddWithValue("@Password", L.Password);

            //commando uitvoeren
            mySqlCommand.ExecuteNonQuery();

            //messagebox tonen
            MessageBox.Show("Wachtwoord gewijzigd", "Wachtwoord gewijzigd!");
            conn.Close();
        }
    }
}
