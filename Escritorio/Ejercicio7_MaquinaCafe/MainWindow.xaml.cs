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
        private Producto[] listaProductos = { new Producto("Café Solo", 0.8), new Producto("Café Cortado", 1.0), new Producto("Chocolate", 1.0), new Producto("Té", 1.2) };
        private double[] monedas = { 3.0, 2.0, 1.0, 0.5, 0.3, 0.2, 0.1 };
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
            cajetin.TotalChange += TotalChange_Click;
            cajetin.MonedaNoValida += MoneadaNoValida_Click;
            tbDispensador.MouseEnter += tbDispensador_Recoger;
        }

        //Método para recoger el producto cuando pasas por encima el ratón
        private void tbDispensador_Recoger(object sender, MouseEventArgs e)
        {
            tbDispensador.Text = "";
            tbDisplay.Text = "";
            tbVuelta.Text = "";
            cajetin.Iniciar();
        }

        private void MoneadaNoValida_Click(object? sender, EventArgs e)
        {
            tbDisplay.Text = "";
            tbVuelta.Text = cajetin.Total.ToString() + "€";
            cajetin.Iniciar();
        }

        private void TotalChange_Click(object? sender, EventArgs e)
        {
            tbVuelta.Text = "";
            tbDisplay.Text = cajetin.Total.ToString() + "€";
        }

        private void Moneda_Click(object sender, RoutedEventArgs e)
        {
            cajetin.Acumular(Double.Parse((sender as Button).Content.ToString()));
        }

        private void Producto_Click(object sender, RoutedEventArgs e)
        {
            Producto p = null;
            for (int i = 0; i < listaProductos.Length; i++)
            {
<<<<<<< HEAD
                if (listaProductos[i].Nombre.Equals((sender as Button).Content.ToString()))
                {
=======

                if(listaProductos[i].Nombre.Equals((sender as Button).Content.ToString())){
>>>>>>> origin/main
                    p = listaProductos[i];
                }
            }
            if (cajetin.Dispensar(p))
            {
                tbDispensador.Text = p.Nombre;
<<<<<<< HEAD
                tbVuelta.Text = cajetin.Devolver(p).ToString() + "€";
=======

                tbVuelta.Text = cajetin.Devolver(p).ToString() + "€";

>>>>>>> origin/main
            }
        }
    }
}