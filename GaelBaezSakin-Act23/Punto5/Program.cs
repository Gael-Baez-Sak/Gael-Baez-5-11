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
                //o IngresarVehiculo(): Solicitar por teclado la patente y el costo de
                //reparación de un vehículo para agregarlo a la lista mediante.Add().

                Console.Write("\nIngrese la patente del vehiculo: ");
                string patente = Console.ReadLine();
                Console.Write("Ingrese el costo de la reparacion realizada: ");
                double costo = int.Parse(Console.ReadLine());
                Vehiculo veh = new Vehiculo(patente, costo);
                listaVehiculos.Add(veh);
                Console.WriteLine("\nVehiculo ingresado exitosamente.\n");
            }
            public void BuscarVehiculo()
            {
                //o BuscarVehiculo(): Pedir al operador que ingrese una patente y,
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
                        Console.WriteLine($"Vehículo encontrado - Patente: {encontrada.Patente}, Costo: {encontrada.CostoReparacion}");
                    }
                    else
                    {
                        Console.WriteLine($"No se encontró un vehículo con la patente '{buscar}'.");
                    }
                }
            }
            public void EntregarVehiculo()
            {
                //o EntregarVehiculo(): Solicitar una patente por teclado, buscar el
                //vehículo en la lista y, si existe, removerlo de la colección mediante
                //.Remove() confirmando la entrega del automóvil.
            }
            public void CalcularRecaudacionPendiente()
            {
                //o CalcularRecaudacionPendiente(): Listar los vehículos
                //actualmente en reparación, la cantidad total de unidades alojadas en
                //el taller mediante la propiedad .Count y la suma total acumulada por
                //cobrar.
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
