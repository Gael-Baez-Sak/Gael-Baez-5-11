using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    //Una empresa de envíos desea registrar sus entregas mediante colaboración de
    //clases.
    //Crear una clase Paquete con propiedades: código, peso y destino.Crear una clase
    //Despachador que contenga una lista de paquetes y un método para registrar nuevos
    //paquetes.
    //Desde el método Main, instanciar un Despachador, cargar 5 paquetes y mostrar:
    // Todos los paquetes registrados.
    // Cuántos superan los 10 kg de peso.
    // Cuántos tienen destino nacional (por ejemplo, “Argentina”).
    class Paquete
    {
        public string Codigo { get; set; }
        public double Peso { get; set; }
        public string Destino { get; set; }

        public Paquete(string codigo, double peso, string destino)
        {
            Codigo = codigo;
            Peso = peso;
            Destino = destino;
        }
    }

    class Despachador
    {
        private List<Paquete> listaPaquetes;

        public List<Paquete> ListaPaquetes
        {
            get
            {
                return listaPaquetes;

            }
        }
        public Despachador()
        {
            listaPaquetes = new List<Paquete>();
        }

        public void RegistrarPaquete(Paquete nuevoPaquete)
        {
            listaPaquetes.Add(nuevoPaquete);
            Console.WriteLine($"Paquete {nuevoPaquete.Codigo} registrado con éxito.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Despachador despachador = new Despachador();

            Console.WriteLine("--- Registro de Paquetes ---\n");

            despachador.RegistrarPaquete(new Paquete("1", 12.5, "Argentina"));
            despachador.RegistrarPaquete(new Paquete("2", 5.2, "Chile"));
            despachador.RegistrarPaquete(new Paquete("3", 22.0, "Argentina"));
            despachador.RegistrarPaquete(new Paquete("4", 8.7, "España"));
            despachador.RegistrarPaquete(new Paquete("5", 15.1, "Argentina"));

            Console.WriteLine("\n--- Reporte de Entregas ---");

            int masDe10Kg = 0;
            int destinoNacional = 0;

            Console.WriteLine("Lista de todos los paquetes:");
            foreach (Paquete p in despachador.ListaPaquetes)
            {
                Console.WriteLine($"\nCódigo: {p.Codigo} | Peso: {p.Peso} kg | Destino: {p.Destino}");

                if (p.Peso > 10)
                {
                    masDe10Kg++;
                }

                if (p.Destino.ToLower() == "argentina")
                {
                    destinoNacional++;
                }
            }

            Console.WriteLine("\n--- Estadísticas ---");
            Console.WriteLine($"Paquetes que superan los 10 kg: {masDe10Kg}");
            Console.WriteLine($"\nPaquetes con destino nacional (Argentina): {destinoNacional}");

            Console.ReadKey();
        }
    }

}
