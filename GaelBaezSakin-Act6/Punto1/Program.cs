using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    //Desarrollar una clase que represente un punto en el plano y tenga los
    //siguientes métodos: cargar los valores de x e y, imprimir en que cuadrante se
    //encuentra dicho punto(concepto matemático, primer cuadrante si x e y son
    //positivas, si x&lt;0 e y&gt;0 segundo cuadrante, etc.)
    class Punto
    {
        private int x, y;

        public void Cargar()
        {
            Console.Write("Ingrese la coordenada X: ");
            x = int.Parse(Console.ReadLine());

            Console.Write("Ingrese la coordenada Y: ");
            y = int.Parse(Console.ReadLine());
        }

        public void ImprimirCuadrante()
        {
            Console.Write($"El punto ({x}, {y}) se encuentra en: ");

            if (x > 0 && y > 0)
            {
                Console.WriteLine("Primer Cuadrante.");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("Segundo Cuadrante.");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("Tercer Cuadrante.");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("Cuarto Cuadrante.");
            }
            else if (x == 0 && y == 0)
            {
                Console.WriteLine("el Origen.");
            }
            else if (x == 0)
            {
                Console.WriteLine("el Eje Y.");
            }
            else if (y == 0)
            {
                Console.WriteLine("el Eje X.");
            }
        }
        static void Main(string[] args)
        {
            Punto punto1 = new Punto();
            punto1.Cargar();
            punto1.ImprimirCuadrante();

            Console.ReadKey();
        }

    }
}