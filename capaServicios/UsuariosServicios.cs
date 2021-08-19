using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaDatos;
using capaEntidad;

namespace capaServicios
{
    public class UsuariosServicios
    {
        PFINALEntities db = new PFINALEntities();

        public List<SP_REPORTE_USUARIOS_Result> ReporteUsers(string nombre)
        {
            return db.SP_REPORTE_USUARIOS(nombre).ToList();
        }
    }
}
