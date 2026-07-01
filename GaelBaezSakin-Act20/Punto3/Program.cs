using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    //Un instituto de arqueología desea registrar las visitas semanales a 3 zonas
    //arqueológicas durante 4 semanas.
    //Plantear una matriz de 3x4 donde las filas representan las zonas y las columnas los
    //días.Luego:
    // Calcular el total de visitas por zona y almacenarlo en un vector.
    // Mostrar los datos en forma tabular.
    // Agregar estos resultados a una lista llamada zonasVisitadas que contenga
    //nombres de zonas y total de visitas.
    // Determinar cuál fue la zona más visitada.
    // Estructura para la lista 'zonasVisitadas'
    class Program
    {
        static void Main(string[] args)
        {
            string[] nombresZonas = { "Zona 1", "Zona 2", "Zona 3" };

            int[,] matrizVisitas = new int[3, 4] {
            { 120, 150, 130, 160 },
            { 200, 180, 220, 210 },
            { 90,  110, 105, 95 }
            };

            int[] totalesPorZona = new int[3];

            for (int i = 0; i < matrizVisitas.GetLength(0); i++)
            {
                int sumaFila = 0;
                for (int j = 0; j < matrizVisitas.GetLength(1); j++)
                {
                    sumaFila += matrizVisitas[i, j];
                }
                totalesPorZona[i] = sumaFila;
            }
            Console.WriteLine("---Reporte de vistas semanales---\n");

            Console.WriteLine("Zona\t| Sem 1\tSem 2\tSem 3\tSem 4\t| Total");

            for (int i = 0; i < nombresZonas.Length; i++)
            {
                Console.WriteLine(
                    nombresZonas[i] + "\t| " +
                    matrizVisitas[i, 0] + "\t" +
                    matrizVisitas[i, 1] + "\t" +
                    matrizVisitas[i, 2] + "\t" +
                    matrizVisitas[i, 3] + "\t| " +
                    totalesPorZona[i]
                );
            }
            Console.WriteLine();

            List<(string Nombre, int TotalVisitas)> zonasVisitadas = new List<(string, int)>();

            for (int i = 0; i < nombresZonas.Length; i++)
            {
                zonasVisitadas.Add((nombresZonas[i], totalesPorZona[i]));
            }

            int maxVisitas = totalesPorZona[0];
            int indiceMaximo = 0;

            for (int i = 1; i < totalesPorZona.Length; i++)
            {
                if (totalesPorZona[i] > maxVisitas)
                {
                    maxVisitas = totalesPorZona[i];
                    indiceMaximo = i;
                }
            }

            string zonaMasVisitada = nombresZonas[indiceMaximo];

            Console.WriteLine("---Resultado final---");
            Console.WriteLine("La zona más visitada fue la " + zonaMasVisitada + " con un total de " + maxVisitas + " visitas.");

            Console.ReadKey();
        }
    }
}

