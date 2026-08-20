using Microsoft.SqlServer.Server;
using Microsoft.Win32;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Punto9
{
    internal class Program
    {
        //9-
        //Un instituto de enseñanza registra de forma dinámica a sus estudiantes para
        //realizar el seguimiento académico de sus materias.
        // Crear la clase Estudiante que contenga como atributos privados:
        //nombreCompleto(string) y calificacion(double). Definir sus propiedades
        //de solo lectura y un constructor que reciba nom y cal.
        // Crear la clase GestionAcademica que administre una lista de objetos
        //List.
        // Métodos en GestionAcademica:
        //o CargarEstudiantes(): Solicitar por teclado nombres y
        //calificaciones para agregar estudiantes a la lista mediante.Add(). La
        //carga finaliza cuando el usuario ingresa la palabra &quot; FIN&quot; como
        //nombre.
        //o ListarEstudiantes(): Mostrar en pantalla todos los alumnos
        //junto a la cantidad total de inscriptos mediante la propiedad .Count.
        //o FiltrarAprobados(): Recorrer la lista e imprimir en consola
        //únicamente aquellos estudiantes cuya calificación sea mayor o igual
        //a 6.0.
        //o DarDeBaja(): Pedir al operador el nombre de un estudiante y,
        //utilizando los métodos de búsqueda y remoción de listas, eliminarlo
        //de la colección si se encuentra presente.
        static void Main(string[] args)
        {
        }
    }
}
