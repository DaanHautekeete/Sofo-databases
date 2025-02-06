using prjBrouwerij.DA;
using prjBrouwerij.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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
            //legen van listview
            lsvBier.Items.Clear();

            txtBrouwerij.Text = lsbBrouwerijen.SelectedItem.ToString();


            //bieren weergeven van die brouwerij
            foreach(Bier bier in BierDA.ophalenBieren(lsbBrouwerijen.SelectedItem.ToString()))
            {
                //voor ieder biertje die we vinden vinden in de lijst Bieren, voegen we toe aan de listview
                //aan de listview -> listviewitem 
                ListViewItem item = new ListViewItem(new string[] { bier.Biernaam, bier.Alcohol.ToString(), bier.Kleur });

                item.Tag = bier;

                lsvBier.Items.Add(item);
            }

            //kolommen resizen
            lsvBier.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);

        }

        private void lsvBier_SelectedIndexChanged(object sender, EventArgs e)
        {
            Bier BO = new Bier();

            if (lsvBier.SelectedItems.Count == 0)
                return;

            ListViewItem item = lsvBier.SelectedItems[0];
            BO.Biernaam = item.Text;
            BO.Alcohol = Convert.ToDecimal(item.SubItems[1].Text);
            BO.Kleur = item.SubItems[2].Text;

            //gegevens inladen in de textboxes
            txtBiernaam.Text = BO.Biernaam;
            txtAlcohol.Text = BO.Alcohol.ToString();
            txtKleur.Text = BO.Kleur;


        }

        private void btnVerwijder_Click(object sender, EventArgs e)
        {
            Bier bier = new Bier();
            bier.Biernaam = txtBiernaam.Text; //of hetgene die geselecteerd is in listview

            BierDA.VerwijderBier(bier);

            //listbox vernieuwen 
            lsbBrouwerijen.Items.Clear();
            VulLijstBrouwerijen();

            //listview vernieuwen
            lsvBier.Items.Clear();

            //tekstvakjes leegmaken
            txtBrouwerij.Clear();
            txtBiernaam.Clear();
            txtAlcohol.Clear();
            txtKleur.Clear();
        }

        private void btnToevoegen_Click(object sender, EventArgs e)
        {
            //nieuw object aanmaken van klasse bier
            Bier bier = new Bier();
            bier.Biernaam = txtBiernaam.Text;
            bier.Brouwerij = txtBrouwerij.Text;
            bier.Alcohol = Convert.ToDecimal(txtAlcohol.Text);
            bier.Kleur = txtKleur.Text;

            //bier toevoegen
            BierDA.VoegBierToe(bier);

            //listbox vernieuwen 
            lsbBrouwerijen.Items.Clear();
            VulLijstBrouwerijen();

            //listview vernieuwen
            lsvBier.Items.Clear();

            //tekstvakjes leegmaken
            txtBrouwerij.Clear();
            txtBiernaam.Clear();
            txtAlcohol.Clear();
            txtKleur.Clear();
        }

        private void btnAanpassen_Click(object sender, EventArgs e)
        {
            Bier BO = new Bier();

            if (lsvBier.SelectedItems.Count == 0)
                return;

            //alles van listview in object steken
            ListViewItem item = lsvBier.SelectedItems[0];
            BO.Biernaam = item.Text;


            //object aanmaken voor aangepaste bier
            Bier bier = new Bier();

            bier.Biernaam = txtBiernaam.Text;
            bier.Brouwerij = txtBrouwerij.Text;
            bier.Alcohol = Convert.ToDecimal(txtAlcohol.Text);
            bier.Kleur = txtKleur.Text;

            //gegevens aanpassen met gegevens uit het object vanuit de listview
            BierDA.PasBierAan(bier, BO.Biernaam);

            //listbox vernieuwen 
            lsbBrouwerijen.Items.Clear();
            VulLijstBrouwerijen();

            //listview vernieuwen
            lsvBier.Items.Clear();

            //tekstvakjes leegmaken
            txtBrouwerij.Clear();
            txtBiernaam.Clear();
            txtAlcohol.Clear();
            txtKleur.Clear();
        }
    }
}
