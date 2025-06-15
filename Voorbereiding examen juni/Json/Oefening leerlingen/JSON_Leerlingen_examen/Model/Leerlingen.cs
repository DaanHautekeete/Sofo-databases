using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace JSON_Leerlingen_examen.Model
{
    public class Leerlingen
    {
        //fields aanmaken
        private string _id;
        private string _naam;
        private string _geboortedatum;
        private string _klas;
        private string _email;

        private List<Leerlingen> _lijstLeerlingen;

        //properties aanmaken
        public string Id { get { return _id; } set { _id = value; } }
        public string Naam { get { return _naam; } set { _naam = value; } }
        public string Geboortedatum { get { return _geboortedatum; } set { _geboortedatum = value; } }
        public string Klas { get { return _klas; } set { _klas = value; } }
        public string Email { get { return _email; } set { _email = value; } }

        public List<Leerlingen> lijstLeerlingen
        {
            get
            {
                string json = File.ReadAllText("leerlingen.json");
                _lijstLeerlingen = JsonConvert.DeserializeObject<List<Leerlingen>>(json);
                return _lijstLeerlingen;
            }
            set { _lijstLeerlingen = value; }
        }

        public override string ToString()
        {
            return this.Naam + " - " + this.Klas + " - " + this.Email + " - " + this.Geboortedatum + " - leeftijd: " + this.BerekenLeeftijd();
        }

        public int BerekenLeeftijd()
        {
            DateTime geboortedatum = DateTime.Parse(this.Geboortedatum);
            DateTime nu = DateTime.Now;
            int leeftijd = nu.Year - geboortedatum.Year;
            if (geboortedatum.Date > nu.AddYears(-leeftijd)) { leeftijd--; };
            return leeftijd;
        }
    }
}