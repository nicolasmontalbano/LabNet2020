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
    public class ProductsLogic :   ILogic<Products>
    {


        private readonly NorthwindContext context;
        private readonly Mock<NorthwindContext> mockContext;

        public ProductsLogic(NorthwindContext context)
        {
            this.context = context;
        }

        public ProductsLogic(Mock<NorthwindContext> mockContext)
        {
            this.mockContext = mockContext;
        }



        public List<Products> GetAll()
        {            
                return context.Products.ToList();            
        }

        public Products GetOne(int id)
        {
            try
            {
                return context.Products.First(p => p.ProductID.Equals(id));
            }
            catch (InvalidOperationException ex)
            {
                throw ex;
            }
        }

        public Products Insert(Products entity)
        {
            int ultimoId = (from prod in context.Products
                            orderby prod.ProductID descending
                            select prod.ProductID
                            ).FirstOrDefault();
            ultimoId++;
            entity.ProductID = ultimoId;
            Products nuevoProducto = context.Products.Add(entity);
            context.SaveChanges();
            return nuevoProducto;           
        }

        public void Update(Products entity, int id)
        {

            Products productoAEditar = GetOne(id);
            productoAEditar.ProductName = entity.ProductName;
            productoAEditar.QuantityPerUnit = entity.QuantityPerUnit;
            productoAEditar.UnitPrice = entity.UnitPrice;
            productoAEditar.UnitsInStock = entity.UnitsInStock;
            productoAEditar.UnitsOnOrder = entity.UnitsOnOrder;

            context.SaveChanges();

        }

        public void Delete(int id)
        {
            Products productoAEliminar = GetOne(id);
            context.Products.Remove(productoAEliminar);
            context.SaveChanges();
        }
    }
}
