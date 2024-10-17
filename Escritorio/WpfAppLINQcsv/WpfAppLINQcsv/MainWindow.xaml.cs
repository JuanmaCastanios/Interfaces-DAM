using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace WpfAppLINQcsv
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //Lleno el ListBox con el resultado de la consulta LINQ 
            //contra el archivo CSV
            //la función leerCSV devuelve una colección
            /*
             Los archivos CSV son archivos de texto sin caracteres
            de control (negrita, colores, etc...) que contienen
            filas(registros) con campos separados por comas
            podemos decidir el caracter delimitador para que
            no sea obligatoriamente la , (; : etc )
            lo habitual es que la primera línea de ese archivo
            contenga los encabezados con los nombres de los campos
            */
            foreach (Empleado item in LeerCSV())
            {
                lbEmpleados.Items.Add($"{item.Apellidos}, {item.Nombre} ({item.FechaNacimiento:d})");
            }

            lvResultados.ItemsSource = LeerCSV();
            //como este ListView se lena con el resultado de LeerCSV
            //sus elementos son de tipo Empleado
            //y puedo enlazar las propiedades de Empleado
            //con DisplayMemberBinding
        }

        private List<Empleado> LeerCSV()
        {
            /*
            return (File.ReadAllLines("Empleados.csv")
                         .Select(x => x.Split(','))
                         .Select(campos =>
                              new Empleado
                              {
                                  Nombre = campos[0],
                                  Apellidos = campos[1],
                                  FechaNacimiento = DateTime.Parse(campos[2]),
                                  Departamento = campos[3]
                              })).ToList<Empleado>();
            */
            //la función Split obtiene un array con elementos
            //a partir de una cadena
            // sigiendo el critero de separción proporcionado
            // en nuestro caso "e"  tiene una cadena
            // que será cada fila con todos los campos
            // y una vez aplicado Split
            // tendré una array cuyos elementos son los campos
            // separados por comas 
            // Juan,garcía Gómez,12/03/1980,conserjería <--- e
            // después de Split --> 
            //     campos[0]="Juan", campos[1]="garcía Gómez" ...
            return (from e in File.ReadAllLines("Empleados.csv")
                    let campos = e.Split(',')
                    select new Empleado //proyecto el resultado en el tipo Empleado
                    {
                        Nombre = campos[0],
                        Apellidos = campos[1],
                        FechaNacimiento = DateTime.Parse(campos[2]),
                        Departamento=campos[3]
                    }).ToList<Empleado>(); // <-- Ejecuta la consulta y la transforma en una colección de tipo List<Empleado>
            // "let" obtiene un resultado intermedio que puedo
            // utilizar posteriormente en la consulta
            // en este caso let proporciona una colección 
            // de arrays de campos
        }

        private void Button_Click(object sender, RoutedEventArgs e)
            //botón ListBox
        {
            Panel.SetZIndex(lbEmpleados, 1); //ZIndex=1 superpone el control al que está en ZIndex = 0
            Panel.SetZIndex(lvResultados, 0); //ZIndex=0 envía el control al "fondo" del eje Z
            //lbEmpleados.Visibility=...
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            // botón ListView
            Panel.SetZIndex(lvResultados, 1);
            Panel.SetZIndex(lbEmpleados, 0);
        }
    }

    internal class Empleado
    {
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Departamento { get; set; }
        public int Edad
        {
            get
            {
                int edad = DateTime.Now.Year - FechaNacimiento.Year;
                // ? puede emplearse como operador ternario
                // valor = condicion? valorCIERTO : valorFALSO
                return (FechaNacimiento > DateTime.Now.AddYears(-edad)) ? --edad : edad;
                // he empleado --edad en lugar de edad--
                // porque edad-- primero devuelve el valor y después resta 1,
                // que en este caso no es lo que quiero, necesito --edad
            }
        }
    }
}
