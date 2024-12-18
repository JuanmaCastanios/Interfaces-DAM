using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace EjercicioMAUI_PrimeraPagina
{
    internal partial class ServicioModelView
    {
        private ObservableCollection<Restaurante> restaurantes;
        [ObservableProperty]
        private Restaurante? currentRestaurante;
        public String Posicion { get; set; }
        public int Indice { get; set; }

        public bool CondicionSiguiente => Indice < (restaurantes.Count - 1);
        public bool CondicionAnterior => Indice > 0;

        [RelayCommand(CanExecute = nameof(CondicionSiguiente))]
        private void Siguiente()
        {
            Indice++;
            currentRestaurante = restaurantes[Indice];
        }
        [RelayCommand(CanExecute = nameof(CondicionAnterior))]
        private void Anterior()
        {
            Indice--;
            currentRestaurante = restaurantes[Indice];
            
        }

        public ServicioModelView()
            {
                restaurantes = new ObservableCollection<Restaurante>
                {
                    new Restaurante{Titulo="UNO",
                        Nombre="restaurante uno",
                        Lema="el número 1",
                        Direccion="Calle del uno,11",
                        Localidad="San Cipriuno",
                        Provincia="Valladolid",
                        Foto="https://picsum.photos/id/10/300/300",
                        ColorBase=Colors.AliceBlue},
                    new Restaurante{Titulo="DOS",
                        Nombre="restaurante dos",
                        Lema="el número 2",
                        Direccion="Calle del dos,22",
                        Localidad="Dosaguas",
                        Provincia="Palencia",
                        Foto="https://picsum.photos/id/11/300/300",
                        ColorBase=Colors.AntiqueWhite},
                    new Restaurante{Titulo="TRES",
                        Nombre="restaurante tres",
                        Lema="el número 3",
                        Direccion="Calle del tres,33",
                        Localidad="Tres Pinares",
                        Provincia="Valladolid",
                        Foto="https://picsum.photos/id/12/300/300",
                        ColorBase = Colors.Aqua},
                    new Restaurante{Titulo="CUATRO",
                        Nombre="restaurante cuatro",
                        Lema="el número 4",
                        Direccion="Calle del cuatro,44",
                        Localidad="VillaCuatro",
                        Provincia="Salamanca",
                        Foto="https://picsum.photos/id/13/300/300",
                        ColorBase=Colors.Aquamarine}
                };
            Indice = 0;
            currentRestaurante = restaurantes[Indice];
            }
        }
}
