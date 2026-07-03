using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    //Crear una clase ClaseGimnasio con atributos: nombreClase, horaInicio y horaFin(usar
    //DateTime).
    // Implementar un constructor que permita cargar los datos desde consola y otro
    //que cargue valores por defecto(sobrecarga de constructores).
    // Incluir un método para calcular la duración de la clase usando TimeSpan.
    // Crear un vector de 3 clases de gimnasio y mostrar:
    //1. La clase que tenga la mayor duración.
    //2. El nombre y el horario de inicio de la clase más temprana.
    public class ClaseGimnasio
    {
        private string nombreClase;
        private DateTime horaInicio;
        private DateTime horaFin;
        public string NombreClase {
            set{ nombreClase = value; }
            get{ return nombreClase; }
        }
        public DateTime HoraInicio {
            set{ horaInicio = value; }
            get{ return horaInicio; }
        }
        public DateTime HoraFin {
            set{ horaFin = value; }
            get{ return horaFin; }
        }

        public ClaseGimnasio()
        {
            NombreClase = "Clase Genérica";
            HoraInicio = DateTime.Today.AddHours(8); 
            HoraFin = DateTime.Today.AddHours(9);
        }

        public ClaseGimnasio(int numeroClase)
        {
            Console.WriteLine($"\n--- Ingreso de datos para la Clase {numeroClase} ---");

            Console.Write("Nombre de la clase (ej. Yoga, Pialtes): ");
            NombreClase = Console.ReadLine();

            Console.Write("Hora de inicio (Hora:Minuto): ");
            string LineaInicio = Console.ReadLine();
            HoraInicio = ConvertirAHora(LineaInicio);

            Console.Write("Hora de fin (Hora:Minuto): ");
            string LineaFin = Console.ReadLine();
            HoraFin = ConvertirAHora(LineaFin);

        }
        public TimeSpan CalcularDuracion()
        {
            return HoraFin - HoraInicio;
        }

        private DateTime ConvertirAHora(string input)
        {
            if (TimeSpan.TryParse(input, out TimeSpan tiempo))
            {
                return DateTime.Today.Add(tiempo);
            }
            else
            {
                Console.WriteLine("Lo escribiste mal, se asigno la hora actual por defecto.");
                return DateTime.Now;
            }
        }

        static void Main(string[] args)
        {
            ClaseGimnasio[] clases = new ClaseGimnasio[3];

            for (int i = 0; i < clases.Length; i++)
            {
                clases[i] = new ClaseGimnasio(i + 1);
            }

            ClaseGimnasio claseMayorDuracion = clases[0];

            for (int i = 1; i < clases.Length; i++)
            {
                if (clases[i].CalcularDuracion() > claseMayorDuracion.CalcularDuracion())
                {
                    claseMayorDuracion = clases[i];
                }
            }

            ClaseGimnasio claseMasTemprana = clases[0];

            for (int i = 1; i < clases.Length; i++)
            {
                if (clases[i].HoraInicio < claseMasTemprana.HoraInicio)
                {
                    claseMasTemprana = clases[i];
                }
            }
            Console.WriteLine("\n--- Resultados ---");

            TimeSpan duracionMax = claseMayorDuracion.CalcularDuracion();
            Console.WriteLine($"Clase con mayor duracion: {claseMayorDuracion.NombreClase} " +  $"(Duracion: {duracionMax.Hours}h {duracionMax.Minutes}m)");

            Console.WriteLine($"Clase más temprana: {claseMasTemprana.NombreClase} " + $"(Hora de inicio: {claseMasTemprana.HoraInicio.ToString("HH:mm")} hs)");

            Console.ReadKey();
        }
    }
}
