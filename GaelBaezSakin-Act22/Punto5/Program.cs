using Microsoft.Win32;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Punto5
{
    //Crear un sistema para gestionar carreras deportivas.Cada carrera tiene un código,
    //una hora de inicio y una hora de fin.Cada carrera puede registrar varios corredores.
    //Se pide:
    //1. Crear una clase Carrera con:
    //o Atributos: código, hora de inicio, hora de fin y lista de corredores ya
    //definidos.
    //o Dos constructores (uno por defecto y otro con parámetros).
    //o Método para calcular la duración de la carrera usando TimeSpan.
    //2. Crear una clase Corredor con:
    //o Atributos: nombre, número de dorsal y tiempo total.
    //o Sobrecarga de métodos para registrar el tiempo total (en minutos o en
    //horas y minutos).

    //3. Mostrar en consola(usando Console.SetCursorPosition()) :
    //o La carrera con mayor duración.
    //o El corredor más rápido.
    //4. Utilizar this en los constructores o métodos donde corresponda.
    class Corredor
    {
        private string nombre;
        private int nroDorsal;
        private int tiempoTotal;

        public string Nombre
        {
            set{ nombre = value; }
            get{ return nombre; }
        }
        public int NroDorsal
        {
            set{ nroDorsal = value; }
            get{ return nroDorsal; }
        }
        public int TiempoTotal
        {
            set{ tiempoTotal = value; }
            get{ return tiempoTotal; }
        }
        public Corredor(string nombre, int nroDorsal)
        {
            this.nombre = nombre;
            this.nroDorsal = nroDorsal;
        }


        public void RegistrarTiempo(int minutos)
        {
            this.tiempoTotal = minutos;
        }

        public void RegistrarTiempo(int horas, int minutos)
        {
            this.tiempoTotal = (horas * 60) + minutos;
        }
    }
    class Carrera
    {
        private string codigo;
        private DateTime horaInicio;
        private DateTime horaFin;
        private List<Corredor> listaCorredores;

        public string Codigo
        {
            set{ codigo = value; }
            get{  return codigo; }
        }
        public DateTime HoraInicio
        {
            set{ horaInicio = value; }
            get{ return horaInicio; }
        }
        public DateTime HoraFin
        {
            set{ horaFin = value; }
            get{ return horaFin; }
        }
        public List<Corredor> ListaCorredores
        {
            set{ listaCorredores = value; }
            get{ return listaCorredores; }
        }

        public Carrera()
        {
            this.codigo = "FLSDMEFR";
            this.horaInicio = DateTime.Today;
            this.horaFin = DateTime.Today;
            this.listaCorredores = new List<Corredor>();
        }

        public Carrera(string codigo, DateTime horaInicio, DateTime horaFin)
        {
            this.codigo = codigo;
            this.horaInicio = horaInicio;
            this.horaFin = horaFin;
            this.listaCorredores = new List<Corredor>(); 
        }
        public void AgregarCorredor(Corredor corredor)
        {
            this.listaCorredores.Add(corredor);
        }

        public TimeSpan CalcularDuracion()
        {
            return this.horaFin - this.horaInicio;
        }
        static void Main(string[] args)
        {
            DateTime hoy = DateTime.Today;

            Carrera c1 = new Carrera("C0110K", hoy.AddHours(8), hoy.AddHours(9).AddMinutes(45));
            Carrera c2 = new Carrera("C0221K", hoy.AddHours(7), hoy.AddHours(10).AddMinutes(15));
            Carrera c3 = new Carrera("C0342K", hoy.AddHours(6), hoy.AddHours(9).AddMinutes(0));

            Corredor corr1 = new Corredor("Juan Pérez", 101);
            corr1.RegistrarTiempo(55);

            Corredor corr2 = new Corredor("María López", 204);
            corr2.RegistrarTiempo(1, 20);

            Corredor corr3 = new Corredor("Carlos Gómez", 305);
            corr3.RegistrarTiempo(1, 45);

            Corredor corr4 = new Corredor("Ana Martínez", 412);
            corr4.RegistrarTiempo(190);

            c1.AgregarCorredor(corr1);

            c2.AgregarCorredor(corr2);
            c2.AgregarCorredor(corr3);

            c3.AgregarCorredor(corr4);

            List<Carrera> todasLasCarreras = new List<Carrera> { c1, c2, c3 };

            Carrera carreraMayorDuracion = todasLasCarreras[0];
            foreach (var c in todasLasCarreras)
            {
                if (c.CalcularDuracion() > carreraMayorDuracion.CalcularDuracion())
                {
                    carreraMayorDuracion = c;
                }
            }

            Corredor corredorMasRapido = null;
            foreach (var c in todasLasCarreras)
            {
                foreach (var corr in c.ListaCorredores)
                {
                    if (corredorMasRapido == null || corr.TiempoTotal < corredorMasRapido.TiempoTotal)
                    {
                        corredorMasRapido = corr;
                    }
                }
            }

            Console.SetCursorPosition(5, 3);
            Console.Write("Carreras:");


            Console.SetCursorPosition(5, 6);
            Console.Write("Carrera con mas duracion:");

            Console.SetCursorPosition(8, 7);
            Console.Write($"Codigo: {carreraMayorDuracion.Codigo}");

            TimeSpan duracionMax = carreraMayorDuracion.CalcularDuracion();
            Console.SetCursorPosition(8, 8);
            Console.Write($"Duracion Total: {duracionMax.Hours}h y {duracionMax.Minutes}m");

    
            Console.SetCursorPosition(5, 11);
            Console.Write("Corredor mas rapido:");

            if (corredorMasRapido != null)
            {
                Console.SetCursorPosition(8, 12);
                Console.Write($"Nombre: {corredorMasRapido.Nombre}");

                Console.SetCursorPosition(8, 13);
                Console.Write($"Dorsal Nro: {corredorMasRapido.NroDorsal}");

                Console.SetCursorPosition(8, 14);
                Console.Write($"Tiempo Marcado: {corredorMasRapido.TiempoTotal} minutos");
            }
            else
            {
                Console.SetCursorPosition(8, 12);
                Console.Write("No se encontraron corredores registrados.");
            }

            Console.SetCursorPosition(5, 16);

            Console.SetCursorPosition(5, 18);
            Console.ReadKey();
        }
    }
}
