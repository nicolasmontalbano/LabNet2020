using EjercicioEF.Data;
using EjercicioEF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEF.Logic
{
    class ProductsLogic : BaseLogic, ILogic<Products>
    {      
        public List<Products> GetAll()
        {
            try
            {
                return context.Products.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Products GetOne(int id)
        {
            try
            {
                return context.Products.First(p => p.ProductID.Equals(id));
            }
            catch (Exception)
            {
                throw;
            }
        }



    }
}
