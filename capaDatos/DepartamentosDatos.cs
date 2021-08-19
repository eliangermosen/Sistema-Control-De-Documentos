using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaEntidad;

namespace capaDatos
{
    public class DepartamentosDatos
    {
        PFINALEntities db = new PFINALEntities();

        public void InsertarDepartamento(DEPARTAMENTO dpt)
        {
            db.DEPARTAMENTOS.Add(dpt);
            db.SaveChanges();
        }
        public List<DEPARTAMENTO> ListarDepartamento()
        {
            return db.DEPARTAMENTOS.ToList();
        }
        public void ActualizarDepartamento(DEPARTAMENTO dpt)
        {
            var registro = db.DEPARTAMENTOS.Find(dpt.ID_DEPARTAMENTO);

            registro.NOMBRE_DPTO = dpt.NOMBRE_DPTO;
            registro.SIGLAS = dpt.SIGLAS;

            db.SaveChanges();
        }
        public void EliminarDepartamento(int id)
        {
            var registro = db.DEPARTAMENTOS.Find(id);

            db.DEPARTAMENTOS.Remove(registro);
            db.SaveChanges();
        }
        public DEPARTAMENTO GetDepartamento(int id)
        {
            var busca = db.DEPARTAMENTOS.Where(a => a.ID_DEPARTAMENTO == id).FirstOrDefault();
            return busca;
        }
    }
}
