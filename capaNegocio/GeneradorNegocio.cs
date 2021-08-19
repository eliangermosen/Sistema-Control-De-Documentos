using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaDatos;
using capaEntidad;

namespace capaNegocio
{
    public class GeneradorNegocio
    {
        GeneradorDatos ejecutor = new GeneradorDatos();
        public void GuardarDocumento(DOCUMENTO doc)
        {
            ejecutor.InsertarDocumento(doc);
        }
        public List<DOCUMENTO> MostrarDocumentos()
        {
            return ejecutor.ListarDocumentos();
        }
        public void ActualizarDocumento(DOCUMENTO doc)
        {
            ejecutor.ActualizarDocumento(doc);
        }
        public void EliminarDocumento(int id)
        {
            ejecutor.EliminarDocumento(id);
        }
        public DOCUMENTO GetDocumento(int id)
        {
            return ejecutor.GetDocumento(id);
        }
        public List<int> GetInfoForUpDDL()
        {
            return ejecutor.GetInfoForUpDDL();
        }
        public List<string> GetDptForOrgDDL()
        {
            return ejecutor.GetDptForOrgDDL();
        }
        public List<string> GetDptForDestDDL()
        {
            return ejecutor.GetDptForDestDDL();
        }
    }
}
