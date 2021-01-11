using System;
using System.Collections.Generic;
using System.Text;

namespace m5_Grupo4
{
    /// <summary>
    /// Excepción para cuando una opción introducida es incorrecta
    /// </summary>
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

    /// <summary>
    /// Excepcion para cuando un sueldo no es correcto para el cargo tratado.
    /// </summary>
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
