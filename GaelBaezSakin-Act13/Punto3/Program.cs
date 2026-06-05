using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    //Plantear una clase Club y otra clase Socio.
    //La clase Socio debe tener los siguientes atributos privados: nombre y la
    //antigüedad en el club (en años). En el constructor pedir la carga del nombre y
    //su antigüedad. La clase Club debe tener como atributos 3 objetos de la clase
    //Socio. Definir una responsabilidad para imprimir el nombre del socio con mayor
    //antigüedad en el club.
    class Socio
    {
        private string nombre;
        private int añosEnElClub;
        public Socio()
        {
            Console.Write("Ingrese el nombre del socio/a: ");
            nombre = Console.ReadLine();

            Console.Write("Ingrese la cantidad de años que estuvo afiliado: ");
            string linea = Console.ReadLine();
            añosEnElClub = int.Parse(linea);
        }
        public string devolverNombre()
        {
            return nombre;
        }
        public int devolverAños()
        {
            return añosEnElClub;
        }
    }

    class Club
    {
        private Socio[] socios;
        public Club()
        {
            socios = new Socio[3];

            for (int i = 0; i < 3; i++)
            {
                socios[i] = new Socio();

            }
        }

        public void socioMasAntiguo()
        {
            Socio sociomasAntiguo = socios[0];

            for (int i = 0; i < 3; i++)
            {
                if (socios[i].devolverAños() > sociomasAntiguo.devolverAños())
                {
                    sociomasAntiguo = socios[i];
                }
            }
            Console.Write("El socio mas antiguo tiene " + sociomasAntiguo.devolverAños() + " afiliado");
        }

        static void Main(string[] args)
        {
            Club c = new Club();    
            
            c.socioMasAntiguo();

            Console.ReadKey();
        }
    }
}
