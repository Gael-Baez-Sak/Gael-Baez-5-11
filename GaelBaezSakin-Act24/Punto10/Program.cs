using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Punto10
{
    internal class Program
    {
        //10-
        //Un estacionamiento medido administra el ingreso y la salida de los vehículos que
        //utilizan su playa por orden de llegada.
        // Crear la clase Ticket que contenga como atributos privados: patente
        //(string) y horasEstadia (int). Definir sus propiedades de solo lectura y un
        //constructor que reciba pat y hs.
        // Crear la clase GestionEstacionamiento que administre una lista
        //dinámica de tickets (List).
        // Métodos en GestionEstacionamiento:
        //o RegistrarIngreso(): Solicitar por teclado los datos de un ticket y
        //agregarlo al final de la lista utilizando .Add().
        //o ProcesarSalida(): Si la lista no está vacía, simular la salida del
        //primer vehículo de la lista (mostrar sus datos en consola) y
        //removerlo de la colección mediante.RemoveAt(0). Si está vacía,
        //advertir que no hay vehículos esperando salida.
        //o MostrarVehiculosEstacionados(): Listar todos los vehículos
        //alojados en la playa y la cantidad total de unidades presentes
        //utilizando la propiedad.Count.
        static void Main(string[] args)
        {
        }
    }
}
