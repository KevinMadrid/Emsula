using ProyectoEmsula.Models;


namespace ProyectoEmsula.DomainServices
{
    public class PuntoRejasDomainService
    {
        public string GetPuntoRejasDomainService(int id, PuntoRejas puntoRejas)
        {
            if (puntoRejas == null)
            {
                return "No se Encontro el Punto con Rejas";
            }

            return null;
        }
        public string PostPuntoRejasDomainService(PuntoRejas puntoRejas)
        {
     
            return null;
        }
        public string PutPuntoRejasDomainService(int id, PuntoRejas puntoRejas)
        {
            if (puntoRejas == null)
            {
                return "No se Encontro el Punto con Rejas";
            }
         
            return null;
        }
        public string DeletePuntoRejasDomainService(int id, PuntoRejas puntoRejas)
        {
            if (puntoRejas == null)
            {
                return "No se Encontro el Punto con Rejas";
            }

            return null;
        }
    }
}
