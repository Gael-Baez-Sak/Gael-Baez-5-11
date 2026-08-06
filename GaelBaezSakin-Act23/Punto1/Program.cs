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
            get { return nombreArchivo; }
        }
        public int CantidadPaginas
        {
            get { return cantidadPaginas; }
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
            Console.Write("Ingrese el nombre del archivo: ");
            string nombre = Console.ReadLine();
            Console.Write("Ingrese la cantidad de páginas: ");
            int paginas = int.Parse(Console.ReadLine());
            Documento doc = new Documento(nombre, paginas);
            listaDocumentos.Add(doc);
            Console.WriteLine("Documento agregado a la cola de impresión.");
        }
        public void ImprimirSiguiente()
        {
            if (listaDocumentos.Count > 0)
            {
                Documento doc = listaDocumentos[0];
            }
        }
        public void MostrarColaPendiente()
        {
            if (listaDocumentos.Count > 0)
            {
                Console.WriteLine("Documentos en la cola de impresión:");
                int totalPaginas = 0;
                foreach (Documento doc in listaDocumentos)
                {
                    Console.WriteLine($"Nombre: {doc.NombreArchivo}, Páginas: {doc.CantidadPaginas}");
                    totalPaginas += doc.CantidadPaginas;
                }
                Console.WriteLine($"Cantidad total de documentos: {listaDocumentos.Count}");
                Console.WriteLine($"Cantidad total de páginas: {totalPaginas}");
            }
            else
            {
                Console.WriteLine("No hay documentos en la cola de impresión.");
            }
        }
        static void Main(string[] args)
        {
            ServidorImpresion si = new ServidorImpresion();

            si.AgregarDocumento();
            si.ImprimirSiguiente();
            si.MostrarColaPendiente();

            Console.ReadKey();
        }
    }
}