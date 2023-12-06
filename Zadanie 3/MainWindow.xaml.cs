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

namespace Zadanie_3
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
            double a = Convert.ToDouble(TexA.Text);
            double b = Convert.ToDouble(TexB.Text);
            double c = Convert.ToDouble(TexC.Text);
            if (a<=b && b<=c && c>a || a>=b && b>=c)
            {
                a = a * 2;
                b = b * 2;
                c = c * 2;
            }
            else
            {
                double d = a;
                a = b;
                b = c;
                c = d;
            }
            TexRE.Text += "\n" + "A=" + a;
            TexRE.Text += "\n" + "B=" + b;
            TexRE.Text += "\n" + "C=" + c;
        }
    }
}
