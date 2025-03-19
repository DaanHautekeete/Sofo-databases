using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Voorbereiding_Apollo.DA;
using Voorbereiding_Apollo.Model;

namespace Voorbereiding_Apollo
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
            VulLijstLeveranciers();
        }

        private void VulLijstLeveranciers()
        {
            foreach(Model.Leverancier leverancier in LeveranciersDA.OphalenLeveranciers())
            {
                ListViewItem item = new ListViewItem(new string[] { leverancier.LeverancierNummer.ToString(), leverancier.FirmaNaam, leverancier.Adres, leverancier.Postnr, leverancier.Gemeente });

                item.Tag = leverancier;

                lsvLeveranciers.Items.Add(item);

            }
        }

        private void lsvLeveranciers_SelectedIndexChanged(object sender, EventArgs e)
        {
            //gegevens in listview van de wijnen verwijderen
            lsvWijnen.Items.Clear();

            if (lsvLeveranciers.SelectedItems.Count == 0)
            {
                return;
            }

            //listviewitem maken
            ListViewItem gekozenLeverancier = lsvLeveranciers.SelectedItems[0];

            txtLevnr.Text = gekozenLeverancier.Text;
            txtNaamFirma.Text = gekozenLeverancier.SubItems[1].Text;
            txtAdres.Text = gekozenLeverancier.SubItems[2].Text;
            txtPostnr.Text = gekozenLeverancier.SubItems[3].Text;
            txtGemeente.Text = gekozenLeverancier.SubItems[4].Text;


            //gegevens inladen in listview van de wijnen
            foreach (Model.Wijnen wijn in WijnenDA.OphalenWijnen(txtLevnr.Text))
            {
                //listviewitem aanmaken
                ListViewItem item = new ListViewItem(new string[] { wijn.Code, wijn.Jaar, wijn.Naam, wijn.Omschrijving, wijn.Groepsnummer.ToString(), wijn.Inhoud, wijn.PrijsPerFles.ToString(), wijn.HoeveelheidPerVerpakking.ToString(), wijn.Voorraad.ToString(), wijn.InBestelling.ToString(), wijn.Bestelpunt.ToString(), wijn.UitAssortiment.ToString(), wijn.LeveranciersNummer.ToString(), wijn.Foto});

                item.Tag = wijn;

                lsvWijnen.Items.Add(item);
            }
        }

        private void lsvWijnen_SelectedIndexChanged(object sender, EventArgs e)
        {
            //listviewitem maken
            if(lsvWijnen.SelectedItems.Count == 0)
            {
                return;
            }

            ListViewItem gekozenWijn = lsvWijnen.SelectedItems[0];
            
            //textboxen vullen met gegevens
            txtCode.Text = gekozenWijn.Text;
            txtJaar.Text = gekozenWijn.SubItems[1].Text;
            txtNaamWijn.Text = gekozenWijn.SubItems[2].Text;
            txtOmschrijving.Text = gekozenWijn.SubItems[3].Text;
            txtGroepsnummer.Text = gekozenWijn.SubItems[4].Text;
            txtInhoud.Text = gekozenWijn.SubItems[5].Text;
            txtPPF.Text = gekozenWijn.SubItems[6].Text;
            txtHoeveelheidPerVerpakking.Text = gekozenWijn.SubItems[7].Text;
            txtVoorraad.Text = gekozenWijn.SubItems[8].Text;
            txtInBestelling.Text = gekozenWijn.SubItems[9].Text;
            txtBestelpunt.Text = gekozenWijn.SubItems[10].Text;
            txtUitAssortiment.Text = gekozenWijn.SubItems[11].Text;
            txtLeveranciersNummer.Text = gekozenWijn.SubItems[12].Text;
            txtFoto.Text = gekozenWijn.SubItems[13].Text;
        }
    }
}
