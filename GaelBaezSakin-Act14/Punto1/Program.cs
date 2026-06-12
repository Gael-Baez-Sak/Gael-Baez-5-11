using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    //lantear una clase llamada Vehiculo y otra clase llamada CabinaPeaje.
    //La clase Vehiculo debe tener los siguientes atributos privados:
    //Patente (de tipo string).
    //Tipo(puede ser "Auto", "Camion" o "Moto").
    //Tarifa(un valor decimal que representa el costo de su pase).
    //El constructor de Vehiculo debe solicitar y cargar estos tres datos por teclado.
    //La clase CabinaPeaje debe tener como atributos privados:
    //El número o identificador de la cabina.
    //Tres objetos de la clase Vehiculo(que representan los últimos 3 vehículos que pagaron en esa cabina).
    //Definir en la clase CabinaPeaje un constructor para inicializar su identificador y solicitar la carga de los 3 vehículos.Además, implementar los siguientes métodos dentro de CabinaPeaje:
    //Un método que imprima la patente y el tipo de los 3 vehículos registrados en la cabina.
    //Un método que calcule y muestre la recaudación total acumulada por esos 3 vehículos.
    //Un método que muestre la patente del vehículo que pagó la tarifa más cara.

   class Vehiculo
   {
        private string Patente;
        private string Tipo;
        private float Tarifa;

        public Vehiculo()
        {
            Console.Write("\nIngrese la patente del vehiculo: ");
            Patente = Console.ReadLine();

            Console.Write("Ingrese el tipo de vehiculo (auto, camion, moto, etc): ");
            Tipo = Console.ReadLine();

            Console.Write("Ingrese la tarifa a pagar: ");
            string linea = Console.ReadLine();
            Tarifa = float.Parse(linea);
        }

        public string devolverPatente()
        {
            return Patente;
        }
        public string devolverTipo()
        {
            return Tipo;
        }
        public float devolverTarifa()
        {
            return Tarifa;
        }
   }
     class CabinaPeaje
     {
        private int id_Cabina = 6967;

        private Vehiculo[] vehiculos;
        public CabinaPeaje()
        {
            vehiculos = new Vehiculo[3];

            Console.WriteLine("--- HISTORIAL CABINA " + id_Cabina + " ---");

            for (int i = 0; i < 3; i++)
            {
                vehiculos[i] = new Vehiculo();

            }
        }

        public void imprimirDatos() 
        {
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"\nVechiculo: {vehiculos[i].devolverTipo()}" + $"\nPatente: {vehiculos[i].devolverPatente()}" + $"\nTarifa pagada: ${vehiculos[i].devolverTarifa()}\n");
            }
        }
        public void tarifaMasAlta()
        {
            Vehiculo TarifaMayor = vehiculos[0];
            string patenteTarifaMax = "";

            for (int i = 0; i < 3; i++)
            {
                if (vehiculos[i].devolverTarifa() > TarifaMayor.devolverTarifa())
                {
                    TarifaMayor = vehiculos[i];
                    patenteTarifaMax = vehiculos[i].devolverPatente();
                }
            }
            Console.WriteLine($"\nEl vehiculo que pago la tarifa mas alta fue la patente: {patenteTarifaMax}" + ", pagó: $" + TarifaMayor.devolverTarifa());
        }
        public void calcularTotalRecaudado()
        {
                float suma = 0;

                for (int j = 0; j < 3; j++)
                {
                    suma += vehiculos[j].devolverTarifa();
                }
                Console.WriteLine($"\nEl total recaudado es: $" + suma);
        }

        static void Main(string[] args)
        {
            CabinaPeaje cp = new CabinaPeaje();
            cp.imprimirDatos();
            cp.calcularTotalRecaudado();
            cp.tarifaMasAlta();

            Console.ReadKey();
        }
     }
}
