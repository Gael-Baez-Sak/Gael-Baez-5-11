using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    //En una empresa trabajan n empleados cuyos sueldos oscilan entre $100 y
    //$500, realizar un programa que lea los sueldos que cobra cada empleado e
    //informe cuántos empleados cobran entre $100 y $300 y cuántos cobran más
    //de $300. Además el programa deberá informar el importe que gasta la empresa
    //en sueldos al personal.
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            int sueldoBajo = 0;
            int sueldoAlto = 0;
            double sueldo;
            double gastoTotal = 0;

            Console.Write("Ingrese la cantidad de empleados (n): ");
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.Write("Ingrese el sueldo del empleado " + i + ": ");
                sueldo = double.Parse(Console.ReadLine());

                if (sueldo >= 100 && sueldo <= 300)
                {
                    sueldoBajo++;
                }
                else if (sueldo > 300)
                {
                    sueldoAlto++;
                }
                gastoTotal = gastoTotal + sueldo;
            }
            Console.WriteLine("Empleados que cobran entre $100 y $300: " + sueldoBajo);
            Console.WriteLine("Empleados que cobran más de $300: " + sueldoAlto);
            Console.WriteLine("Importe total que gasta la empresa en sueldos: $" + gastoTotal);

            Console.ReadKey();
        }
    }
}
