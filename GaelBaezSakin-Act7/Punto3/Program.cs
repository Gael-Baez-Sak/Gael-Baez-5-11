using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
//Pedir al usuario que ingrese las puntuaciones obtenidas en 6 partidas seguidas de
//un videojuego.El programa debe:
// Mostrar la puntuación más alta y la más baja.
// Calcular el promedio de puntuación.
// Contar cuántas veces superó los 500 puntos.
    class puntuacionJuego
    {
        private int[] Puntuacion;
        private float promedio;

        public void cargarPuntuaciones()
        {
            Puntuacion = new int[6];
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("Ingresa tu puntuacion: ");
                string linea;
                linea = Console.ReadLine();
                Puntuacion[i] = int.Parse(linea);
            }
            Console.WriteLine("  ");
        }
        public void minYMax() 
        {
            int mayor = Puntuacion.Max();
            int menor = Puntuacion.Min();

            Console.WriteLine("Puntuación máxima: " + mayor);
            Console.WriteLine("Puntuación mínima: " + menor);
            Console.WriteLine("  ");
        }
        public void promedioPuntuaiones() 
        {
            float suma;
            suma = 0;

            for (int i = 0; i < 6; i++)
            {
                suma = suma + Puntuacion[i];
            }
            promedio = suma / 6;
            Console.WriteLine("El promedio de las puntuaciones es: " + promedio);
             Console.WriteLine("  ");   
        }
        public void mayorA500() 
        {
            int mayora500;
            mayora500 = 0;
            for(int i = 0;i < 6; i++)
            {
                if (Puntuacion[i] > 500)
                {
                    mayora500++;
                }
            }
            Console.WriteLine("La puntuacion es mayor a 500 " + mayora500 + " veces");
        }
        static void Main(string[] args)
        {
            puntuacionJuego pj = new puntuacionJuego();
            pj.cargarPuntuaciones();
            pj.promedioPuntuaiones();
            pj.minYMax();
            pj.mayorA500();

            Console.ReadKey();
        }
    }
}
