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
    public class GeneradorDocController : Controller
    {
        GeneradorNegocio negocio = new GeneradorNegocio();
        DocumentosServicios servicio = new DocumentosServicios();

        // GET: GeneradorDoc
        public ActionResult Index()
        {
            return View();
        }

        // GET: GeneradorDoc/Details/5
        public ActionResult Details()
        {
            return View(negocio.MostrarDocumentos());
        }

        // GET: GeneradorDoc/Create
        public ActionResult Create()
        {
            ViewBag.UsrSelectList = new SelectList(negocio.GetInfoForUpDDL(), "Usuario");
            ViewBag.DptDSelectList = new SelectList(negocio.GetDptForOrgDDL(), "Departamento_Origen");
            ViewBag.DptOSelectList = new SelectList(negocio.GetDptForDestDDL(), "Departamento_Destino");
            return View();
        }

        // POST: GeneradorDoc/Create
        [HttpPost]
        public ActionResult Create(DOCUMENTO param)
        {
            try
            {
                ViewBag.UsrSelectList = new SelectList(negocio.GetInfoForUpDDL(), "Usuario");
                ViewBag.DptDSelectList = new SelectList(negocio.GetDptForOrgDDL(), "Departamento_Origen");
                ViewBag.DptOSelectList = new SelectList(negocio.GetDptForDestDDL(), "Departamento_Destino");
                negocio.GuardarDocumento(param);
                return RedirectToAction("Details");
            }
            catch
            {
                return View();
            }
        }

        // GET: GeneradorDoc/Edit/5
        public ActionResult Edit(int id)
        {
            var dc = negocio.GetDocumento(id);
            return View(dc);
        }

        // POST: GeneradorDoc/Edit/5
        [HttpPost]
        public ActionResult Edit(DOCUMENTO param)
        {
            try
            {
                negocio.ActualizarDocumento(param);

                return RedirectToAction("Details");
            }
            catch
            {
                return View();
            }
        }

        // GET: GeneradorDoc/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);

            var dc = negocio.GetDocumento(id.Value);
            return View(dc);
        }

        // POST: GeneradorDoc/Delete/5
        [HttpPost]
        public ActionResult Delete(int id)
        {
            try
            {
                negocio.EliminarDocumento(id);

                return RedirectToAction("Details");
            }
            catch
            {
                return View();
            }
        }
        public ActionResult GetDocumento(int id)
        {
            var dc = negocio.GetDocumento(id);
            return View(dc);
        }
        public ActionResult FiltroRAllDoc()
        {
            return View();
        }
        public ActionResult ResultRAllDoc(int alldoc)
        {
            return View(servicio.ReporteAllDoc(alldoc));
        }
        public ActionResult FiltroRGEmpDoc()
        {
            return View();
        }
        public ActionResult ResultRGEmpDoc(int gedoc)
        {
            return View(servicio.ReporteDocForEmployees(gedoc));
        }
        public ActionResult FiltroRDocDepOrg()
        {
            return View();
        }
        public ActionResult ResultRDocDepOrg(string deporg)
        {
            return View(servicio.ReporteDepOrg(deporg));
        }
        public ActionResult FiltroRDocDepDest()
        {
            return View();
        }
        public ActionResult ResultRDocDepDest(string depdest)
        {
            return View(servicio.ReporteDepDest(depdest));
        }
        public ActionResult FiltroRDocRangFec()
        {
            return View();
        }
        public ActionResult ResultRDocRangFec(string fecStart, string fecFinish)
        {
            return View(servicio.ReporteRanFech(fecStart, fecFinish));
        }
    }
}
