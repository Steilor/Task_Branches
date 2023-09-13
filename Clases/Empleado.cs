

using System.Net.Http.Headers;

namespace Clase.Clases
{
    public class Empleado:MiembrosDeLaComunidad
    {
        
        public string GenerarFacturaAnual()
        {
            
            Nombre = "Juan"; 
            Cantidad_Personas = 3; 
            Mensualidad = 100; 
            Descuento = 100;
            // Llamando al método de la clase base usando base
            return base.pago_Anual(Mensualidad, Cantidad_Personas, Nombre, Descuento);

        }
    }
}
