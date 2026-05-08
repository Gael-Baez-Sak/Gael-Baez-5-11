using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    //Se desea saber la temperatura media trimestral de cuatro paises.Para ello se tiene como
    //dato las temperaturas medias mensuales de dichos paises.
    //Se pide ingresar el nombre del país y seguidamente las tres temperaturas medias
    //mensuales.
    //Seleccionar las estructuras de datos adecuadas para el almacenamiento de los datos en
    //memoria.
    //a.Cargar por teclado los nombres de los paises y las temperaturas medias mensuales.
    //b.Imprimir los nombres de los paises y las temperaturas medias mensuales de los
    //mismos.
    //c.Calcular la temperatura media trimestral de cada país.
    //d.Imprimir los nombres de los paises y las temperaturas medias trimestrales.
    //e.Imprimir el nombre del país con la temperatura media trimestral mayor.
    internal class Program
    {
        private string[] paises;
        private double[,] temperaturas;
        private double[] tempMedia;

        public void Cargar()
        {
            paises = new string[4];
            temperaturas = new double[4, 3];
            for(int f = 0; f < paises.Length; f++)
            {
                Console.Write("Ingrese el nombre del pais: ");
                paises[f] = Console.ReadLine();
                for(int c = 0; c < temperaturas.GetLength(1); c++)
                {
                    Console.Write("Ingrese las temperaturas medias: ");
                    string linea;
                    linea = Console.ReadLine();
                    temperaturas[f, c] = double.Parse(linea);
                }
            }
        }

        public void calcularTempMedia()
        {
            tempMedia = new double[4];
            for(int f = 0; f < temperaturas.GetLength(0); f++)
            {
                double suma = 0;
                for(int c = 0; c < temperaturas.GetLength(1); c++)
                {
                    suma = suma + temperaturas[f, c];
                }
                tempMedia[f] = suma / temperaturas.GetLength(1);
            }
        }
        public void imprimir()
        {
            for(int f = 0; f < paises.Length; f++)
            {
                Console.WriteLine("Pais: " + paises[f]);
                Console.Write("Temperaturas medias: ");
                for(int c = 0; c < temperaturas.GetLength(1); c++)
                {
                    Console.Write(temperaturas[f, c] + " ");
                }
                Console.WriteLine();
            }
        }
        public void imprimirMediaTrimestral()
        {
            for (int f = 0; f < paises.Length; f++)
            {
                Console.WriteLine("Pais: " + paises[f] + " Temperatura media trimestral: " + tempMedia[f]);
            }
        }
        public void imprimirTempMediaMayor()
        {
            double may = tempMedia[0];
            string nom = paises[0];
            for (int f = 0; f < tempMedia.Length; f++)
            {
                if (tempMedia[f] > may)
                {
                    may = tempMedia[f];
                    nom = paises[f];
                }
            }
            Console.WriteLine("El pais con la temperatura media trimestral mayor es: " + nom + " con la temperatura de " + may);
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Cargar();
            p.imprimir();
            p.calcularTempMedia();
            p.imprimirMediaTrimestral();
            p.imprimirTempMediaMayor();

            Console.ReadKey();
        }
    }
}
