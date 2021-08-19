using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaDatos;
using capaEntidad;

namespace capaNegocio
{
    public class LogueoNegocio
    {
        LogueoDatos ejecutor = new LogueoDatos();

        public LOGUEO Loguearse(string correo, string contrasena)
        {
            return ejecutor.Loguearse(correo, contrasena);
        }
    }
}
