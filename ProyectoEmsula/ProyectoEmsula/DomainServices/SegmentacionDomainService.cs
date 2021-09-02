using ProyectoEmsula.Models;


namespace ProyectoEmsula.DomainServices
{
    public class SegmentacionDomainService
    {
        public string GetSegmentacionDomainService(int id, Segmentacion segmentacion)
        {
            if (segmentacion == null)
            {
                return "No se Encontro el Segmentacion";
            }

            return null;
        }
        public string PostSegmentacionDomainService(Segmentacion segmentacion)
        {
     
            return null;
        }
        public string PutSegmentacionDomainService(int id, Segmentacion segmentacion)
        {
            if (segmentacion == null)
            {
                return "No se Encontro el Segmentacion";
            }
         
            return null;
        }
        public string DeleteSegmentacionDomainService(int id, Segmentacion segmentacion)
        {
            if (segmentacion == null)
            {
                return "No se Encontro el Segmentacion";
            }

            return null;
        }
    }
}
