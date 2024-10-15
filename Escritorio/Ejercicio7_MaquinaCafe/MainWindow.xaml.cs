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

namespace Ejercicio7_MaquinaCafe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window 
    {
        private Producto[] listaProductos = {new Producto("Café Solo", 0.8), new Producto("Café Cortado", 1.0), new Producto("Chocolate", 1.0), new Producto("Té", 1.2)};
        private double[] monedas = {3.0, 2.0, 1.0, 0.5, 0.3, 0.2, 0.1};
        private Cajetin cajetin = new Cajetin();
        public MainWindow()
        {
            InitializeComponent();
            for (int i = 0; i < listaProductos.Length; i++)
            {
                Button b = new Button();
                b.Content = listaProductos[i].Nombre;
                b.Click += Producto_Click;
                spProductos.Children.Add(b);
            }

            for (int i = 0; i < monedas.Length; i++)
            {
                Button b = new Button();
                b.Content = monedas[i].ToString();
                b.Click += Moneda_Click;
                spMonedas.Children.Add(b);
            }
        }

        private void Moneda_Click(object sender, RoutedEventArgs e)
        {
            cajetin.Acumular((double)(sender as Button).Content);

        }

        private void Producto_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}