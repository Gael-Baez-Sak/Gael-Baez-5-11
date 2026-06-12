using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Punto4
{
//Plantear una clase llamada Articulo que tenga como atributos privados el NombreArticulo, el Precio y el StockActual. El constructor de la clase debe cargar estos atributos por teclado.
//Confeccionar otra clase llamada Sucursal que contenga un vector de 3 objetos de la clase Articulo.El constructor de Sucursal debe pedir el nombre o número de la sucursal y realizar la carga de los 3 artículos.
//Implementar en la clase Sucursal los siguientes métodos:
//Un método que imprima la lista de los artículos junto con su valor total en inventario (Precio* Stock).
//Un método que busque y muestre el nombre del artículo más caro del local.
//Un método que verifique e indique qué artículos de la sucursal requieren reposición urgente (aquellos cuyo stock sea menor o igual a 5 unidades).

    class Articulo
    {
        private string nombreArticulo;
        private float precio;
        private int stockActual;
        public Articulo()
        {
            Console.Write("\nIngrese el nombre del Articulo: ");
            nombreArticulo = Console.ReadLine();

            Console.Write("Ingrese el precio del articulo: ");
            string linea = Console.ReadLine();
            precio = int.Parse(linea);

            Console.Write("Ingrese el stock actual del articulo: ");
            string linea2 = Console.ReadLine();
            stockActual = int.Parse(linea2);
        }
        public string devolverNombre()
        {
            return nombreArticulo;
        }
        public float devolverPrecio()
        {
            return precio;
        }
        public int devolverStock()
        {
            return stockActual;
        }
    }
    class Sucursal
    {
        private int numSucursal;
        private Articulo[] articulos;
        public Sucursal()
        {
            Console.Write("Ingrese el numero de sucursal: ");
            string linea = Console.ReadLine();
            numSucursal = int.Parse(linea);

            articulos = new Articulo[3];

            for (int i = 0; i < 3; i++)
            {
                articulos[i] = new Articulo();
            }
        }
        public void imprimirDatos()
        {
            Console.WriteLine("---INVENTARIO DE LA SUCURSAL " + numSucursal + "---");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"\nArticulo: {articulos[i].devolverNombre()}" + $"\nValor total del stock: {articulos[i].devolverPrecio() * articulos[i].devolverStock()} ");
            }
        }
        public void articuloMasCaro()
        {
            Articulo masCaro = articulos[0];
            string nombreArticulo = "";

            for (int i = 0; i < 3; i++)
            {
                if (articulos[i].devolverPrecio() > masCaro.devolverPrecio())
                {
                    masCaro = articulos[i];
                    nombreArticulo = articulos[i].devolverNombre();
                }
            }
            Console.WriteLine($"\nEl articulo mas caro es: {nombreArticulo}" + ", cuesta: $" + masCaro.devolverPrecio());
        }
        public void reponerStock()
        {
            for (int i = 0; i < 3; i++)
            {
                if (articulos[i].devolverStock() <=  5)
                {
                    Console.WriteLine($"\nStock menor o igual a 5 en el articulo {articulos[i].devolverNombre()}. Reponer con urgencia porfi");
                }
            }
        }
        static void Main(string[] args)
        {
            Sucursal s = new Sucursal();
            s.imprimirDatos();
            s.articuloMasCaro();
            s.reponerStock();

            Console.ReadKey();
        }
    }
}
