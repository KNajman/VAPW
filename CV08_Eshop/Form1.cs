using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CV08_eshop
{
    public partial class Form1 : Form
    {

        public static BindingList<Uzivatel> Uzivatele = new BindingList<Uzivatel>();
        public static BindingList<Zbozi> Sklad = new BindingList<Zbozi>();


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Uzivatele.Add(new Uzivatel("Jan Novak", "jan.novak@tul.cz"));
            Sklad.Add(new Zbozi("Rohlik", 10, 1.50));
            Sklad.Add(new Zbozi("Banan", 1, 7.90));
            Sklad.Add(new Zbozi("Marmelada", 4, 99.90));
            Sklad.Add(new Zbozi("Máslo", 8, 48.50));
            ListBox_SKLAD.DataSource = Sklad;
            ListBox_UZIVATELE.DataSource = Uzivatele;
            ListBox_KOSIK.DataSource = (ListBox_UZIVATELE.SelectedItem as Uzivatel).getKosik();
            
        }

        private void Vrat_Na_Sklad(object sender, EventArgs e)
        {
            if(ListBox_KOSIK.SelectedItem != null) { 
                int index = -1;
                foreach (Zbozi zbozi in Sklad)
                {
                    if (zbozi.Nazev == (ListBox_KOSIK.SelectedItem as Zbozi).Nazev)
                    {
                       index = Sklad.IndexOf(zbozi);
                    }
                }

                if(index > -1)
                {
                    Sklad[index].Pocet++;
                }
                else
                {
                    Zbozi z = (ListBox_KOSIK.SelectedItem as Zbozi).Clone() as Zbozi;
                    z.Pocet = 1;
                    Sklad.Add(z);
                }

                (ListBox_UZIVATELE.SelectedItem as Uzivatel).OdeberZKosiku((ListBox_KOSIK.SelectedItem as Zbozi));
            }
            RefreshData();
        }

        private void Dej_Do_Kosiku(object sender, EventArgs e)
        {
            //do košíku;
            if (ListBox_SKLAD.SelectedItem != null) { 
                (ListBox_UZIVATELE.SelectedItem as Uzivatel).PridejDoKosiku((ListBox_SKLAD.SelectedItem as Zbozi).Clone() as Zbozi);
                if((ListBox_SKLAD.SelectedItem as Zbozi).Pocet > 1)
                {
                    (ListBox_SKLAD.SelectedItem as Zbozi).Pocet--;
                }
                else
                {
                    Sklad.Remove(ListBox_SKLAD.SelectedItem as Zbozi);
                }
            }
            RefreshData();
        }

        private void Pridani_noveho_uzivatele(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();

        }

        private void RefreshData()
        {
            ListBox_SKLAD.DataSource = null;
            ListBox_SKLAD.DataSource = Sklad;
            ListBox_KOSIK.DataSource = null;
            ListBox_KOSIK.DataSource = (ListBox_UZIVATELE.SelectedItem as Uzivatel).getKosik();
        }

        private void ListBox_UZIVATELE_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void Suma(object sender, EventArgs e)
        {
            if(ListBox_KOSIK.SelectedItem !=null)
            {
                double suma=(ListBox_UZIVATELE.SelectedItem as Uzivatel).SumaKosiku();
                MessageBox.Show("Celková cena nákupu: " + suma+"Kč");
            }
            else{
                MessageBox.Show("Košík je prázdný.");
            }
        }
    }
}
