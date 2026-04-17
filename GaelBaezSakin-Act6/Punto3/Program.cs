using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    //Confeccionar una clase que represente un empleado. Definir como atributos su
    //nombre y su sueldo. Confeccionar los métodos para la carga, otro para imprimir
    //sus datos y por último uno que imprima un mensaje si debe pagar impuestos
    //(si el sueldo supera a 3000).
    class Empleado
    {
        private string nombre;
        private double sueldo;

        public void Cargar()
        {
            Console.Write("Nombre: ");
            nombre = Console.ReadLine();
            Console.Write("Sueldo: ");
            sueldo = double.Parse(Console.ReadLine());
        }

        public void Imprimir()
        {
            Console.WriteLine("Empleado: " + nombre);
            Console.WriteLine("Sueldo: " + sueldo);
        }

        public void PagaImpuestos()
        {
            if (sueldo > 3000)
            {
                Console.WriteLine("Debe pagar impuestos.");
            }
            else
            {
                Console.WriteLine("No paga impuestos.");
            }
        }

        static void Main()
        {
            Empleado emp = new Empleado();
            emp.Cargar();
            emp.Imprimir();
            emp.PagaImpuestos();

            Console.ReadKey();
        }
    }
}
