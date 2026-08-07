using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
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

        public void IngresarVehiculo()
        {
        }
        public void BuscarVehiculo()
        {
        }
        public void EntregarVehiculo()
        {
        }
        public void CalcularRecaudacionPendiente()
        {
        }
        static void Main(string[] args)
        {
        }
    }
}
