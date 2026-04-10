using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto4
{
    //Cargar un vector de 10 elementos y verificar posteriormente si el mismo está
    //ordenado de menor a mayor y de mayor a menor.
    class vectorOrdenado
    {
        private int[] Vector;
        public void ingresarValores()
        {

            Vector = new int[10];
            for (int i = 0; i < 10; i++)
            {

                Console.WriteLine("Ingresa un valor del VectorA: ");
                string linea;
                linea = Console.ReadLine();
                Vector[i] = int.Parse(linea);

            }
        }
        public void verificarOrden()
        {
            int ordenAsc;
            int ordenDes;
            ordenAsc = 0;
            ordenDes = 0;
            for (int i = 0; i < 9; i++)
            {
                if (Vector[i + 1] > i)
                {
                    ordenAsc++;
                }
            }
            for (int i = 0; i < 9; i++)
            {
                if (Vector[i + 1] <= Vector[i])
                    {
                    ordenDes++;
                }
            }
            if (ordenAsc == 9)
            {
                Console.WriteLine("El vector está ordenado de menor a mayor.");
            }
            else if (ordenDes == 9)
            {
                Console.WriteLine("El vector está ordenado de mayor a menor.");
            }
            else
            {
                Console.WriteLine("El vector está desordenado.");
            }
        }
        static void Main(string[] args)
        {
            vectorOrdenado vo = new vectorOrdenado();
            vo.ingresarValores();
            vo.verificarOrden();

            Console.ReadKey();
        }
    }
}
