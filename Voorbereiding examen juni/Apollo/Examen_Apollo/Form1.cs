using Examen_Apollo.DA;
using Examen_Apollo.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_Apollo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LaadLeveranciers();
        }

        private void LaadLeveranciers()
        {
            lsvLeveranciers.Items.Clear();

            List<Leverancier> leveranciers = LeverancierDA.OphalenLeveranciers();

            foreach (Leverancier leverancier in leveranciers)
            {
                ListViewItem item = new ListViewItem(new string[] { leverancier.leveranciernummer.ToString(), leverancier.firmanaam, leverancier.adres, leverancier.postnr, leverancier.gemeente });

                item.Tag = leverancier;
                lsvLeveranciers.Items.Add(item);
            }

        }

        private void LaadWijnen()
        {
            //listview legen
            lsvWijnen.Items.Clear();

            //lijst opmaken voor wijnen
            List<Wijnen> LijstWijnen = WijnenDA.OphalenWijnen(Convert.ToInt16(txtLevnr.Text));

            foreach(Wijnen wijn in LijstWijnen)
            {
                //listviewitem maken
                ListViewItem item = new ListViewItem(new string[] {wijn.Code.ToString(), wijn.Jaar.ToString(), wijn.Naam, wijn.Omschrijving, wijn.Groepsnummer.ToString(), wijn.Inhoud.ToString(), wijn.PrijsPerFles.ToString(), wijn.HoeveelheidPerVerpakking.ToString(), wijn.Voorraad.ToString(), wijn.InBestelling.ToString(), wijn.Bestelpunt.ToString(), wijn.UitAssortiment.ToString(), wijn.Leveranciersnummer.ToString(), wijn.foto.ToString()});

                item.Tag = wijn;
                lsvWijnen.Items.Add(item);
            }
        }

        private void lsvLeveranciers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lsvLeveranciers.SelectedItems.Count == 0)
            {
                return;
            }


            //listviewitem aanmaken
            ListViewItem gekozenItem = lsvLeveranciers.SelectedItems[0];

            txtLevnr.Text = gekozenItem.Text;
            txtNaamFirma.Text = gekozenItem.SubItems[1].Text;
            txtAdres.Text = gekozenItem.SubItems[2].Text;
            txtPostnr.Text = gekozenItem.SubItems[3].Text;
            txtGemeente.Text = gekozenItem.SubItems[4].Text;

            //wijnen inladen
            LaadWijnen();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //object aanmaken van leverancier
            Leverancier EigenLeverancier = new Leverancier()
            {
                firmanaam = txtNaamFirma.Text,
                adres = txtAdres.Text,
                postnr = txtPostnr.Text,
                gemeente = txtGemeente.Text
            }; 

            //leverancier toevoegen
            LeverancierDA.LeverancierToevoegen(EigenLeverancier);

            //listview opnieuw laden
            LaadLeveranciers();

            //textboxen resetten
            ResetTextboxesLeverancier();
        }

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

        private void btnVerwijder_Click(object sender, EventArgs e)
        {
            //object maken van leverancier
            Leverancier TeVerwijderenLeverancier = new Leverancier()
            {
                leveranciernummer = Convert.ToInt16(txtLevnr.Text)
            };

            //leverancier verwijderen
            LeverancierDA.LeverancierVerwijderen(TeVerwijderenLeverancier);

            //listview opnieuw laden
            LaadLeveranciers();

            ResetTextboxesLeverancier();
        }

        private void btnWijzig_Click(object sender, EventArgs e)
        {
            //object van leverancier maken
            Leverancier leverancier = new Leverancier()
            {
                leveranciernummer = Convert.ToInt16(txtLevnr.Text),
                firmanaam = txtNaamFirma.Text,
                adres = txtAdres.Text,
                postnr = txtPostnr.Text,
                gemeente = txtGemeente.Text
            };

            //leverancier wijzigen
            LeverancierDA.LeverancierWijzigen(leverancier);

            //listview opnieuw laden
            LaadLeveranciers();

            ResetTextboxesLeverancier();
        }

        private void lsvWijnen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lsvWijnen.SelectedItems.Count == 0) { return; }
            //listviewitem maken
            ListViewItem gekozenWijn = lsvWijnen.SelectedItems[0];

            //textboxen vullen met data
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

        private void btnWijnToevoegen_Click(object sender, EventArgs e)
        {
            //object maken van wijnen
            Wijnen ToeTeVoegenWijn = new Wijnen()
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
                Leveranciersnummer = Convert.ToInt16(txtLeveranciersNummer.Text),
                foto = txtFoto.Text
            };

            //wijn toevoegen 
            WijnenDA.VoegWijnToe(ToeTeVoegenWijn);

            //listview opnieuw laden
            LaadWijnen();
        }

        private void btnVerwijderWijn_Click(object sender, EventArgs e)
        {
            //object aanmaken van wijn
            Wijnen TeVerwijderenWijn = new Wijnen()
            {
                Code = txtCode.Text
            };

            //wijn verwijderen
            WijnenDA.VerwijderWijn(TeVerwijderenWijn);

            //listview opnieuw laden
            LaadWijnen();

            ResetTextboxesWijn();
        }

        private void btnWijzigWijnen_Click(object sender, EventArgs e)
        {
            //oude code ophalen
            ListViewItem item = lsvWijnen.SelectedItems[0];
            string oudeCode = item.Text;

            //object aanmaken van wijn
            Wijnen wijn = new Wijnen()
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
                Leveranciersnummer = Convert.ToInt16(txtLeveranciersNummer.Text),
                foto = txtFoto.Text
            };

            //wijn wijzigen
            WijnenDA.WijzigWijn(wijn, oudeCode);

            LaadWijnen();

        }
    }
}
