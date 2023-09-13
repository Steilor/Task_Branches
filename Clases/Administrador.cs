using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase.Clases
{
    public abstract class Administrador : Docente
    {
        public string factura()
        {
            Nombre = "Lucia";
            Cantidad_Personas = 3;
            Mensualidad = 900;
            Descuento = 200;
            return base.pago_Anual(Mensualidad, Cantidad_Personas, Nombre, Descuento);
        }
    }
}
