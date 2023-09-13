using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase.Clases
{
    public class Docente : Empleado
    {
        public string factura()
        {
            Nombre = "Josua";
            Cantidad_Personas = 10;
            Mensualidad = 250;
            Descuento = 100;
            return base.pago_Anual(Mensualidad, Cantidad_Personas, Nombre, Descuento);
        }
    }
}
