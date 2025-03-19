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
        string GekozenLeveranciersnummer;
        string GekozenCode;

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

        private void vulLijstWijnen()
        {
            //gegevens inladen in listview van de wijnen
            foreach (Model.Wijnen wijn in WijnenDA.OphalenWijnen(txtLevnr.Text))
            {
                //listviewitem aanmaken
                ListViewItem item = new ListViewItem(new string[] { wijn.Code, wijn.Jaar, wijn.Naam, wijn.Omschrijving, wijn.Groepsnummer.ToString(), wijn.Inhoud, wijn.PrijsPerFles.ToString(), wijn.HoeveelheidPerVerpakking.ToString(), wijn.Voorraad.ToString(), wijn.InBestelling.ToString(), wijn.Bestelpunt.ToString(), wijn.UitAssortiment.ToString(), wijn.LeveranciersNummer.ToString(), wijn.Foto });

                item.Tag = wijn;

                lsvWijnen.Items.Add(item);
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

            vulLijstWijnen();
            

            //gekozen leverancier opslaan
            GekozenLeveranciersnummer = txtLevnr.Text;
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

            //gekozen wijn opslaan
            GekozenCode = txtCode.Text;
        }

        //methode om info leverancier te wijzigen
        private void btnWijzig_Click(object sender, EventArgs e)
        {
            //object aanmaken van leverancier
            Model.Leverancier leverancier = new Model.Leverancier() 
            {
                LeverancierNummer = Convert.ToInt16(txtLevnr.Text),
                FirmaNaam = txtNaamFirma.Text,
                Adres = txtAdres.Text,
                Postnr = txtPostnr.Text,
                Gemeente = txtGemeente.Text,
            };

            //methode aanroepen om leverancier te wijzigen
            LeveranciersDA.WijzigLeverenancier(GekozenLeveranciersnummer, leverancier);

            //alle leveranciers opnieuw inladen
            lsvLeveranciers.Items.Clear();
            VulLijstLeveranciers();

            //textboxen leegmaken
            ResetTextboxesLeverancier();
        }

        //methode om leverancier toe te voegen
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //object aanmaken van leverancier
            Model.Leverancier leverancier = new Leverancier()
            {
                LeverancierNummer = Convert.ToInt16(txtLevnr.Text),
                FirmaNaam = txtNaamFirma.Text,
                Adres = txtAdres.Text,
                Postnr = txtPostnr.Text,
                Gemeente = txtGemeente.Text,
            };

            //methode aanroepen om leverancier toe te voegen
            LeveranciersDA.VoegLeverancierToe(leverancier);

            //alle leveranciers opnieuw inladen
            lsvLeveranciers.Items.Clear();
            VulLijstLeveranciers();

            //textboxen leegmaken
            ResetTextboxesLeverancier();
        }

        //methode om leverancier te verwijderen
        private void btnVerwijder_Click(object sender, EventArgs e)
        {
            //methode aanroepen om leverancier te verwijderen
            LeveranciersDA.VerwijderLeverancier(GekozenLeveranciersnummer);

            //alle leveranciers opnieuw inladen
            lsvLeveranciers.Items.Clear();
            VulLijstLeveranciers();

            //textboxen leegmaken
            ResetTextboxesLeverancier();
        }

        //methode om wijn te wijzigen
        private void btnWijzigWijnen_Click(object sender, EventArgs e)
        {
            //object aanmaken van wijn
            Model.Wijnen wijn = new Model.Wijnen()
            {
                Code = txtCode.Text,
                Jaar = txtJaar.Text,
                Naam = txtNaamWijn.Text,
                Omschrijving = txtOmschrijving.Text,
                Groepsnummer = Convert.ToInt16(txtGroepsnummer.Text),
                Inhoud = txtInhoud.Text,
                PrijsPerFles = Convert.ToDouble(txtPPF.Text),
                HoeveelheidPerVerpakking = Convert.ToInt16(txtHoeveelheidPerVerpakking.Text),
                Voorraad = Convert.ToInt16(txtVoorraad.Text),
                InBestelling = Convert.ToInt16(txtInBestelling.Text),
                Bestelpunt = Convert.ToInt16(txtBestelpunt.Text),
                UitAssortiment = Convert.ToInt16(txtUitAssortiment.Text),
                LeveranciersNummer = Convert.ToInt16(txtLeveranciersNummer.Text),
                Foto = txtFoto.Text
            };

            //methode aanroepen om wijn te wijzigen
            WijnenDA.WijzigWijn(GekozenCode, wijn);

            //alle wijnen opnieuw inladen
            lsvWijnen.Items.Clear();
            vulLijstWijnen();

            ResetTextboxesWijn();
        }

        //methode om textboxen te legen
        private void ResetTextboxesLeverancier()
        {
            txtLevnr.Clear();
            txtNaamFirma.Clear();
            txtAdres.Clear();
            txtPostnr.Clear();
            txtGemeente.Clear();
        }

        private void ResetTextboxesWijn()
        {
            txtCode.Clear();
            txtJaar.Clear();
            txtNaamWijn.Clear();
            txtOmschrijving.Clear();
            txtGroepsnummer.Clear();
            txtInhoud.Clear();
            txtPPF.Clear();
            txtHoeveelheidPerVerpakking.Clear();
            txtVoorraad.Clear();
            txtInBestelling.Clear();
            txtBestelpunt.Clear();
            txtUitAssortiment.Clear();
            txtLeveranciersNummer.Clear();
            txtFoto.Clear();
        }
    }
}
