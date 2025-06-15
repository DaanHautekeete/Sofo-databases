using Json_Examen.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Json_Examen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void laadData_Click(object sender, EventArgs e)
        {
            Scholen scholen = new Scholen();

            foreach(Scholen school in scholen.lijstScholen)
            {
                listBox1.Items.Add(school);
            }
        }
    }
}
