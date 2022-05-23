using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV_06
{
    public class Osoba
    {
        private string jmeno { get; }

        public Osoba(string jmeno)
        {
            this.jmeno = jmeno;
        }

        public override string ToString()
        {
            return jmeno + " ";
        }
    }
}
