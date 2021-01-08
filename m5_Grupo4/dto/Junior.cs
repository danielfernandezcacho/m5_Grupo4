using System;
using System.Collections.Generic;
using System.Text;

namespace m5_Grupo4
{
    class Junior : Empleat
    {
        private const double PORCENTAGE = 0.15;
        public Junior() : base()
        {

            reducir_sueldo(PORCENTAGE);
        }
    }
}
