using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace capaPresentacion.Controllers
{
    [Authorize]
    public class IniciopController : Controller
    {
        // GET: Iniciop
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult VReportes()
        {
            return View();
        }
    }
}