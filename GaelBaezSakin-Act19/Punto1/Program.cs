using System;
using System.Security.Policy;

namespace Punto1
{
    //En el primer archivo, definir las propiedades NombreCliente, CantidadNoches y
    //TipoHabitacion(puede ser “Simple”, “Doble” o “Suite”), validando que la cantidad de
    //noches sea mayor a 0. Estos valores son cargados desde la consola.
    //En el segundo archivo, agregar un método que calcule el total a pagar según la
    //habitación elegida(por ejemplo: Simple = $5000, Doble = $8000, Suite = $12000 por
    //noche).
    //Desde la clase principal, cargar 3 reservas y mostrar cuál cliente pagará más
    class Program
    {
        public void MostrarClienteQuePagoMas(Reservas r1, Reservas r2, Reservas r3)
        {
            double total1 = r1.CalcularTotalAPagar();
            double total2 = r2.CalcularTotalAPagar();
            double total3 = r3.CalcularTotalAPagar();
            if (total1 > total2 && total1 > total3)
            {
                Console.WriteLine($"El cliente que pagará más es: {r1.NombreCliente} con un total de ${total1}");
            }
            else if (total2 > total1 && total2 > total3)
            {
                Console.WriteLine($"El cliente que pagará más es: {r2.NombreCliente} con un total de ${total2}");
            }
            else if (total3 > total1 && total3 > total2)
            {
                Console.WriteLine($"El cliente que pagará más es: {r3.NombreCliente} con un total de ${total3}");
            }
            else
            {
                Console.WriteLine("Hay un empate entre los clientes.");
            }
        }
        static void Main(string[] args)
        {
            Reservas r1 = new Reservas();
            Reservas r2 = new Reservas();
            Reservas r3 = new Reservas();

            Console.Write("Ingrese el nombre del cliente: ");
            r1.NombreCliente = Console.ReadLine();
            Console.Write("Ingrese la cantidad de noches: ");
            r1.CantidadNoches = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el tipo de habitación (Simple/Doble/Suite): ");
            r1.TipoHabitacion = Console.ReadLine();
            Console.WriteLine("Total a pagar: ${0}", r1.CalcularTotalAPagar());
            
            Console.Write("\nIngrese el nombre del cliente: ");
            r2.NombreCliente = Console.ReadLine();
            Console.Write("Ingrese la cantidad de noches: ");
            r2.CantidadNoches = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el tipo de habitación (Simple/Doble/Suite): ");
            r2.TipoHabitacion = Console.ReadLine();
            Console.WriteLine("Total a pagar: ${0}", r2.CalcularTotalAPagar());

            Console.Write("\nIngrese el nombre del cliente: ");
            r3.NombreCliente = Console.ReadLine();
            Console.Write("Ingrese la cantidad de noches: ");
            r3.CantidadNoches = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el tipo de habitación (Simple/Doble/Suite): ");
            r3.TipoHabitacion = Console.ReadLine();
            Console.WriteLine("Total a pagar: ${0}", r3.CalcularTotalAPagar());

            Program p = new Program();
            p.MostrarClienteQuePagoMas(r1, r2, r3);

            Console.ReadKey();
        }   
    }
}
