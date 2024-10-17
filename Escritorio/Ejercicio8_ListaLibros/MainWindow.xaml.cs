using System.IO;
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

namespace Ejercicio8_ListaLibros
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            lvResultados.ItemsSource = LeerCSV();
        }

        private List<Libro> LeerCSV()
        {

            return (from e in File.ReadAllLines("Libros.csv")
                    let campos = e.Split(',')
                    select new Libro
                    {
                        ISBN = campos[0],
                        Titulo = campos[1],
                        Autor = campos[2],
                        Precio = double.Parse(campos[3])
                    }).ToList<Libro>();
        }
    }
    internal class Libro
    {
        public string ISBN { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public double Precio { get; set; }
    }
}