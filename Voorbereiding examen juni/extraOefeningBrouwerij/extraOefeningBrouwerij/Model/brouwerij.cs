using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extraOefeningBrouwerij.Model
{
    public  class brouwerij
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Street { get; set; }
        public string House_number { get; set; }
        public string Postal_code { get; set; }
        public string City_name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public string Description_nl { get; set; }
        public string Description_en { get; set; }
        public string ImagesURL { get; set; }
    }
}
