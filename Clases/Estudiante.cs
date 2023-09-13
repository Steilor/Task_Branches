using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase.Clases
{
    internal class Estudiante : MiembrosDeLaComunidad
    {
        public string factura ()
        {
            Nombre = "Manuel";
            Cantidad_Personas = 4;
            Mensualidad = 300;
            Descuento = 200;
            return base.pago_Anual(Mensualidad, Cantidad_Personas, Nombre, Descuento);
        }
    }
}
