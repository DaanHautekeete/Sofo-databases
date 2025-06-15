using JSON_Leerlingen_examen.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JSON_Leerlingen_examen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //data inladen
            Leerlingen leerlingen = new Leerlingen();

            foreach(Leerlingen leerling in leerlingen.lijstLeerlingen)
            {
                listBox1.Items.Add(leerling);
            }
        }
    }
}
