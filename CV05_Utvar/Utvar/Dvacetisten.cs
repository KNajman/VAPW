using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dedeni
{
    class Dvacetisten : Utvar
    {
        public Dvacetisten(double edgeLength) : base("Dvacetisten", edgeLength) { }
        protected override double Objem()
        {
            double a = this.EdgeLength;
            return 5 * (3 * Math.Sqrt(5)) / 12 * Math.Pow(a, 3);
        }

        protected override double Povrch()
        {
            double a = this.EdgeLength;
            return 5 * Math.Sqrt(3) * Math.Pow(a, 2);
        }
    }
}
