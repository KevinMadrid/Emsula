using ProyectoEmsula.Models;


namespace ProyectoEmsula.DomainServices
{
    public class SegmentoDomainService
    {
        public string GetSegmentoDomainService(int id, Segmento segmento)
        {
            if (segmento == null)
            {
                return "No se Encontro el Segmento";
            }

            return null;
        }
        public string PostSegmentoDomainService(Segmento ssegmento)
        {
     
            return null;
        }
        public string PutSegmentoDomainService(int id, Segmento segmento)
        {
            if (segmento == null)
            {
                return "No se Encontro el Segmento";
            }
         
            return null;
        }
        public string DeleteSegmentoDomainService(int id, Segmento segmento)
        {
            if (segmento == null)
            {
                return "No se Encontro el Segmento";
            }

            return null;
        }
    }
}
