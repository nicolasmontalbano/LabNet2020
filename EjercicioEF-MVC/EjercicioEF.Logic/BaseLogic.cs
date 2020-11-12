using EjercicioEF.Data;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEF.Logic
{
    public class BaseLogic
    {
        protected readonly NorthwindContext context;
        //protected readonly Mock<NorthwindContext> mockContext;

        public BaseLogic()
        {
            this.context = new NorthwindContext();
        }

        //public BaseLogic(Mock<NorthwindContext> mockContext)
        //{
        //    this.mockContext = mockContext;
        //}


    }
}
