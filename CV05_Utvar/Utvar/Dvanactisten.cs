using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dedeni
{
    class Dvanactisten : Utvar
    {
        public Dvanactisten(double edgeLength) : base("Dvanactisten", edgeLength) { }
        protected override double Objem()
        {
            double a = this.EdgeLength;
            return 15 + 7 * Math.Sqrt(5) / 4 * Math.Pow(a, 3);
        }

        protected override double Povrch()
        {
            double a = this.EdgeLength;
            return 3 * Math.Sqrt(25 + 10 * Math.Sqrt(5) * Math.Pow(a, 2));
        }
    }
}
