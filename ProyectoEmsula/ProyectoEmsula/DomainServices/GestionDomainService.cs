using ProyectoEmsula.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoEmsula.DomainService
{
    public class GestionDomainService
    {
        public string GetGestionDomainService(int id, Gestion gestion)
        {
            if (gestion == null)
            {
                return "No se Encuentra la Gestion";
            }
            return null;
        }
         public string PostGestionDomainService(Ajuste ajuste)
         {
            if (ajuste.Canal == null)
             {
                 return "No se encontro el Canal";
             }
             if (ajuste.CaracteristicaZona== null)
             {
                 return "La Caracteristica de esta zona no existe";
             }

             if (ajuste.Ciudad== null)
             {
                 return "La Ciudad no existe";
             }
             if (ajuste.Compania == null)
             {
                 return "La Compañia no existe";
             }

            if (ajuste.Departamento == null)
            {
                return "No se encontro el Departamento";
            }
            if (ajuste.DiaVisita == null)
            {
                return "No se encontro el dia de visita";
            }

            if (ajuste.FormaAtencion == null)
            {
                return "La Forma de Atencion no existe";
            }
            if (ajuste.PuntoPos == null)
            {
                return "El Punto Pos no existe";
            }
            if (ajuste.PuntoRejas == null)
            {
                return "El Punto con Reja no existe";
            }
            if (ajuste.Ramo == null)
            {
                return "El Ramo no existe";
            }

            if (ajuste.Segmentacion == null)
            {
                return "La Segmantacion no existe";
            }
            if (ajuste.Segmento == null)
            {
                return "El Segmento no existe";
            }

            if (ajuste.Tamano == null)
            {
                return "El tamaño del negocio no existe";
            }
            if (ajuste.Territorio == null)
            {
                return "El territorio no existe";
            }

            if (ajuste.TipoCliente == null)
            {
                return "El Tipo de Cliente Contable no existe";
            }
            if (ajuste.TipoEmpresa == null)
            {
                return "El Tipo de Empresa no existe";
            }
            if (ajuste.TipoReferencia == null)
            {
                return "El Tipo de Referencia no existe";
            }
            if (ajuste.TipoZona == null)
            {
                return "El Tipo de Zona no existe";
            }

            if (ajuste.ZonaEntrega == null)
            {
                return "La Zona de Entrega no existe";
            }
            return null;
         }
        public string PutGestionDomainService(int id,Ajuste ajuste)
        {
            if (ajuste.Gestion== null)
            {
                return "No se Encontro la Gestion";
            }
            if (ajuste.Canal == null)
            {
                return "No se encontro el Canal";
            }
            if (ajuste.CaracteristicaZona == null)
            {
                return "La Caracteristica de esta zona no existe";
            }

            if (ajuste.Ciudad == null)
            {
                return "La Ciudad no existe";
            }
            if (ajuste.Compania == null)
            {
                return "La Compañia no existe";
            }

            if (ajuste.Departamento == null)
            {
                return "No se encontro el Departamento";
            }
            if (ajuste.DiaVisita == null)
            {
                return "No se encontro el dia de visita";
            }

            if (ajuste.FormaAtencion == null)
            {
                return "La Forma de Atencion no existe";
            }
            if (ajuste.PuntoPos == null)
            {
                return "El Punto Pos no existe";
            }
            if (ajuste.PuntoRejas == null)
            {
                return "El Punto con Reja no existe";
            }
            if (ajuste.Ramo == null)
            {
                return "El Ramo no existe";
            }

            if (ajuste.Segmentacion == null)
            {
                return "La Segmantacion no existe";
            }
            if (ajuste.Segmento == null)
            {
                return "El Segmento no existe";
            }

            if (ajuste.Tamano == null)
            {
                return "El tamaño del negocio no existe";
            }
            if (ajuste.Territorio == null)
            {
                return "El territorio no existe";
            }

            if (ajuste.TipoCliente == null)
            {
                return "El Tipo de Cliente Contable no existe";
            }
            if (ajuste.TipoEmpresa == null)
            {
                return "El Tipo de Empresa no existe";
            }
            if (ajuste.TipoReferencia == null)
            {
                return "El Tipo de Referencia no existe";
            }
            if (ajuste.TipoZona == null)
            {
                return "El Tipo de Zona no existe";
            }

            if (ajuste.ZonaEntrega == null)
            {
                return "La Zona de Entrega no existe";
            }
            return null;
        }
        public string DeletetGestionDomainService(int id, Gestion gestion)
        {
            if (gestion == null)
            {
                return "No se encuentro la Gestion";
            }
            return null;

        }
    }
}
