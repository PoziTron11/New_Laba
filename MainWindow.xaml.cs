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

namespace WpfApp6
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public static double sum(double a, double b)
        {
            return a + b;

        }
        public static double umnoz(double a, double b)
        {
            return a * b;

        }
        public static double vicit(double a, double b)
        {
            return a - b;

        }
        public static double del(double a, double b)
        {
            return a / b;

        }




    }

}
