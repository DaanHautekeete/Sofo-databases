using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjApollo.Model
{
    public class Wijnen
    {
        public string Code { get; set; }
        public string Jaar { get; set; }
        public string Naam { get; set; }
        public string Omschrijving { get; set; }
        public int Groepsnummer { get; set; }
        public string Inhoud { get; set; }
        public double PrijsPerFles { get; set; }
        public int HoeveelheidPerVerpakking { get; set; }
        public int Voorraad { get; set; }
        public int InBestelling { get; set; }
        public int Bestelpunt { get; set; }

        public int UitAssortiment { get; set; }
        public int Leveranciersnummer { get; set; }

        public string Foto { get; set; }
    }
}
