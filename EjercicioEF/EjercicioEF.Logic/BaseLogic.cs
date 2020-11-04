using EjercicioEF.Data;
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

        public BaseLogic()
        {
            this.context = new NorthwindContext();
        }
    }
}
