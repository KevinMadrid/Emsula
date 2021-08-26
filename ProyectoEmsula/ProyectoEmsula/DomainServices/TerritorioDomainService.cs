using ProyectoEmsula.Models;


namespace ProyectoEmsula.DomainServices
{
    public class TerritorioDomainService
    {
        public string GetTerritorioDomainService(int id, Territorio territorio)
        {
            if (territorio == null)
            {
                return "No se Encontro el Territorio";
            }

            return null;
        }
        public string PostTerritorioDomainService(Territorio territorio)
        {
     
            return null;
        }
        public string PutTerritorioDomainService(int id, Territorio territorio)
        {
            if (territorio == null)
            {
                return "No se Encontro el Territorio";
            }
         
            return null;
        }
        public string DeleteTerritorioDomainService(int id, Territorio territorio)
        {
            if (territorio == null)
            {
                return "No se Encontro el Territorio";
            }

            return null;
        }
    }
}
