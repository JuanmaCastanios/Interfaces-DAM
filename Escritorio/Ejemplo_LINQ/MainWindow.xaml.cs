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

namespace Ejemplo_LINQ
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            bResultado.Click += BResultado_Click3;
        }

        private void BResultado_Click1(object sender, RoutedEventArgs e)
        {
            int[] puntuaciones = { 90, 71, 82, 93, 75, 82 };

            var consulta = 
                from num in puntuaciones
                where num > 80
                orderby num descending
                select num;
            Ejecutar(consulta);
        }

        private void BResultado_Click2(object sender, RoutedEventArgs e)
        {
            int[] puntuaciones = { 90, 71, 82, 93, 75, 82 };

            var consulta = puntuaciones.Where<int>(p => p > 80).OrderByDescending(p => p);
            Ejecutar(consulta);
        }

        private void BResultado_Click6(object sender, RoutedEventArgs e)
        {
            Cliente[] clientes =  new Cliente[4];
            clientes[0] = new Cliente
            {
                Id = 1,
                Nombre = "Juancito",
                Apellido = "Perez",
                Localidad = "Valladolid",
                TotalGasto = 25000
            };

            clientes[1] = new Cliente
            {
                Id = 1,
                Nombre = "Juancito",
                Apellido = "Perez",
                Localidad = "Valladolid",
                TotalGasto = 65000
            };

            clientes[2] = new Cliente
            {
                Id = 1,
                Nombre = "Juancito",
                Apellido = "Perez",
                Localidad = "Valladolid",
                TotalGasto = 15000
            };

            clientes[3] = new Cliente
            {
                Id = 1,
                Nombre = "Juancito",
                Apellido = "Perez",
                Localidad = "Valladolid",
                TotalGasto = 215000
            };

            var consulta = from int num in clientes
                           select new
                           {
                           }

        }

        private void Ejecutar(IEnumerable<int> consultilla)
        {
            foreach (int num in consultilla)
            {
                tbResultado.Text += num.ToString() + "\n";
            }
        }

    }

    internal class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Localidad { get; set; }
        public int TotalGasto { get; set; }

        public override string ToString()
        {
            return this.Nombre + ", " + this.Localidad + ", " + this.TotalGasto;
        }

    }
}