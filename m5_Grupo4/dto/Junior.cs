using System;
using System.Collections.Generic;
using System.Text;

namespace m5_Grupo4
{
    class Junior : Empleat
    {
        private const string CATEGORIA = "Junior";
        public Junior() : base()
        {
            setCategoria(CATEGORIA);
        }
    }
}
