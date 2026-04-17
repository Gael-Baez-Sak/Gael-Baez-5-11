using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    //Desarrollar una clase que represente un Cuadrado y tenga los siguientes
    //métodos: cargar el valor de su lado, imprimir su perímetro y su superficie.
    class Cuadrado
    {
        private double lado;

        public void CargarLado()
        {
            Console.Write("Ingrese el valor del lado del cuadrado: ");
            lado = double.Parse(Console.ReadLine());
        }

        public void ImprimirPerimetro()
        {
            double perimetro = lado * 4;
            Console.WriteLine($"El perímetro del cuadrado es: {perimetro}");
        }
        public void ImprimirSuperficie()
        {
            double superficie = lado * lado;
            Console.WriteLine($"La superficie del cuadrado es: {superficie}");
        }

        static void Main(string[] args)
        {
            Cuadrado c = new Cuadrado();

            c.CargarLado();
            c.ImprimirPerimetro();
            c.ImprimirSuperficie();

            Console.ReadKey();
        }
    }
}
