using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    public class CustomException : Exception
    {
        #region Atributos
        private string myException;
        #endregion

        #region Constructor
        public CustomException(string myException) : base ("Excepcion personalizada: " + myException)
        {
            this.myException = myException;
        }
        #endregion
    }
}
