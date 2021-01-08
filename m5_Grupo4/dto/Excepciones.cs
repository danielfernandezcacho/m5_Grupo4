using System;
using System.Collections.Generic;
using System.Text;

namespace m5_Grupo4
{
    public class OptionInsertedIncorrect : Exception
    {
        public OptionInsertedIncorrect()
        {

        }

        public OptionInsertedIncorrect(string message)
            : base(message)
        {

        }

        public OptionInsertedIncorrect(string message, Exception inner)
            : base(message, inner)
        {

        }

        
    }
    public class sueldo_incorrecto : Exception
    {
        public sueldo_incorrecto()
        {

        }

        public sueldo_incorrecto(string message)
            : base(message)
        {

        }

        public sueldo_incorrecto(string message, Exception inner)
            : base(message, inner)
        {

        }

    }

}
