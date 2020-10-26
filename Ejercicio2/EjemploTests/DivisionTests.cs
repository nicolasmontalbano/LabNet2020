using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ejercicio2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2.Tests
{
    [TestClass()]
    public class DivisionTests
    {
        [TestMethod()]
        [ExpectedException(typeof(DivideByZeroException))]
        public void DivideByZeroTest()
        {
            //arrange

            int dividendo = 5;
            int divisor = 0;

            //act

            Division divisionExceptionTest = new Division();

            divisionExceptionTest.DivisionsExceptions(dividendo, divisor);

            //assert

        }

        /*[TestMethod()]
        [ExpectedException(typeof(FormatException))]
        public void FormatExceptionTest()
        {
            //arrange

            int dividendo = 5;
            int divisor = 1;

            //act

            Division divisionExceptionTest = new Division();

            divisionExceptionTest.DivisionsExceptions(dividendo, divisor);

            //assert

        }*/
        //(Como le paso un string para testear si el metodo solo recibe int????)       
    }
}