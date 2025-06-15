using Examen_Artemis.DA;
using Examen_Artemis.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_Artemis
{
    public partial class frmLeveranciersProducten : Form
    {
        public frmLeveranciersProducten()
        {
            InitializeComponent();
        }

        private void frmLeveranciersProducten_Load(object sender, EventArgs e)
        {
            LaadLeveranciers();
        }

        private void LaadLeveranciers()
        {
            lsvLeveranciers.Items.Clear();

            foreach(Leveranciers leverancier in LeveranciersDA.LeveranciersOphalen())
            {
                //listviewitem maken 
                ListViewItem item = new ListViewItem(new string[] { leverancier.Leveranciersnummer.ToString(), leverancier.Bedrijf, leverancier.Adres, leverancier.Plaats, leverancier.Postcode, leverancier.Land, leverancier.URL });

                item.Tag = leverancier;
                lsvLeveranciers.Items.Add(item);
                
            }
        }

        private void LaadProducten()
        {
            lsvProducten.Items.Clear();

            foreach(Producten product in ProductenDA.ProductenOphalen(Convert.ToInt16(txtLeveranciersnummer.Text)))
            {
                //listviewitem maken 
                ListViewItem item = new ListViewItem(new string[] { product.Productnummer.ToString(), product.Leveranciersnummer.ToString(), product.CategorieNummer.ToString(), product.NederlandseNaam, product.HoeveelheidPerEenheid, product.PrijsPerEenheid.ToString(), product.Voorraad.ToString(), product.BTWCode.ToString(), product.InBestelling.ToString(), product.Bestelpunt.ToString(), product.UitAssortiment.ToString() });

                item.Tag = product;
                lsvProducten.Items.Add(item);
            }
        }

        private void lsvLeveranciers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lsvLeveranciers.SelectedItems.Count == 0) { return; }

            //listviewitem aanmaken
            ListViewItem GekozenItem = lsvLeveranciers.SelectedItems[0];

            txtLeveranciersnummer.Text = GekozenItem.Text;
            txtBedrijf.Text = GekozenItem.SubItems[1].Text;
            txtAdres.Text = GekozenItem.SubItems[2].Text;
            txtPlaats.Text = GekozenItem.SubItems[3].Text;
            txtPostcode.Text = GekozenItem.SubItems[4].Text;
            txtLand.Text = GekozenItem.SubItems[5].Text;
            txtURL.Text = GekozenItem.SubItems[6].Text;


            LaadProducten();
        }

        private void btnVoegToe_Click(object sender, EventArgs e)
        {
            //nieuw object maken van leverancier
            Leveranciers leverancier = new Leveranciers
            {
                Bedrijf = txtBedrijf.Text,
                Adres = txtAdres.Text,
                Plaats = txtPlaats.Text,
                Postcode = txtPostcode.Text,
                Land = txtLand.Text,
                URL = txtURL.Text
            };
            
            LeveranciersDA.LeverancierToevoegen(leverancier);
            LaadLeveranciers();

            ResetTextboxenLeverancier();
        }

        private void btnWijzig_Click(object sender, EventArgs e)
        {
            //nieuw object maken van leveranciers
            Leveranciers leveranciers = new Leveranciers
            {
                Leveranciersnummer = Convert.ToInt16(txtLeveranciersnummer.Text),
                Bedrijf = txtBedrijf.Text,
                Adres = txtAdres.Text,
                Plaats = txtPlaats.Text,
                Postcode = txtPostcode.Text,
                Land = txtLand.Text,
                URL = txtURL.Text
            };
            
            //leverancier wijzigen
            LeveranciersDA.leverancierWijzigen(leveranciers);
            LaadLeveranciers();

            ResetTextboxenLeverancier();
        }

        private void ResetTextboxenLeverancier()
        {
            txtLeveranciersnummer.Clear();
            txtBedrijf.Clear();
            txtAdres.Clear();
            txtPlaats.Clear();
            txtPostcode.Clear();
            txtLand.Clear();
            txtURL.Clear();
        }

        private void btnVerwijder_Click(object sender, EventArgs e)
        {
            //object aanmaken van leverancier
            Leveranciers leverancier = new Leveranciers
            {
                Leveranciersnummer = Convert.ToInt16(txtLeveranciersnummer.Text)
            };

            LeveranciersDA.LeverancierVerwijderen(leverancier);
            LaadLeveranciers();

            ResetTextboxenLeverancier();
        }
    }
}
