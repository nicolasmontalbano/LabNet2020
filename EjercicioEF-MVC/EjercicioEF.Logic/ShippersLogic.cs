using EjercicioEF.Data;
using EjercicioEF.Entities;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEF.Logic
{
    public class ShippersLogic :  ILogic<Shippers>
    {


        private readonly NorthwindContext context;
        private readonly Mock<NorthwindContext> mockContext;

        public ShippersLogic(NorthwindContext context)
        {
            this.context = context;
        }

        public ShippersLogic(Mock<NorthwindContext> mockContext)
        {
            this.mockContext = mockContext;
        }



        public List<Shippers> GetAll()
        {           
                return context.Shippers.ToList();           
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

        public Shippers Insert(Shippers entity)
        {
            int ultimoId = (from prod in context.Products
                            orderby prod.ProductID descending
                            select prod.ProductID
                            ).FirstOrDefault();
            ultimoId++;
            entity.ShipperID = ultimoId;
            Shippers nuevoExpedidor = context.Shippers.Add(entity);
            context.SaveChanges();
            return nuevoExpedidor;
        }

        public void Update(Shippers entity, int id)
        {
            Shippers expedidorAEditar = GetOne(id);
            expedidorAEditar.CompanyName = entity.CompanyName;
            expedidorAEditar.Orders = entity.Orders;
            expedidorAEditar.Phone = entity.Phone;

            context.SaveChanges();
        }

        public void Delete(int id)
        {
            Shippers expedidorAEliminar = GetOne(id);
            context.Shippers.Remove(expedidorAEliminar);
            context.SaveChanges();
        }
    }
}
