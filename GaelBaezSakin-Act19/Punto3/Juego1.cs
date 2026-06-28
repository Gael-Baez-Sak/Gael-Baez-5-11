using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    //En el primer archivo, definir las propiedades NombreJuego, PuntajeMaximo, y
    //NivelDificultad(de 1 a 5). Valores cargados desde consola
    partial class Juego
    {
        private string nombreJuego;
        private int puntajeMaximo;
        private int nivelDificultad;

        public string NombreJuego
        {
            set
            {
                nombreJuego = value;
            }
            get
            {
                return nombreJuego;
            }
        }
        public int PuntajeMaximo
        {
            set
            {
                puntajeMaximo = value;
            }
            get
            {
                return puntajeMaximo;
            }
        }
        public int NivelDificultad
        {
            set
            {
                if (value >= 1 && value <= 5)
                {
                    nivelDificultad = value;
                }
            }
            get
            {
                return nivelDificultad;
            }

        }
    }
}
