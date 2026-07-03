using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    //Plantear una clase Entrenamiento con atributos: deportista y duración(en minutos).
    // Incluir dos métodos RegistrarDuracion(sobrecarga de métodos):
    //1. Uno que reciba horas y minutos y los convierta a minutos.
    //2. Otro que reciba directamente los minutos.
    // Crear una lista con 5 entrenamientos y mostrar el entrenamiento más largo y el
    //más corto.
    public class Entrenamiento
    {
        private string deportista;
        private int duracion;
        public string Deportista {
            set
            {
                deportista = value;
            }
            get
            {
                return deportista;
            }
        }
        public int Duracion {
            set
            {
                duracion = value;
            }
            get
            {
                return duracion;
            }
        }

        public Entrenamiento(string deportista)
        {
            Deportista = deportista;
            Duracion = 0;
        }

        public void RegistrarDuracion(int horas, int minutos)
        {
            this.Duracion = (horas * 60) + minutos;
        }

        public void RegistrarDuracion(int minutos)
        {
            this.Duracion = minutos;
        }
        static void Main(string[] args)
        {
            List<Entrenamiento> entrenamientos = new List<Entrenamiento>();

            Entrenamiento e1 = new Entrenamiento("Cuti Romero");
            Entrenamiento e2 = new Entrenamiento("Lionel Messi");
            Entrenamiento e3 = new Entrenamiento("Julian Alvarez");
            Entrenamiento e4 = new Entrenamiento("Dibu Martinez");
            Entrenamiento e5 = new Entrenamiento("Nico Paz");

            e1.RegistrarDuracion(2, 15);
            e2.RegistrarDuracion(90); 
            e3.RegistrarDuracion(1, 45);
            e4.RegistrarDuracion(140);
            e5.RegistrarDuracion(3, 0);

            entrenamientos.Add(e1);
            entrenamientos.Add(e2);
            entrenamientos.Add(e3);
            entrenamientos.Add(e4);
            entrenamientos.Add(e5);

            Entrenamiento masLargo = entrenamientos[0];
            Entrenamiento masCorto = entrenamientos[0];

            foreach (Entrenamiento e in entrenamientos)
            {
                if (e.Duracion > masLargo.Duracion)
                {
                    masLargo = e;
                }
                if (e.Duracion < masCorto.Duracion)
                {
                    masCorto = e;
                }
            }

            Console.WriteLine("\n---Reporte de entrenamientos---\n");

            Console.WriteLine($"El entrenamiento MAS LARGO fue de: {masLargo.Deportista}");
            Console.WriteLine($"Duracion: {masLargo.Duracion} minutos.");
            Console.WriteLine();
            Console.WriteLine($"El entrenamiento MAS CORTO fue de: {masCorto.Deportista}");
            Console.WriteLine($"Duracion: {masCorto.Duracion} minutos.");

            Console.ReadKey();
        }
    }
}
