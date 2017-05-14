using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Tarea2Registro.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Medicinas()
        {
            ViewBag.Message = "Elige tu Medicina.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Pagina de Contacto.";

            return View();
        }
    }
}