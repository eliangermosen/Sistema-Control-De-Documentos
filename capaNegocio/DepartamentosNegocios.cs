using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaDatos;
using capaEntidad;

namespace capaNegocio
{
    public class DepartamentosNegocios
    {
        DepartamentosDatos ejecutor = new DepartamentosDatos();

        public void GuardarUsuarios(DEPARTAMENTO dpt)
        {
            ejecutor.InsertarDepartamento(dpt);
        }
        public List<DEPARTAMENTO> MostrarDatos()
        {
            return ejecutor.ListarDepartamento();
        }
        public void ActualizarUsuarios(DEPARTAMENTO dpt)
        {
            ejecutor.ActualizarDepartamento(dpt);
        }
        public void EliminarUsuarios(int id)
        {
            ejecutor.EliminarDepartamento(id);
        }
        public DEPARTAMENTO GetDepartamento(int id)
        {
            return ejecutor.GetDepartamento(id);
        }
    }
}
