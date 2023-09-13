using Clase.Clases;
// Esteilor Paniagua Mateo 2022-1966
namespace Clase
{
    internal class Program
    {
        // Metodo Main
        static void Main(string[] args)
        {
            Empleado empleado = new Empleado();
            

            // Método de Empleado
            string facturaEmpleado = empleado.GenerarFacturaAnual();

            Console.WriteLine(facturaEmpleado); // Factura generada por Empleado

            MiembrosDeLaComunidad miembro = new MiembrosDeLaComunidad();
            miembro.Nombre = "Ana";
            miembro.Cantidad_Personas = 2;
            miembro.Mensualidad = 120;
            miembro.Descuento = 100;

            //  Método de MiembrosDeLaComunidad
            string facturaMiembro = miembro.pago_Anual(miembro.Mensualidad, miembro.Cantidad_Personas, miembro.Nombre, miembro.Descuento);

            Console.WriteLine(facturaMiembro); // Factura generada por MiembrosDeLaComunidad

            Console.ReadKey();
        }
    }
}