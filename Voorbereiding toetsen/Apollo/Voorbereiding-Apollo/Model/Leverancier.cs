using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voorbereiding_Apollo.Model
{
    public class Leverancier
    {
        public int LeverancierNummer { get; set; }
        public string FirmaNaam { get; set; }
        public string Adres { get; set; }
        public string Postnr { get; set; }
        public string Gemeente { get; set; }
    }
}
