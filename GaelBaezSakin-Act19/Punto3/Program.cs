using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    //En el primer archivo, definir las propiedades NombreJuego, PuntajeMaximo, y
    //NivelDificultad(de 1 a 5). Valores cargados desde consola
    //En el segundo archivo, implementar un método que indique si un puntaje ingresado
    //supera el récord o no.
    //Desde Main, simular 4 partidas, mostrar qué jugador rompió el récord de su juego.
    class Program
    {
        static void Main(string[] args)
        {
            Juego j1 = new Juego();
            Juego j2 = new Juego();
            Juego j3 = new Juego();
            Juego j4 = new Juego();

            Console.Write("Ingrese el nombre del juego: ");
            j1.NombreJuego = Console.ReadLine();
            Console.Write("Ingrese el puntaje máximo: ");
            j1.PuntajeMaximo = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el nivel de dificultad (1-5): ");
            j1.NivelDificultad = int.Parse(Console.ReadLine());

            Console.Write("\nIngrese el nombre del juego: ");
            j2.NombreJuego = Console.ReadLine();
            Console.Write("Ingrese el puntaje máximo: ");
            j2.PuntajeMaximo = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el nivel de dificultad (1-5): ");
            j2.NivelDificultad = int.Parse(Console.ReadLine());

            Console.Write("\nIngrese el nombre del juego: ");
            j3.NombreJuego = Console.ReadLine();
            Console.Write("Ingrese el puntaje máximo: ");
            j3.PuntajeMaximo = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el nivel de dificultad (1-5): ");
            j3.NivelDificultad = int.Parse(Console.ReadLine());

            Console.Write("\nIngrese el nombre del juego: ");
            j4.NombreJuego = Console.ReadLine();
            Console.Write("Ingrese el puntaje máximo: ");
            j4.PuntajeMaximo = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el nivel de dificultad (1-5): ");
            j4.NivelDificultad = int.Parse(Console.ReadLine());


            Console.Write("\nIngrese el puntaje del jugador 1: ");
            int puntaje1 = int.Parse(Console.ReadLine());
            j1.SuperaRecord(puntaje1);

            Console.Write("\nIngrese el puntaje del jugador 2: ");
            int puntaje2 = int.Parse(Console.ReadLine());
            j2.SuperaRecord(puntaje2);

            Console.Write("\nIngrese el puntaje del jugador 3: ");
            int puntaje3 = int.Parse(Console.ReadLine());
            j3.SuperaRecord(puntaje3);

            Console.Write("\nIngrese el puntaje del jugador 4: ");
            int puntaje4 = int.Parse(Console.ReadLine());
            j4.SuperaRecord(puntaje4);
        }
    }
}
