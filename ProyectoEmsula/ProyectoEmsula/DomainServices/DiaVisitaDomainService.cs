
using ProyectoEmsula.Models;

namespace ProyectoEmsula.DomainServices
{
    public class DiaVisitaDomainService
    {
        public string GetDiaVisitaDomainService(int id, DiaVisita diaVisita)
        {
            if (diaVisita == null)
            {
                return "No se Encontro el Dia de Visita";
            }

            return null;
        }
        public string PostDiaVisitaDomainService(DiaVisita diaVisita)
        {

            return null;
        }
        public string PutDiaVisitaDomainService(int id, DiaVisita diaVisita)
        {
            if (diaVisita == null)
            {
                return "No se Encontro el Dia de Visita";
            }

            return null;
        }
        public string DeleteDiaVisitaDomainService(int id, DiaVisita diaVisita)
        {
            if (diaVisita == null)
            {
                return "No se Encontro el Dia de Visita";
            }

            return null;
        }
    }
}
