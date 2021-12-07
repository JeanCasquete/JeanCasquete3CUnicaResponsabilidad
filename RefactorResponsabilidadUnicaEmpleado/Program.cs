using System;

namespace RefactorResponsabilidadUnicaEmpleado
{
    class Program
    {
        static void Main(string[] args)
        {
            CEmpleado empleado = new CEmpleado("Rene", "Fisico", 25, 29000);
            
            Console.WriteLine(empleado);
            Console.WriteLine(Cimpuestos.CalcularImpuesto(empleado));
            Cimpuestos.PagarImpuesto(empleado);
        }
    }
}
