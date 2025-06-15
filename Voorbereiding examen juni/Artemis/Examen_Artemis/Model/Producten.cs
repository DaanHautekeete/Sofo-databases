using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Artemis.Model
{
    public class Producten
    {
        public int Productnummer { get; set; }
        public int Leveranciersnummer { get; set; }
        public int CategorieNummer { get; set; }
        public string ProductNaam { get; set; }
        public string NederlandseNaam { get; set; }
        public string HoeveelheidPerEenheid { get; set; }
        public decimal PrijsPerEenheid { get; set; }
        public int Voorraad { get; set; }
        public int BTWCode { get; set; }
        public int InBestelling { get; set; }
        public int Bestelpunt  { get; set; }
        public int UitAssortiment { get; set; }
    }
}
