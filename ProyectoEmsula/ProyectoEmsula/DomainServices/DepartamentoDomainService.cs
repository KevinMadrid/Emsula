using ProyectoEmsula.Models;


namespace ProyectoEmsula.DomainServices
{
    public class DepartamentoDomainService
    {
        public string GetDepartamentoDomainService(int id, Departamento departamento)
        {
            if (departamento == null)
            {
                return "No se Encontro el Departamento";
            }

            return null;
        }
        public string PostDepartamentoDomainService(Departamento departamento)
        {
     
            return null;
        }
        public string PutDepartamentoDomainService(int id, Departamento departamento)
        {
            if (departamento == null)
            {
                return "No se Encontro el Departamento";
            }
         
            return null;
        }
        public string DeleteDepartamentoDomainService(int id, Departamento departamento)
        {
            if (departamento == null)
            {
                return "No se Encontro el Departamento";
            }

            return null;
        }
    }
}
