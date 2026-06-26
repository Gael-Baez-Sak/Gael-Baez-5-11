using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Punto3
{
    //Crear una clase base Vehículo que contenga atributos marca y
    //velocidadMaxima.
    //Definir dos clases derivadas: Auto y Moto, que hereden de Vehículo.Cada
    //una debe tener un constructor que reciba los valores de los atributos base
    //mediante la palabra clave base, y un atributo propio (cantidadPuertas en
    //Auto, cilindrada en Moto).
    //Crear un objeto de cada clase y mostrar todos sus datos por consola.
    public class Vehiculo
    {
        protected string marca;
        protected int velocidadMaxima;

        public string Marca
        {
            set
            {
                marca = value;
            }
            get
            {
                return marca;
            }
        }
        public int VelocidadMaxima
        {
            set
            {
                velocidadMaxima = value;
            }
            get
            {
                return velocidadMaxima;
            }
        }
        public Vehiculo(string marca, int velocidadMaxima) 
        { 
            Marca = marca; 
            VelocidadMaxima = velocidadMaxima;
        }
        public void Imprimir()
        {
            Console.WriteLine("\nMarca: " + marca);
            Console.WriteLine("Velocidad Maxima: " + velocidadMaxima);
        }
    }
    public class Auto : Vehiculo
    {
        private int cantidadPuertas;
        public Auto(string marca, int velocidadMaxima, int cantidadPuertas) : base(marca, velocidadMaxima)
        {
            Console.WriteLine("este auto tiene: " + cantidadPuertas + " puertas");
        }
        public class Moto : Vehiculo
        {
            private int cilindrada;
            public Moto(string marca, int velocidadMaxima, int cilindrada) : base(marca, velocidadMaxima)
            {
                Console.WriteLine("Cantidad de cilindrada: " + cilindrada + " cc");
            }

            static void Main(string[] args)
            {
                Vehiculo V1 = new Vehiculo("Ford", 230);
                V1.Imprimir();
                Auto A = new Auto("chevrolet", 150, 4);
                Vehiculo V2 = new Vehiculo("Ninja H2R", 400);
                V2.Imprimir();
                Moto M = new Moto("suzuki",250, 750 );

                Console.ReadKey();
            }
        }
    }
}

