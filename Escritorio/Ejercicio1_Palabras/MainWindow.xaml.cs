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

namespace Ejercicio1_Palabras
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            inicializacionPalabras();
        }
        string palabraMisteriosa;
        char letra;
        char[] palabraSegmentada;
        private void inicializacionPalabras()
        {
            string[] palabras = { "Perro", "Gato", "Pingüino", "Pajaro", "Pez", "Llama", "Delfin", "Nutria" };
            foreach (string palabra in palabras)
            {
                lbPalabras.Items.Add(palabra);
            }
        }

        private void botA_Click(object sender, RoutedEventArgs e)
        {
            if (tbxLetra.Text.Equals(""))
            {
                MessageBox.Show("Introduce una letra");
            }
            else
            {
                letra = tbxLetra.Text.ToString()[0];
                string resultado = "";

                if (palabraMisteriosa.Contains(letra))
                {
                    for (int i = 0; i < palabraMisteriosa.Length; i++)
                    {
                        if (palabraMisteriosa[i] == letra)
                        {
                            palabraSegmentada[i] = letra;
                        }

                        else if (palabraSegmentada[i] == '-')
                        { }

                    }
                }

                resultado = String.Join("", palabraSegmentada);
                tbkPalabra.Text = resultado;
                if (resultado.Equals(palabraMisteriosa))
                {
                    MessageBox.Show("Has acertado la palabra!!!");
                    resultado = "";
                }
                tbxLetra.Text = "";
            }
        }

        private void botSiguiente_Click(object sender, RoutedEventArgs e)
        {
            if (lbPalabras.SelectedItem == null) {
                MessageBox.Show("Selecciona una palabra");
            }
            else
            {
                string longitudPalabra = "";
                palabraMisteriosa = lbPalabras.SelectedItem.ToString().ToLower();
                for (int i = 0; i < palabraMisteriosa.Length; i++)
                {
                    longitudPalabra += "-";
                }

                palabraSegmentada = new char[palabraMisteriosa.Length];
                for (int i = 0; i < palabraSegmentada.Length; i++)
                {
                    palabraSegmentada[i] = '-';
                }
                tbkPalabra.Text = longitudPalabra;
            }
        }
    }
}