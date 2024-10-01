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

namespace Ejercicio3_MasterMind
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string numero = "";
        private string numeroAdivinar = "";
        private int cont = 0;
        private string validacion = "";
        public MainWindow()
        {
            InitializeComponent();
            numeroAdivinar = GeneradorNumero();
        }

        private static string GeneradorNumero()
        {
            Random gen = new Random();
            var cifras = Enumerable.Range(0, 10).OrderBy(x => gen.Next()).Take(4).ToArray();
            return string.Join("", cifras);
        }
        
        private void Button_Click (Object sender, EventArgs e)
        {
            Button botonSeleccionado = sender as Button;
            string letra = " ";
            if(cont < 4 && botonSeleccionado != null)
            {
                letra = botonSeleccionado.Content.ToString();
                numero += letra;
                TbPropuesto.Text = numero;
                botonSeleccionado.Visibility = Visibility.Hidden;
            }
            cont++;
        }
        private void BotComprobar_Click(Object sender, RoutedEventArgs e)
        {
            if (numero.Equals(numeroAdivinar))
            {
                MessageBox.Show("Felicidades. Has acertado el número!!!");
            }
            else
            {
                for(int i = 0; i < 4; i++)
                {
                    if (numero[i].Equals(numeroAdivinar[i]))
                    {
                        
                    }
                }
               LbHistorial.Items.Add(numero + "");
            }
        }
        private void BotCancelar_Click(Object sender, RoutedEventArgs e)
        {
            TbPropuesto.Text = "";
            numero = "";
            cont = 0;
            foreach (var boton in PanelDigitos.Children)
            {
                if (boton is Button botonInvisible)
                {
                    botonInvisible.Visibility = Visibility.Visible;
                }
            }
        }
        private void BotOtro_Click(Object sender, RoutedEventArgs e)
        {
            numeroAdivinar = GeneradorNumero();
        }

    }
    
}