using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CV08_eshop
{
    public class Uzivatel
    {
        private string Jmeno { get; }
        private string Email { get; }

        private BindingList<Zbozi> Kosik = new BindingList<Zbozi>();

        public Uzivatel(string jmeno, string email)
        {
            this.Jmeno = jmeno;
            this.Email = email;
        }

        public void PridejDoKosiku(Zbozi z)
        {
            foreach (Zbozi zbozi in Kosik)
            {
                if (zbozi.Nazev == z.Nazev){
                    Kosik[Kosik.IndexOf(zbozi)].Pocet++;
                    return;
                }
            }
                z.Pocet = 1;
                Kosik.Add(z);
        }

        public void OdeberZKosiku(Zbozi z)
        {
            if (Kosik.Contains(z))
            {
               if( Kosik[Kosik.IndexOf(z)].Pocet > 1) {
                    Kosik[Kosik.IndexOf(z)].Pocet--;
                }
                else
                {
                    Kosik.Remove(z);
                }
            }
        }

        public double SumaKosiku()
        {
            double suma = 0;
            foreach (Zbozi zbozi in Kosik)
            {
                 suma += zbozi.Pocet*zbozi.Cena;
            }
            return suma;
        }

        public BindingList<Zbozi> getKosik()
        {
            return Kosik;
        }


        public override string ToString()
        {
            return Jmeno;
        }
    }
}
