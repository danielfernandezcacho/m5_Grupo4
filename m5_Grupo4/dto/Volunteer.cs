using System;
using System.Collections.Generic;
using System.Text;

namespace m5_Grupo4
{
    class Volunteer : Empleat
    {
        private const string CATEGORIA = "Volunteer";

        public Volunteer() : base()
        {
            setCategoria(CATEGORIA);
        }
    }
}
