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

namespace Ejercicio2_Palabras2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private char[] letras = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'ñ', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        private string[] palabras = { "Perro", "Gato", "Caballo", "Iguana" };
        private char[] palabraSegmentada;
        private Label palabra;
        private StackPanel spBotones;
        private string palabraMisteriosa;
        public MainWindow()
        {
            InitializeComponent();

            StackPanel spPalabra = new();
            spPalabra.Background = new SolidColorBrush(Colors.LightGreen);
            Grid.SetRow(spPalabra, 0);
            grid.Children.Add(spPalabra);

            palabra = new();
            palabra.HorizontalAlignment = HorizontalAlignment.Center;
            palabra.VerticalAlignment = VerticalAlignment.Center;
            palabra.FontSize = 69;
            spPalabra.Children.Add(palabra);

            Button bSiguiente = new();
            bSiguiente.HorizontalAlignment = HorizontalAlignment.Center;
            bSiguiente.VerticalAlignment = VerticalAlignment.Center;
            bSiguiente.Content = "Siguiente";
            bSiguiente.Padding = new Thickness(3);
            bSiguiente.Click += BSiguiente_Click;
            Grid.SetRow(bSiguiente, 1);
            grid.Children.Add(bSiguiente);

            spBotones = new();
            spBotones.HorizontalAlignment = HorizontalAlignment.Center;
            spBotones.VerticalAlignment = VerticalAlignment.Center;
            spBotones.Orientation = Orientation.Horizontal;
            Grid.SetRow(spBotones, 2);
            grid.Children.Add(spBotones);

            for (int i = 0; i < letras.Length; i++)
            {
                Button bLetras = new();
                bLetras.Content = letras[i].ToString();
                bLetras.Margin = new Thickness(5);
                bLetras.Padding = new Thickness(3);
                bLetras.Click += BLetras_Click;
                spBotones.Children.Add(bLetras);
                
            }
        }
        private int cont = 0;
        private void BSiguiente_Click(object sender, RoutedEventArgs e)
        {
            foreach (var boton in spBotones.Children)
            {
                if (boton is Button botonDesactivado)
                {
                    botonDesactivado.IsEnabled = true;
                }
            }
            if (cont == palabras.Length)
            {
                cont = 0;
            }
            palabraMisteriosa = palabras[cont].ToLower();
            palabraSegmentada = new char[palabraMisteriosa.Length];
            for (int i = 0; i < palabraMisteriosa.Length; i++)
            {
                palabraSegmentada[i] += '-';
            }
            palabra.Content = String.Join("", palabraSegmentada);
            cont++;
        }

        private void BLetras_Click(object sender, RoutedEventArgs e)
        {
            Button botonSeleccionado = sender as Button;
            char letra = ' ';
            if (botonSeleccionado != null)
            {
                letra = botonSeleccionado.Content.ToString()[0];
            };
            for (int i = 0; i < palabraMisteriosa.Length; i++)
            {

                if (palabraMisteriosa[i] == letra)
                {
                    palabraSegmentada[i] = letra;
                }
                else if (palabraSegmentada[i] != '-') { }
            }
            palabra.Content = String.Join("", palabraSegmentada);
            botonSeleccionado.IsEnabled = false;
            if (String.Join("", palabraSegmentada).Equals(palabraMisteriosa))
            {
                MessageBox.Show("Has adivinado la palabra!!!");
                palabraSegmentada = new char[palabraMisteriosa.Length];
            }
        }
    }
}
