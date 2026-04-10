using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    //Realizar un programa que pida la carga de dos vectores numéricos enteros de 4
    //elementos.Obtener la suma de los dos vectores, dicho resultado guardarlo en untercer vector del mismo tamaño.
    //Sumar componente a componente.
   class SumaVectores
    {
        private int[] vectorA;
        private int[] vectorB;
        private int[] vectorC;
        public void cargarElementosVA()
        {
            vectorA = new int[4];
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Ingresa un valor del VectorA: ");
                string linea;
                linea = Console.ReadLine();
                vectorA[i] = int.Parse(linea);
            }
        }
        public void cargarElementosVB()
        {
            vectorB = new int[4];
            for (int i = 0; i < 4; i++)
            {

                Console.WriteLine("Ingresa un valor del VectorB: ");
                string linea;
                linea = Console.ReadLine();
                vectorB[i] = int.Parse(linea);
            }
        }
        public void Sumar()
        {
            vectorC = new int[4];
            for (int i = 0; i < 4; i++)
            {
                vectorC[i] = vectorA[i] + vectorB[i];
            }
        }
        public void mostrarResultados()
        {
            Console.Write("El resultado de la suma es: ");
            for (int i = 0; i < 4; i++)
            {

                Console.WriteLine($"Posición {i}: {vectorC[i]}");
            }
        }
        static void Main(string[] args)
        {
            SumaVectores sm = new SumaVectores();
            sm.cargarElementosVA();
            sm.cargarElementosVB();
            sm.Sumar();
            sm.mostrarResultados();

            Console.ReadKey();
        }
    }
}
