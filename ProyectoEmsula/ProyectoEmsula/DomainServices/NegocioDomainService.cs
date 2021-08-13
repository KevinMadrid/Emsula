
using ProyectoEmsula.Models;

namespace ProyectoEmsula.DomainServices
{
    public class NegocioDomainService
    {
        public string GetNegocioDomainService(int id, Negocio negocio)
        {
            if (negocio == null)
            {
                return "No se Encontro el Negocio";
            }

            return null;
        }
        public string PostNegocioDomainService(Negocio negocio)
        {

            return null;
        }
        public string PutNegocioDomainService(int id, Negocio negocio)
        {
            if (negocio == null)
            {
                return "No se Encontro el Negocio";
            }

            return null;
        }
        public string DeleteNegocioDomainService(int id, Negocio negocio)
        {
            if (negocio == null)
            {
                return "No se Encontro el Negocio";
            }

            return null;
        }
    }
}
