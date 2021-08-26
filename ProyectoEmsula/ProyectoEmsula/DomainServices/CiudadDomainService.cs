using ProyectoEmsula.Models;


namespace ProyectoEmsula.DomainServices
{
    public class CiudadDomainService
    {
        public string GetCiudadDomainService(int id, Ciudad ciudad)
        {
            if (ciudad == null)
            {
                return "No se Encontro la Ciudad";
            }

            return null;
        }
        public string PostCiudadDomainService(Ciudad ciudad)
        {
     
            return null;
        }
        public string PutCiudadDomainService(int id, Ciudad ciudad)
        {
            if (ciudad == null)
            {
                return "No se Encontro la Ciudad";
            }
         
            return null;
        }
        public string DeleteCiudadDomainService(int id, Ciudad ciudad)
        {
            if (ciudad == null)
            {
                return "No se Encontro la Ciudad";
            }

            return null;
        }
    }
}
