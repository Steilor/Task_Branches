using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase.Clases
{
    internal class ExAlumno : MiembrosDeLaComunidad
    {
        public string factura()
        {
            Nombre = "Esteilor";
            Cantidad_Personas = 8;
            Mensualidad = 400;
            Descuento = 300;
            return base.pago_Anual(Mensualidad, Cantidad_Personas, Nombre, Descuento);
        }
    } 
}
