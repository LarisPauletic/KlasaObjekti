using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlaseObjekti
{
    class Class
    {
        string ime;
        int godRod;

        public string Ime { get => ime; set => ime = value; }
        public int GodRod { get => godRod; set => godRod = value; }

        public override string ToString()
        {
            string ispis = "String" + this.Ime + "/rInt: " + this.GodRod;
            return ispis;

        }

        public Class(string ime, int godRod)
        {
            this.Ime = ime;
            this.GodRod = godRod;
        }

       
    }
}
