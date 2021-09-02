using ProyectoEmsula.Models;


namespace ProyectoEmsula.DomainServices
{
    public class TipoEmpresaDomainService
    {
        public string GetTipoEmpresaDomainService(int id, TipoEmpresa tipoEmpresa)
        {
            if (tipoEmpresa == null)
            {
                return "No se Encontro el Tipo de Empresa";
            }

            return null;
        }
        public string PostTipoEmpresaDomainService(TipoEmpresa tipoEmpresa)
        {
     
            return null;
        }
        public string PutTipoEmpresaDomainService(int id, TipoEmpresa tipoEmpresa)
        {
            if (tipoEmpresa == null)
            {
                return "No se Encontro el Tipo de Empresa";
            }
         
            return null;
        }
        public string DeleteTipoEmpresaDomainService(int id, TipoEmpresa tipoEmpresa)
        {
            if (tipoEmpresa == null)
            {
                return "No se Encontro el Tipo de Empresa";
            }

            return null;
        }
    }
}
