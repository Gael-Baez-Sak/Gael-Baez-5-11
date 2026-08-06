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
    //List&lt;DispositivoInteligente&gt;.
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
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
