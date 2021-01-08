using System;
using System.Collections.Generic;
using System.Text;

namespace m5_Grupo4
{

    class Manager : Empleat
    {
        private const string CATEGORIA = "Manager";

        public Manager() : base()
        {
            setCategoria(CATEGORIA);
        }
    }
}
