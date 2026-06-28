using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    //En el segundo archivo, implementar un método que indique si un puntaje ingresado
    //supera el récord o no.
    partial class Juego
    {
        public void SuperaRecord(int puntajeIngresado)
        {
            if (puntajeIngresado > PuntajeMaximo)
            {
                Console.WriteLine("Superaste el récord.:D");
            }
            else
            {
                Console.WriteLine("No superaste el récord. :(");
            }
        }
    }
}
