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

namespace EjercicioXAML1_GridConInkCanvas
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            miInkCanvas.DefaultDrawingAttributes.Color = Colors.Black;
            miInkCanvas.DefaultDrawingAttributes.Width = 2;
            miInkCanvas.DefaultDrawingAttributes.Height = 2;
        }

        private void InkCanvas_PreviewMouseDown(object sender, InkCanvasStrokeCollectedEventArgs e)
        {
            Random rnd = new Random();
            Color colorAleatorio = Color.FromRgb(
                (byte)rnd.Next(0, 256),
                (byte)rnd.Next(0, 256),
                (byte)rnd.Next(0, 256)
            );
            miInkCanvas.DefaultDrawingAttributes.Color = colorAleatorio;
            double grosorAleatorio = rnd.Next(2, 11);
            miInkCanvas.DefaultDrawingAttributes.Width = grosorAleatorio;
            miInkCanvas.DefaultDrawingAttributes.Height = grosorAleatorio;
        }

    }
}