using ProyectoEmsula.Models;


namespace ProyectoEmsula.DomainServices
{
    public class TipoClienteDomainService
    {
        public string GetTipoTipoClienteDomainService(int id, TipoCliente tipoCliente)
        {
            if (tipoCliente == null)
            {
                return "No se Encontro el Tipo de Cliente";
            }

            return null;
        }
        public string PostTipoClienteDomainService(TipoCliente tipoCliente)
        {
     
            return null;
        }
        public string PutTipoClienteDomainService(int id, TipoCliente tipoCliente)
        {
            if (tipoCliente == null)
            {
                return "No se Encontro el Tipo de Cliente";
            }
         
            return null;
        }
        public string DeleteTipoClienteDomainService(int id, TipoCliente tipoCliente)
        {
            if (tipoCliente == null)
            {
                return "No se Encontro el Tipo de Cliente";
            }

            return null;
        }
    }
}
