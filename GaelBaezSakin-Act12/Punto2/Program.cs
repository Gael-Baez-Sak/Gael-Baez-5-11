using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
//Un cine tiene 4 salas con diferentes capacidades de espectadores(la Sala 1 tiene 10
//asientos, la Sala 2 tiene 15, la Sala 3 tiene 8 y la Sala 4 tiene 12).
//● Definir una matriz irregular de 4 filas para representar los asientos.
//● Métodos:
//1. Inicializar la matriz con los tamaños de las salas mencionadas(sin
//intervención del operador).
//2. Crear un método de &quot; Venta de Entradas & quot; que permita cargar la edad del
//espectador en un asiento específico(fila y columna).
//3. Imprimir el mapa de ocupación de las salas indicando la edad del espectador
//en cada asiento.
//4. Calcular cuántos menores de edad (menos de 18 años) hay en cada sala.
//5. Informar cuál es el promedio de edad de los espectadores de todo el
//complejo.
    internal class Program
    {
        private int[][] salas;
        public void InicializarSalas()
        {
            salas = new int[4][];

            salas[0] = new int[10];
            salas[1] = new int[15];
            salas[2] = new int[8];
            salas[3] = new int[12];

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < salas[i].Length; j++)
                {
                    salas[i][j] = 0;
                }
            }
            Console.WriteLine("Salas inicializadas correctamente.");
        }

        public void VentaDeEntradas()
        {
            Console.Write("Ingrese el numero de sala (1 a 4): ");
            int nroSala = int.Parse(Console.ReadLine());
            int fila = nroSala - 1;

            Console.Write("Ingrese el numero de asiento (1 a " + salas[fila].Length + "): ");
            int nroAsiento = int.Parse(Console.ReadLine());
            int columna = nroAsiento - 1;

            Console.Write("Ingrese la edad del espectador: ");
            int edad = int.Parse(Console.ReadLine());

            salas[fila][columna] = edad;
        }
        public void ImprimirMapaOcupacion()
        {
            for (int i = 0; i < 4; i++)
            {
                Console.Write("Sala " + (i + 1) + ": ");
                for (int j = 0; j < salas[i].Length; j++)
                {
                    Console.Write("[" + salas[i][j] + "] ");
                }
                Console.WriteLine();
            }
        }
        public void CalcularMenoresPorSala()
        {
            for (int i = 0; i < 4; i++)
            {
                int contadorMenores = 0;
                for (int j = 0; j < salas[i].Length; j++)
                {
                    if (salas[i][j] > 0 && salas[i][j] < 18)
                    {
                        contadorMenores = contadorMenores + 1;
                    }
                }
                Console.WriteLine("Sala " + (i + 1) + ": " + contadorMenores + " menores de edad.");
            }
        }
        public void CalcularPromedioEdadComplejo()
        {
            double sumaEdades = 0;
            int totalEspectadores = 0;

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < salas[i].Length; j++)
                {
                    if (salas[i][j] > 0)
                    {
                        sumaEdades = sumaEdades + salas[i][j];
                        totalEspectadores = totalEspectadores + 1;
                    }
                }
            }

            if (totalEspectadores > 0)
            {
                double promedio = sumaEdades / totalEspectadores;
                Console.WriteLine("El promedio de edad de todo el complejo es: " + promedio + " años.");
            }
            else
            {
                Console.WriteLine("No hay espectadores en el complejo para calcular el promedio.");
            }
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            p.InicializarSalas();
            p.VentaDeEntradas();
            p.VentaDeEntradas();
            p.VentaDeEntradas();
            p.ImprimirMapaOcupacion();
            p.CalcularMenoresPorSala();
            p.CalcularPromedioEdadComplejo();

            Console.ReadKey();
        }
    }
}
