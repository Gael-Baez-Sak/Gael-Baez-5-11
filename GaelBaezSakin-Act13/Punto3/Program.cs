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
    //su antigüedad.La clase Club debe tener como atributos 3 objetos de la clase
    //Socio.Definir una responsabilidad para imprimir el nombre del socio con mayor
    //antigüedad en el club.
    class socio 
    {
        private string nombre;
        private int añosEnElClub;
        public socio()
        {
            Console.Write("Ingrese el nombre del socio/a: ");
            nombre = Console.ReadLine();

            Console.Write("Ingrese la cantidad de años que estuvo afiliado: ");
            string linea = Console.ReadLine();
            añosEnElClub = int.Parse(linea);
        }
      
        }


    }
    class Club
    {
        private socio socio1, socio2, socio3;

        public void socioMasAntiguo()
        {
            if (socio1.añosEnElClub > socio2.añosEnElClub)
            {
                    
            }
        }

        static void Main(string[] args)
        {
        }
    }
}
