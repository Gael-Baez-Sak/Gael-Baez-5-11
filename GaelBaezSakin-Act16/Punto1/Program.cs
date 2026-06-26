using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
//Confeccionar una clase Persona que tenga como atributos el nombre y la
//edad(definir las propiedades para poder acceder a dichos atributos). Definir
//un método para imprimirlos.Plantear una segunda clase Empleado que
//herede de la clase Persona.Añadir un atributo sueldo (y su propiedad) y el
//método para imprimir su sueldo.Definir un objeto de la clase Persona y
//llamar a sus métodos y propiedades.También crear un objeto de la clase
//Empleado y llamar a sus métodos y propiedades.
    class Persona
    {
        private string nombre;
        private int edad;

        public string Nombre
        {
            set
            {
                nombre = value;
            }
            get
            {
                return nombre;
            }
        }
        public int Edad
        {
            set
            {
                edad = value;
            }
            get
            {
                return edad;
            }
        }
        public void Imprimir()
        {
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Edad: " + edad);
        }
    }
    class Empleado : Persona
    {
        private int sueldo;

        public int Sueldo
        {
            set
            {
                sueldo = value;
            }
            get
            {
                return sueldo;
            }
        }
        public void ImprimirSueldo()
        {
            Console.WriteLine("Sueldo: " + sueldo);
        }
        static void Main(string[] args)
        {
            Persona p = new Persona();
            p.Nombre = "Dante Sparda";
            p.Edad = 44;
            p.Imprimir();

            Empleado e = new Empleado();
            e.Sueldo = 1000;
            e.ImprimirSueldo();
            Console.ReadKey();

        }
    }
}
