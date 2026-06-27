using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Punto3
{
    //Crear una clase base llamada Computadora que contenga los atributos Marca y
    //MemoriaRAM(en GB). Definir un constructor que reciba estos dos valores obligatoriamente.
    //Luego, definir dos clases derivadas de la clase base:
    // Notebook: que añade el atributo propio TamanoPantalla(en pulgadas).
    // Escritorio: que añade el atributo propio PotenciaFuente(en Watts).
    //Cada una de estas clases derivadas debe poseer su propio constructor, el cual debe recibir
    //tanto los atributos específicos como los de la clase base, transfiriendo estos últimos a la
    //clase Computadora mediante el uso explícito de la palabra clave base. Instanciar un objeto
    //de cada clase derivada en el Main y mostrar la totalidad de sus datos por consola.
    public class Computadora
    {
        private string marca;
        private int memoriaRAM;

        public string Marca
        {
            set 
            { 
                marca = value; 
            }
            get 
            { 
                return marca; 
            }
        }
        public int MemoriaRAM
        {
            set 
            { 
                memoriaRAM = value; 
            }
            get 
            { 
                return memoriaRAM; 
            }
        }
        public Computadora(string marca, int memoriaRAM)
        {
            Marca = marca;
            MemoriaRAM = memoriaRAM;

            Console.WriteLine($"\nMarca de la computadora: {marca}, Cantidad de memoria RAM: {memoriaRAM}");
        }
    }
    public class Notebook : Computadora
    {
        private int tamañoPantalla;

        public int TamañoPantalla
        {
            set
            {
                tamañoPantalla = value;
            }
            get
            {
                return tamañoPantalla;
            }
        }

        public Notebook(string marca, int memoriaRAM, int tamañoPantalla) : base(marca, memoriaRAM)
        {
            TamañoPantalla = tamañoPantalla;
            Console.WriteLine($"\nTamaño de la pantalla: {tamañoPantalla}");
        }
    }
    public class Escritorio : Computadora
    {
        private int potenciaFuente;
        public int PotenciaFuente
        {
            set
            {
                potenciaFuente = value;
            }
            get
            {
                return potenciaFuente;
            }
        }
        public Escritorio(string marca, int memoriaRAM, int potenciaFuente) : base (marca, memoriaRAM)
        {
            PotenciaFuente = potenciaFuente;
            Console.WriteLine($"\nPotencia de la fuente: {potenciaFuente}");
        }

        static void Main(string[] args)
        {
            Computadora c = new Computadora("DELL", 8);

            Console.WriteLine("\n---Notebook---");
            Notebook n = new Notebook("Lenovo", 8 , 18);

            Console.WriteLine("\n---Escritorio---");
            Escritorio e = new Escritorio("GADNIC", 16 , 24);

            Console.ReadKey();
        }
    }
}
