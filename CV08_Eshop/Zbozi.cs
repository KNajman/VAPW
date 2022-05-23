using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV08_eshop
{
    public class Zbozi : ICloneable 
    {
        public string Nazev { get; set; }
        public int Pocet { get; set; }
        public double Cena { get; set; }
        public Zbozi(string nazev, int pocet, double cena)
        {
            this.Nazev = nazev;
            this.Pocet = pocet;
            this.Cena = cena;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public override string ToString()
        {
            return Nazev + "    ["+ Pocet + "]"+"   "+Cena+"Kč";
        }
    }
}
