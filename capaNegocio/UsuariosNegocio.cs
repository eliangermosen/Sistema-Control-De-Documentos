using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaDatos;
using capaEntidad;

namespace capaNegocio
{
    public class UsuariosNegocio
    {
        UsuariosDatos ejecutor = new UsuariosDatos();

        public void GuardarUsuarios(USUARIO elemento)
        {
            ejecutor.InsertarUsuarios(elemento);
        }
        public List<USUARIO> MostrarDatos()
        {
            return ejecutor.ListarUsuarios();
        }
        public void ActualizarUsuarios(USUARIO user)
        {
            ejecutor.ActualizarUsuarios(user);
        }
        public void EliminarUsuarios(int id)
        {
            ejecutor.EliminarUsuarios(id);
        }
        public USUARIO GetUSUARIO(int id)
        {
            return ejecutor.GetUSUARIO(id);
        }
        public List<string> GetDptForUserDDL()
        {
            return ejecutor.GetDptForUserDDL();
        }
    }
}
