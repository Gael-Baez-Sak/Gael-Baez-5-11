using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    //Confeccionar una clase llamada DispositivoEnergia que tenga como atributos privados el
    //CodigoIdentificador(string) y la GeneracionKwh(double, que representa los Kilowatts-hora
    //generados). Definir sus respectivas propiedades de lectura y escritura, validando que la
    //generación no sea un valor negativo(en caso de serlo, asignarle 0). Plantear un método para
    //imprimir estos datos básicos.
    //Luego, crear una segunda clase llamada PanelSolar que herede de DispositivoEnergia. Añadir
    //un atributo propio privado llamado AreaMetros (double, que representa la superficie del panel
    //en metros cuadrados) con su propiedad correspondiente(validando que sea mayor a cero).
    //Implementar un método para imprimir todos los datos del panel, incluyendo los heredados.
    //En el programa principal (Main):
    //● Crear un objeto de la clase DispositivoEnergia, ingresar valores y probar su impresión.
    //● Crear un objeto de la clase PanelSolar, cargar sus datos por consola y comprobar que
    //puede acceder tanto a sus propiedades heredadas como a las propias para realizar la
    //muestra de información.
    public class dispositivoEnergia
    {
        private string codigoIdentificador;
        private double generacionKwh;

        public string CodigoIdentificador
        {
            set
            {
                codigoIdentificador = value;
            }
            get
            {
                return codigoIdentificador;
            }
        }
        public double GeneracionKwh
        {
            set
            {
                if (value < 0)
                    generacionKwh = 0;
                else
                    generacionKwh = value;
            }
            get
            {
                return generacionKwh;
            }
        }
        public dispositivoEnergia(string codigoIdentificador, double generacionKwh)
        {
            CodigoIdentificador = codigoIdentificador;
            GeneracionKwh = generacionKwh;
        }

        public void Imprimir()
        {
            Console.WriteLine($"\nCodigo de identificacion: {codigoIdentificador}, Kilowatts por hora: {generacionKwh}");
        }
    }

    public class panelSolar : dispositivoEnergia
    {
        private double areaMetros;

        public double AreaMetros
        {
            set
            {
                if (value > 0)
                    areaMetros = value;
                else
                    areaMetros = 0;
            }
            get
            {
                return areaMetros;
            }
        }

        public panelSolar(string codigoIdentificador, double generacionKwh, double areaMetros) : base(codigoIdentificador, generacionKwh)
        {
            AreaMetros = areaMetros;
        }

        public void Imprimir()
        {
            base.Imprimir();
            Console.WriteLine($"Metros totales que cubre: {areaMetros}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            dispositivoEnergia de = new dispositivoEnergia("KAME34", 340);
            de.Imprimir();

            Console.WriteLine("\n--- Ingrese datos del Panel Solar ---");
            Console.Write("Codigo identificador: ");
            string linea = Console.ReadLine();

            Console.Write("Generacion en Kwh: ");
            double linea2 = double.Parse(Console.ReadLine());

            Console.Write("Area en metros cuadrados: ");
            double linea3 = double.Parse(Console.ReadLine());

            panelSolar ps = new panelSolar(linea, linea2, linea3);
            ps.Imprimir();

            Console.ReadKey();
        }
    }
}
