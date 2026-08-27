using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Punto7
        //7-
        //Un restaurante automatizado procesa la comanda de una mesa para controlar la
        //preparación y el cobro de los platos pedidos.
        // Crear la clase Plato que contenga como atributos privados: nombrePlato
        //(string) y precio (double). Definir sus propiedades correspondientes y un
        //constructor que reciba nom y pre.
        // Crear la clase GestionComandas que administre una lista de objetos List.
        // Métodos en GestionComandas:
        //o AgregarPlato():Solicitar por teclado los datos de un plato y
        //agregarlo a la lista utilizando .Add().
        //o MostrarComanda(): Listar todos los platos agregados hasta el
        //momento junto a la cantidad total de ítems pedidos utilizando la
        //propiedad.Count.
        //o CalcularTotalMesa(): Calcular y mostrar en pantalla el monto
        //total a cobrar sumando los precios de la lista.
        //o CancelarPlato(): Solicitar al usuario el nombre de un plato y, si
        //se encuentra en la lista, removerlo mediante .Remove() para
        //actualizar la comanda.
{
    class Plato
    {
        private string nombrePlato;
        private double precio;
        public string NombrePlato
        {
            set
            {
                nombrePlato = value;
            }
            get
            {
                return nombrePlato;
            }
        }
        public double Precio
        {
            set
            {
                precio = value;
            }
            get
            {
                return precio;
            }
        }
        public Plato(string nom, double pre)
        {
            nombrePlato = nom;
            precio = pre;
        }
    }
   class GestionComandas
    {
        private List<Plato> listaPlatos;
        public GestionComandas()
        {
            listaPlatos = new List<Plato>();
        }
        public void AgregarPlato(Plato plato)
        {
            listaPlatos.Add(plato);
        }
        public void MostrarComanda()
        {
            foreach (var plato in listaPlatos)
            {
                Console.WriteLine($"Plato: {plato.NombrePlato}, Precio: {plato.Precio}");
            }
            Console.WriteLine($"Cantidad total de ítems pedidos: {listaPlatos.Count}");
        }
        public double CalcularTotalMesa()
        {
            double total = 0;
            foreach (var plato in listaPlatos)
            {
                total += plato.Precio;
            }
            return total;
        }
        public void CancelarPlato(string nombrePlato)
        {
            var platoAEliminar = listaPlatos.FirstOrDefault(p => p.NombrePlato == nombrePlato);
            if (platoAEliminar != null)
            {
                listaPlatos.Remove(platoAEliminar);
                Console.WriteLine($"El plato {nombrePlato} ha sido cancelado.");
            }
            else
            {
                Console.WriteLine($"El plato {nombrePlato} no se encuentra en la comanda.");
            }
        }
        static void Main(string[] args)
        {
            GestionComandas gc = new GestionComandas();

            gc.AgregarPlato(new Plato("Milanesa", 1500));
            gc.AgregarPlato(new Plato("Pizza", 2000));
            gc.AgregarPlato(new Plato("Ensalada", 800));
            gc.MostrarComanda();
            gc.CalcularTotalMesa();
            gc.CancelarPlato("Ensalada");

            Console.ReadKey();
        }
   }
}
