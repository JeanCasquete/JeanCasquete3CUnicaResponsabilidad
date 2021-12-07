using System;

namespace ResponsabilidadUnicaEmpleados
{
    class Program
    {
        static void Main(string[] args)
        {
            CEmpleadito empleado = new CEmpleadito("Ulices", "Programador", 23, 150000);
            Console.WriteLine(empleado);
            empleado.PagarImpuesto();
        }

    }
}
