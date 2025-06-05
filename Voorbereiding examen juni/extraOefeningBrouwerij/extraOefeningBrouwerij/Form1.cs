using extraOefeningBrouwerij.DA;
using extraOefeningBrouwerij.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace extraOefeningBrouwerij
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnToonData_Click(object sender, EventArgs e)
        {
            VulLijst();
        }

        private void lsvBrouwerijen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lsvBrouwerijen.SelectedItems.Count == 0)
            {
                return;
            }

            //listviewitem aanmaken
            ListViewItem gekozenBrouwerij = lsvBrouwerijen.SelectedItems[0];
            foreach (brouwerij brouwerij in brouwerijDA.OphalenBrouwerijen())
            {
                //controleren of id's overeenkomen
                if(brouwerij.id.ToString() == gekozenBrouwerij.Text.ToString())
                {
                    //textvakken vullen met informatie
                    txtBeschrijvingNL.Text = brouwerij.Description_nl;
                    txtBeschrijvingEN.Text = brouwerij.Description_en;
                }

            }
        }

        private void btnPasBeschrijvingAan_Click(object sender, EventArgs e)
        {
            if (lsvBrouwerijen.SelectedItems.Count == 0)
            {
                return;
            }

            //listviewitem aanmaken
            ListViewItem gekozenBrouwerij = lsvBrouwerijen.SelectedItems[0];
            brouwerijDA.UpdateDescriptions(gekozenBrouwerij.Text.ToString(), txtBeschrijvingNL.Text, txtBeschrijvingEN.Text);
        }

        private void btnVerwijderBrouwerij_Click(object sender, EventArgs e)
        {
            if (lsvBrouwerijen.SelectedItems.Count == 0)
            {
                return;
            }

            //listviewitem aanmaken
            ListViewItem gekozenBrouwerij = lsvBrouwerijen.SelectedItems[0];

            brouwerijDA.VerwijderBrouwerij(gekozenBrouwerij.Text.ToString());
            lsvBrouwerijen.Items.Clear();

            VulLijst();
        }

        private void VulLijst()
        {
            //listview opnieuw inladen
            foreach (brouwerij brouwerij in brouwerijDA.OphalenBrouwerijen())
            {
                ListViewItem listViewItem = new ListViewItem(new string[] { brouwerij.id.ToString(), brouwerij.Name, brouwerij.Email, brouwerij.Website });

                listViewItem.Tag = brouwerij;
                listViewItem.BackColor = brouwerijDA.GetColorCode(brouwerij.id.ToString());


                lsvBrouwerijen.Items.Add(listViewItem);
            }

            //textboxen legen
            txtBeschrijvingEN.Clear();
            txtBeschrijvingNL.Clear();
        }
    }
}
