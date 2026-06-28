using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
//En el primer archivo, declarar las propiedades Título, Autor y Páginas.Validar que la
//cantidad de páginas sea mayor a 10.Valores cargados desde consola
//En el segundo archivo, agregar un método Resumen() que muestre el título, autor y
//si el libro es corto(menos de 100 páginas) o largo.
//Desde la clase principal, cargar 2 libros y mostrar cuál es el más extenso.
    class Program
    {
        public void MostrarLibroMasExtenso(Libros l1, Libros l2)
        {
            if (l1.Paginas > l2.Paginas)
            {
                Console.WriteLine($"\nEl libro más extenso es: {l1.Titulo} con {l1.Paginas} páginas");
            }
            else if (l2.Paginas > l1.Paginas)
            {
                Console.WriteLine($"\nEl libro más extenso es: {l2.Titulo} con {l2.Paginas} páginas");
            }
            else
            {
                Console.WriteLine("\nAmbos libros tienen la misma cantidad de páginas.");
            }
        }
        static void Main(string[] args)
        {
            Libros l1 = new Libros();
            Libros l2 = new Libros();

            Console.Write("Ingrese el nombre del libro: ");
            l1.Titulo = Console.ReadLine();
            Console.Write("Ingrese el autor/a del libro: ");
            l1.Autor = Console.ReadLine();
            Console.Write("Ingrese la cantidad de páginas: ");
            l1.Paginas = int.Parse(Console.ReadLine());

            Console.Write("\nIngrese el nombre del libro: ");
            l2.Titulo = Console.ReadLine();
            Console.Write("Ingrese el autor/a del libro: ");
            l2.Autor = Console.ReadLine();
            Console.Write("Ingrese la cantidad de páginas: ");
            l2.Paginas = int.Parse(Console.ReadLine());

            l1.Resumen();
            l2.Resumen();


            Program p = new Program();
            p.MostrarLibroMasExtenso(l1, l2);

            Console.ReadKey();
        }
    }
}
