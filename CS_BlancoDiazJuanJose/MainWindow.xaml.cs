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

namespace CS_BlancoDiazJuanJose
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private TipoSurtidor surtidor;
        private double importeCliente;
        public MainWindow()
        {
            InitializeComponent();
            surtidor = new TipoSurtidor(1.4, 0.005);
            textBoxPrecio.Text = surtidor.precio.ToString("C") + "/l.";
            buttonSurtir.IsEnabled = false;
            surtidor.CambioLitros += Surtidor_CambioLitros;
            surtidor.TopeAlcanzado += Surtidor_TopeAlcanzado;
        }

        private void Surtidor_TopeAlcanzado(object? sender, EventArgs e)
        {
            buttonSurtir.Click -= ButtonSurtir_Click;
        }

        private void Surtidor_CambioLitros(object? sender, EventArgs e)
        {
            textBoxLitros.Text = surtidor.Litros.ToString("F2") + "l";
        }

        private void buttonIniciar_Click(object sender, RoutedEventArgs e)
        {
            surtidor.iniciar();
            buttonSurtir.Click += ButtonSurtir_Click;
            textBoxImporte.Text = "0,00 €";
            importeCliente = 0.0;
            textBoxLitros.Text = surtidor.Importe.ToString("F2") + "l";
        }

        private void buttonDesColgar_Checked(object sender, RoutedEventArgs e)
        {
            //Descolgar
            buttonIniciar.IsEnabled = false;
            buttonSurtir.IsEnabled = true;
            buttonDesColgar.Content = "Colgar";
        }

        private void buttonDesColgar_Unchecked(object sender, RoutedEventArgs e)
        {
            //colgar
            buttonIniciar.IsEnabled = true;
            buttonSurtir.IsEnabled = false;
            buttonDesColgar.Content = "Descolgar";
        }

        private void ButtonSurtir_Click(object sender, RoutedEventArgs e)
        {
            textBoxImporte.Text = surtidor.surtir(importeCliente).ToString("C");
        }

        private void buttonMas1_Click(object sender, RoutedEventArgs e)
        {
            importeCliente += 1.0;
            textBoxImporte.Text= importeCliente.ToString("C");

        }

        private void buttonMas10_Click(object sender, RoutedEventArgs e)
        {
            importeCliente += 10.0;
            textBoxImporte.Text = importeCliente.ToString("C");
        }

    }
}