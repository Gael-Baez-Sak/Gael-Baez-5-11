using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    //Plantear una clase llamada Atleta que tenga como atributos privados el Nombre y el TiempoSegundos(tiempo que tardó en completar una carrera). Definir un constructor para ingresar ambos datos.
    //Luego, crear una clase llamada Carrera que administre 3 objetos de la clase Atleta como atributos de la clase.
    //Definir los siguientes métodos en la clase Carrera:
    //1) Un constructor que cargue los datos de los 3 atletas de la carrera. X
    //2) Un método que imprima los nombres de los atletas junto con sus marcas de tiempo. X
    //3) Un método que calcule e imprima el tiempo promedio de la carrera. X 
    //4) Un método que informe el nombre del atleta ganador de la carrera (aquel que completó la prueba en el menor tiempo). X
    //5) Un método que muestre a los atletas que superaron el promedio.

    class Atleta
    {
        private string Nombre;
        private float TiempoSegundos;

        public Atleta()
        {
            Console.Write("Ingrese el nombre del Atleta: ");
            Nombre = Console.ReadLine();

            Console.Write("Ingrese el tiempo en segundos conseguido por el atleta: ");
            string linea = Console.ReadLine();
            TiempoSegundos = int.Parse(linea);
        }
        public string devolverNombre()
        {
            return Nombre;
        }
        public float devolverTiempo()
        {
            return TiempoSegundos;
        }

    }

    class Carrera
    {
        private float promedio;

        private Atleta[] atletas;
        public Carrera()
        {
            atletas = new Atleta[3];

            for (int i = 0; i < 3; i++)
            {
                atletas[i] = new Atleta();
            }
        }
        public void imprimirDatos()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"\nAtleta: {atletas[i].devolverNombre()}" + $"\nTiempo: {atletas[i].devolverTiempo()}\n");
            }
        }
        public void sacarPromedio()
        {
                float suma = 0;

                for (int j = 0; j < 3; j++)
                {
                    suma += atletas[j].devolverTiempo();
                }
                promedio = suma / 3;
                Console.WriteLine($"\nEl tiempo promedio de la carrera es: " + promedio);          
        }
        public void mostrarGanador()
        {
            Atleta tiempoMenor = atletas[0];
            string nombreGanador = "";

            for (int i = 0; i < 3; i++)
            {
                if (atletas[i].devolverTiempo() >= tiempoMenor.devolverTiempo())
                {
                    tiempoMenor = atletas[i];
                    nombreGanador = atletas[i].devolverNombre();
                }
            }
            Console.WriteLine($"\nEl atleta ganador es: {nombreGanador}" + ", logrando: " + tiempoMenor.devolverTiempo() + " secs\n");
        }
        public void superaronPromedio()
        {
            for (int i = 0; i < 3; i++)
            {
                if (atletas[i].devolverTiempo() > promedio)
                {
                    Console.WriteLine($"\nEl atleta {atletas[i].devolverNombre()} superó el promedio ({atletas[i].devolverTiempo()})");
                }
            }
        }
        static void Main(string[] args)
        {
            Carrera c = new Carrera();
            c.imprimirDatos();
            c.sacarPromedio();
            c.mostrarGanador();
            c.superaronPromedio();

            Console.ReadKey();
        }
    }
}
