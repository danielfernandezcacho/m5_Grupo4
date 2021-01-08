using System;
using System.Collections.Generic;
using System.Text;

namespace m5_Grupo4
{
    class Senior : Empleat
    {
        private const double PORCENTAGE = 0.05;
        public Senior() : base()
        {
            reducir_sueldo(PORCENTAGE);
        }

    }
}
