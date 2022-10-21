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

namespace retagulo_app
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
            Retamgulo r = new Retamgulo();
            r.SetBase(double.Parse(txtbase.Text));
            r.SetAltura(double.Parse(txtaltura.Text));
            txtArea.Text = r.CalcArea().ToString("0.00");
            txtDiagonal.Text = r.CalcDiagonal().ToString("0.00");
        }
    }
}
