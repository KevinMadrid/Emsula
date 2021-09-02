using ProyectoEmsula.Models;


namespace ProyectoEmsula.DomainServices
{
    public class PuntoPosDomainService
    {
        public string GetPuntoPosDomainService(int id, PuntoPos puntoPos)
        {
            if (puntoPos == null)
            {
                return "No se Encontro el Punto Pos";
            }

            return null;
        }
        public string PostPuntoPosDomainService(PuntoPos puntoPos)
        {
     
            return null;
        }
        public string PutPuntoPosDomainService(int id, PuntoPos puntoPos)
        {
            if (puntoPos == null)
            {
                return "No se Encontro el Punto Pos";
            }
         
            return null;
        }
        public string DeletePuntoPosDomainService(int id, PuntoPos puntoPos)
        {
            if (puntoPos == null)
            {
                return "No se Encontro el Punto Pos";
            }

            return null;
        }
    }
}
