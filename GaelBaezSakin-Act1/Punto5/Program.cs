using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Realizar la carga del radio de un círculo, mostrar por pantalla la circunferencia y el área del mismo
            //(La circunferencia se calcula multiplicando el doble del radio por π (pi), y el área se calcula multiplicando π por el cuadrado del radio).

            double radio, circunferencia, area;
            string linea;

            Console.Write("Ingrese el valor del radio: ");
            linea = Console.ReadLine();
            radio = double.Parse(linea);

            circunferencia = (radio * 2) * 3.14;
            area = (radio * radio) * 3.14;

            Console.WriteLine("La circunferencia es: " + circunferencia);
            Console.WriteLine("El area es: " + area);

            Console.ReadKey();
        }
    }
}
