using ProyectoEmsula.Models;


namespace ProyectoEmsula.DomainServices
{
    public class UbicacionDomainService
    {
        public string GetUbicacionDomainService(int id, Ubicacion ubicacion)
        {
            if (ubicacion == null)
            {
                return "No se Encontro el Ubicacion";
            }

            return null;
        }
        public string PostUbicacionDomainService(Ubicacion ubicacion)
        {
     
            return null;
        }
        public string PutUbicacionDomainService(int id, Ubicacion ubicacion)
        {
            if (ubicacion == null)
            {
                return "No se Encontro el Ubicacion";
            }
         
            return null;
        }
        public string DeleteUbicacionDomainService(int id, Ubicacion ubicacion)
        {
            if (ubicacion == null)
            {
                return "No se Encontro el Ubicacion";
            }

            return null;
        }
    }
}
