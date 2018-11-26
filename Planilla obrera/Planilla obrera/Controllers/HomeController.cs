using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Planilla_obrera.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View("Login");
        }

        [HttpPost]
        public ActionResult Login(LoginModel model)
        {
            ViewBag.Message = "Your Login page.";

            return View("Bonos");
        }
        public ActionResult Bonos()
        {
            ViewBag.Message = "Bonos";
            return View("Bonos");
        }
    }
}