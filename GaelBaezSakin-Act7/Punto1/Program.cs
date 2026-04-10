using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    // Desarrollar un programa que permita ingresar un vector de 8 elementos, e informe:
    // El valor acumulado de todos los elementos del vector.
    //El valor acumulado de los elementos del vector que sean mayores a 36.
    //Cantidad de valores mayores a 50.

    class EjVector1
    {
        private int[] vector; 
        public void cargarElementos()
        {    
        vector = new int[8];

            for (int i = 0; i < 8; i++) {
                Console.WriteLine("Ingresa un valor: ");
                string linea;
                linea = Console.ReadLine();
                vector[i] = int.Parse(linea);           
            }    
        }
        public void valoresMayor36()
        {
            int sumam36;
            sumam36 = 0;

            foreach (int valor in vector)
            {
                if (valor >= 36)
                {
                    sumam36 += valor;
                }
            }
            Console.WriteLine("El valor acumulado de los valoes mayores a 36 es: " + sumam36);
        }
        public void valoresMayor50()
        {
            int sumam50;
            sumam50 = 0;

            foreach (int valor in vector)
            {
                if (valor >= 50)
                {
                    sumam50 += valor;
                }
            }
            Console.WriteLine("El valor acumulado de los valoes mayores a 50 es: " + sumam50);
        }
        public void suma()
        {
            int suma;
            suma = 0;

            for (int i = 0; i < 8; i++)
            {
                suma = suma + vector[i];
            }
            Console.WriteLine("La suma de los 8 valores es: " + suma);
        }
        public void imprimir()
        {
            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine(vector[i]);
            }
        }
        static void Main(string[] args)
        {
            EjVector1 ev = new EjVector1();
            ev.cargarElementos();
            ev.imprimir();
            ev.suma();
            ev.valoresMayor36();
            ev.valoresMayor50();

            Console.ReadKey();

        }
    }
}
