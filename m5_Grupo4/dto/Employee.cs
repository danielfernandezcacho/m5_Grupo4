using System;
using System.Collections.Generic;
using System.Text;

namespace m5_Grupo4.dto
{
    class Employee : Empleat
    {
        private const string CATEGORIA = "Employee";

        public Employee() : base()
        {
            setCategoria(CATEGORIA);
        }
    }
}
