using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjBrouwerij.Model
{
    //public maken
    public class Bier
    {
        //db controleren en gegevens overeen laten komen
        public string Biernaam { get; set; }

        public string Brouwerij { get; set; }

        public string Kleur { get; set; }

        public decimal Alcohol { get; set; }
    }
}
