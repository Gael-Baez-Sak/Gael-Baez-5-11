using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    //Confeccionar una clase que represente un empleado. Definir como atributos su
    //nombre y su sueldo. En el constructor cargar los atributos y luego en otro
    //método imprimir sus datos y por último uno que imprima un mensaje si debe
    //pagar impuestos(si el sueldo supera a 3000)
    class Empleado
    {
        private string nombre;
        private int sueldo;
        public Empleado()
        {
            Console.Write("Ingrese el nombre del empleado/a: ");
            nombre = Console.ReadLine();

            Console.Write("Ingrese el sueldo del empleado/a: ");
            string linea = Console.ReadLine();
            sueldo = int.Parse(linea);
        }
        public void ImprimirDatos()
        {
            Console.WriteLine("Nombre del empleado: " + nombre);
            Console.WriteLine("Sueldo del empleado: " + sueldo);
        }
        public void PagarImpuestos()
        {
            if (sueldo > 3000)
            {
                Console.WriteLine("El empleado debe pagar impuestos.");
            }
            else
            {
                Console.WriteLine("El empleado no debe pagar impuestos.");
            }
        }
        public
        static void Main(string[] args)
        {
            Empleado e = new Empleado();
            e.ImprimirDatos();
            e.PagarImpuestos();

            Console.ReadKey();
        }
    }
}
