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

namespace Zadanie_5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           int x = Convert.ToInt32(TexA.Text);
            int y = Convert.ToInt32(TexB.Text);
            string s = "";
            if(x<=25 && y<=50 && x>=-25 && y>=-50)
            {
                if(x ==25 && y == 50 || x== -25 && y == -50)
                {
                    s = "На границе";
                }
                else { s = "Нет"; }
            }
            else { s = "Да"; }
            TexRE.Text += "\n" + s;
        }
    }
}
