using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjBrouwerij
{
    public partial class frmBrouwerij : Form
    {
        public frmBrouwerij()
        {
            InitializeComponent();

            //listbox vullen
            VulLijstBrouwerijen();
        }

        public void VulLijstBrouwerijen()
        {
            //voor ieder textitem in de list voegen we toe aan de listbox
            foreach(string brouwerij in DA.BierDA.BrouwerijenOphalen())
            {
                lsbBrouwerijen.Items.Add(brouwerij);
            }
        }

        private void lsbBrouwerijen_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtBrouwerij.Text = lsbBrouwerijen.SelectedItem.ToString();
        }
    }
}
