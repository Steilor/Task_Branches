

namespace Clase.Clases
{
    public class Empleado:MiembrosDeLaComunidad
    {
        public new virtual void saludo()
        {
            // Agregar código personalizado al método sobrescrito
            Console.WriteLine("Buenos días, empleados");
        }
    }
}
