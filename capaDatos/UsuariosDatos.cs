using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaEntidad;

namespace capaDatos
{
    public class UsuariosDatos
    {
        PFINALEntities db = new PFINALEntities();
        //List<USUARIO> lst = null;
        public void InsertarUsuarios(USUARIO user)
        {
            db.USUARIOS.Add(user);
            db.SaveChanges();
        }
        public List<USUARIO> ListarUsuarios()
        {
            return db.USUARIOS.ToList();
        }
        public void ActualizarUsuarios(USUARIO user)
        {
            var registro = db.USUARIOS.Find(user.ID_USUARIO);

            registro.NOMBRE_U = user.NOMBRE_U;
            registro.APELLIDO = user.APELLIDO;
            registro.CEDULA = user.CEDULA;
            registro.CORREO_U = user.CORREO_U;
            registro.TELEFONO = user.TELEFONO;
            registro.DEPARTAMENTO_U = user.DEPARTAMENTO_U;
            registro.CARGO = user.CARGO;

            db.SaveChanges();
        }
        public void EliminarUsuarios(int id)
        {
            var registro = db.USUARIOS.Find(id);

            db.USUARIOS.Remove(registro);
            db.SaveChanges();
        }
        public USUARIO GetUSUARIO(int id)
        {
            var busca = db.USUARIOS.Where(a => a.ID_USUARIO == id).FirstOrDefault();
            return busca;
        }

        public List<string> GetDptForUserDDL()
        {
            var dpt = db.DEPARTAMENTOS.ToList();
            var ndpt = new List<string>();
            foreach(DEPARTAMENTO elemento in (dpt))
            {
                ndpt.Add(elemento.NOMBRE_DPTO);
            }
            return ndpt;
        }


        //public List<USUARIO> DDList()
        //{
        //    List<USUARIO> lst = null;

        //    using (PFINALEntities dbx = new PFINALEntities())
        //    {
        //        lst = (from d in dbx.DEPARTAMENTOS.AsEnumerable()
        //               select new USUARIO
        //               {
        //                   //ID_USUARIO = d.ID_DEPARTAMENTO,
        //                   DEPARTAMENTO_U = d.NOMBRE_DPTO
        //               }).ToList();
        //    }

        //    List<SelectListItem> items = lst.ConvertAll(d =>
        //    {
        //        return new SelectListItem()
        //        {
        //            n = d.DEPARTAMENTO_U.ToString(),
        //            Value = d.ID_USUARIO,
        //            Selected = false;
        //        }
        //    });

        //    return items;
        //}
    }
}
