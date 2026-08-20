using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Collections.Specialized.BitVector32;

namespace Punto5
{
    //    5-
    //Un taller mecánico automatizado administra la recepción y egreso de automóviles
    //que se encuentran en el sector de reparaciones.
    // Crear la clase Vehiculo que contenga como atributos privados: patente
    //(string) y costoReparacion(double). Definir sus propiedades
    //correspondientes y un constructor que reciba pat y costo.
    // Crear la clase GestionTaller que administre una lista de objetos List.
    // Métodos en GestionTaller:
    //o IngresarVehiculo(): Solicitar por teclado la patente y el costo de
    //reparación de un vehículo para agregarlo a la lista mediante.Add().
    //o BuscarVehiculo(): Pedir al operador que ingrese una patente y,
    //recorriendo la lista, informar si el vehículo está en el taller y mostrar
    //su costo asociado.
    //o EntregarVehiculo(): Solicitar una patente por teclado, buscar el
    //vehículo en la lista y, si existe, removerlo de la colección mediante
    //.Remove() confirmando la entrega del automóvil.
    //o CalcularRecaudacionPendiente(): Listar los vehículos
    //actualmente en reparación, la cantidad total de unidades alojadas en
    //el taller mediante la propiedad .Count y la suma total acumulada por
    //cobrar.
    class Vehiculo
    {
        private string patente;
        private double costoReparacion;

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
        public double CostoReparacion
        {
            set
            {
                costoReparacion = value;
            }
            get
            {
                return costoReparacion;
            }
        }

        public Vehiculo(string pat, double costo)
        {
            patente = pat;
            costoReparacion = costo;
        }
        class GestionTaller
        {
            private List<Vehiculo> listaVehiculos;
        
            public GestionTaller()
            {
                listaVehiculos = new List<Vehiculo>();
            }
            public void IngresarVehiculo()
            {
                //IngresarVehiculo(): Solicitar por teclado la patente y el costo de
                //reparación de un vehículo para agregarlo a la lista mediante.Add().

                while (true)
                {
                    Console.Write("\nIngrese la patente del vehiculo: ");
                    string patente = Console.ReadLine();
                    Console.Write("Ingrese el costo de la reparacion realizada: ");
                    double costo = double.Parse(Console.ReadLine());
                    Vehiculo veh = new Vehiculo(patente, costo);
                    listaVehiculos.Add(veh);
                    Console.WriteLine("\nVehiculo ingresado exitosamente\n");

                    Console.Write("Desea agregar otro vehiculo? (Si/No): ");
                    string respuesta = Console.ReadLine();
                    if (respuesta != "Si")
                    {
                        break;
                    }
                }
            }
            public void BuscarVehiculo()
            {
                //BuscarVehiculo(): Pedir al operador que ingrese una patente y,
                //recorriendo la lista, informar si el vehículo está en el taller y mostrar
                //su costo asociado.

                while (true)
                {
                    Console.Write("\nIngrese la patente del vehiculo que desea buscar (o 'FIN' para terminar): ");
                    string buscar = Console.ReadLine();

                    if (buscar == "FIN")
                    {
                        break;
                    }

                    Vehiculo encontrada = listaVehiculos.Find(e => e.Patente == buscar);
                    if (encontrada != null)
                    {
                        Console.WriteLine($"Vehiculo encontrado - Patente: {encontrada.Patente}, Costo: {encontrada.CostoReparacion}");
                    }
                    else
                    {
                        Console.WriteLine($"No se encontro un vehiculo con la patente '{buscar}'.");
                    }
                }
            }
            public void EntregarVehiculo()
            {
                //EntregarVehiculo(): Solicitar una patente por teclado, buscar el
                //vehículo en la lista y, si existe, removerlo de la colección mediante
                //.Remove() confirmando la entrega del automóvil.

                while (true)
                {
                    Console.Write("\nIngrese la patente del vehiculo a entregar (o 'FIN' para terminar): ");
                    string patente = Console.ReadLine();

                    if (patente == "FIN")
                    {
                        break;
                    }

                    Vehiculo v = listaVehiculos.Find(x => x.Patente == patente);
                    if (v != null)
                    {
                        listaVehiculos.Remove(v);
                        Console.WriteLine($"Vehiculo con patente '{patente}' entregado. Costo asociado: {v.CostoReparacion}");
                    }
                    else
                    {
                        Console.WriteLine($"No se encontró un vehiculo con la patente '{patente}'.");
                    }
                }
            }
            public void CalcularRecaudacionPendiente()
            {
                //CalcularRecaudacionPendiente(): Listar los vehículos
                //actualmente en reparación, la cantidad total de unidades alojadas en
                //el taller mediante la propiedad .Count y la suma total acumulada por
                //cobrar.

                Console.WriteLine("\nVehiculos actualmente en reparacion: ");
                double total = 0;
                foreach (var veh in listaVehiculos)
                {
                    Console.WriteLine($"Patente: {veh.Patente}, Costo: {veh.CostoReparacion}");
                    total += veh.CostoReparacion;
                }

                Console.WriteLine($"\nCantidad total de vehiculos en taller: {listaVehiculos.Count}");
                Console.WriteLine($"Suma total pendiente por cobrar: {total}");
            }
            static void Main(string[] args)
            {
                GestionTaller gt = new GestionTaller();

                gt.IngresarVehiculo();
                gt.BuscarVehiculo();
                gt.EntregarVehiculo();
                gt.CalcularRecaudacionPendiente();

                Console.ReadKey();
            }
        }
    }
}
