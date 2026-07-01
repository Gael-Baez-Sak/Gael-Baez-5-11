using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    //Una aerolínea administra los vuelos programados mediante un sistema orientado a
    //objetos.
    //Plantear una clase base Vuelo que contenga como propiedades: número de vuelo,
    //destino y duración en horas.Luego definir una clase derivada VueloInternacional que
    //herede de Vuelo e incluya una propiedad adicional llamada paisDestino.
    //Crear una lista de objetos de tipo VueloInternacional, cargar 5 vuelos con sus datos
    //desde consola y luego:
    // Mostrar los vuelos registrados y el país de destino.
    // Informar cuál es el vuelo con mayor duración.
    // Mostrar el orden de ejecución de los constructores.
    class Vuelos
    {
        private string destino;
        private int numeroVuelo;
        private int duracionHoras;

        public string Destino
        {
            set
            { 
                destino = value; 
            }
            get 
            { 
                return destino;
            }
        }
        public int NumeroVuelo 
        { 
            set 
            {
                numeroVuelo = value;
            }
            get
            { 
                return numeroVuelo;
            } 
        }
        public int DuracionHoras
        {  
            set 
            {
                duracionHoras = value;
            }
            get 
            {
                return duracionHoras; 
            } 
        }
        public Vuelos(string destino, int numeroVuelo, int duracionHoras)
        {
            Destino = destino;
            NumeroVuelo = numeroVuelo;
            DuracionHoras = duracionHoras;  
     
            Console.WriteLine($"(Constructor Vuelos) Vuelos creado: Vuelo {NumeroVuelo} a {Destino} ({DuracionHoras}h)");
        }
        public void Imprimir()
        {
            Console.WriteLine("\nDestino: " + Destino);
            Console.WriteLine("Número de Vuelo: " + NumeroVuelo);
            Console.WriteLine("Duración (horas): " + DuracionHoras);
        }
    }

    class VueloInternacional : Vuelos
    {
        private string paisDestino;

        public string PaisDestino
        {
            set
            {
                paisDestino = value;
            }
            get
            {
                return paisDestino;
            }
        }
        public VueloInternacional(string destino, int numeroVuelo, int duracionHoras, string paisDestino) : base(destino, numeroVuelo, duracionHoras)
        {
 
            PaisDestino = paisDestino;
            Console.WriteLine($"(Constructor vueloInternacional) Vuelo Internacional creado: Vuelo {NumeroVuelo} hacia {PaisDestino}");
        }

        static void Main(string[] args)
        {
            List<VueloInternacional> vi = new List<VueloInternacional>();

            for (int i = 0; i < 5; i++)
            {
                Console.Write("\nIngrese el destino del vuelo internacional: ");
                string destino = Console.ReadLine();

                Console.Write("Ingrese el número de vuelo: ");
                int numeroVuelo = Convert.ToInt32(Console.ReadLine());

                Console.Write("Ingrese la duración en horas: ");
                int duracionHoras = Convert.ToInt32(Console.ReadLine());

                Console.Write("Ingrese el país de destino: ");
                string paisDestino = Console.ReadLine();

                VueloInternacional vuelo = new VueloInternacional(destino, numeroVuelo, duracionHoras, paisDestino);
                vi.Add(vuelo);
                Console.WriteLine("\nVuelo guardado Exitosamente");
            }

            Console.WriteLine("\n---Listado de vuelos registrados---");
            foreach (VueloInternacional v in vi)
            {
                v.Imprimir();
                Console.WriteLine("País de Destino: " + v.PaisDestino);
            }

            if (vi.Count > 0)
            {
                VueloInternacional mayor = vi[0];
                for (int i = 1; i < vi.Count; i++)
                {
                    if (vi[i].DuracionHoras > mayor.DuracionHoras)
                    {
                        mayor = vi[i];
                    }
                }
                Console.WriteLine("\n---Vuelo con mayor duración---");
                mayor.Imprimir();
                Console.WriteLine("País de Destino: " + mayor.PaisDestino);
            }
        }
    }
}
