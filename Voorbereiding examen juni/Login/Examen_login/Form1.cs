using Examen_login.DA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInloggen_Click(object sender, EventArgs e)
        {
            //controleren of inloggegevens kloppen
            if (loginDA.checkLogin(txtNaam.Text, txtPass.Text))
            {
                frmIngelogd frmingelogd = new frmIngelogd();
                frmingelogd.Show();
            };
        }

        private void btnRegistreer_Click(object sender, EventArgs e)
        {
            //controleren of username al bestaat
            if (loginDA.CheckUsername(txtNaam.Text))
            {
                MessageBox.Show("Username bestaat al", "foutieve gegevens", MessageBoxButtons.OK);
            }
            else
            {
                loginDA.AddUser(txtNaam.Text, txtPass.Text);
                frmIngelogd frmingelogd = new frmIngelogd(); 
                frmingelogd.Show();
            }
        }
    }
}
