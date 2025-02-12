using prjApollo.DA;
using prjApollo.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjApollo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            vulListviewLeveranciers();
            cmbCode.SelectedIndex = 0;
        }

        private void vulListviewLeveranciers()
        {
            foreach (Leveranciers leverancier in LeveranciersDA.OphalenLeveranciers())
            {
                ListViewItem item = new ListViewItem(new string[] { leverancier.Leveranciernummer.ToString(), leverancier.Firmanaam, leverancier.Adres, leverancier.Postnr, leverancier.Gemeente });

                item.Tag = leverancier;

                lsvLeveranciers.Items.Add(item);
            }
        }

        private void lsvLeveranciers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lsvLeveranciers.SelectedItems.Count == 0)
            {
                return;
            }
            
            //listviewitem maken
            ListViewItem gekozenItem = lsvLeveranciers.SelectedItems[0];
            
            //textboxen vullen met informatie
            txtLevnr.Text = gekozenItem.Text;
            txtNaamFirma.Text = gekozenItem.SubItems[1].Text;
            txtAdres.Text = gekozenItem.SubItems[2].Text;
            txtPostnr.Text = gekozenItem.SubItems[3].Text;
            txtGemeente.Text = gekozenItem.SubItems[4].Text;


            //andere listview vullen
            foreach(Wijnen wijn in DA.WijnenDA.OphalenWijnen())
            {
                ListViewItem item = new ListViewItem(new string[] {wijn.Code, wijn.Jaar, wijn.Omschrijving, wijn.Inhoud, wijn.PrijsPerFles.ToString(), wijn.HoeveelheidPerVerpakking.ToString(), wijn.Voorraad.ToString() });

                item.Tag = wijn;

                lsvWijnen.Items.Add(item);
            }
        }

        private void lsvWijnen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lsvWijnen.SelectedItems.Count == 0)
            {
                return;
            }

            ListViewItem gekozenItem = lsvWijnen.SelectedItems[0];

            //textboxen aanpassen
            txtCode.Text = gekozenItem.Text;
            txtJaar.Text = gekozenItem.SubItems[1].Text;
            txtOmschrijving.Text = gekozenItem.SubItems[2].Text;
            txtInhoud.Text = gekozenItem.SubItems[3].Text;
            txtPPF.Text = gekozenItem.SubItems[4].Text;
            txtPrijsPerPak.Text = gekozenItem.SubItems[5].Text;
            txtVoorraad.Text = gekozenItem.SubItems[6].Text;

        }
    }
}
