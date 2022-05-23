using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dedeni
{
    public class Krychle : Utvar
    {
        public Krychle(double delka_hrany) : base("Krychle", delka_hrany) { }
        protected override double Objem()
        {
            double a = this.EdgeLength;
            return Math.Pow(a,3);
        }

        protected override double Povrch()
        {
            double a = this.EdgeLength;
            return 6 * Math.Pow(a, 2);
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
