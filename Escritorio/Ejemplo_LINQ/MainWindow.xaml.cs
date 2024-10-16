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
        private int[] numbers = [0, 1, 2, 3, 4, 5, 6];
        public MainWindow()
        {
            InitializeComponent();

            var c1 =
            from num in numbers
            where (num % 2) == 0
            select num;
            Ejecutar1(c1);
        }

        private void Ejecutar1(IEnumerable<int> consultilla)
        {
            foreach (int num in consultilla)
            {
                Console.Write("{0,1} ", num);
            }
        }

    }
}