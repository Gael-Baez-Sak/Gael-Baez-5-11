using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Punto4
{
    //Definir una clase Vuelo con atributos: codigo, horaSalida y horaLlegada(DateTime).
    // Usar la palabra clave this en el constructor para diferenciar los parámetros de
    //los atributos.
    // Crear un método para calcular la duración del vuelo (TimeSpan).
    // Cargar un vector con 4 vuelos y mostrar:
    //1. El código y duración del vuelo más largo.
    //2. El código del vuelo que salga más temprano.
    class Vuelo
    {
        private string codigo;
        private DateTime horaSalida;
        private DateTime horaLlegada;
        public Vuelo(string codigo, DateTime horaSalida, DateTime horaLlegada)
        {
            this.codigo = codigo;
            this.horaSalida = horaSalida;
            this.horaLlegada = horaLlegada;
        }
        public TimeSpan CalcularDuracion()
        {
            return horaLlegada - horaSalida;
        }
    
    
        static void Main(string[] args)
        {
        }
    }
}
