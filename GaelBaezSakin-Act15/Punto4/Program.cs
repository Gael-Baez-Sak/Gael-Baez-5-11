using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Punto4
{
    //    4. Línea de Ensamblaje Robótico
    //En una planta de fabricación automatizada, cada robot industrial realiza tareas de
    //ensamblaje complejas divididas en operaciones secundarias de duración variable.
    //● Diseñar la clase RobotEnsamblador que tenga como atributos privados:
    //1. ModeloRobot.
    //2. Una matriz irregular de tipo float (float[][] tiemposOperacion) donde cada
    //fila representa una de las 4 fases principales del proceso (Estructura,
    //Cableado, Pintura y Testeo), y cada columna los segundos que demoró en
    //completar las distintas subtareas de esa fase(por ejemplo, en la fase de
    //Estructura el robot puede tener 3 sub-tareas, pero en la de Testeo solo tiene
    //1).
    //3. El constructor de RobotEnsamblador debe pedir su modelo, preguntar para
    //cada una de las 4 fases de fabricación cuántas sub - tareas requirió realizar

    //(definiendo el tamaño de cada fila) y cargar la duración en segundos de cada
    //una de ellas.

    //● Diseñar la clase colaboradora PlantaIndustrial que gestione a 3 objetos de la clase
    //RobotEnsamblador.Implementar en PlantaIndustrial:
    //1. Un constructor que cargue la información de los 3 robots instalados en la
    //planta.
    //2. Un método que muestre un reporte detallado con los tiempos de operación
    //de cada robot fase por fase.
    //3. Un método que calcule el promedio general de tiempo por tarea de cada
    //robot y declare al "Robot más Eficiente" (aquel que registre el promedio de
    //tiempo por operación más bajo de la planta).
    class RobotEnsamblador
    {
        private string ModeloRobot;
        private float[][] tiemposOperacion;
        private string[] nombresFases = { "Estructura", "Cableado", "Pintura", "Testeo" };

        public RobotEnsamblador() 
        {
            Console.Write("\nIngrese el modelo del robot: ");
            ModeloRobot = Console.ReadLine();
            Console.WriteLine(" ");

            tiemposOperacion = new float[4][];

            for (int i = 0; i < 4; i++)
            {
                Console.Write($"\nCuántas sub-tareas requirió la tarea {i + 1} ({nombresFases[i]}): ");
                int cantidad = int.Parse(Console.ReadLine());

                tiemposOperacion[i] = new float[cantidad];
            }

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"\nTarea {i + 1} ({nombresFases[i]}):");
                for (int j = 0; j < tiemposOperacion[i].Length; j++)
                {
                    Console.Write($"  Duración de la sub-tarea {j + 1} (Segundos): ");
                    tiemposOperacion[i][j] = float.Parse(Console.ReadLine());
                }
            }
        }

        public string devolverModelo()
        {
            return ModeloRobot;
        }

        public float[][] devolverTiempos()
        {
            return tiemposOperacion;
        }
    }   

    class PlantaIndustrial
    {
        private RobotEnsamblador[] robots;
        private string[] nombresFases = { "Estructura", "Cableado", "Pintura", "Testeo" };

        public PlantaIndustrial()
        {
            robots = new RobotEnsamblador[3];

            for (int i = 0; i < 3; i++)
            {
                robots[i] = new RobotEnsamblador();
            }
        }

        public void reporteOperaciones()
        {
            Console.WriteLine("\n--- REPORTE DETALLADO DE OPERACIONES ---");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"\nRobot: {robots[i].devolverModelo()}");
                float[][] tiempos = robots[i].devolverTiempos();
                
                for (int f = 0; f < 4; f++)
                {
                    Console.Write($"  {nombresFases[f]}: ");
                    for (int c = 0; c < tiempos[f].Length; c++)
                    {
                        Console.Write($"[{tiempos[f][c]}s] ");
                    }
                    Console.WriteLine();
                }
            }
        }

        public void robotMasEficiente()
        {
            double[] promedios = new double[3];

            for (int i = 0; i < 3; i++)
            {
                float[][] tiempos = robots[i].devolverTiempos();
                double sumaTotal = 0;
                int cantidadTareas = 0;

                for (int f = 0; f < 4; f++)
                {
                    for (int c = 0; c < tiempos[f].Length; c++)
                    {
                        sumaTotal += tiempos[f][c];
                        cantidadTareas++;
                    }
                }

                promedios[i] = sumaTotal / cantidadTareas;
            }

            double menorPromedio = promedios[0];
            int robotEficiente = 0;

            for (int i = 1; i < 3; i++)
            {
                if (promedios[i] < menorPromedio)
                {
                    menorPromedio = promedios[i];
                    robotEficiente = i;
                }
            }

            Console.WriteLine("\n--- ROBOT MÁS EFICIENTE ---");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Robot {robots[i].devolverModelo()}: Promedio = {promedios[i]} segundos");
            }
            Console.WriteLine($"\n Robot más eficiente: {robots[robotEficiente].devolverModelo()} con {menorPromedio} segundos por operación");
        }

        static void Main(string[] args)
        {
            PlantaIndustrial pi = new PlantaIndustrial();
            pi.reporteOperaciones();
            pi.robotMasEficiente();

            Console.ReadKey();
        }
    }
}
