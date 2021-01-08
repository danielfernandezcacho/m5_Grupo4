using System;
using System.Collections.Generic;
using System.Text;

namespace m5_Grupo4
{
    class Mid : Empleat
    {
        private const double PORCENTAGE = 0.1;
        public Mid():base()
        {
            reducir_sueldo(PORCENTAGE);
        }

    }
}
