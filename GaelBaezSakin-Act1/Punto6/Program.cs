using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Escribir un programa que lea el peso (en kilogramos) y la altura (en metros) de una persona, y mostrar por pantalla su índice de masa corporal (IMC) (El IMC se calcula dividiendo el peso entre el cuadrado de la altura).

            int peso, altura, IMC;
            string linea;

            Console.Write("Ingrese su peso: ");
            linea = Console.ReadLine();
            peso = int.Parse(linea);

            Console.Write("Ingrese su altura: ");
            linea = Console.ReadLine();
            altura = int.Parse(linea);

            IMC =  (altura * altura) / peso;
            
            Console.WriteLine("Su IMC es: " + IMC);

            Console.ReadKey();
        }
    }
}
