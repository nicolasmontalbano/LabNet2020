using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    public class Division
    {
        public string DivisionsExceptions(int dividendo, int divisor)
        {
            try
            {               
                int resultado = dividendo / divisor;
                return ("El resultado es: " + resultado);
            }                       
            catch (FormatException ex)
            {
                throw (ex);
            }
            catch (DivideByZeroException ex)
            {
                throw (ex);
            }
        }
    }
}
