using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CV_PEXESO
{
    public partial class Form1 : Form
    {
        private int Y_possition = 0;
        private int X_possition = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Rozdej_Pexeso((int)numericUpDown1.Value);
            button1.Enabled = false;
        }


        private void Rozdej_Pexeso(int pocetKaret)
        {
            for(int i=0; i < pocetKaret; i++) {
                Karticka new_btn = new Karticka();
                new_btn.Hodnota = VygenerujHodnotu();
                new_btn.Text = "";
                new_btn.Width = 45;
                new_btn.Height = 45;
                new_btn.Location = new Point(X_possition, Y_possition);
                X_possition += 45;
                if (X_possition >= pocetKaret/4 * 45)
                {
                    X_possition = 0;
                    Y_possition += 45;
                }
                Controls.Add(new_btn);
            }
            
        }

        private int VygenerujHodnotu()
        {
            throw new NotImplementedException();
        }
    }
}
