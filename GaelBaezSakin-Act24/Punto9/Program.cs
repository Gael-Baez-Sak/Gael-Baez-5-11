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
{
    class Estudiante
    {
        private string nombreCompleto;
        private double calificacion;
        public string NombreCompleto
        {
            set
            {
                nombreCompleto = value;
            }
            get 
            {
                return nombreCompleto;
            }
        }
        public double Calificacion
        {
            set
            {
                calificacion = value;
            }
            get 
            { 
                return calificacion;
            }
        }
        public Estudiante(string nom, double cal)
        {
            nombreCompleto = nom;
            calificacion = cal;
        }
    }

    class GestionAcademica
    {
        private List<Estudiante> estudiantes;
        public GestionAcademica()
        {
            estudiantes = new List<Estudiante>();
        }
        public void CargarEstudiantes()
        {
            while (true)
            {
                Console.Write("Ingrese el nombre del estudiante (o 'FIN' para terminar): ");
                string nombre = Console.ReadLine();
                if (nombre.ToUpper() == "FIN")
                    break;
                Console.Write("Ingrese la calificacion del estudiante: ");
                double calificacion;
                while (!double.TryParse(Console.ReadLine(), out calificacion))
                {
                    Console.Write("Entrada invalida. Ingrese un numero para la calificacion: ");
                }
                estudiantes.Add(new Estudiante(nombre, calificacion));
            }
        }
        public void ListarEstudiantes()
        {
            Console.WriteLine("\nLista de Estudiantes:");
            foreach (var estudiante in estudiantes)
            {
                Console.WriteLine($"Nombre: {estudiante.NombreCompleto}, Calificacion: {estudiante.Calificacion}");
            }
            Console.WriteLine($"Total de inscriptos: {estudiantes.Count}");
        }
        public void FiltrarAprobados()
        {
            Console.WriteLine("\nEstudiantes Aprobados (Calificación >= 6.0):");
            foreach (var estudiante in estudiantes)
            {
                if (estudiante.Calificacion >= 6.0)
                {
                    Console.WriteLine($"Nombre: {estudiante.NombreCompleto}, Calificacion: {estudiante.Calificacion}");
                }
            }
        }
        public void DarDeBaja()
        {
            Console.Write("Ingrese el nombre del estudiante a dar de baja: ");
            string nombre = Console.ReadLine();
            var estudiante = estudiantes.FirstOrDefault(e => e.NombreCompleto.Equals(nombre, StringComparison.OrdinalIgnoreCase));
            if (estudiante != null)
            {
                estudiantes.Remove(estudiante);
                Console.WriteLine($"Estudiante {nombre} dado de baja.");
            }
            else
            {
                Console.WriteLine($"No se encontro al estudiante con nombre {nombre}.");
            }
        }
        static void Main(string[] args)
        {
            GestionAcademica ga = new GestionAcademica();

            ga.CargarEstudiantes();
            ga.ListarEstudiantes();
            ga.FiltrarAprobados();
            ga.DarDeBaja();

            Console.ReadKey();
        }
    }
}
