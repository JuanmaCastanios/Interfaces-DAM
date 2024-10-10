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
            slider1.Maximum = 99;
            lbInforme.Items.Add("Inicio " + DateTime.Now.ToString("HH:mm:ss"));
            caldera.Estado = "Correcto";
            caldera.ActualizarCaldera += Caldera_ActualizarCaldera;
            caldera.CalderaMaximo += Caldera_CalderaMaximo;
            txtbTemperatura.Text = caldera.ValorCaldera.ToString();
        }


        private void Caldera_ActualizarCaldera(object sender, EventArgs e)
        {
            lbInforme.Items.Add(caldera.mostrarEstado());
            if (caldera.Estado.Equals("Correcto"))
            {
                txtbTemperatura.Background = new SolidColorBrush(Colors.Green);
            }
            else if (caldera.Estado.Equals("Alerta\t"))
            {
                txtbTemperatura.Background = new SolidColorBrush(Colors.Yellow);
            }
            else if (caldera.Estado.Equals("Peligro"))
            {
                txtbTemperatura.Background = new SolidColorBrush(Colors.Red);
            }

        }

        private void Caldera_CalderaMaximo(object sender, EventArgs e)
        {
            slider1.IsEnabled = false;
            lbInforme.Items.Add("Fin " + DateTime.Now.ToString("HH:mm:ss"));
        }

        private void slider1_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            caldera.ValorCaldera = (int)slider1.Value;
            caldera.Estado = caldera.Estado;
            txtbTemperatura.Text = caldera.ValorCaldera.ToString();
            
        }
    }
}