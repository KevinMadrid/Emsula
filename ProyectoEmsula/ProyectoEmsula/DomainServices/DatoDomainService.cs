using ProyectoEmsula.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoEmsula.DomainService
{
    public class DatoDomainService
    {
        public string GetDatoDomainService(int id, Dato dato)
        {
            if (dato == null)
            {
                return "No se Encuentra el Dato";
            }
            return null;
        }
         public string PosttDatoDomainService(Ajuste ajuste)
         {
            if (ajuste.Cliente == null)
             {
                 return "No se encontro el Cliente";
             }
             if (ajuste.DatoEmsula== null)
             {
                 return "El Dato de Emsula no existe";
             }

             if (ajuste.Negocio== null)
             {
                 return "El Negocio no existe";
             }
             if (ajuste.Ubicacion == null)
             {
                 return "La Ubicacion no existe";
             }

             return null;
         }
        public string PuttDatoDomainService(int id,Ajuste ajuste)
        {
            if (ajuste.Cliente == null)
            {
                return "No se encontro el Cliente";
            }
            if (ajuste.DatoEmsula== null)
            {
                return "El Dato de Emsula no existe";
            }

            if (ajuste.Negocio== null)
            {
                return "El Negocio no existe";
            }
            if (ajuste.Ubicacion == null)
            {
                return "La Ubicacion no existe";
            }
            return null;
        }
        public string DeletetDatoDomainService(int id, Dato Dato)
        {
            if (Dato == null)
            {
                return "No se encuentro el Dato";
            }
            return null;

        }
    }
}
