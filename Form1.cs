using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buttons
{
    public partial class Form1 : Form
    {
        private int click_counter =0;
        private int Y_possition = 0;
        private int X_possition = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            click_counter++;
            Add_Button(click_counter);            
        }

        private void Add_Button(int number)
        {
            Button new_btn = new Button();
            int value = number;
            new_btn.Text = number.ToString();            
            new_btn.Location = new Point(X_possition, Y_possition);
            Y_possition += 23;
            if(Y_possition >= 20*23)
            {
                Y_possition = 0;
                X_possition += 75;
            }
            Controls.Add(new_btn);
            new_btn.Click += new EventHandler(DynamicButton_Click);
        }

        private void DynamicButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show((sender as Button).Text);
        }
    }
}
