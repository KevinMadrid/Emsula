using ProyectoEmsula.Models;


namespace ProyectoEmsula.DomainServices
{
    public class CompaniaDomainService
    {
        public string GetCompaniaDomainService(int id, Compania compania)
        {
            if (compania == null)
            {
                return "No se Encontro la Compañia";
            }

            return null;
        }
        public string PostCompaniaDomainService(Compania compania)
        {
     
            return null;
        }
        public string PutCompaniaDomainService(int id, Compania compania)
        {
            if (compania == null)
            {
                return "No se Encontro la Compañia";
            }
         
            return null;
        }
        public string DeleteCompaniaDomainService(int id, Compania compania)
        {
            if (compania == null)
            {
                return "No se Encontro la Compañia";
            }

            return null;
        }
    }
}
