using Microsoft.Win32;
using Punto3;
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
    //objetos de la clase ReservaNatural. .
    //La clase CentroEcologico debe implementar los siguientes métodos:
    //1. Un constructor que solicite la carga secuencial de las 3 reservas. x
    //2. Un método que enliste cada reserva junto a la cantidad total de avistamientos que
    //registró en toda su superficie(la suma de toda su matriz rectangular).
    //3. Un método que determine e informe cuál fue la coordenada o sector específico([fila,
    //columna]) que registró la mayor concentración de avistamientos de toda la red de
    //reservas, indicando a qué reserva pertenece.
    class ReservaNatural
    {
        private string NombreReserva;
        private int[,] avistamientos;

        public ReservaNatural()
        {
            avistamientos = new int[3, 3];

            Console.Write("\nIngrese el nombre de la reserva: ");
            NombreReserva = Console.ReadLine();
            Console.WriteLine(" ");

            for (int f = 0; f < 3; f++)
            {
                for (int c = 0; c < 3; c++)
                {
                    Console.Write($"Ingrese la cantidad de animales avistados en el cuadrante: {(f + 1, c + 1)}: ");
                    string linea;
                    linea = Console.ReadLine();
                    avistamientos[f, c] = int.Parse(linea);
                }
            }
        }
        public string devolverNombre()
        {
            return NombreReserva;
        }
        public int devolverPosicion(int f, int c)
        {
            return avistamientos[f, c];
        }
    }

    class CentroEcologico
    {
        private ReservaNatural[] reservas;
        public CentroEcologico()
        {
            reservas = new ReservaNatural[3];

            for (int i = 0; i < 3; i++)
            {
                reservas[i] = new ReservaNatural();
            }
        }

        public void imprimirDatosReservas()
        {
            Console.WriteLine("\n---Mapa de avistamientos---");
            for (int i = 0; i < 3; i++)
            {

                Console.Write($"\nReserva {reservas[i].devolverNombre()}: \n");
                for (int f = 0; f < 3; f++)
                {
                    for (int c = 0; c < 3; c++)
                    {
                        Console.Write("[" + reservas[i].devolverPosicion(f, c) + "] ");
                    }
                    Console.WriteLine();
                }
            }
        }
        public void avistamientosTotales()
        {
            int suma = 0;

            for (int i = 0; i < 3; i++)
            {
                for (int f = 0; f < 3; f++)
                {
                    for (int c = 0; c < 3; c++)
                    {
                        suma += reservas[i].devolverPosicion(f, c);
                    }
                }
                Console.WriteLine($"\nLos avistamientos totales en la reserva {reservas[i].devolverNombre()} fueron: " + suma);
                suma = 0;
            }
        }
        public void areaMasAvistamientos()
        {
            int maxPeso = reservas[0].devolverPosicion[0,0];
            string sucursalMayor = reservas[0].devolverNombre();

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < paquetes[i].Length; j++)
                {
                    if (paquetes[i][j] > maxPeso)
                    {
                        maxPeso = paquetes[i][j];
                        sucursalMayor = sucursales[i];
                    }
                }
            }

            Console.WriteLine("El paquete mas pesado de la empresa pesa: " + maxPeso + " kg");
            Console.WriteLine("Pertenece a la sucursal: " + sucursalMayor);
        }
        }
        static void Main(string[] args)
        {
            CentroEcologico ce = new CentroEcologico();

            ce.imprimirDatosReservas();
            ce.avistamientosTotales();
            ce.areaMasAvistamientos();

            Console.ReadKey();
        }
    }
}
