using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CV_06
{
    
    public partial class Form1 : Form        
    {
        public Form1()
        {
            InitializeComponent();
            listBox1.DataSource = listOsob;
        }

        private BindingList<Osoba> listOsob = new BindingList<Osoba>();
        public int pocet = 0;
        private void Button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                listOsob.Add(new Osoba(textBox1.Text));
                //UpdateListBox();
            }
            else if (radioButton2.Checked)
            {
                listOsob.Add(new Zamestnanec(textBox1.Text, (int)numericUpDown1.Value));
                //UpdateListBox();
            }
        }


        private void UpdateListBox()
        {
            //listBox1.DataSource.ToString();
            //label3.Text = o[o.Count - 1].ToString();
            //pocet = o.Count-1;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (pocet > 0){ pocet--; }

    
;           if (pocet >= 0)
            {
                label3.Text = listOsob[pocet].ToString();
            }
            else
            {
                label3.Text = "";
            }
                

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (pocet < listOsob.Count() - 1) { pocet++; }

            if (pocet <= listOsob.Count()-1)
            {
                label3.Text = listOsob[pocet].ToString();
            }
            else
            {
                label3.Text = "";
            }

        }
    }
}
