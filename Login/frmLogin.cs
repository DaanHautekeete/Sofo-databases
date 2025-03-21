﻿using Login.DA;
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

            //gebruiker registreren
            LoginDA.Register(L);

            //velden leegmaken
            txtNaam.Clear();
            txtWachtwoord.Clear();
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

                //velden leegmaken
                txtNaam.Clear();
                txtWachtwoord.Clear();
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
                //inputbox weergeven voor nieuw wachtwoord
                string strNewPass = Interaction.InputBox("Geef een nieuw wachtwoord in!", "Nieuw wachtwoord");

                //wachtwoord veranderen
                L.Password = strNewPass;


                //wachtwoord updaten
                LoginDA.UpdatePassword(L);

                //velden leegmaken
                txtNaam.Clear();
                txtWachtwoord.Clear();
            }
        }
    }
}
