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
using static System.Math;

namespace Zadanie_4
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
            double m = Convert.ToDouble(TexC.Text);
            double x = a * Pow(b, 2) - Sin(Pow(b, 2) + m * b);
            double y = 0;
            if(x< -PI)
            {
               y = 1 - (Exp(-a * x) + Exp(-b * x));
            }
            if (x<=PI)
                    {
                y = 1 - Exp(-a * x) * (a * x + b);
            }
            else
            {
               y = 1 - Exp(-a * x) * Sin(a * x + b);
            }
            TexRE.Text += "\n" + "Y=" + y;
        }
    }
}
