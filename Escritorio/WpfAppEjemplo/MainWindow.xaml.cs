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

namespace WpfAppEjemplo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button boton = (Button)sender;
            MessageBoxResult resultado;
            resultado = MessageBox.Show($"{boton.Content.ToString()},[{sender.GetType()}]","Atención",MessageBoxButton.YesNo,MessageBoxImage.Information);
            if (resultado == MessageBoxResult.Yes)
            {
                App.Current.Shutdown();
            }
        }
    }
}