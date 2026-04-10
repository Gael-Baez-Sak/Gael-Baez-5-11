using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    //Definir un vector donde almacenar los nombres de 5 países.Confeccionar el
    //algoritmo de ordenamiento alfabético.
    internal class Paises
    {
        private string[] vectorPaises;

        public void cargarVector()
        {
            vectorPaises = new string[5];
            for (int i = 0; i < vectorPaises.Length; i++)
             {
                Console.WriteLine("Ingresa un pais: ");
                vectorPaises[i] = Console.ReadLine();
            }
        }
        public void ordenarVector()
        {
            Array.Sort(vectorPaises);    
        }
        public void imprimirVector()
        {
            foreach (string pais in vectorPaises)
            {
                Console.WriteLine("- " + pais);
            }
        }
        static void Main(string[] args)
        {
            Paises p = new Paises();
            p.cargarVector();
            p.ordenarVector();
            p.imprimirVector();

            Console.ReadKey();
        }
    }
}
