using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    //Realizar un programa que imprima 25 términos de la serie 11 - 22 - 33 - 44, etc. (No se ingresan valores por teclado)
    internal class Program
    {
        static void Main(string[] args)
        {
            int terminos, maximo;
            terminos = 0;
            maximo = 0;

            while (maximo <= 25)
            {

                terminos = terminos + 11;
                Console.WriteLine(terminos);
                maximo++;

            }
        }
    }
}
