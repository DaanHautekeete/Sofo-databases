using Login.DA;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Internal;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //we maken een object van ons model
            Model.Login L = new Model.Login();

            L.Username = txtNaam.Text;
            L.Password = txtWachtwoord.Text;

            bool blnLogin = LoginDA.LoginValidate(L);

            //controleren of de login juist is => Ja? => 2de form openen, Nee? => melding tonen
            if (blnLogin == true)
            {
                this.Hide();
                frmIngelogd dashboard = new frmIngelogd();
                dashboard.Show();
            }
        }

        private void btnRegistreren_Click(object sender, EventArgs e)
        {
            Model.Login L = new Model.Login();

            L.Username = txtNaam.Text;
            L.Password = txtWachtwoord.Text;

            LoginDA.Register(L);
        }

        private void btnVerwijder_Click(object sender, EventArgs e)
        {
            //controleren of de gebruiker bestaat
            Model.Login L = new Model.Login();

            L.Username = txtNaam.Text;
            L.Password = txtWachtwoord.Text;

            bool blnLogin = LoginDA.LoginValidate(L);

            if (blnLogin == true)
            {
                LoginDA.Remove(L);
            }
        }

        private void btnUpdatePass_Click(object sender, EventArgs e)
        {
            //controleren of gebruiker bestaat
            Model.Login L = new Model.Login();

            L.Username = txtNaam.Text;
            L.Password = txtWachtwoord.Text;

            bool blnLogin = LoginDA.LoginValidate(L);

            if (blnLogin == true)
            {
                string strNewPass = Interaction.InputBox("Geef een nieuw wachtwoord in!", "Nieuw wachtwoord");

                L.Password = strNewPass;

                //inputbox weergeven voor nieuw wachtwoord
                LoginDA.UpdatePassword(L);
            }
            else
            {
                MessageBox.Show("Gebruiker bestaat niet", "Foutmelding");
            }
        }
    }
}
