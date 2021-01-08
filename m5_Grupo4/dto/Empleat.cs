﻿using System;
using System.Collections.Generic;
using System.Text;

namespace m5_Grupo4
{
    class Empleat
    {
        double sueldo = 0;
        double sueldoMensualBruto = 0;
        double sueldoMensualNeto = 0;
        double sueldoAnualBruto = 0;
        double sueldoAnualNeto = 0;
        string categoria = "";
        public Empleat()
        {

        }

        private void AjustarSueldo()
        {
            if (categoria == "Manager")
            {
                sueldo *= 1.1; // Se aumenta el sueldo un 10% 

            }
            else if (categoria == "Boss")
            {
                sueldo *= 1.5; // Se aumenta el sueldo un 50% 

            }
            else if (categoria == "Employee")
            {
                sueldo *= 0.85; // Se reduce el sueldo un 15% 

            }
            else if (categoria == "Volunteer")
            {
                sueldo *= 0; // Se reduce el sueldo un 100% 
            }
            else if (categoria == "Junior")
            {
                sueldo *= 0.85; // Se reduce el sueldo un 15% 
            }
            else if (categoria == "Mid")
            {
                sueldo *= 0.90; // Se reduce el sueldo un 10% 
            }
            else if (categoria == "Senior")
            {
                sueldo *= 0.95; // Se reduce el sueldo un 5% 
            }
            else
            {
                Console.WriteLine("Has introducido {0} que es una categoria erronea.", categoria);
            }
        }

        public void Pedir()
        {
            try
            {
                Console.WriteLine("Introduce el sueldo Mensual bruto:");
                sueldoMensualBruto = Convert.ToDouble(Console.ReadLine());

                AjustarSueldo();

                if (categoria == "Boss" && sueldo <= 8000)
                {
                    throw new sueldo_incorrecto("El sueldo es inferior a 8000");
                }
                else if (categoria == "Manager" && sueldo >= 5000 || categoria == "Manager"  && sueldo<= 3000)
                {
                    throw new sueldo_incorrecto("El sueldo no esta en entre 3000 y 5000");
                }       
                else if (categoria == "volunteer" && sueldo > 300 )
                {
                    throw new sueldo_incorrecto("El sueldo es superior a 300");
                }
                else if (categoria == "volunteer" && sueldo <= 300 && sueldo > 0)
                {
                    Console.WriteLine("El sueldo del volunteer de {0} proviene de una ayuda del estado.", sueldo);
                }
                else if (categoria == "Senior" && sueldo >= 4000 || categoria == "Senior" && sueldo <= 2700)
                {
                    throw new sueldo_incorrecto("El sueldo no esta en entre 2700 y 4000");
                }
                else if (categoria == "Mid" && sueldo >= 2500 || categoria == "Mid" && sueldo <= 1800)
                {
                    throw new sueldo_incorrecto("El sueldo no esta en entre 1800 y 2500");
                }
                else if (categoria == "Junior" && sueldo >= 2500 || categoria == "Junior" && sueldo <= 900)
                {
                    throw new sueldo_incorrecto("El sueldo no esta en entre 900 y 1600");
                }
            }
            catch(Exception e)
            {

                Console.WriteLine("La excepción  {0}  acaba de saltar. ", e.Message);
            }

        }

        public void setCategoria(string categoria)
        {
            this.categoria = categoria;
        }
    }
}
