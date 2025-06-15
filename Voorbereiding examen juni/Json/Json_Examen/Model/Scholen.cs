using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;
using System.IO;

namespace Json_Examen.Model
{
    public class Scholen
    {
        //fields aanmaken
        private string _School;
        private string _Vestiging;
        private string _aantal;

        //lijst aanmaken
        private List<Scholen> _lijstScholen;

        //properties aanmaken
        public string School { get { return _School; } set { _School = value; } }
        public string Vestiging { get { return _Vestiging; } set { _Vestiging = value; } }
        public string Aantal { get { return _aantal; } set { _aantal = value; } }

        public List<Scholen> lijstScholen
        {
            get
            {
                //waarden uit json file ophalen
                string json = File.ReadAllText("scholen.json");
                _lijstScholen = JsonConvert.DeserializeObject<List<Scholen>>(json);
                return _lijstScholen;
            }
            set
            {
                _lijstScholen = value;
            }
        }

        public override string ToString()
        {
            return _School + " - " + _Vestiging + " - Aantal lln:  " + _aantal;
        }
    }
}
