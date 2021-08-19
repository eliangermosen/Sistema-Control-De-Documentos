using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using capaEntidad;
using capaNegocio;

namespace capaPresentacion.Controllers
{
    public class HomeLoginController : Controller
    {
        LogueoNegocio negocio = new LogueoNegocio();

        // GET: HomeLogin
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(string correo, string contrasena)
        {
            if (!string.IsNullOrEmpty(correo) && !string.IsNullOrEmpty(contrasena))
            {
                var logueado = negocio.Loguearse(correo, contrasena);
                //si el usuario es diferente a null
                if (logueado != null)
                {
                    //encontramos un usuario con los datos 
                    FormsAuthentication.SetAuthCookie(contrasena, true);
                    return RedirectToAction("Index", "Iniciop");
                }
                else
                {
                    return RedirectToAction("Index", new { message = "No Encontramos Sus Datos!!!" });
                }
            }
            else
            {
                return RedirectToAction("Index", new { message = "Complete los campos de Sus Datos!!!" });
            }
        }
        [Authorize]
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index");
        }
    }
}