using EjercicioEF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEF.Logic
{
    public class CategoriesLogic : BaseLogic, ILogic<Categories>
    {

        public List<Categories> GetAll()
        {
            return context.Categories.ToList();
        }

        public Categories GetOne(int id)
        {
            try
            {
                return context.Categories.First(p => p.CategoryID.Equals(id));
            }
            catch (InvalidOperationException ex)
            {
                throw ex;
            }
        }

        public Categories Insert(Categories entity)
        {         
            try
            {
                Categories nuevaCategoria = context.Categories.Add(entity);
                context.SaveChanges();
                return nuevaCategoria;
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException ex)
            {
                throw ex;
            }
        }


        public void Update(Categories entity, int id)
        {
                     
            try
            {
                Categories categoriaAEditar = GetOne(id);
                categoriaAEditar.CategoryName = entity.CategoryName;
                categoriaAEditar.Description = entity.Description;
                context.SaveChanges();
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException ex)
            {
                throw ex;
            }
        }

        public void Delete(int id)
        {
            Categories categoriaAEliminar = GetOne(id);
            context.Categories.Remove(categoriaAEliminar);
            context.SaveChanges();
        }

    }
}
