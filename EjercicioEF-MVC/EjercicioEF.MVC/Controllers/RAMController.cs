using EjercicioEF.MVC.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Mvc;
using PagedList.Mvc;
using PagedList;
using System.Linq;

namespace EjercicioEF.MVC.Controllers
{
    public class RAMController : Controller
    {
        // GET: RAM

        public async Task<ActionResult> Api(int? i)
        {

            Example characters = new Example();

            using (var charact = new HttpClient())
            {
                charact.BaseAddress = new Uri("https://rickandmortyapi.com");

                HttpResponseMessage res = await charact.GetAsync("/api/character/");

                if (res.IsSuccessStatusCode)
                {
                    var charactResponse = res.Content.ReadAsStringAsync().Result;

                    characters = JsonConvert.DeserializeObject<Example>(charactResponse.ToString());
                }
            }

            return View(characters.Results.ToList().ToPagedList(i ?? 1,15));

        }

        public async Task<ActionResult> Pages()
        {

            Example characters = new Example();

            using (var charact = new HttpClient())
            {
                charact.BaseAddress = new Uri("https://rickandmortyapi.com");

                HttpResponseMessage res = await charact.GetAsync("/api/character/");

                if (res.IsSuccessStatusCode)
                {
                    var charactResponse = res.Content.ReadAsStringAsync().Result;

                    characters = JsonConvert.DeserializeObject<Example>(charactResponse.ToString());
                }
            }

            return View(characters.Info);

        }
    }
}