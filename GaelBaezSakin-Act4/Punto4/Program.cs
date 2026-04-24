using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto4
{
    //En un banco se procesan datos de las cuentas corrientes de sus clientes.De cada
    //cuenta corriente se conoce: número de cuenta y saldo actual.El ingreso de datos debe
    //finalizar al ingresar un valor negativo en el número de cuenta.
    //Se pide confeccionar un programa que lea los datos de las cuentas corrientes e
    //informe:
    //a) De cada cuenta: número de cuenta y estado de la cuenta según su saldo, sabiendo
    //que:
    //Estado de la cuenta:
    //○ “Acreedor” si el saldo es &gt;0.
    //○ “Deudor” si el saldo es &lt;0.
    //○ “Nulo” si el saldo es = 0.
    //b) La suma total de los saldos acreedores.
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroCuenta;
            double saldo;
            double sumaAcreedores = 0;

            Console.Write("\nIngrese número de cuenta (valor negativo para finalizar): ");
            numeroCuenta = int.Parse(Console.ReadLine());

            while (numeroCuenta >= 0)
            {
                Console.Write("Ingrese el saldo actual: ");
                saldo = double.Parse(Console.ReadLine());
                if (saldo > 0)
                {
                    Console.WriteLine("Cuenta: " + numeroCuenta + " Estado: Acreedor");
                    sumaAcreedores = sumaAcreedores + saldo;
                }
                else if (saldo < 0)
                {
                    Console.WriteLine("Cuenta: " + numeroCuenta + " Estado: Deudor");
                }
                else
                {
                    Console.WriteLine("Cuenta: " + numeroCuenta + " Estado: Nulo");
                }
                Console.Write("\nIngrese número de cuenta (valor negativo para finalizar): ");
                numeroCuenta = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Suma total de saldos acreedores: $" + sumaAcreedores);

            Console.ReadKey();
        }
    }
}

