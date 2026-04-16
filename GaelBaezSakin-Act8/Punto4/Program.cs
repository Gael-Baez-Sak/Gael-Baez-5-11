using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto4
{
    //Cargar en un vector los nombres de 5 países y en otro vector paralelo la cantidad de
    //habitantes de este.Ordenar alfabéticamente e imprimir los resultados.Por último
    //ordenar con respecto a la cantidad de habitantes (de mayor a menor) e imprimir
    //nuevamente.
    internal class OrdenarPaises
    {
        private string[] paises;
        private int[] habitantes;

        public void cargarElementos()
        {
            paises = new string[5];
            habitantes = new int[5];

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Ingresa el nombre del país {i + 1}: ");
                paises[i] = Console.ReadLine();
                Console.Write($"Ingresa los habitantes de {paises[i]}: ");
                habitantes[i] = int.Parse(Console.ReadLine());
            }
        }

        public void ordenarAlfabeticamente()
        {
            Array.Sort(paises, habitantes);
            Console.WriteLine("  ");
            Console.WriteLine("Ordenado por Nombre");
        }

        public void ordenarPorHabitantes()
        {
            Array.Sort(habitantes, paises);
            Array.Reverse(habitantes);
            Array.Reverse(paises);
            Console.WriteLine("  ");
            Console.WriteLine("Ordenado por Habitantes (Mayor a Menor)");
        }

        public void imprimir()
        {
            for (int i = 0; i < paises.Length; i++)
            {
                Console.WriteLine($"{paises[i]}: {habitantes[i]} habitantes.");
            }
        }

        static void Main(string[] args)
        {
            OrdenarPaises op = new OrdenarPaises();
            op.cargarElementos();
            op.ordenarAlfabeticamente();
            op.imprimir();
            op.ordenarPorHabitantes();
            op.imprimir();

            Console.ReadKey();
        }
    }
}
