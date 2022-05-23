using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HerniPostava
{
    /// <summary>
    /// Interakční logika pro MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {

        public HerniPostava p1;
        public HerniPostava p2;
        Random rnd = new Random(DateTime.Now.Millisecond);

        public MainWindow()
        {
            InitializeComponent();
        }

        public int hodKostkou()
        {            
            return rnd.Next(1, 6);
        }

        public class HerniPostava
        {
            private string jmeno;
            private int umeniBoje;
            private int HP;

            public HerniPostava(string jmeno, int umeniBoje, int HP)
            {
                this.jmeno = jmeno;
                this.umeniBoje = umeniBoje;
                this.HP = HP;
            }

            public int getHP()
            {
                return this.HP;
            }

            public int getUB()
            {
                return this.umeniBoje;
            }

            public string getName()
            {
                return this.jmeno;
            }

            public void setHP(int newHP)
            {
                this.HP = newHP;
            }

            public void setUB(int newUmeniBoje)
            {
                this.HP = newUmeniBoje;
            }
        }

        public void Boj(HerniPostava p1, HerniPostava p2)
        {

            int p1UC = hodKostkou() + hodKostkou() + p1.getUB();
            int p2UC = hodKostkou() + hodKostkou() + p2.getUB();

            if (p1UC > p2UC)
            {
                p2.setHP(p2.getHP() - 2);
                p2HP.Content = p2.getHP().ToString();
                prubeh.Content = "Výhra " + p1.getName();
            }
            else if (p1UC < p2UC)
            {
                p1.setHP(p1.getHP() - 2);
                p1HP.Content = p1.getHP().ToString();
                prubeh.Content = "Výhra " + p2.getName();
            }
            else
            {
                p1HP.Content = p1.getHP();
                p2HP.Content = p2.getHP();
                prubeh.Content = "Remiza ";

            }

            if (p1.getHP() <= 0)
            {
                //vyhrala p2
            }
            else if (p2.getHP() <= 0)
            {
                //vyhrala p1
            }

        }

        private void P1_button_Click(object sender, RoutedEventArgs e)
        {
            p1 = new HerniPostava(p1_textbox.Text.Clone().ToString(), hodKostkou() + 6, hodKostkou() + hodKostkou() + 12);
            p1HP.Content = p1.getHP();
            p1UB.Content = p1.getUB();
            
        }

        private void P2_button_Click(object sender, RoutedEventArgs e)
        {
            p2 = new HerniPostava(p2_textbox.Text.Clone().ToString(), 8, 14);
            p2HP.Content = p2.getHP();
            p2UB.Content = p2.getUB();
        }

        private void Boj_button_Click(object sender, RoutedEventArgs e)
        {
            Boj(p1, p2);

            if(p1.getHP() <= 0 || p2.getHP() <= 0){
                Boj_button.IsEnabled = false;
            }
        }
    }
}


