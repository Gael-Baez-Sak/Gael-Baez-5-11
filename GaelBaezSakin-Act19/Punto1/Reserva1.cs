using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    //En el primer archivo, definir las propiedades NombreCliente, CantidadNoches y
    //TipoHabitacion(puede ser “Simple”, “Doble” o “Suite”), validando que la cantidad de
    //noches sea mayor a 0. Estos valores son cargados desde la consola.
    partial class Reservas
    {
        private string nombreCliente;
        private int cantidadNoches;
        private string tipoHabitacion;

        public string NombreCliente
        {
            set
            {
                nombreCliente = value;
            }
            get
            {
                return nombreCliente;
            }
        }
        public int CantidadNoches
        {
            set
            {
                if (value > 0)
                {
                    cantidadNoches = value;
                }
            }
            get
            {
                return cantidadNoches;
            }
        }

        public string TipoHabitacion
        {
            set
            {
                if (value == "Simple" || value == "Doble" || value == "Suite")
                {
                    tipoHabitacion = value;
                }
            }
            get
            {
                return tipoHabitacion;
            }
        }
    }
}
