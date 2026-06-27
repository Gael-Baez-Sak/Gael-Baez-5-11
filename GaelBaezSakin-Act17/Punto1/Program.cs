using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    //Confeccionar una clase llamada PersonaGimnasio que tenga como atributos privados el
    //Nombre y el DNI(definir sus respectivas propiedades de lectura y escritura). Plantear un
    //método para imprimir estos datos básicos.
    //Luego, crear una segunda clase llamada Profesor que herede de PersonaGimnasio. Añadir
    //un atributo propio llamado Especialidad (con su propiedad correspondiente) y un método
    //para imprimir todos los datos del profesor(incluyendo los heredados).
    //En el programa principal(Main):
    // Definir un objeto de la clase PersonaGimnasio, asignar valores a sus propiedades y
    //llamar a su método de impresión.
    // Crear un objeto de la clase Profesor, interactuar con sus propiedades y comprobar
    //que puede acceder tanto a sus métodos propios como a los de la clase base.
    public class PersonaGimnasio
    {
        private string nombre;
        private int dni;

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

        public int Dni
        {
            set 
            { 
                dni = value;
            }
            get
            {
                return dni; 
            }
        }
        public PersonaGimnasio(string nombre, int dni)
        {
            //Console.WriteLine("--Persona---");
            Console.WriteLine($"\nNombre: {nombre}, DNI: {dni}");
        }
    }

    public class Profesor : PersonaGimnasio
    {
        private string especialidad;

        public string Especialidad
        {
            set
            {
                especialidad = value;
            }
            get
            {
                return especialidad;
            }
        }


        public Profesor(string nombre, int dni, string especialidad) : base(nombre, dni)
        {
            Console.WriteLine($"\nEspecialidad: {especialidad}");
        }


        static void Main(string[] args)
        {
            Console.WriteLine("\n--Persona---");
            PersonaGimnasio pg = new PersonaGimnasio("Leon Scott Kennedy", 20392883);

            Console.WriteLine("\n--Profesor---");
            Profesor p = new Profesor("Chris redfield", 18203772, "Fuerza de brazos");

            Console.ReadKey();
        }
    }
}
