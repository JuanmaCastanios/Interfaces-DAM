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

namespace Ejercicio6_Caldera
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Caldera caldera = new();
        public MainWindow()
        {
            InitializeComponent();
            caldera.ActualizarCaldera += Caldera_ActualizarCaldera;
            caldera.CalderaMaximo += Caldera_CalderaMaximo;
        }


        private void Caldera_ActualizarCaldera(object sender, EventArgs e)
        {

        }

        private void Caldera_CalderaMaximo(object sender, EventArgs e)
        {

        }

        private void slider1_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }
    }
}