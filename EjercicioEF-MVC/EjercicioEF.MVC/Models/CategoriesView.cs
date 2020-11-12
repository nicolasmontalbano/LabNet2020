using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EjercicioEF.MVC.Models
{
    public class CategoriesView
    {
        public int Id { get; set; }

        [Required]
        public string Descripcion { get; set; }
        [Required]
        public string Nombre { get; set; }

    }
}