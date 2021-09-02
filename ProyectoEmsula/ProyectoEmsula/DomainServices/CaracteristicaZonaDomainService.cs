using ProyectoEmsula.Models;


namespace ProyectoEmsula.DomainServices
{
    public class CaracteristicaZonaDomainService
    {
        public string GetCaracteristicaZonaDomainService(int id, CaracteristicaZona caracteristicaZona)
        {
            if (caracteristicaZona == null)
            {
                return "No se Encontro la Caracteristica de la Zona";
            }

            return null;
        }
        public string PostCaracteristicaZonaDomainService(CaracteristicaZona caracteristicaZona)
        {
     
            return null;
        }
        public string PutCaracteristicaZonaDomainService(int id, CaracteristicaZona caracteristicaZona)
        {
            if (caracteristicaZona == null)
            {
                return "No se Encontro la Caracteristica de la Zona";
            }
         
            return null;
        }
        public string DeleteCaracteristicaZonaDomainService(int id, CaracteristicaZona caracteristicaZona)
        {
            if (caracteristicaZona == null)
            {
                return "No se Encontro la Caracteristica de la Zona";
            }

            return null;
        }
    }
}
