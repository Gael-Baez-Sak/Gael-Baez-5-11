using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    //Plantear una clase Producto y otra clase Inventario.
    //La clase Producto debe tener como atributos privados el nombre, precio y
    //stock.Definir propiedades para acceder a estos atributos, asegurando que el
    //stock no pueda ser negativo y el precio sea mayor a cero.
    //La clase Inventario debe contener 3 objetos de la clase Producto. Definir un
    //método para mostrar todos los productos ordenados de menor a mayor en
    //base al precio, además, mostrar el producto más caro y más barato del
    //inventario.
    class Producto
    {
        protected string nombre;
        protected double precio;
        protected int stock;

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
        public double Precio
        {
            set
            {
                if (value > 0)
                {
                    precio = value;
                }
                else
                {
                    Console.WriteLine("El precio debe ser mayor a cero");
                }
            }
            get
            {
                return precio;
            }
        }
        public int Stock
        {
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("El stock no puede ser menor a 0");
                }
                else
                {
                    stock = value;
                }
            }
            get
            {
                return stock;
            }
        }
        public void Imprimir()
        {
            Console.WriteLine("Nombre del producto: " + Nombre);
            Console.WriteLine("Stock: " + Stock);
            Console.WriteLine("Precio: " + Precio);
        }
    }

    class Inventario : Producto
    {
        private Producto producto1, producto2, producto3;

        public Inventario(Producto p1, Producto p2, Producto p3)
        {
            producto1 = p1;
            producto2 = p2;
            producto3 = p3;
        }

        public void ordenarPrecio()
        {
             Producto primero, segundo, tercero;

            if (producto1.Precio <= producto2.Precio && producto1.Precio <= producto3.Precio)
                primero = producto1;
            else if (producto2.Precio <= producto1.Precio && producto2.Precio <= producto3.Precio)
                primero = producto2;
            else
                primero = producto3;

            if (producto1.Precio >= producto2.Precio && producto1.Precio >= producto3.Precio)
                tercero = producto1;
            else if (producto2.Precio >= producto1.Precio && producto2.Precio >= producto3.Precio)
                tercero = producto2;
            else
                tercero = producto3;

            if (primero != producto1 && tercero != producto1)
                segundo = producto1;
            else if (primero != producto2 && tercero != producto2)
                segundo = producto2;
            else
                segundo = producto3;

            Console.WriteLine("\n---Productos ordenados de menor a mayor por precio---");
            Console.WriteLine(primero.Nombre + " - $" + primero.Precio);
            Console.WriteLine(segundo.Nombre + " - $" + segundo.Precio);
            Console.WriteLine(tercero.Nombre + " - $" + tercero.Precio);
        }

        public void productMasCaro()
        {
            if (producto1.Precio > producto2.Precio && producto1.Precio > producto3.Precio)
            {
                Console.WriteLine("\nEl producto mas caro es: " + producto1.Nombre + " ($" + producto1.Precio + ")");
            }
            if (producto2.Precio > producto1.Precio && producto2.Precio > producto3.Precio)
            {
                Console.WriteLine("\nEl producto mas caro es: " + producto2.Nombre + " ($" + producto2.Precio + ")");
            }
            if (producto3.Precio > producto2.Precio && producto3.Precio > producto1.Precio)
            {
                Console.WriteLine("\nEl producto mas caro es: " + producto3.Nombre + " ($" + producto3.Precio + ")");
            }
        }
        public void productMasBarato()
        {
            if (producto1.Precio < producto2.Precio && producto1.Precio < producto3.Precio)
            {
                Console.WriteLine("\nEl producto mas barato es: " + producto1.Nombre + " ($" + producto1.Precio + ")");
            }
            if (producto2.Precio < producto1.Precio && producto2.Precio < producto3.Precio)
            {
                Console.WriteLine("\nEl producto mas barato es: " + producto2.Nombre + " ($" + producto2.Precio + ")");
            }
            if (producto3.Precio < producto2.Precio && producto3.Precio < producto1.Precio)
            {
                Console.WriteLine("\nEl producto mas barato es: " + producto3.Nombre + " ($" + producto3.Precio + ")");
            }
        }

        static void Main(string[] args)
        {
            Producto p1 = new Producto();
            p1.Nombre = "queso cremoso";
            p1.Precio = 2500;
            p1.Stock = 20;
            p1.Imprimir();
            Producto p2 = new Producto();
            p2.Nombre = "dulce de leche";
            p2.Precio = 3000;
            p2.Stock = 50;
            p2.Imprimir();
            Producto p3 = new Producto();
            p3.Nombre = "galletitas surtidas";
            p3.Precio = 2800;
            p3.Stock = 34;
            p3.Imprimir();

            Inventario inv = new Inventario(p1, p2, p3);
            inv.ordenarPrecio();
            inv.productMasCaro();
            inv.productMasBarato();

            Console.ReadKey();
        }
    }
}
