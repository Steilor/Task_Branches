using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Clase.Clases
{
    public  class MiembrosDeLaComunidad //Clase padre 
    {
        public string Nombre  {  get; set; }
        public int Mensualidad { get; set; }
        public int Cantidad_Personas { get; set; }
        public int Descuento { get; set; }
        
        public string pago_Anual(int Mensualidad, int Cantidad_Personas, string Nombre, int Descuento)
        {
            int pago_Anual = (Mensualidad * 12 * Cantidad_Personas) - Descuento;

            String factura = $"{Nombre}, Su pago anual siendo {Cantidad_Personas} personas, con un descuento de {Descuento} es de {pago_Anual}";

            return factura;        

        }
    }
}
