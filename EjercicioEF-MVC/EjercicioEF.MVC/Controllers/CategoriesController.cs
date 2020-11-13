using EjercicioEF.Entities;
using EjercicioEF.Logic;
using EjercicioEF.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EjercicioEF.MVC.Controllers
{
    public class CategoriesController : Controller
    {
        // GET: Categories
        public ActionResult Index()
        {
            var logic = new CategoriesLogic();
            var categorias = logic.GetAll();

            List<CategoriesView> categoriesViews = (from categoria in categorias
                                                    select new CategoriesView() {
                                                        Id = categoria.CategoryID,
                                                        Nombre = categoria.CategoryName,
                                                        Descripcion = categoria.Description                                                          
                                                    }).ToList();
            ViewBag.Visitas = HttpContext.Application["CantidadDeVisitantes"];
            return View(categoriesViews);
        }

        public ActionResult Agregar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Agregar(CategoriesView categoria)
        {

            var logic = new CategoriesLogic();
            var categoriaEntity = new Categories() { Description = categoria.Descripcion, CategoryName = categoria.Nombre };
            logic.Insert(categoriaEntity);
            return RedirectToAction("Index");
        }

        public ActionResult Actualizar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Actualizar(CategoriesView categoria, int id)
        {
            var logic = new CategoriesLogic();
            var categoriaEntity = new Categories() { CategoryID = categoria.Id ,Description = categoria.Descripcion, CategoryName = categoria.Nombre };
            logic.Update(categoriaEntity, id);
            return RedirectToAction("Index");
        }


        public ActionResult Delete(int id)
        {
            var logic = new CategoriesLogic();
            logic.Delete(id);
            return RedirectToAction("Index");
        }


    }
}