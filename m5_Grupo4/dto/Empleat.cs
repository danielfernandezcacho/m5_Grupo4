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
            try
            {
                Console.WriteLine("Introduce tu tipo de empleado:");
                tipoEmpleado = Console.ReadLine();
                Console.WriteLine("Introduce el sueldo:");
                sueldo = Convert.ToDouble(Console.ReadLine());

                if (tipoEmpleado == "boss" && sueldo <= 8000)
                {
                    throw new sueldo_incorrecto("El sueldo es inferior a 8000");
                }
                else if (tipoEmpleado == "manager" && sueldo >= 5000 && sueldo<= 3000)
                {
                    throw new sueldo_incorrecto("El sueldo no esta en entre 3000 y 5000");
                }
                else if (tipoEmpleado == "Senior" && sueldo >= 4000 && sueldo <= 2700)
                {
                    throw new sueldo_incorrecto("El sueldo no esta en entre 2700 y 4000");
                }
                else if (tipoEmpleado == "mid" && sueldo >= 2500 && sueldo <= 1800)
                {
                    throw new sueldo_incorrecto("El sueldo no esta en entre 1800 y 2500");
                }
                else if (tipoEmpleado == "Junior" && sueldo >= 2500 && sueldo <= 900)
                {
                    throw new sueldo_incorrecto("El sueldo no esta en entre 900 y 1600");
                }
                else if (tipoEmpleado == "volunteer" && sueldo > 0)
                {
                    throw new sueldo_incorrecto("El sueldo es superior a 0");
                }
            }
            catch(Exception e)
            {

                Console.WriteLine("La excepción  {0}  acaba de saltar. ", e.Message);
            }

            AjustarSueldo();

        }

        public void reducir_sueldo(double porcentage)
        {

            sueldo = sueldo - sueldo * porcentage;
        
        
        }
    }
}
