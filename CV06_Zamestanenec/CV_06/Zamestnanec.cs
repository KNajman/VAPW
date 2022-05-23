using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV_06
{
    public class Zamestnanec : Osoba
    {
        private int plat { get; }

        public Zamestnanec(string jmeno, int plat): base(jmeno)
        {
            this.plat = plat;
        }

        public override string ToString()
        {
            return base.ToString() + "s platem " + plat + "Kč";
        }
    }

}
