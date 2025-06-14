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
    }
}
