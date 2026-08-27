using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Punto10
{
    //10-
    //Un estacionamiento medido administra el ingreso y la salida de los vehículos que
    //utilizan su playa por orden de llegada.
    // Crear la clase Ticket que contenga como atributos privados: patente
    //(string) y horasEstadia (int). Definir sus propiedades de solo lectura y un
    //constructor que reciba pat y hs.
    // Crear la clase GestionEstacionamiento que administre una lista
    //dinámica de tickets (List).
    // Métodos en GestionEstacionamiento:
    //o RegistrarIngreso(): Solicitar por teclado los datos de un ticket y
    //agregarlo al final de la lista utilizando .Add().
    //o ProcesarSalida(): Si la lista no está vacía, simular la salida del
    //primer vehículo de la lista (mostrar sus datos en consola) y
    //removerlo de la colección mediante.RemoveAt(0). Si está vacía,
    //advertir que no hay vehículos esperando salida.
    //o MostrarVehiculosEstacionados(): Listar todos los vehículos
    //alojados en la playa y la cantidad total de unidades presentes
    //utilizando la propiedad.Count.
    class Ticket
    {
        private string patente;
        private int horasEstadia;
        public string Patente
        {
            set
            {
                patente = value;
            }
            get 
            {
                return patente; 
            }
        }
        public int HorasEstadia
        {
            set
            {
                horasEstadia = value;
            }
            get
            { 
                return horasEstadia; 
            }
        }
        public Ticket(string pat, int hs)
        {
            patente = pat;
            horasEstadia = hs;
        }
    }
    class GestionEstacionamiento
    {
        private List<Ticket> tickets;
        public GestionEstacionamiento()
        {
            tickets = new List<Ticket>();
        }
        public void RegistrarIngreso()
        {
            Console.WriteLine("Ingrese la patente del vehículo:");
            string pat = Console.ReadLine();
            Console.WriteLine("Ingrese la cantidad de horas de estadía:");
            int hs = Convert.ToInt32(Console.ReadLine());
            Ticket ticket = new Ticket(pat, hs);
            tickets.Add(ticket);
            Console.WriteLine("Ticket registrado correctamente.");
        }
        public void ProcesarSalida()
        {
            if (tickets.Count > 0)
            {
                Ticket ticket = tickets[0];
                Console.WriteLine($"Procesando salida del vehículo con patente {ticket.Patente} y {ticket.HorasEstadia} horas de estadía.");
                tickets.RemoveAt(0);
            }
            else
            {
                Console.WriteLine("No hay vehículos esperando salida.");
            }
        }
        public void MostrarVehiculosEstacionados()
        {
            if (tickets.Count > 0)
            {
                Console.WriteLine("Vehículos estacionados:");
                foreach (Ticket ticket in tickets)
                {
                    Console.WriteLine($"Patente: {ticket.Patente}, Horas de estadía: {ticket.HorasEstadia}");
                }
                Console.WriteLine($"Cantidad total de vehículos estacionados: {tickets.Count}");
            }
            else
            {
                Console.WriteLine("No hay vehículos estacionados.");
            }
        }
        static void Main(string[] args)
        {
            GestionEstacionamiento ge = new GestionEstacionamiento();

            ge.RegistrarIngreso();
            ge.ProcesarSalida();
            ge.MostrarVehiculosEstacionados();

            Console.ReadKey();
        }
    }
}
