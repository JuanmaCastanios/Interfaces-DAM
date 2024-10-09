using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Ejercicio5_Deposito
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Deposito deposito = new();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void botonBeber_Click(object sender, RoutedEventArgs e)
        {
            deposito.Cantidad--;
        }

        private void botonLlenar_Click(object sender, RoutedEventArgs e)
        {
            deposito.Llenar(10);
            botonBeber.IsEnabled = true;
        }
    }
}