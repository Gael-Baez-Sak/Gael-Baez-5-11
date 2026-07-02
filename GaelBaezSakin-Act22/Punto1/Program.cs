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
    class ClaseGimnasio
    {
        private string nombreClase;
        private DateTime horaInicio;
        private DateTime horaFin;

        public ClaseGimnasio(string nombreClase, DateTime horaInicio, DateTime horaFin)
        {
            this.nombreClase = nombreClase;
            this.horaInicio = horaInicio;
            this.horaFin = horaFin;

            Console.WriteLine("Ingrese el nombre de la clase: ");
            nombreClase = Console.ReadLine();
            Console.WriteLine("\nIngrese la hora de inicio : ");
            horaInicio = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("\nIngrese la hora de fin : ");
            horaFin = DateTime.Parse(Console.ReadLine());
        }
        
        public ClaseGimnasio()
        {
            this.nombreClase = "Clase por defecto";
            this.horaInicio = DateTime.Now;
            this.horaFin = DateTime.Now;
        }

        public void CalcularDuracion()
        {
            TimeSpan duracion = horaFin - horaInicio;
            Console.WriteLine($"\nLa duración de la clase {nombreClase} es: {duracion} minutos.");
        }
        static void Main(string[] args)
        {
            ClaseGimnasio[] clases = new ClaseGimnasio[3];




            Console.ReadKey();
        }
    }
}
