﻿using System;
using System.Collections.Generic;
using System.Text;

namespace m5_Grupo4.dto
{

    class Boss : Empleat
    {
        private const string CATEGORIA = "Boss";

        public Boss() : base()
        {
            setCategoria(CATEGORIA);
        }
    }
}
