using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Punto4
{
    //Definir una clase Vuelo con atributos: codigo, horaSalida y horaLlegada(DateTime).
    // Usar la palabra clave this en el constructor para diferenciar los parámetros de
    //los atributos.
    // Crear un método para calcular la duración del vuelo (TimeSpan).
    // Cargar un vector con 4 vuelos y mostrar:
    //1. El código y duración del vuelo más largo.
    //2. El código del vuelo que salga más temprano.
    class Vuelo
    {
        private string codigo;
        private DateTime horaSalida;
        private DateTime horaLlegada;

        public string Codigo
        {
            set{ codigo = value;}
            get{ return codigo; }
        }

        public DateTime HoraSalida
        {
            set{ horaSalida = value; }
            get{ return horaSalida; }
        }
        public DateTime HoraLlegada
        {
            set{ horaLlegada = value; }
            get{ return horaLlegada; }
        }
        public Vuelo(string codigo, DateTime horaSalida, DateTime horaLlegada)
        {
            this.codigo = codigo;
            this.horaSalida = horaSalida;
            this.horaLlegada = horaLlegada;
        }
        public TimeSpan CalcularDuracion()
        {
            return horaLlegada - horaSalida;
        }
    
    
        static void Main(string[] args)
        {
            DateTime hoy = DateTime.Today;

            Vuelo[] vuelos = new Vuelo[4];
            vuelos[0] = new Vuelo("AR1302", hoy.AddHours(8).AddMinutes(0), hoy.AddHours(10).AddMinutes(30));
            vuelos[1] = new Vuelo("IB2401", hoy.AddHours(14).AddMinutes(15), hoy.AddHours(22).AddMinutes(45));
            vuelos[2] = new Vuelo("LA4420", hoy.AddHours(5).AddMinutes(30), hoy.AddHours(7).AddMinutes(15));
            vuelos[3] = new Vuelo("AA901", hoy.AddHours(20).AddMinutes(0), hoy.AddHours(23).AddMinutes(15));

            Vuelo vueloMasLargo = vuelos[0];
            Vuelo vueloMasTemprano = vuelos[0];

            for (int i = 1; i < vuelos.Length; i++)
            {
                if (vuelos[i].CalcularDuracion() > vueloMasLargo.CalcularDuracion())
                {
                    vueloMasLargo = vuelos[i];
                }

                if (vuelos[i].HoraSalida < vueloMasTemprano.HoraSalida)
                {
                    vueloMasTemprano = vuelos[i];
                }
            }
            Console.WriteLine("\n---Reporte de vuelos---\n");

            TimeSpan duracionMax = vueloMasLargo.CalcularDuracion();
            Console.WriteLine($"Vuelo más largo:");
            Console.WriteLine($"Código: {vueloMasLargo.Codigo}");
            Console.WriteLine($"Duración: {duracionMax.Hours} horas y {duracionMax.Minutes} minutos.");
            Console.WriteLine();

            Console.WriteLine($"\nVuelo que sale más temprano:");
            Console.WriteLine($"Código: {vueloMasTemprano.Codigo}");
            Console.WriteLine($"Hora de salida: {vueloMasTemprano.HoraSalida.ToString("HH:mm")} hs.");

            Console.ReadKey();
        }
    }
    }
