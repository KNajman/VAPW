using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Dedeni
{
    class UtvarFactory
    {
        public static IUtvar UtvarFactor(string tvar, double delkahrany)
        {
            IUtvar u;
            switch (tvar)
            {
                case "Krychle":
                    u = new Krychle(delkahrany);
                    break;
                case "Koule":
                    u = new Koule(delkahrany);
                    break;
                case "Dvanactisten":
                    u = new Dvanactisten(delkahrany);
                    break;
                case "Dvacetisten":
                    u = new Dvacetisten(delkahrany);
                    break;
                default:
                    u = new Krychle(delkahrany);
                    break;
            }
            return u;
        }
    }
}
