using ProyectoEmsula.Models;


namespace ProyectoEmsula.DomainServices
{
    public class RamoDomainService
    {
        public string GetRamoDomainService(int id, Ramo ramo)
        {
            if (ramo == null)
            {
                return "No se Encontro el Ramo";
            }

            return null;
        }
        public string PostRamoDomainService(Ramo ramo)
        {
     
            return null;
        }
        public string PutRamoDomainService(int id, Ramo ramo)
        {
            if (ramo == null)
            {
                return "No se Encontro el Ramo";
            }
         
            return null;
        }
        public string DeleteRamoDomainService(int id, Ramo ramo)
        {
            if (ramo == null)
            {
                return "No se Encontro el Ramo";
            }

            return null;
        }
    }
}
