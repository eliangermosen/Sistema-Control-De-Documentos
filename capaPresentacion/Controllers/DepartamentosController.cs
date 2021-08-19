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
    public class DepartamentosController : Controller
    {
        DepartamentosNegocios negocioD = new DepartamentosNegocios();
        DepartamentosServicios servicio = new DepartamentosServicios();

        // GET: Departamentos
        public ActionResult Index()
        {
            return View();
        }

        // GET: Departamentos/Details/5
        public ActionResult Details()
        {
            return View(negocioD.MostrarDatos());
        }

        // GET: Departamentos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Departamentos/Create
        [HttpPost]
        public ActionResult Create(DEPARTAMENTO param)
        {
            try
            {
                if(param.NOMBRE_DPTO == null)
                {
                    ModelState.AddModelError("", "INGRESE EL NOMBRE DEL DEPARTAMENTO");
                    return View(param);
                }
                if (param.SIGLAS == null)
                {
                    ModelState.AddModelError("", "INGRESE LAS SIGLAS DEL DEPARTAMENTO");
                    return View(param);
                }
                negocioD.GuardarUsuarios(param);

                return RedirectToAction("Details");
            }
            catch(Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return View();
            }
        }

        // GET: Departamentos/Edit/5
        public ActionResult Edit(int id)
        {
            var dpto = negocioD.GetDepartamento(id);
            return View(dpto);
        }

        // POST: Departamentos/Edit/5
        [HttpPost]
        public ActionResult Edit(DEPARTAMENTO param)
        {
            try
            {
                negocioD.ActualizarUsuarios(param);
                // TODO: Add update logic here

                return RedirectToAction("Details");
            }
            catch
            {
                return View();
            }
        }

        // GET: Departamentos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);

            var dpto = negocioD.GetDepartamento(id.Value);
            return View(dpto);
        }

        // POST: Departamentos/Delete/5
        [HttpPost]
        public ActionResult Delete(int id)
        {
            try
            {
                negocioD.EliminarUsuarios(id);

                return RedirectToAction("Details");
            }
            catch
            {
                return View();
            }
        }
        public ActionResult GetDepartamento(int id)
        {
            var dpto = negocioD.GetDepartamento(id);
            return View(dpto);
        }
        public ActionResult FiltroRDepartamento()
        {
            return View();
        }
        public ActionResult ResultRDepartamento(string depart)
        {
            return View(servicio.ReporteDepartments(depart));
        }
    }
}
