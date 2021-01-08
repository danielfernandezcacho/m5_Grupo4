using System;
using System.Collections.Generic;
using System.Text;

namespace m5_Grupo4
{
    class Empleat
    {
        string tipoEmpleado = "";
        double sueldo = 0;

        public Empleat()
        {

        }

        private void AjustarSueldo()
        {
            if (tipoEmpleado == "Manager")
            {
                sueldo *= 1.1; // Se aumenta el sueldo un 10% 
               
            }
            else if (tipoEmpleado == "Boss")
            {
                sueldo *= 1.5; // Se aumenta el sueldo un 50% 

            }
            else if (tipoEmpleado == "Employee")
            {
                sueldo *= 0.85; // Se reduce el sueldo un 15% 

            }
            else if (tipoEmpleado == "Volunteer")
            {
                sueldo *= 0; // Se reduce el sueldo un 100% 
            }
            else
            {
                Console.WriteLine("Has introducido {0} que es un tipo de empleado erroneo.", tipoEmpleado);
            }
        }

        public void Pedir()
        {
            Console.WriteLine("Introduce tu tipo de empleado:");
            tipoEmpleado = Console.ReadLine();
            Console.WriteLine("Introduce el sueldo:");
            sueldo = Convert.ToDouble(Console.ReadLine());

            AjustarSueldo();

        }
    }
}
