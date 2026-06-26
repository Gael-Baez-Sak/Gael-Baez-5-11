using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Punto4
{
    //Armar tres clases: Animal, Mamífero y Perro.
    //La clase Animal debe tener un atributo especie.
    //La clase Mamífero, que hereda de Animal, debe tener un atributo
    //tipoAlimentacion.
    //La clase Perro, que hereda de Mamífero, debe tener un atributo nombre.
    //Cada clase debe tener un constructor que reciba los datos correspondientes
    //y los imprima indicando a qué clase pertenecen.Los datos deben ser
    //asignados previamente
    //Crear un objeto de la clase Perro y verificar la ejecución en cadena de los
    //constructores.
    public class Animal
    {
        protected string especie;

        public string Especie {          
            set
            {
                especie = value;
            }
            get
            {
                return especie;
            }
        }
        public Animal(string especie)
        {
            Especie = especie;
            Console.WriteLine("Especie Animal: " + especie);
        }
    }
    public class Mamifero : Animal
    {
        private string tipoAlimentacion;

        public Mamifero(string especie, string tipoAlimentacion) : base(especie)
        {
            Console.WriteLine("\nSu tipo de alimentacion es: " + tipoAlimentacion);
        }
    }
    public class Perro: Mamifero
    {
        private string nombre;

        public Perro(string especie, string tipoAlimentacion, string nombre) : base(especie, tipoAlimentacion)
        {
            Console.WriteLine("\nSu nombre es: " + nombre);
        }
        static void Main(string[] args)
        {
            Perro p = new Perro("canino", "carnivoro", "Moscu");

            Console.ReadKey();
        }
    }
}
