using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ejercicio4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4.Tests
{
    [TestClass()]
    public class LogicTests
    {
        [TestMethod()]
        [ExpectedException(typeof(CustomException))]
        public void GetExceptionTest()
        {
            //arrange

            //act
            Logic logic = new Logic();
            logic.GetException("Test");

            //assert
            
        }
    }
}