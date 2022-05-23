using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dedeni
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Sestav_Click(object sender, EventArgs e)
        {
            string tvar = "";
            if (radioButton1.Checked) tvar = "Krychle";
            if (radioButton2.Checked) tvar = "Koule";
            if (radioButton3.Checked) tvar = "Dvanactisten";
            if (radioButton4.Checked) tvar = "Dvacetisten";

            IUtvar u = UtvarFactory.UtvarFactor(tvar, ((double)numericUpDown1.Value));
            listBox1.Items.Add(u);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            numericUpDown1.Value = 5;
            radioButton1.Checked = true;
        }
    }
}
