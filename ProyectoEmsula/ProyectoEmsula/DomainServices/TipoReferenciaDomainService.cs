using ProyectoEmsula.Models;


namespace ProyectoEmsula.DomainServices
{
    public class TipoReferenciaDomainService
    {
        public string GetTipoReferenciaDomainService(int id, TipoReferencia tipoReferencia)
        {
            if (tipoReferencia == null)
            {
                return "No se Encontro el Tipo de Referencia";
            }

            return null;
        }
        public string PostTipoReferenciaDomainService(TipoReferencia tipoReferencia)
        {
     
            return null;
        }
        public string PutTipoReferenciaDomainService(int id, TipoReferencia tipoReferencia)
        {
            if (tipoReferencia == null)
            {
                return "No se Encontro el Tipo de Referencia";
            }
         
            return null;
        }
        public string DeleteTipoReferenciaDomainService(int id, TipoReferencia tipoReferencia)
        {
            if (tipoReferencia == null)
            {
                return "No se Encontro el Tipo de Referencia";
            }

            return null;
        }
    }
}
