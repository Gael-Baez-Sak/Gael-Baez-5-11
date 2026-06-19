using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Punto1
{
    //    1. Monitoreo Clínico de Pacientes
    //En una sala de cuidados intensivos, se requiere realizar un seguimiento constante del ritmo
    //cardíaco de los pacientes.
    //● Plantear una clase llamada Paciente que tenga como atributos privados:
    //1. Nombre(de tipo string).
    //2. Una matriz llamada ritmoCardiaco de tamaño 3x4(representando los
    //registros de pulsaciones tomados durante 3 días diferentes, en 4 momentos
    //clave de cada día: mañana, mediodía, tarde y noche).
    //3. El constructor de Paciente debe pedir su nombre y solicitar la carga por
    //teclado de las 12 lecturas cardíacas.

    //● Confeccionar la clase colaboradora SalaMonitoreo que administre un vector de 3
    //objetos de la clase Paciente.Su constructor debe inicializar el vector y solicitar la
    //carga de los 3 pacientes.Implementar los siguientes métodos dentro de
    //SalaMonitoreo:
    //1. Un método que imprima la grilla de lecturas cardíacas completa de cada
    //paciente organizada por día y momento.
    //2. Un método que calcule e imprima el promedio de pulsaciones de cada
    //paciente a lo largo de todo su monitoreo.
    //3. Un método que verifique si algún paciente registró un evento de taquicardia
    //severa (cualquier lectura individual que sea estrictamente mayor a 120
    //pulsaciones), mostrando por consola su nombre y la lectura detectada.
    class Paciente
    {
        private string nombre;
        private int[,] ritmoCardiaco;
        public Paciente()
        {
            ritmoCardiaco = new int[3, 4];

            Console.Write("\nIngrese el nombre del paciente: ");
            nombre = Console.ReadLine();

            for (int f = 0; f < 3; f++)
            {
                for (int c = 0; c < 4; c++)
                {
                    Console.Write("Ingrese las pulsaciones tomadas: ");
                    string linea;
                    linea = Console.ReadLine();
                    ritmoCardiaco[f, c] = int.Parse(linea);
                }
            }
        }
        public string devolverNombre()
        {
            return nombre;
        }
        public int devolverRitmo(int f, int c)
        {
            return ritmoCardiaco[f, c];
        }
    }

    class SalaMonitoreo
    {
        private Paciente[] pacientes;
        public SalaMonitoreo()
        {
            pacientes = new Paciente[3];

            for (int i = 0; i < 3; i++)
            {
                pacientes[i] = new Paciente();
            }
        }
        public void imprimirDatos()
        {
            for (int i = 0; i < 3; i++)
            {

                Console.Write($"\npaciente {pacientes[i].devolverNombre()}: \n");
                for (int f = 0; f < 3; f++)
                {
                    Console.Write("Dia: " + (f + 1));
                    for (int c = 0; c < 4; c++)
                    {
                        Console.Write("[" + pacientes[i].devolverRitmo(f, c) + "] ");
                    }
                    Console.WriteLine();
                }
            }
        }
        public void promedioPulsaciones()
        {
            float suma = 0;

            for (int i = 0; i < 3; i++)
            {
                for (int f = 0; f < 3; f++)
                {
                    for (int c = 0; c < 4; c++)
                    {
                        suma += pacientes[i].devolverRitmo(f, c);
                    }

                }
                float promedio = suma / 12;
                Console.WriteLine($"\nLas pulsaciones promedio del paciente {pacientes[i].devolverNombre()}  son: " + promedio);
                suma = 0;
                promedio = 0;
            }
        }
        public void taquicardia()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int f = 0; f < 3; f++)
                {
                    for (int c = 0; c < 4; c++)
                    {
                        if (pacientes[i].devolverRitmo(f,c) > 120)
                        {
                            Console.Write($"\nEl paciente {pacientes[i].devolverNombre()} tuvo un ataque de taquicardia ({pacientes[i].devolverRitmo(f,c)})");
                        }
                    }

                }
            }
        }
        static void Main(string[] args)
        {
            SalaMonitoreo sm = new SalaMonitoreo();
            sm.imprimirDatos();
            sm.promedioPulsaciones();
            sm.taquicardia();

            Console.ReadKey();
        }
    }
}
