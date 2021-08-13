using ProyectoEmsula.Models;


namespace ProyectoEmsula.DomainServices
{
    public class ClienteDomainService
    {
        public string GetClienteDomainService(int id, Cliente cliente)
        {
            if (cliente == null)
            {
                return "No se Encontro el cliente";
            }

            return null;
        }
        public string PostClienteDomainService(Cliente cliente)
        {
     
            return null;
        }
        public string PutClienteDomainService(int id, Cliente cliente)
        {
            if (cliente == null)
            {
                return "No se Encontro el Cliente";
            }
         
            return null;
        }
        public string DeleteClienteDomainService(int id, Cliente cliente)
        {
            if (cliente == null)
            {
                return "No se Encontro el Cliente";
            }

            return null;
        }
    }
}
