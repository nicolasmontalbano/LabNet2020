using Microsoft.VisualStudio.TestTools.UnitTesting;
using EjercicioEF.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjercicioEF.Entities;
using EjercicioEF.Data;

namespace EjercicioEF.Logic.Tests
{
    [TestClass()]
    public class ProductsLogicTests
    {
        [TestMethod()]
        public void GetAllTest()
        {
            //arrange

            //act

            ProductsLogic productsLogic = new ProductsLogic();

            var res = productsLogic.GetAll();

            //assert System.Collections.Generic.List`1.[EjercicioEF.Entities.Products]
            Assert.AreEqual(typeof(List<Products>), res);
        }



        [TestMethod()]
        [ExpectedException(typeof(InvalidOperationException))]
        public void GetOne()
        {
            //arrange

            //act

            // assert

            ProductsLogic productsLogic = new ProductsLogic();

            productsLogic.GetOne(99);
        }

    }
}