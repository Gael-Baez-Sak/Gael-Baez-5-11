using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Se cuenta con la siguiente información:
            ● Las edades de 20 estudiantes del turno mañana.
            ● Las edades de 30 estudiantes del turno tarde.
            ● Las edades de 15 estudiantes del turno noche.
            Las edades de cada estudiante deben ingresarse por teclado.
            a) Obtener el promedio de las edades de cada turno (tres promedios)
            b) Imprimir dichos promedios (promedio de cada turno)
            c) Mostrar por pantalla un mensaje que indique cuál de los tres turnos tiene un
            promedio de edades menor.*/

            int i, edad, sumaTurnoMañana, sumaTurnoTarde, sumaTurnoNoche;
            float promedioMañana, promedioTarde, promedioNoche;
            string linea;

            sumaTurnoMañana = 0;
            sumaTurnoTarde = 0;
            sumaTurnoNoche = 0;

            for (i = 1; i < 20; i++) {

                Console.Write("Ingresa tu edad (turno mañana): ");
                linea = Console.ReadLine();
                edad = int.Parse(linea);
                sumaTurnoMañana = sumaTurnoMañana + edad;

            }
            for (i = 1; i < 30; i++)
            {

                Console.Write("Ingresa tu edad (turno tarde): ");
                linea = Console.ReadLine();
                edad = int.Parse(linea);
                sumaTurnoTarde = sumaTurnoTarde + edad;

            }
            for (i = 1; i < 15; i++)
            {

                Console.Write("Ingresa tu edad (turno noche): ");
                linea = Console.ReadLine();
                edad = int.Parse(linea);
                sumaTurnoNoche = sumaTurnoNoche + edad;

            }
            promedioMañana = sumaTurnoMañana / 20;
            promedioTarde = sumaTurnoTarde / 30;
            promedioNoche = sumaTurnoNoche / 15;

            Console.WriteLine("Promedio Mañana: " + promedioMañana);
            Console.WriteLine("Promedio Tarde: " + promedioTarde);
            Console.WriteLine("Promedio Noche: " + promedioNoche);

            if (promedioMañana < promedioTarde && promedioMañana < promedioNoche)
            {
                Console.WriteLine("El turno con el promedio menor es: Turno Mañana");
            }
            else
            {
                if (promedioTarde < promedioNoche)
                {
                    Console.WriteLine("El turno con el promedio menor es: Turno Tarde");
                }
                else
                {
                    Console.WriteLine("El turno con el promedio menor es: Turno Noche");
                }
            }

            Console.ReadKey();
        }
    }
}
