using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dedeni
{
    class Koule : Utvar
    {
        public Koule(double edgeLength) : base("Koule",edgeLength) { }
        override protected double Objem()
        {
            double r = this.EdgeLength;
            return 4 / 3 * Math.PI * Math.Pow(r, 3);
        }

        override protected double Povrch()
        {
            double r = this.EdgeLength;
            return 4 * Math.PI * Math.Pow(r, 2);
        }
    }
}
