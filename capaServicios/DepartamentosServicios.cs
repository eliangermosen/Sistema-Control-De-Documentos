using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaDatos;
using capaEntidad;

namespace capaServicios
{
    public class DepartamentosServicios
    {
        PFINALEntities db = new PFINALEntities();

        public List<SP_REPORTE_DEPARTAMENTOS_Result> ReporteDepartments(string dpt)
        {
            return db.SP_REPORTE_DEPARTAMENTOS(dpt).ToList();
        }
    }
}
