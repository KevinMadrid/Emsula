using ProyectoEmsula.Models;


namespace ProyectoEmsula.DomainServices
{
    public class ZonaEntregaDomainService
    {
        public string GetZonaEntregaDomainService(int id, ZonaEntrega zonaEntrega)
        {
            if (zonaEntrega == null)
            {
                return "No se Encontro la Zona de Entrega";
            }

            return null;
        }
        public string PostZonaEntregaDomainService(ZonaEntrega zonaEntrega)
        {
     
            return null;
        }
        public string PutZonaEntregaDomainService(int id, ZonaEntrega zonaEntrega)
        {
            if (zonaEntrega == null)
            {
                return "No se Encontro la Zona de Entrega";
            }
         
            return null;
        }
        public string DeleteZonaEntregaDomainService(int id, ZonaEntrega zonaEntrega)
        {
            if (zonaEntrega == null)
            {
                return "No se Encontro la Zona de Entrega";
            }

            return null;
        }
    }
}
