using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ejercicio1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Tests
{
    [TestClass()]
    public class DivisionExceptionTests
    {
        [TestMethod()]
        [ExpectedException(typeof(DivideByZeroException))]
        public void DivisionByZeroTest()
        {
            //arrange

            int dividendo = 5;

            //act

            DivisionException divisionExceptionTest = new DivisionException();

            divisionExceptionTest.Division(dividendo);

            //assert

            
        }
    }
}