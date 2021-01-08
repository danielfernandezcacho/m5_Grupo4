using System;
using System.Collections.Generic;
using System.Text;

namespace m5_Grupo4
{
    class Mid : Empleat
    {
        private const string CATEGORIA = "Mid";
        public Mid():base()
        {
            setCategoria(CATEGORIA);
        }

    }
}
