using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsabilidadUnicaEmpleados
{
    class CEmpleadito

    {
        private string nombre;
        private string puesto;
        private int edad;
        private double sueldo;

        public CEmpleadito(string pNombre, string pPuesto, int pEdad, double pSueldo)
        {
            nombre = pNombre;
            puesto = pPuesto;
            edad = pEdad;
            sueldo = pSueldo;

        }
        public override string ToString()
        {
            return string.Format("Nombre: " + nombre
                + "\nPuesto: " + puesto
                + "\nEdad: " + edad
                + "\nSueldo:" + sueldo);

        } 
        //Aqui van otros metodos propios de empleado
        //- AsignarHorario
        //- ProyectoActual

        //Aqui podemos ver metodos que no es responsabilidad del empleado
        //Tenemos dos razones para cambiar la clase
        //cuando cambia algo de empleado y cambia algo relacionado con los impuestos esta ultima no tiene
        //nada que ver con los empleados
        public double CalcularImpuesto()
        {
            return sueldo * 0.35;
        }
        public void PagarImpuesto()
        {
            Double imp = CalcularImpuesto();
            Console.WriteLine("Se pago {0} en impuestos por parte de {1}", imp, nombre);
        }
    }

}
