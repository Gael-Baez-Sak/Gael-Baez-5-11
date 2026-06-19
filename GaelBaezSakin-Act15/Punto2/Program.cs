using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    //    2. Logística de Puerto Espacial
    //Una estación de acoplamiento registra el peso de los contenedores transportados en las
    //bodegas de carga de las naves espaciales que llegan al puerto.
    //● Crear la clase NaveEspacial que contenga únicamente el atributo privado
    //NombreNave y su constructor para cargarlo.
    //● Crear la clase colaboradora PuertoControl que contenga:
    //○ Un vector de 3 objetos de la clase NaveEspacial.
    //○ Una matriz irregular de tipo double llamado pesoContenedores, donde
    //cada fila representa a una nave, el tamaño de la fila es la cantidad de
    //bodegas que posee esa nave, y los valores almacenados son los pesos (en
    //toneladas) de los contenedores que transporta cada bodega.

    //En PuertoControl, definir los siguientes métodos:

    //1. Un constructor que cargue los nombres de las 3 naves, pregunte para cada una
    //cuántas bodegas activas posee (para definir el tamaño de su fila en la matriz
    //irregular) y cargue el peso del contenedor asignado a cada bodega. X
    //2. Un método que muestre en pantalla el detalle de los pesos cargados por cada nave
    //espacial. 
    //3. Un método que identifique e informe qué nave transporta el contenedor individual
    //más pesado de todo el puerto espacial (el valor máximo absoluto de la matriz
    //irregular).
    //4. Un método que indique el nombre de la nave que transporta menor peso acumulado
    //total(la suma de todos sus contenedores).
    class NaveEspacial
    {
        private string NombreNave;

        public NaveEspacial()
        {
            Console.Write("\nIngrese el nombre de la nave: ");
            NombreNave = Console.ReadLine();
        }
        public string devolverNombre()
        {
            return NombreNave;
        }
    }
    class PuertoControl
    {
        private double[][] pesoContenedores;
        private NaveEspacial[] naves;
        public PuertoControl()
        {
            naves = new NaveEspacial[3];

            for (int i = 0; i < 3; i++)
            {
                naves[i] = new NaveEspacial();
            }
        }

        public void cargarMatriz()
        {
            pesoContenedores = new double[3][];

            for (int i = 0; i < 3; i++)
            {

                Console.Write("\nCuántos paquetes se enviaron hoy en " + naves[i].devolverNombre() + "?: ");
                int cantidad = int.Parse(Console.ReadLine());

                pesoContenedores[i] = new double[cantidad];
            }
        }
        public void CargarPesos()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("\nNave: " + naves[i].devolverNombre());
                for (int j = 0; j < pesoContenedores[i].Length; j++)
                {
                    Console.Write("  Peso del paquete " + (j + 1) + " (Toneladas): ");
                    pesoContenedores[i][j] = double.Parse(Console.ReadLine());
                }
            }
        }
        public void imprimirDatos()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.Write("\nNave: " + naves[i].devolverNombre() + ": ");
                for (int j = 0; j < pesoContenedores[i].Length; j++)
                {
                    Console.Write("[" + pesoContenedores[i][j] + " t] ");
                }
                Console.WriteLine();
            }
        }
        public void contenedorMasPesado()
        {
            double maxPeso = pesoContenedores[0][0];
            string naveContenedor = naves[0].devolverNombre();

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < pesoContenedores[i].Length; j++)
                {
                    if (pesoContenedores[i][j] > maxPeso)
                    {
                        maxPeso = pesoContenedores[i][j];
                        naveContenedor = naves[i].devolverNombre();
                    }
                }
            }

            Console.WriteLine("El contenedor mas pesado pesa: " + maxPeso + " t");
            Console.WriteLine("Pertenece a la nave: " + naveContenedor);
        }
        public void naveMasLigera()
        {
            double suma = 0;
          
            /*string naveLigera*/;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < pesoContenedores[i].Length; j++)
                {
                    suma += pesoContenedores[i];
                }
                Console.WriteLine($"\nLas pulsaciones promedio del paciente {naves[i].devolverNombre()}  son: " + suma);
                suma = 0;
            }
        }
        static void Main(string[] args)
        {
            PuertoControl pc = new PuertoControl();
            pc.cargarMatriz();
            pc.CargarPesos();
            pc.imprimirDatos();
            pc.contenedorMasPesado();
            pc.naveMasLigera();

            Console.ReadKey();
        }
    }
}
