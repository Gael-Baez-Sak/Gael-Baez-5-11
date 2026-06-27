using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


namespace Punto2
{
    //Plantear una clase llamada Pelicula y otra clase llamada Catalogo.
    //La clase Pelicula debe tener como atributos privados: Titulo, DuracionMinutos y Calificacion
    //(un puntaje del 1 al 5). Definir las propiedades necesarias para acceder a estos atributos,
    //asegurando mediante validaciones lógicas que:
    // La duración en minutos sea estrictamente mayor a cero(0).
    // La calificación se encuentre únicamente en el rango de 1 a 5 (de lo contrario, asignar
    //un valor por defecto de 1).
    //La clase Catalogo debe contener internamente un vector capaz de almacenar 3 objetos de
    //la clase Pelicula.Definir un método dentro de Catalogo para mostrar por pantalla todas las
    //películas ordenadas de mayor a menor en base a su duración.Además, el método debe
    //informar el título de la película con mejor calificación y cuál es la película más corta del
    //catálogo.
    public class Pelicula
    {
        private string titulo;
        private int duracionMinutos;
        private int calificacion;

        public string Titulo
        {
            set 
            {
                titulo = value; 
            }
            get 
            {
                return titulo;
            }
        }

        public int DuracionMinutos
        {
            set
            {
                if (value > 0)
                {
                    duracionMinutos = value;
                }
                else
                {
                    Console.WriteLine("La duracion de la pelicula debe ser mayor a 0");
                }
            }
            get 
            {
                return duracionMinutos;
            }
        }

        public int Calificacion
        {
            set
            {
                if (value >= 1 && value <= 5)
                {
                    calificacion = value;
                }
                else
                {
                    Console.WriteLine("La calificacion debe encontrarse entre 1 y 5. Se asigna el valor por defecto (1).");
                    calificacion = 1;
                }
            }
            get 
            {
                return calificacion;
            }
        }
    }

    public class Catalogo
    {
        private Pelicula[] peliculas = new Pelicula[3];
        private int cantidad = 0;

        public bool AgregarPelicula(Pelicula p)
        {
            if (cantidad < peliculas.Length)
            {
                peliculas[cantidad] = p;
                cantidad++;
                return true;
            }

            Console.WriteLine("El catalogo ya esta lleno (maximo 3 peliculas).");
            return false;
        }
        public void MostrarOrdenadasPorDuracion()
        {
            if (cantidad == 0)
            {
                Console.WriteLine("El catalogo no tiene peliculas cargadas.");
                return;
            }

            Pelicula[] ordenadas = new Pelicula[cantidad];
            for (int i = 0; i < cantidad; i++)
            {
                ordenadas[i] = peliculas[i];
            }

            for (int i = 0; i < cantidad - 1; i++)
            {
                for (int j = 0; j < cantidad - 1 - i; j++)
                {
                    if (ordenadas[j].DuracionMinutos < ordenadas[j + 1].DuracionMinutos)
                    {
                        Pelicula temp = ordenadas[j];
                        ordenadas[j] = ordenadas[j + 1];
                        ordenadas[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine("\n--- Peliculas ordenadas por duracion (mayor a menor) ---\n");
            for (int i = 0; i < cantidad; i++)
            {
                Pelicula p = ordenadas[i];
                Console.WriteLine($"{p.Titulo} - {p.DuracionMinutos} min - Calificacion: {p.Calificacion}");
            }

            Pelicula mejorCalificada = peliculas[0];
            for (int i = 1; i < cantidad; i++)
            {
                if (peliculas[i].Calificacion > mejorCalificada.Calificacion)
                {
                    mejorCalificada = peliculas[i];
                }
            }

            Pelicula masCorta = peliculas[0];
            for (int i = 1; i < cantidad; i++)
            {
                if (peliculas[i].DuracionMinutos < masCorta.DuracionMinutos)
                {
                    masCorta = peliculas[i];
                }
            }

            Console.WriteLine();
            Console.WriteLine($"Pelicula con mejor calificacion: {mejorCalificada.Titulo} (Calificacion: {mejorCalificada.Calificacion})");
            Console.WriteLine($"Pelicula mas corta: {masCorta.Titulo} ({masCorta.DuracionMinutos} min)");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Catalogo catalogo = new Catalogo();

            Pelicula p1 = new Pelicula();
            p1.Titulo = "El Padrino";
            p1.DuracionMinutos = 175;
            p1.Calificacion = 5;

            Pelicula p2 = new Pelicula();
            p2.Titulo = "Toy Story";
            p2.DuracionMinutos = 81;
            p2.Calificacion = 4;

            Pelicula p3 = new Pelicula();
            p3.Titulo = "Interstellar";
            p3.DuracionMinutos = 169;
            p3.Calificacion = 8; 

            catalogo.AgregarPelicula(p1);
            catalogo.AgregarPelicula(p2);
            catalogo.AgregarPelicula(p3);

            catalogo.MostrarOrdenadasPorDuracion();

            Console.ReadKey();
        }
    }
}

