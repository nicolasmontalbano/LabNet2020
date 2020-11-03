using EjercicioEF.Data;
using EjercicioEF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEF.Logic
{
    class ShippersLogic : BaseLogic, ILogic<Shippers>
    {

        public List<Shippers> GetAll()
        {
            try
            {
                return context.Shippers.ToList();
            }
            catch (InvalidOperationException ex)
            {
                throw ex;
            }
        }


        public Shippers GetOne(int id)
        {
            try
            {
                return context.Shippers.First(s => s.ShipperID.Equals(id));
            }
            catch (InvalidOperationException ex)
            {
                throw ex;
            }
        }
    }
}
