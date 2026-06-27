using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    //Crear una clase base llamada SondaExploradora que contenga los atributos Modelo(string) y
    //AutonomiaMinutos(int). Definir un constructor que reciba estos dos valores como parámetros y
    //realice su asignación.
    //Luego, definir dos clases derivadas de la clase base:
    //● SondaSubmarina: que añade el atributo propio PresionMaximaAtm (int, presión máxima
    //soportada en atmósferas).
    //● RoverTerrestre: que añade el atributo propio CantidadRuedas(int).
    //Cada una de estas clases derivadas debe poseer su propio constructor.El mismo debe recibir
    //tanto el atributo específico como los heredados de la clase base, transfiriendo estos últimos a la
    //clase SondaExploradora mediante el uso explícito de la palabra clave base.
    //En el método Main, instanciar un objeto de cada clase derivada y mostrar la totalidad de sus
    //parámetros unificados por consola.
    public class sondaExploradora
    {
        private string modelo;
        private int autonomiaMinutos;

        public string Modelo
        {
            set
            {
                modelo = value;
            }
            get
            {
                return modelo;
            }
        }
        public int AutonomiaMinutos
        {
            set
            {
                autonomiaMinutos = value;
            }
            get
            {
                return autonomiaMinutos;
            }
        }
        public sondaExploradora(string modelo, int autonomiaMinutos)
        {
            Modelo = modelo;
            AutonomiaMinutos = autonomiaMinutos;
            Console.WriteLine($"\nModelo: {modelo}, minutos de autonomia: {autonomiaMinutos} ");
        }
    }
    public class sondaSubmarina : sondaExploradora
    {
        private int presionMaxima;

        public int PresionMaxima
        {
            set
            {
                presionMaxima = value;
            }
            get
            {
                return presionMaxima;
            }
        }
        public sondaSubmarina(string modelo, int autonomiaMinutos, int presionMaxima) : base (modelo, autonomiaMinutos)
        {
            PresionMaxima = presionMaxima;

            Console.WriteLine($"La presion maxima que se soporta es: {presionMaxima}");
        }
    }
    public class roverTerrestre : sondaExploradora
    {
        private int cantidadRuedas;

        public int CantidadRuedas
        {
            set
            {
                cantidadRuedas = value;
            }
            get
            {
                return cantidadRuedas;
            }
        }
        public roverTerrestre(string modelo, int autonomiaMaxima, int cantidadRuedas) : base(modelo, autonomiaMaxima)
        {
            CantidadRuedas = cantidadRuedas;

            Console.WriteLine($"Cantidad de ruedas del rover: {cantidadRuedas}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            sondaExploradora se = new sondaExploradora("SER420", 239);
            sondaSubmarina ss = new sondaSubmarina("SSR421", 250 , 30);
            roverTerrestre st = new roverTerrestre("RTR422", 340, 4);

            Console.ReadKey();
        }
    }
}
