using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    //En el segundo archivo, agregar un método que calcule el total a pagar según la
    //habitación elegida(por ejemplo: Simple = $5000, Doble = $8000, Suite = $12000 por
    //noche).
    partial class Reservas
    {
        public double CalcularTotalAPagar()
        {
            double total = 0;

            if(TipoHabitacion == "Simple")
            {
                total = CantidadNoches * 5000;
            }
            else if(TipoHabitacion == "Doble")
            {
                total = CantidadNoches * 8000;
            }
            else if(TipoHabitacion == "Suite")
            {
                total = CantidadNoches * 12000;
            }
            return total;
        }
    }
}

