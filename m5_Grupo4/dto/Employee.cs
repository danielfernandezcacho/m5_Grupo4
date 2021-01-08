using System;
using System.Collections.Generic;
using System.Text;

namespace m5_Grupo4
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
