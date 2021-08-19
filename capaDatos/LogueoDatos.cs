using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaEntidad;

namespace capaDatos
{
    public class LogueoDatos
    {
        PFINALEntities db = new PFINALEntities();
        public LOGUEO Loguearse(string correo, string contrasena)
        {
            var logueado = db.LOGUEOs.FirstOrDefault(l => l.CORREO_L == correo && l.PASSWORD_L == contrasena);
            //db.SaveChanges();
            return logueado;
        }
    }
}
