using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace Punto3
{
    //    3. Geolocalización de Reservas Naturales
    //Un centro de ecología realiza mapeos de biodiversidad para contabilizar el avistamiento de
    //especies protegidas en cuadrículas de territorio.
    //● Confeccionar la clase ReservaNatural que tenga como atributos privados el
    //NombreReserva y una matriz llamada avistamientos de 3x3(que representa un
    //mapa de coordenadas o sectores de 3 filas y 3 columnas, donde se almacena la
    //cantidad de animales avistados en cada sector). El constructor de la clase debe
    //cargar por teclado el nombre y rellenar el mapa de avistamientos.
    //● Confeccionar la clase colaboradora CentroEcologico que contenga un vector de 3
    //objetos de la clase ReservaNatural.
    //La clase CentroEcologico debe implementar los siguientes métodos:
    //1. Un constructor que solicite la carga secuencial de las 3 reservas.
    //2. Un método que enliste cada reserva junto a la cantidad total de avistamientos que
    //registró en toda su superficie(la suma de toda su matriz rectangular).
    //3. Un método que determine e informe cuál fue la coordenada o sector específico([fila,
    //columna]) que registró la mayor concentración de avistamientos de toda la red de
    //reservas, indicando a qué reserva pertenece.
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
