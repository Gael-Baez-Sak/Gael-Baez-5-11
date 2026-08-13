using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    //    2-
    //Una empresa de logística autónoma monitorea el estado y nivel de batería de sus
    //drones de entrega en vuelo de regreso a la base.
    // Crear la clase Dron que contenga los atributos privados: codigo(string) y
    //nivelBateria(int, de 0 a 100). Definir sus propiedades correspondientes.
    //Su constructor debe recibir cod y bat.
    // Crear la clase CentroControl que administre una lista de objetos
    //List<Dron>;.
    // Métodos en CentroControl:
    //1. Un constructor que cargue por teclado una lista inicial de 4 drones
    //ingresando sus códigos y baterías.
    //2. ListarFlota(): Mostrar la lista de drones en pantalla.
    //3. RemoverDronesBajos(): Recorrer la lista y remover por
    //completo de la flota a todos aquellos drones cuyo nivel de batería
    //sea menor o igual al 15% (ya que requieren mantenimiento
    //automático urgente).
    //4. MostrarDronesRestantes() : Imprimir la flota actualizada y la
    //cantidad de drones operativos utilizando la propiedad.Count.

    class Dron
    {
        private string codigo;
        private int nivelBateria;
        public string Codigo
        {
            set 
            {
                codigo = value;
            }
            get
            { 
                return codigo;
            }
        }
        public int NivelBateria
        {
            set
            {              
                nivelBateria = value;                
            }
            get 
            {
                return nivelBateria;
            }
        }
        public Dron(string cod, int bat)
        {
            codigo = cod;
            nivelBateria = bat;
        }
    }
    class CentroControl
    {
        private List<Dron> listaDrones;
        public CentroControl()
        {
            listaDrones = new List<Dron>();
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"\nIngrese los  datos del dron {i + 1}:");
                Console.Write("Código: ");
                string codigo = Console.ReadLine();
                Console.Write("Nivel de batería (0-100): ");
                int nivelBateria = int.Parse(Console.ReadLine());
                listaDrones.Add(new Dron(codigo, nivelBateria));
            }
        }
        public void ListarFlota()
        {
            Console.WriteLine("\nLista de drones:");
            foreach (var dron in listaDrones)
            {
                Console.WriteLine($"Código: {dron.Codigo}, Nivel de batería: {dron.NivelBateria}%");
            }
        }
        public void RemoverDronesBajos()
        {
            listaDrones.RemoveAll(d => d.NivelBateria <= 15);
        }
        public void MostrarDronesRestantes()
        {
            Console.WriteLine("\nDrones restantes:");
            foreach (var dron in listaDrones)
            {
                Console.WriteLine($"Código: {dron.Codigo}, Nivel de batería: {dron.NivelBateria}%");
            }
            Console.WriteLine($"Cantidad de drones operativos: {listaDrones.Count}");
        }
        static void Main(string[] args)
        {
            CentroControl cc = new CentroControl();

            cc.ListarFlota();
            cc.RemoverDronesBajos();
            cc.MostrarDronesRestantes();

            Console.ReadKey();
        }
    }
}
