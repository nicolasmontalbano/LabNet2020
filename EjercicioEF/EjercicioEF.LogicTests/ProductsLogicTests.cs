using Microsoft.VisualStudio.TestTools.UnitTesting;
using EjercicioEF.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjercicioEF.Entities;
using EjercicioEF.Data;
using Moq;

namespace EjercicioEF.Logic.Tests
{
    [TestClass()]
    public class ProductsLogicTests 

    {
        Mock<NorthwindContext> mockContext = new Mock<NorthwindContext>();
        [TestMethod()]
        public void GetAllTest()
        {


            Mock<NorthwindContext> mockContext = new Mock<NorthwindContext>();          

            ProductsLogic productsLogic = new ProductsLogic(mockContext);

            Mock<ILogic<Products>> mock = new Mock<ILogic<Products>>();            
          
            mock.Setup(m => m.GetAll()).Returns( new List<Products>()  );                     

            var allProducts = productsLogic.GetAll();


            Assert.AreEqual( typeof(Mock<List<Products>>), allProducts );
            
        }



        [TestMethod()]
        [ExpectedException(typeof(InvalidOperationException))]
        public void GetOne()
        {
            //arrange

            //act

            // assert

            ProductsLogic productsLogic = new ProductsLogic(mockContext);

            productsLogic.GetOne(99);
        }

    }
}