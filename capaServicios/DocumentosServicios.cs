using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaDatos;
using capaEntidad;

namespace capaServicios
{
    public class DocumentosServicios
    {
        PFINALEntities db = new PFINALEntities();

        public List<SP_REPORTE_ALLDOCUMENTS_Result> ReporteAllDoc(int alldoc)
        {
            return db.SP_REPORTE_ALLDOCUMENTS(alldoc).ToList();
        }
        public List<SP_REPORTE_DOCFOREMPLOYEES_Result> ReporteDocForEmployees(int emp)
        {
            return db.SP_REPORTE_DOCFOREMPLOYEES(emp).ToList();
        }
        public List<SP_REPORTE_DEPORG_Result> ReporteDepOrg(string deporg)
        {
            return db.SP_REPORTE_DEPORG(deporg).ToList();
        }
        public List<SP_REPORTE_DEPDEST_Result> ReporteDepDest(string depdst)
        {
            return db.SP_REPORTE_DEPDEST(depdst).ToList();
        }
        public List<SP_REPORTE_RANGOFECHA_Result> ReporteRanFech(string fecStart, string fecFinish)
        {
            return db.SP_REPORTE_RANGOFECHA( fecStart, fecFinish).ToList();
        }
    }
}
