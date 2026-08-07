using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Punto3
{
    //    3-
    //Un centro de conservación marina registra de forma dinámica las especies de
    //mamíferos marinos divisadas en la costa para su posterior análisis estadístico.
    // Crear la clase MonitoreoCostero que contenga como atributo privado
    //una lista de cadenas de texto List<string> especiesDetectadas.
    // Métodos en MonitoreoCostero:
    //1. CargarAvistamientos() : Solicitar por teclado nombres de
    //especies marinas avistadas(ej: "Ballena Franca", "Lobo Marino",
    //"Delfín") y agregarlos a la lista utilizando.Add(). La carga finaliza
    //cuando el usuario ingresa la palabra "FIN".
    //2. MostrarReporteOrdenado() : Imprimir la lista de avistamientos
    //organizada alfabéticamente de la A a la Z utilizando el método
    //.Sort().
    //3. MostrarReporteInvertido() : Imprimir la lista organizada de la
    //Z a la A combinando.Sort() con el método.Reverse().
    //4. BuscarEspecie() : Pedir al operador que ingrese el nombre de un
    //animal y, utilizando los métodos de búsqueda de listas, informar si la
    //especie fue divisada en la costa durante el día.
    class MonitoreoCostero
    {
        private List<string> especiesDetectadas = new List<string>();
        public void CargarAvistamentos()
        {
            especiesDetectadas = new List<string>();
            while (true)
            {
                Console.Write("Ingrese el nombre de la especie que fue avistada en la zona ('FIN' para terminar): ");
                string especieAvistada = Console.ReadLine();
                if (especieAvistada == "FIN")
                {
                    break;
                }

                especiesDetectadas.Add(especieAvistada);
            }
        }
        public void MostrarReporteOrdenado()
        {    
            especiesDetectadas.Sort();
            Console.WriteLine("\nReporte de avistamientos ordenado alfabéticamente de la A a la Z:");
            foreach (string especie in especiesDetectadas)
            {
                Console.WriteLine(especie);
            }
        }
        public void MostrarReporteInvertido()
        {
            especiesDetectadas.Sort();
            especiesDetectadas.Reverse();
            Console.WriteLine("\nReporte de avistamientos ordenado alfabéticamente de la Z a la A:");
            foreach (string especie in especiesDetectadas)
            {
                Console.WriteLine(especie);
            }
        }
        public void BuscarEspecie()
        {
            while (true)
            {
                Console.Write("\nIngrese el nombre de la especie que desea buscar: ");
                string buscar = Console.ReadLine();

                string encontrada = especiesDetectadas.Find(e => e == buscar);

                Console.WriteLine($"Especie encontrada: {encontrada}");
                if (buscar == "FIN")
                {
                    break;
                }
            } 

        }
        static void Main(string[] args)
        {
            MonitoreoCostero mc = new MonitoreoCostero();

            mc.CargarAvistamentos();
            mc.MostrarReporteOrdenado();
            mc.MostrarReporteInvertido();
            mc.BuscarEspecie();

            Console.ReadKey();
        }
    }
}
