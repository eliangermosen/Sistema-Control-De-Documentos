using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using capaEntidad;
using capaNegocio;
using capaServicios;

namespace capaPresentacion.Controllers
{
    [Authorize]
    public class UsuariosController : Controller
    {
        UsuariosNegocio negocio = new UsuariosNegocio();
        UsuariosServicios servicio = new UsuariosServicios();

        // GET: Usuarios
        public ActionResult Index()
        {
            return View();
        }

        // GET: Usuarios/Details/5
        public ActionResult Details()
        {
            return View(negocio.MostrarDatos());
        }

        // GET: Usuarios/Create
        public ActionResult Create()
        {
            ViewBag.DptSelectList = new SelectList(negocio.GetDptForUserDDL(), "Nombre_Dpt");
            return View();
        }

        // POST: Usuarios/Create
        [HttpPost]
        public ActionResult Create(USUARIO param)
        {
            try
            {
                ViewBag.DptSelectList = new SelectList(negocio.GetDptForUserDDL(), "Nombre_Dpt");
                negocio.GuardarUsuarios(param);

                return RedirectToAction("Details");
            }
            catch
            {
                return View();
            }
        }

        // GET: Usuarios/Edit/5
        public ActionResult Edit(int id)
        {
            ViewBag.DptSelectList = new SelectList(negocio.GetDptForUserDDL(), "Nombre_Dpt");
            var usr = negocio.GetUSUARIO(id);
            return View(usr);
        }

        // POST: Usuarios/Edit/5
        [HttpPost]
        public ActionResult Edit(USUARIO param)
        {
            try
            {
                ViewBag.DptSelectList = new SelectList(negocio.GetDptForUserDDL(), "Nombre_Dpt");
                negocio.ActualizarUsuarios(param);

                return RedirectToAction("Details");
            }
            catch
            {
                return View();
            }
        }

        // GET: Usuarios/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);

            var usr = negocio.GetUSUARIO(id.Value);
            return View(usr);
        }

        // POST: Usuarios/Delete/5
        [HttpPost]
        public ActionResult Delete(int id)
        {
            try
            {
                negocio.EliminarUsuarios(id);

                return RedirectToAction("Details");
            }
            catch
            {
                return View();
            }
        }
        public ActionResult GetUsuario(int id)
        {
            var usr = negocio.GetUSUARIO(id);
            return View(usr);
        }
        public ActionResult FiltroRUsuario()
        {
            return View();
        }
        public ActionResult ResultRUsuario(string nombre)
        {
            return View(servicio.ReporteUsers(nombre));
        }
    }
}
