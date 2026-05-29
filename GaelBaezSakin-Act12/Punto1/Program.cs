
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
//Una empresa de correo tiene 3 sucursales principales.Cada sucursal procesa una
//cantidad diferente de paquetes por día dependiendo de su demanda.
//● Definir un vector de tipo string para los nombres de las 3 sucursales.
//● Definir una matriz irregular donde cada fila sea una sucursal y cada columna
//represente el peso (en kg) de cada paquete enviado.
//● Métodos:
//1. Cargar los nombres de las sucursales y, para cada una, preguntar cuántos
//paquetes se enviaron hoy para definir el tamaño de su fila.
//2. Cargar el peso de cada paquete.
//3. Imprimir el peso de todos los paquetes organizados por sucursal.
//4. Calcular e informar el peso total despachado por cada sucursal.
//5. Informar cuál es el paquete más pesado de toda la empresa y a qué sucursal
//pertenece.
    internal class Program
    {
            private string[] sucursales;
            private double[][] paquetes;

            public void Cargar()
            {
                sucursales = new string[3];
                paquetes = new double[3][];

                for (int i = 0; i < 3; i++)
                {
                    Console.Write("Ingrese el nombre de la sucursal " + (i + 1) + ": ");
                    sucursales[i] = Console.ReadLine();

                    Console.Write("Cuántos paquetes se enviaron hoy en " + sucursales[i] + "?: ");
                    int cantidad = int.Parse(Console.ReadLine());

                    paquetes[i] = new double[cantidad];
                }
            }
            public void CargarPesos()
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("Sucursal: " + sucursales[i]);
                    for (int j = 0; j < paquetes[i].Length; j++)
                    {
                        Console.Write("  Peso del paquete " + (j + 1) + " (en kg): ");
                        paquetes[i][j] = double.Parse(Console.ReadLine());
                    }
                }
            }
            public void ImprimirPaquetes()
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.Write("Sucursal " + sucursales[i] + ": ");
                    for (int j = 0; j < paquetes[i].Length; j++)
                    {
                        Console.Write("[" + paquetes[i][j] + " kg] ");
                    }
                    Console.WriteLine();
                }
            }
            public void PesoTotal()
            {
                for (int i = 0; i < 3; i++)
                {
                    double sumaTotal = 0;
                    for (int j = 0; j < paquetes[i].Length; j++)
                    {
                        sumaTotal = sumaTotal + paquetes[i][j];
                    }
                    Console.WriteLine("Sucursal " + sucursales[i] + " despachó en total: " + sumaTotal + " kg");
                }
            }
            public void MasPesado()
            {
                double maxPeso = paquetes[0][0];
                string sucursalMayor = sucursales[0];

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < paquetes[i].Length; j++)
                    {
                        if (paquetes[i][j] > maxPeso)
                        {
                            maxPeso = paquetes[i][j];
                            sucursalMayor = sucursales[i];
                        }
                    }
                }

                Console.WriteLine("El paquete mas pesado de la empresa pesa: " + maxPeso + " kg");
                Console.WriteLine("Pertenece a la sucursal: " + sucursalMayor);
            }

        static void Main(string[] args)
        {
            Program p = new Program();
            p.Cargar();
            p.CargarPesos();
            p.ImprimirPaquetes();
            p.PesoTotal();
            p.MasPesado();

            Console.ReadKey();
        }
    }
}
