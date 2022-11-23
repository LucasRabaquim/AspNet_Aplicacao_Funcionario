using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TesteWeb.Models;

namespace TesteWeb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Usuario()
        {
            var usuario = new Usuario();
            return View(usuario); 
        }
        [HttpPost]
        public ActionResult Usuario(Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                return View("Resultado", usuario); 
            }
            return View(usuario); 
        }

        public ActionResult Resultado(Usuario usuario) { return View(usuario); }
    }
}