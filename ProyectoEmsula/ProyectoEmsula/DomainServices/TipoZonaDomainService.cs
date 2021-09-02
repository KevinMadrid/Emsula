using ProyectoEmsula.Models;


namespace ProyectoEmsula.DomainServices
{
    public class TipoZonaDomainService
    {
        public string GetTipoZonaDomainService(int id, TipoZona tipoZona)
        {
            if (tipoZona == null)
            {
                return "No se Encontro el Tipo de Zona";
            }

            return null;
        }
        public string PostTipoZonaDomainService(TipoZona tipoZona)
        {
     
            return null;
        }
        public string PutTipoZonaDomainService(int id, TipoZona tipoZona)
        {
            if (tipoZona == null)
            {
                return "No se Encontro el Tipo de Zona";
            }
         
            return null;
        }
        public string DeleteTipoZonaDomainService(int id, TipoZona tipoZona)
        {
            if (tipoZona == null)
            {
                return "No se Encontro el Tipo de Zona";
            }

            return null;
        }
    }
}
