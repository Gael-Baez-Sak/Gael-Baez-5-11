using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    //    2. Logística de Puerto Espacial
    //Una estación de acoplamiento registra el peso de los contenedores transportados en las
    //bodegas de carga de las naves espaciales que llegan al puerto.
    //● Crear la clase NaveEspacial que contenga únicamente el atributo privado
    //NombreNave y su constructor para cargarlo.
    //● Crear la clase colaboradora PuertoControl que contenga:
    //○ Un vector de 3 objetos de la clase NaveEspacial.
    //○ Una matriz irregular de tipo double llamado pesoContenedores, donde
    //cada fila representa a una nave, el tamaño de la fila es la cantidad de
    //bodegas que posee esa nave, y los valores almacenados son los pesos (en
    //toneladas) de los contenedores que transporta cada bodega.

    //En PuertoControl, definir los siguientes métodos:

    //1. Un constructor que cargue los nombres de las 3 naves, pregunte para cada una
    //cuántas bodegas activas posee (para definir el tamaño de su fila en la matriz
    //irregular) y cargue el peso del contenedor asignado a cada bodega.
    //2. Un método que muestre en pantalla el detalle de los pesos cargados por cada nave
    //espacial.
    //3. Un método que identifique e informe qué nave transporta el contenedor individual
    //más pesado de todo el puerto espacial (el valor máximo absoluto de la matriz
    //irregular).
    //4. Un método que indique el nombre de la nave que transporta menor peso acumulado
    //total(la suma de todos sus contenedores).
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
