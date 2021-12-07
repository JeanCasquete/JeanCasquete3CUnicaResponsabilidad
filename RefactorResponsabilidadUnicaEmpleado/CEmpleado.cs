using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorResponsabilidadUnicaEmpleado
{  //Ahora empleado si solo tiene responsabilidad con cosas que le competen
    class CEmpleado
    {
        private string nombre;
        private string puesto;
        private int edad;
        private double sueldo;

       public string Nombre { get => nombre; set => nombre = value; }
       public double Sueldo { get => sueldo; set => sueldo = value; }

        public CEmpleado(string pNombre, string pPuesto, int pEdad, double pSueldo)
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
        //AsigarHorario
        //ProyectoActual
    }
}