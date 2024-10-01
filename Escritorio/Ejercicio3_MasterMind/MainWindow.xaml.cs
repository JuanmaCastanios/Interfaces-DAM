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
            LbHistorial.FontFamily = new System.Windows.Media.FontFamily("Segoe UI Emoji");
            LbHistorial.FontSize = 25;
            this.MaxHeight = 800;
            this.MinHeight = 333;
            this.MaxWidth = 327;
            this.MinWidth = 327;
        }

        private static string GeneradorNumero()
        {
            Random gen = new Random();
            var cifras = Enumerable.Range(0, 10).OrderBy(x => gen.Next()).Take(4).ToArray();
            return string.Join("", cifras);
        }
        private void Reset()
        {
            BotComprobar.IsEnabled = true;
            TbPropuesto.Text = "";
            numero = "";
            validacion = "";
            cont = 0;
            foreach (var boton in PanelDigitos.Children)
            {
                if (boton is Button botonInvisible)
                {
                    botonInvisible.Visibility = Visibility.Visible;
                }
            }
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
                cont++;
            }   
        }
        private void BotComprobar_Click(Object sender, RoutedEventArgs e)
        {
            BotComprobar.IsEnabled = false;
            if (numero.Equals(numeroAdivinar))
            {
                MessageBox.Show("Felicidades. Has acertado el número!!!");
                BotCancelar.IsEnabled = false;
            }
            for (int i = 0; i < 4; i++)
            {
                if (numero[i].Equals(numeroAdivinar[i]))
                {
                    validacion += "\U0001F44D ";
                }
                else if (numeroAdivinar.IndexOf(numero[i]) != -1)
                {
                    validacion += "\U0001F610 ";
                }
                else
                {
                    validacion += "\U0001F44E ";
                }
            }
               LbHistorial.Items.Add(numero + "\t" + validacion);
        }
        private void BotCancelar_Click(Object sender, RoutedEventArgs e)
        {
            Reset();
        }
        private void BotOtro_Click(Object sender, RoutedEventArgs e)
        {
            numeroAdivinar = GeneradorNumero();
            Reset();
            LbHistorial.Items.Clear();
            BotCancelar.IsEnabled = true;
        }
    }
    
}