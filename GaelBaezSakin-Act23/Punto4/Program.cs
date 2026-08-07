using Microsoft.SqlServer.Server;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Punto4
{
    //    4-

    //Un sistema central de domótica gestiona el consumo de los artefactos inteligentes
    //vinculados a una red hogareña.
    // Crear la clase DispositivoInteligente que contenga como atributos
    //privados: nombreDispositivo(string) y consumoWatts(double). Definir
    //sus propiedades y un constructor que reciba nom y watts.
    // Crear la clase colaboradora PanelDomotico que administre un objeto
    //List<DispositivoInteligente>.
    // Métodos en PanelDomotico:
    //1. Un constructor que permita al usuario cargar dinámicamente
    //dispositivos por teclado.El sistema preguntará después de cada
    //carga si se desea agregar otro dispositivo.
    //2. MostrarDispositivos(): Listar todos los dispositivos
    //configurados junto a sus consumos.
    //3. CalcularConsumoTotal(): Calcular y mostrar en pantalla los
    //Watts totales que consume la casa sumando los valores de la lista.
    //4. DesconectarDispositivo(): Solicitar al usuario el nombre de
    //un dispositivo y, si existe en la lista, removerlo de forma dinámica
    //para simular su apagado remoto.
    class DispositivoInteligente
    {
        private string nombreDispositivo;
        private double consumoWatts;

        public string nombredispositivo
        {
            set
            {
                nombreDispositivo = value;
            }
            get
            {
                return nombreDispositivo;
            }
        }
        public double consumowatts
        {
            set
            {
                consumoWatts = value;
            }
            get
            {
                return consumoWatts;
            }
        }
        public DispositivoInteligente(string nom, double watts)
        {
            nombreDispositivo = nom;
            consumoWatts = watts;
        }
    }
    class PanelDomotico
        //1. Un constructor que permita al usuario cargar dinámicamente
        //dispositivos por teclado.El sistema preguntará después de cada
        //carga si se desea agregar otro dispositivo.
    {
        private List<DispositivoInteligente> listaDispositivos;

        public PanelDomotico()
        {
            listaDispositivos = new List<DispositivoInteligente>();
            while (true)
            {
                Console.Write("\nIngrese el nombre del dispositivo: ");
                string nombreDispositivo = Console.ReadLine();
                Console.Write("Ingrese el consumo en Watts del dispositivo: ");
                double consumoWatts = double.Parse(Console.ReadLine());
                DispositivoInteligente dispositivo = new DispositivoInteligente(nombreDispositivo, consumoWatts);
                listaDispositivos.Add(dispositivo);

                Console.Write("\nqueres agregar otro dispositivo? (Si/No): ");
                string respuesta = Console.ReadLine();
                if (respuesta != "Si")
                {
                    break;
                }
            }
        }
        public void MostrarDispositivos()
        {

            Console.WriteLine("\nLista de dispositivos y sus consumos correspondientes:");
            foreach (var dispositivos in listaDispositivos)
            {
                Console.WriteLine($"Dispositivo: {dispositivos.nombredispositivo}, consumo: {dispositivos.consumowatts}W");
            }
        }
        public void CalcularConsumoTotal()
        {
            //3. CalcularConsumoTotal(): Calcular y mostrar en pantalla los
            //Watts totales que consume la casa sumando los valores de la lista.
        }
        public void DesconectarDispositivo()
        {
            //4. DesconectarDispositivo(): Solicitar al usuario el nombre de
            //un dispositivo y, si existe en la lista, removerlo de forma dinámica
            //para simular su apagado remoto.
            while (true)
            {
                Console.Write("\nIngrese el dispositivo que desea desconectar: ");
                string desconectar = Console.ReadLine();

                string encontrada = listaDispositivos.RemoveAll(d => d == desconectar);

                Console.WriteLine($"Especie encontrada: {encontrada}");
                if (desconectar == "FIN")
                {
                    break;
                }
            }
        }

        static void Main(string[] args)
        {
            PanelDomotico pd = new PanelDomotico();

            pd.CalcularConsumoTotal();
            pd.MostrarDispositivos();
            pd.DesconectarDispositivo();

            Console.ReadKey();
        }
    }
}
