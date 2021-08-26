using ProyectoEmsula.Models;


namespace ProyectoEmsula.DomainServices
{
    public class CanalDomainService
    {
        public string GetCanalDomainService(int id, Canal canal)
        {
            if (canal == null)
            {
                return "No se Encontro el Canal";
            }

            return null;
        }
        public string PostCanalDomainService(Canal canal)
        {
     
            return null;
        }
        public string PutCanalDomainService(int id, Canal canal)
        {
            if (canal == null)
            {
                return "No se Encontro el Canal";
            }
         
            return null;
        }
        public string DeleteCanalDomainService(int id, Canal canal)
        {
            if (canal == null)
            {
                return "No se Encontro el Canal";
            }

            return null;
        }
    }
}
