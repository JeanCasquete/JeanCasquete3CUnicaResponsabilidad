using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorResponsabilidadUnicaEmpleado
{
    class Cimpuestos
    { 
        //Creamos una clase especial para la otra responsabilidad
        //Ahora cada clase tiene solo una responsabilidad
        public static double CalcularImpuesto(CEmpleado pEmpleado)
        {
            return pEmpleado.Sueldo * 0.35;
        } 
        public static void PagarImpuesto(CEmpleado Pempleado)
        {
            double imp = CalcularImpuesto(Pempleado);
            Console.WriteLine("Se pago {0} en Impuestos por parte de {1}", imp, Pempleado.Nombre);
        }
    }
}
