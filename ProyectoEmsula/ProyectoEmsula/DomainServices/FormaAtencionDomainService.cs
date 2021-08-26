using ProyectoEmsula.Models;


namespace ProyectoEmsula.DomainServices
{
    public class FormaAtencionDomainService
    {
        public string GetFormaAtencionDomainService(int id, FormaAtencion formaAtencion)
        {
            if (formaAtencion == null)
            {
                return "No se Encontro el Forma de Atencion";
            }

            return null;
        }
        public string PostFormaAtencionDomainService(FormaAtencion formaAtencion)
        {
     
            return null;
        }
        public string PutFormaAtencionDomainService(int id, FormaAtencion formaAtencion)
        {
            if (formaAtencion == null)
            {
                return "No se Encontro el Forma de Atencion";
            }
         
            return null;
        }
        public string DeleteFormaAtencionDomainService(int id, FormaAtencion formaAtencion)
        {
            if (formaAtencion == null)
            {
                return "No se Encontro el Forma de Atencion";
            }

            return null;
        }
    }
}
