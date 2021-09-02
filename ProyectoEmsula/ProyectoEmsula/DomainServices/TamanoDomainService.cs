using ProyectoEmsula.Models;


namespace ProyectoEmsula.DomainServices
{
    public class TamanoDomainService
    {
        public string GetTamanoDomainService(int id, Tamano tamano)
        {
            if (tamano == null)
            {
                return "No se Encontro el Tamaño";
            }

            return null;
        }
        public string PostTamanoDomainService(Tamano tamano)
        {
     
            return null;
        }
        public string PutTamanoDomainService(int id, Tamano tamano)
        {
            if (tamano == null)
            {
                return "No se Encontro el Tamaño";
            }
         
            return null;
        }
        public string DeleteTamanoDomainService(int id, Tamano tamano)
        {
            if (tamano == null)
            {
                return "No se Encontro el Tamaño";
            }

            return null;
        }
    }
}
