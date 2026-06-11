using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    //Plantear una clase llamada Pasajero que tenga los atributos privados: Nombre, DNI y EquipajeKilos(peso del equipaje en kg). En su constructor, solicitar la carga de estos tres datos.
    //Luego, confeccionar una clase llamada Vuelo que administre un vector de 4 objetos de la clase Pasajero.Su constructor debe inicializar el vector y solicitar la carga por teclado de cada uno de los 4 pasajeros.
    //Agregar los siguientes métodos en la clase Vuelo:
    //Un método que muestre un listado completo con los datos de todos los pasajeros del vuelo.
    //Un método que calcule y muestre el peso total de equipaje que transporta el avión (la suma de todos los pesos).
    //Un método que informe si algún pasajero excede el límite permitido de equipaje(mayor a 23 kg), imprimiendo su nombre y su DNI.

    class Pasajero
    {
        private string Nombre;
        private int DNI;
        private int equipajeKilos;

        public Pasajero()
        {
            Console.Write("\nIngrese el nombre del pasajero: ");
            Nombre = Console.ReadLine();

            Console.Write("Ingrese el DNI del pasajero: ");
            string linea = Console.ReadLine();
            DNI = int.Parse(linea);

            Console.Write("Ingrese el peso de su equipaje (kilos): ");
            string linea2 = Console.ReadLine();
            equipajeKilos = int.Parse(linea2);

        }
        public string devolverNombre()
        {
            return Nombre;
        }
        public int devolverDNI()
        {
            return DNI;
        }
        public int devolverKilos()
        {
            return equipajeKilos;
        }
    }
    
    class Vuelo
    {
        private Pasajero[] pasajeros;
        public Vuelo()
        {
            pasajeros = new Pasajero[4];

            for (int i = 0; i < 4; i++)
            {
                pasajeros[i] = new Pasajero();

            }
        }
        public void imprimirDatos()
        {
            for (int i = 0; i < 4; i++)
            {
                Console.Write($"\nPasajero: {pasajeros[i].devolverNombre()}" + $"\nDNI: {pasajeros[i].devolverDNI()}" + $"\nPeso del equipaje: {pasajeros[i].devolverKilos()}\n");
            }
        }
        public void pesoTotal()
        {
            int suma = 0;

            for (int j = 0; j < 3; j++)
            {
                suma += pasajeros[j].devolverKilos();
            }
            Console.WriteLine($"\nEl peso total del vuelo es: " + suma);
        }
        public void excedeLimite()
        {
            for(int i = 0; i < 4; i++)
            {
                if (pasajeros[i].devolverKilos() > 23)
                {
                    Console.Write($"\nEl pasajero/a {pasajeros[i].devolverNombre()} excede el limite de peso (23kg), tiene {pasajeros[i].devolverKilos()}");
                }
            }
        }
        static void Main(string[] args)
        {
            Vuelo v = new Vuelo();
            v.imprimirDatos();
            v.pesoTotal();
            v.excedeLimite();
        }
    }
    
}