using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    //    1-
    //En un servidor de red, las solicitudes de impresión se procesan dinámicamente en orden de
    //llegada.
    // Crear la clase Documento que contenga como atributos privados:
    //nombreArchivo(string) y cantidadPaginas(int). Definir sus
    //propiedades de solo lectura y un constructor que reciba los parámetros nom
    //y pag.
    // Crear la clase ServidorImpresion que administre una lista dinámica de
    //documentos (List<Documento>).
    // Métodos en ServidorImpresion:
    //1. AgregarDocumento() : Solicitar por teclado los datos de un
    //documento y agregarlo al final de la lista utilizando.Add().
    //2. ImprimirSiguiente() : Si la lista no está vacía, simular la
    //impresión del primer documento de la lista(mostrar sus datos en
    //consola) y removerlo de la colección mediante.RemoveAt(0). Si está
    //vacía, advertir que no hay trabajos pendientes.
    //3. MostrarColaPendiente(): Listar todos los documentos que
    //están esperando ser impresos y la cantidad total de páginas
    //acumuladas en la cola de espera utilizando .Count.
    class Documento
    {
        private string nombreArchivo;
        private int cantidadPaginas;
        public string NombreArchivo
        {
            set
            {
                nombreArchivo = value;
            }
            get 
            {
                return nombreArchivo;
            }
        }
        public int CantidadPaginas
        {
            set
            {
                cantidadPaginas = value;
            }
            get 
            {
                return cantidadPaginas;
            }
        }
        public Documento(string nom, int pag)
        {
            nombreArchivo = nom;
            cantidadPaginas = pag;
        }
    }
    class ServidorImpresion
    {
        private List<Documento> listaDocumentos;
        public ServidorImpresion()
        {
            listaDocumentos = new List<Documento>();
        }
        public void AgregarDocumento()
        {
            Console.Write("\nIngrese el nombre del archivo: ");
            string nombre = Console.ReadLine();
            Console.Write("Ingrese la cantidad de páginas: ");
            int paginas = int.Parse(Console.ReadLine());
            Documento doc = new Documento(nombre, paginas);
            listaDocumentos.Add(doc);
            Console.WriteLine("\nDocumento agregado a la cola de impresión.\n");
        }
        public void ImprimirSiguiente()
        {
            if (listaDocumentos.Count > 0)
            {
                Documento doc = listaDocumentos[0];
                Console.WriteLine("\nImprimiendo siguiente documento:");
                Console.WriteLine($"Nombre: {doc.NombreArchivo}, Páginas: {doc.CantidadPaginas}");
                listaDocumentos.RemoveAt(0);
                Console.WriteLine("Documento impreso y removido de la cola.\n");
            }
            else
            {
                Console.WriteLine("\nNo hay trabajos pendientes en la cola.\n");
            }
        }
        public void MostrarColaPendiente()
        {
            if (listaDocumentos.Count > 0)
            {
                Console.WriteLine("\nDocumentos en la cola de impresión:");
                int totalPaginas = 0;
                foreach (Documento doc in listaDocumentos)
                {
                    Console.WriteLine($"Nombre: {doc.NombreArchivo}, Páginas: {doc.CantidadPaginas}");
                    totalPaginas += doc.CantidadPaginas;
                }
                Console.WriteLine($"\nCantidad total de documentos: {listaDocumentos.Count}");
                Console.WriteLine($"Cantidad total de páginas: {totalPaginas}");
            }
            else
            {
                Console.WriteLine("\nNo hay documentos en la cola de impresión.");
            }
        }
        static void Main(string[] args)
        {
            ServidorImpresion si = new ServidorImpresion();

            while (true)
            {
                Console.WriteLine("Seleccione una opción:");
                Console.WriteLine("1 - Agregar documento");
                Console.WriteLine("2 - Imprimir siguiente");
                Console.WriteLine("3 - Mostrar cola pendiente");
                Console.WriteLine("4 - Salir");
                Console.Write("Opción: ");
                string opcion = Console.ReadLine();

                if (opcion == "1")
                {
                    si.AgregarDocumento();
                }
                else if (opcion == "2")
                {
                    si.ImprimirSiguiente();
                }
                else if (opcion == "3")
                {
                    si.MostrarColaPendiente();
                }
                else if (opcion == "4")
                {
                    return;
                }
                else
                {
                    Console.WriteLine("\nOpción inválida. Intente de nuevo.\n");
                }

                Console.WriteLine("Presiona una tecla para continuar");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}