using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    //En el segundo archivo, agregar un método Resumen() que muestre el título, autor y
    //si el libro es corto(menos de 100 páginas) o largo.
    partial class Libros
    {
        public void Resumen()
        {
            Console.WriteLine("\nTítulo: " + Titulo);
            Console.WriteLine("Autor: " + Autor);
            Console.WriteLine("Páginas: " + Paginas);
            if (Paginas < 100)
            {
                Console.WriteLine("\nEl libro es corto.");
            }
            else
            {
                Console.WriteLine("\nEl libro es largo.");
            }
        }
    }
}
