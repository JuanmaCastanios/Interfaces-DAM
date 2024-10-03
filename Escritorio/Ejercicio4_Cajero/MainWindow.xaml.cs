using System.Runtime.InteropServices.Marshalling;
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

namespace Ejercicio4_Cajero
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string pinUsuario = "1234";
        private string pin = "";
        private string pinEnmascarado = "";
        private bool pinCorrecto = false;
        private string cantidadSacar = "";

        private int[] billetes = { 10, 20, 30, 40, 50 };

        private int[] numBilletes = { 0, 0, 0, 0, 0 };
        


        public MainWindow()
        {
            InitializeComponent();
            foreach (var billete in billetes)
            {
                lbBilletes.Items.Add(billete);
            }
        }

        private void Calcular_Billetes()
        {
            int num = int.Parse(cantidadSacar);
            bool continuar = true;
            while (continuar)
            {
                if(num - 200 >= 0)
                {
                    numBilletes[0]++;
                    num -= 200;
                }
                else if (num - 100 >= 0)
                {
                    numBilletes[1]++;
                    num -= 100;
                }
                else if (num - 50 >= 0)
                {
                    numBilletes[2]++;
                    num -= 50;
                }
                else if (num - 20 >= 0)
                {
                    numBilletes[3]++;
                    num -= 20;
                }
                else if (num - 10 >= 0)
                {
                    numBilletes[4]++;
                    num -= 10;
                }
                else if(num == 0)
                {
                    continuar = false;
                }
            }
        }

        private void Digitos_Click(Object sender, RoutedEventArgs e)
        {
            Button botonSeleccionado = sender as Button;
            if (pin.Length < 4 && !pinCorrecto)
            {
                pin += botonSeleccionado.Content.ToString();
                pinEnmascarado += "*";
                textBlockDisplay.Text = "Introduzca su PIN: " + pinEnmascarado;
            }
            else
            {
                cantidadSacar += botonSeleccionado.Content.ToString();
                textBlockDisplay.Text = "Introduzca Cantidad: " + cantidadSacar;
            }
        }
        
        private void botonBorrar_Click(Object sender, RoutedEventArgs e)
        {          

        }

        private void botonOk_Click(Object sender, RoutedEventArgs e)
        {
            if (pinCorrecto)
            {
                Calcular_Billetes();
                if (numBilletes[0] != 0)
                {
                    listBoxResultado.Items.Add(numBilletes[0] + " de 200€");
                    billetes[0] -= numBilletes[0];
                }
                if (numBilletes[1] != 0)
                {
                    listBoxResultado.Items.Add(numBilletes[1] + " de 100€");
                    billetes[1] -= numBilletes[1];
                }
                if (numBilletes[2] != 0)
                {
                    listBoxResultado.Items.Add(numBilletes[2] + " de 50€");
                    billetes[2] -= numBilletes[2];
                }
                if (numBilletes[3] != 0)
                {
                    listBoxResultado.Items.Add(numBilletes[3] + " de 20€");
                    billetes[3] -= numBilletes[3];
                }
                if (numBilletes[4] != 0)
                {
                    listBoxResultado.Items.Add(numBilletes[4] + " de 10€");
                    billetes[4] -= numBilletes[4];
                }
                lbBilletes.Items.Clear();
                foreach (var billete in billetes)
                {
                    lbBilletes.Items.Add(billete);
                }

            }
            else if (pinUsuario.Equals(pin))
            {
                pinCorrecto = true;
                textBlockDisplay.Text = "Introduzca Cantidad: ";
            }
            else
            {
                textBlockDisplay.Text = "Introduzca su PIN: ";
                pin = "";
                pinEnmascarado = "";
            }
        }

        private void botonRecoger_Click(Object sender, RoutedEventArgs e)
        {
            pin = "";
            cantidadSacar = "";
            listBoxResultado.Items.Clear ();
            pinCorrecto = false;
            textBlockDisplay.Text = "Introduzca su PIN: ";
            pinEnmascarado = "";
            for (int i = 0; i < numBilletes.Length;i++)
            {
                numBilletes[i] = 0;
            }
        }
    }
}