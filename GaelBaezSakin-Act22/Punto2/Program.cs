using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    //Definir una clase ElementoPantalla con atributos: nombre, posX y posY.
    // Implementar propiedades y un constructor que cargue valores.
    // Crear un método Mostrar() que use Console.SetCursorPosition() para ubicar el
    //nombre en pantalla y Console.CursorVisible para ocultar el cursor.
    // Generar un vector de 4 elementos y mostrarlos en distintas posiciones en la
    //consola.
    class ElementoPantalla
    {
        private string nombre;
        private int posX;
        private int posY;

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
        public int PosX
        {
            set
            {
                posX = value;
            }
            get
            {
                return posX;
            }
        }
        public int PosY
        {
            set
            {
                posY = value;
            }
            get
            {
                return posY;
            }
        }

        public ElementoPantalla(string nombre, int posX, int posY)
        {
            this.nombre = nombre;
            this.posX = posX;
            this.posY = posY;
        }

        public void Mostrar()
        {
            Console.SetCursorPosition(posX, posY);
            Console.CursorVisible = false;
            Console.WriteLine(nombre);
        }

        static void Main(string[] args)
        {
            ElementoPantalla[] e = new ElementoPantalla[4];
            e[0] = new ElementoPantalla("Elemento 1", 10, 5);
            e[1] = new ElementoPantalla("Elemento 2", 20, 10);
            e[2] = new ElementoPantalla("Elemento 3", 30, 15);
            e[3] = new ElementoPantalla("Elemento 4", 40, 20);

            e[0].Mostrar();
            e[1].Mostrar();
            e[2].Mostrar();
            e[3].Mostrar();

            Console.ReadKey();
        }
    }
}
