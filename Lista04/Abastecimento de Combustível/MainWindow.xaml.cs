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

namespace Abastecimento_de_Combustível
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
            Abastecimento obj = new Abastecimento();
            obj.SetValorKmrodado(double.Parse(ValorKmrodado.Text));
            obj.SetValorPago(double.Parse(Valogasto.Text));
            obj.SetValorLitro(double.Parse(ValorLitro.Text));
            kmlitro.Text = obj.MediaKmlitro().ToString("0.00");
            Reais.Text = obj.MediaReaiskm().ToString("0.00");

        }
    }
}
