using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CV08_eshop
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Uzivatel u = new Uzivatel(textBox1.Text, textBox2.Text);
            Form1.Uzivatele.Add(u);
            MessageBox.Show("Uživatel úspěšně přidán.");
            this.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            this.Close();                   
        }

        private Boolean Kontrola_emailu(string email)
        {
            //@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"); 
            string email_pattern = @"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$";
            Regex r = new Regex(email_pattern);
            Match m = r.Match(email);
            if (m.Success)
                return true;
            else
                return false;
        }

        private void Button1_Validating(object sender, CancelEventArgs e)
        {
            if (Kontrola_emailu(textBox2.Text) && textBox1.Text != "")
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }
    }
}
