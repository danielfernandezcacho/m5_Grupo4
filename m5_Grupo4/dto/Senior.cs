using System;
using System.Collections.Generic;
using System.Text;

namespace m5_Grupo4
{
    class Senior : Empleat
    {
        private const string CATEGORIA = "Senior";
        public Senior() : base()
        {
            setCategoria(CATEGORIA);
        }

    }
}
