using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase.Clases
{
    public abstract class Maestro : Docente
    {
        public string factura()
        {
            Nombre = "Eladio";
            Cantidad_Personas = 7;
            Mensualidad = 500;
            Descuento = 30;
            return base.pago_Anual(Mensualidad, Cantidad_Personas, Nombre, Descuento);
        }
    }
}
