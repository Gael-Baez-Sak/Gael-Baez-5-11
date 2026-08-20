using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Punto6
{
    //    6-
    //Una biblioteca pública gestiona de forma digital su catálogo de obras literarias
    //para organizar la consulta de ejemplares por parte de los lectores.
    // Crear la clase Libro que contenga como atributos privados: titulo
    //(string) y anioPublicacion(int). Definir sus propiedades de solo lectura y
    //un constructor que reciba tit y anio.
    // Crear la clase BibliotecaCentral que administre una lista de objetos
    //List.
    // Métodos en BibliotecaCentral:
    //1. CargarCatalogo(): Solicitar por teclado títulos y años de
    //publicación para agregar libros a la lista mediante.Add(). La carga
    //finaliza cuando el usuario ingresa la palabra &quot; FIN&quot; como título.
    //2. ListarCatalogo(): Mostrar en pantalla todos los libros del catálogo
    //junto a la cantidad total de obras registradas mediante la propiedad
    //.Count.
    //3. FiltrarPorAnio(): Solicitar al usuario un año determinado e
    //imprimir en consola únicamente aquellos libros cuyo año de
    //publicación sea menor a dicho valor.
    //4. RemoverLibro(): Pedir al usuario el título de un libro y, utilizando
    //los métodos de búsqueda y remoción de listas, eliminarlo de la
    //colección si se encuentra presente.
    class Libro
    {
        private string titulo;
        private int añoPublicacion;
        public string Titulo
        {
            get { return titulo; }
        }
        public int AñoPublicacion
        {
            get { return añoPublicacion; }
        }
        public Libro(string tit, int año)
        {
            titulo = tit;
            añoPublicacion = año;
        }
    }
    class Biblioteca
    {
        private List<Libro> catalogo = new List<Libro>();

        public void CargarCatalogo()
        {
            //1. CargarCatalogo(): Solicitar por teclado títulos y años de
            //publicación para agregar libros a la lista mediante.Add(). La carga
            //finaliza cuando el usuario ingresa la palabra &quot; FIN&quot; como título.
            while (true)
            {
                Console.Write("Ingrese el titulo del libro (o 'FIN' para terminar): ");
                string titulo = Console.ReadLine();
                if (titulo == "FIN")
                {
                    break;
                }

                Console.Write("Ingrese el año de publicacion: ");
                int año = int.Parse(Console.ReadLine());
                catalogo.Add(new Libro(titulo, año));
            }
        }

        public void ListarCatalogo()
        {
            //2. ListarCatalogo(): Mostrar en pantalla todos los libros del catálogo
            //junto a la cantidad total de obras registradas mediante la propiedad
            //.Count.
            Console.WriteLine("\nCatalogo de libros:");
            foreach (var libro in catalogo)
            {
                Console.WriteLine($"Titulo: {libro.Titulo}, Año: {libro.AñoPublicacion}");
            }
            Console.WriteLine($"Cantidad total de obras registradas: {catalogo.Count}");
        }

        public void FiltrarPorAño()
        {
            //3. FiltrarPorAño(): Solicitar al usuario un año determinado e
            //imprimir en consola únicamente aquellos libros cuyo año de
            //publicación sea menor a dicho valor.
            Console.Write("\nIngrese un año para buscar los libros publicados antes de ese año: ");
            int año = int.Parse(Console.ReadLine());
            Console.WriteLine($"\nLibros publicados antes de {año}:");
            foreach (var libro in catalogo)
            {
                if (libro.AñoPublicacion < año)
                {
                    Console.WriteLine($"Titulo: {libro.Titulo}, Año: {libro.AñoPublicacion}");
                }
            }
        }

        public void RemoverLibro()
        {
            //4. RemoverLibro(): Pedir al usuario el título de un libro y, utilizando
            //los métodos de búsqueda y remoción de listas, eliminarlo de la
            //colección si se encuentra presente.   
            Console.Write("\nIngrese el título del libro a remover: ");
            string titulo = Console.ReadLine();
            int removed = catalogo.RemoveAll(l => l.Titulo == titulo);
            if (removed > 0)
            {
                Console.WriteLine($"Se removieron {removed} ejemplar/es con el título '{titulo}'");
            }
            else
            {
                Console.WriteLine($"No se encontro ningun libro con el titulo '{titulo}'");
            }
        }

        static void Main(string[] args)
        {
            Biblioteca b = new Biblioteca();

            b.CargarCatalogo();
            b.ListarCatalogo();
            b.FiltrarPorAño();
            b.RemoverLibro();

            Console.ReadKey();
        }
    }
}
