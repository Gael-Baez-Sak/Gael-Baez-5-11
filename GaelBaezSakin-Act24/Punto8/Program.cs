using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Punto8
{
    //8-
    //Una farmacia controla el nivel de stock de sus medicamentos para evitar el
    //desabastecimiento de insumos esenciales.
    // Crear la clase Medicamento que contenga los atributos privados: nombre
    //(string) y stock(int). Definir sus propiedades correspondientes.Su
    //constructor debe recibir nom y stk.
    // Crear la clase ControlFarmacia que administre una lista de objetos List.
    // Métodos en ControlFarmacia:
    //o Un constructor que cargue por teclado una lista inicial de 4
    //medicamentos ingresando sus nombres y stock.
    //o ListarStock(): Mostrar la lista de medicamentos en pantalla.

    //o RemoverAgotados(): Recorrer la lista y remover por completo de
    //la colección a todos aquellos medicamentos cuyo stock sea igual a 0.
    //o MostrarMedicamentosDisponibles(): Imprimir la lista
    //actualizada y la cantidad de productos disponibles en el inventario
    //utilizando la propiedad .Count.


    public class Medicamento
    {
        private string nombre;
        private int stock;

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

        public int Stock
        {
            set 
            { 
                stock = value;
            }
            get 
            {
                return stock; 
            }
        }

        public Medicamento(string nom, int stk)
        {
           nombre = nom;
           stock = stk;
        }
    }
    public class ControlFarmacia
    {
        private List<Medicamento> medicamentos;
        public ControlFarmacia()
        {
            medicamentos = new List<Medicamento>();

            for (int i = 1; i <= 4; i++)
            {
                Console.WriteLine($"Ingrese nombre del medicamento #{i}:");
                string nom = Console.ReadLine();

                int stk;
                while (true)
                {
                    Console.WriteLine($"Ingrese stock del medicamento '{nom}':");
                    string stkInput = Console.ReadLine();
                    if (int.TryParse(stkInput, out stk) && stk >= 0)
                        break;
                    Console.WriteLine("Stock invalido. Ingrese un numero entero mayor o igual a 0.");
                }

                medicamentos.Add(new Medicamento(nom, stk));
                Console.WriteLine();
            }
        }
        public void ListarStock()
        {
            if (medicamentos.Count == 0)
            {
                Console.WriteLine("No hay medicamentos en la lista.");
                return;
            }

            foreach (var med in medicamentos)
            {
                Console.WriteLine($"Nombre: {med.Nombre} - Stock: {med.Stock}");
            }
        }

        public void RemoverAgotados()
        {
            medicamentos.RemoveAll(m => m.Stock == 0);
        }

        public void MostrarMedicamentosDisponibles()
        {
            Console.WriteLine("Medicamentos disponibles:");
            ListarStock();
            Console.WriteLine($"Cantidad de productos disponibles en inventario: {medicamentos.Count}");
        }
        static void Main(string[] args)
        {
            ControlFarmacia cf = new ControlFarmacia();

            Console.WriteLine();
            Console.WriteLine("Listado inicial de stock:");
            cf.ListarStock();

            Console.WriteLine();
            Console.WriteLine("Removiendo medicamentos agotados (stock == 0)...");
            cf.RemoverAgotados();

            Console.WriteLine();
            cf.MostrarMedicamentosDisponibles();

            Console.WriteLine();
            Console.WriteLine("Presione una tecla para salir...");

            Console.ReadKey();
        }
    }
}
