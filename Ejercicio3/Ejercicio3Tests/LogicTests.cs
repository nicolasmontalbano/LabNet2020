using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ejercicio3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3.Tests
{
    [TestClass()]
    public class LogicTests
    {
        [TestMethod()]
        [ExpectedException(typeof(FormatException))]
        public void GetExceptionTest()
        {
            //arrange

            //act

            Logic logic = new Logic();
            logic.GetException();

            //assert

        }
    }
}