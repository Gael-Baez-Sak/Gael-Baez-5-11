using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    //Plantear una clase llamada CriaturaMarina y otra clase llamada HabitatAcuatico.
    //La clase CriaturaMarina debe tener como atributos privados: Especie (string),
    //ProfundidadOptima (int, en metros) y NivelSalinidad (un valor de 1 a 100). Definir las
    //propiedades necesarias para acceder a estos atributos asegurando mediante validaciones que:
    //● La profundidad óptima sea estrictamente mayor a cero(0).
    //● El nivel de salinidad se encuentre únicamente en el rango de 1 a 100 (de lo contrario,
    //asignar un valor por defecto de 35, que representa la salinidad promedio del océano).
    //La clase HabitatAcuatico debe contener como atributo un vector capable de almacenar 3 objetos
    //de la clase CriaturaMarina.Definir un método dentro de HabitatAcuatico para cargar las 3
    //criaturas y otro método para mostrar todas las criaturas ordenadas de menor a mayor en base
    //a su profundidad óptima.Además, el programa debe informar la especie que requiere el mayor
    //nivel de salinidad para sobrevivir.
    public class criaturaMarina
    {
        private string especie;
        private int profundidadOptima;
        private int nivelSalinidad;
        public string Especie
        {
            set
            {
                especie = value;
            }
            get
            {
                return especie;
            }
        }
        public int ProfundidadOptima
        {
            set
            {
                if (value > 0)
                    profundidadOptima = value;
                else
                    profundidadOptima = 1;
            }
            get
            {
                return profundidadOptima;
            }
        }
        public int NivelSalinidad
        {
            set
            {
                if (value >= 1 && value <= 100)
                    nivelSalinidad = value;
                else
                    nivelSalinidad = 35;
            }
            get
            {
                return nivelSalinidad;
            }
        }
        public criaturaMarina(string especie, int profundidadOptima, int nivelSalinidad)
        {
            Especie = especie;
            ProfundidadOptima = profundidadOptima;
            NivelSalinidad = nivelSalinidad;
        }
        public void Imprimir()
        {
            Console.WriteLine($"Especie: {Especie}, Profundidad Óptima: {ProfundidadOptima} m, Nivel de Salinidad: {NivelSalinidad}");
        }
    }
    public class habitatAcuatico
    {
        private criaturaMarina[] criaturas;

        public habitatAcuatico()
        {
            criaturas = new criaturaMarina[3];
        }

        public void CargarCriaturas()
        {
            for (int i = 0; i < criaturas.Length; i++)
            {
                Console.WriteLine($"\n--- Ingrese datos de la criatura {i + 1} ---");
                Console.Write("Especie: ");
                string especie = Console.ReadLine();

                Console.Write("Profundidad óptima (m): ");
                int profundidad = int.Parse(Console.ReadLine());

                Console.Write("Nivel de salinidad (1-100): ");
                int salinidad = int.Parse(Console.ReadLine());
                Console.WriteLine("");

                criaturas[i] = new criaturaMarina(especie, profundidad, salinidad);
            }
        }

        public void MostrarCriaturas()
        {
            for (int i = 0; i < criaturas.Length - 1; i++)
            {
                for (int j = i + 1; j < criaturas.Length; j++)
                {
                    if (criaturas[i].ProfundidadOptima > criaturas[j].ProfundidadOptima)
                    {
                        criaturaMarina temp = criaturas[i];
                        criaturas[i] = criaturas[j];
                        criaturas[j] = temp;
                    }
                }
            }
            
            for (int i = 0; i < criaturas.Length; i++)
            {
                criaturas[i].Imprimir();
            }

            int indiceMayorSalinidad = 0;
            for (int i = 1; i < criaturas.Length; i++)
            {
                if (criaturas[i].NivelSalinidad > criaturas[indiceMayorSalinidad].NivelSalinidad)
                    indiceMayorSalinidad = i;
            }
            Console.WriteLine($"\nEspecie que requiere mayor nivel de salinidad: {criaturas[indiceMayorSalinidad].Especie}");
        }

        static void Main(string[] args)
        {
            habitatAcuatico habitat = new habitatAcuatico();
            habitat.CargarCriaturas();
            habitat.MostrarCriaturas();

            Console.ReadKey();
        }
    }
}
