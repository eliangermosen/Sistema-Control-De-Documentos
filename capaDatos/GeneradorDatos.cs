using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaEntidad;

namespace capaDatos
{
    public class GeneradorDatos
    {
        PFINALEntities db = new PFINALEntities();
        public void InsertarDocumento(DOCUMENTO doc)
        {
            ////string fecha = DateTime.Now;
            //doc.FECHA = DateTime.Now.ToString("MM/dd/yyyy hh:mm tt");
            doc.FECHA = DateTime.Now;
            db.DOCUMENTOS.Add(doc);
            db.SaveChanges();
            db.SP_PRUEBA_SECU();
        }
        public List<DOCUMENTO> ListarDocumentos()
        {
            return db.DOCUMENTOS.ToList();
        }
        public void ActualizarDocumento(DOCUMENTO doc)
        {
            var registro = db.DOCUMENTOS.Find(doc.ID_DOCUMENTO);

            registro.TIPO = doc.TIPO;
            registro.UP_USUARIO = doc.UP_USUARIO;
            registro.DEPARTAMENTO_ORIGEN = doc.DEPARTAMENTO_ORIGEN;
            registro.DEPARTAMENTO_DESTINO = doc.DEPARTAMENTO_DESTINO;
            registro.FECHA = doc.FECHA;
            registro.NUMERACION = doc.NUMERACION;

            db.SaveChanges();
        }
        public void EliminarDocumento(int id)
        {
            var registro = db.DOCUMENTOS.Find(id);

            db.DOCUMENTOS.Remove(registro);
            db.SaveChanges();
        }
        public DOCUMENTO GetDocumento(int id)
        {
            var busca = db.DOCUMENTOS.Where(a => a.ID_DOCUMENTO == id).FirstOrDefault();
            return busca;
        }
        public List<int> GetInfoForUpDDL()
        {
            var usr = db.USUARIOS.ToList();
            var nusr = new List<int>();
            foreach (USUARIO elemento in (usr))
            {
                nusr.Add(elemento.ID_USUARIO);
            }
            return nusr;
        }
        public List<string> GetDptForOrgDDL()
        {
            var dpt = db.DEPARTAMENTOS.ToList();
            var ndpt = new List<string>();
            foreach (DEPARTAMENTO elemento in (dpt))
            {
                ndpt.Add(elemento.NOMBRE_DPTO);
            }
            return ndpt;
        }
        public List<string> GetDptForDestDDL()
        {
            var dpt = db.DEPARTAMENTOS.ToList();
            var ndpt = new List<string>();
            foreach (DEPARTAMENTO elemento in (dpt))
            {
                ndpt.Add(elemento.NOMBRE_DPTO);
            }
            return ndpt;
        }

        //public string GetSiglas(int id)
        //{
        //    //db.DEPARTAMENTOS.Where(a => a.ID_DEPARTAMENTO == id).FirstOrDefault();
        //    ////DEPARTAMENTO DP = new DEPARTAMENTO();
        //    db.DEPARTAMENTOS.Find(id);
        //    string siglas = DEPARTAMENTO.;
        //    return siglas;
        //}
    }
}
