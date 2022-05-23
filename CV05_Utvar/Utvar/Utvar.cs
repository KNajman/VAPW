using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dedeni
{
    public abstract class Utvar : IUtvar
    {
        private readonly string name;
        public double EdgeLength { get;}

        protected abstract double Objem();
        protected abstract double Povrch();

        //Konstruktor
        protected Utvar(string name, double EdgeLength)
        {
            this.EdgeLength = EdgeLength;
            this.name = name;
        }

        override public string ToString()
        {
            return name +" "+ Objem().ToString() +" "+ Povrch().ToString();
        }
    }
}
