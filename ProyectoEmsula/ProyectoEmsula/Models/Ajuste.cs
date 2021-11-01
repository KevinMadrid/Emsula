using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoEmsula.Models
{
    public class Ajuste
    {

        public Ajuste(Canal canal, CaracteristicaZona caracteristicaZona, Ciudad ciudad, Compania compania,
                      Departamento departamento, FormaAtencion formaAtencion,
                      PuntoPos puntoPos, PuntoRejas puntoRejas, Ramo ramo, Segmentacion segmentacion, Segmento segmento,
                      Tamano tamano, Territorio territorio, TipoCliente tipoCliente, TipoEmpresa tipoEmpresa, TipoReferencia tipoReferencia,
                      TipoZona tipoZona, ZonaEntrega zonaEntrega,Gestion gestion)
        {
          
            Canal = canal;
            Gestion = gestion;
            CaracteristicaZona = caracteristicaZona;
            Ciudad= ciudad;
            Compania= compania;
            Departamento = departamento;
            FormaAtencion = formaAtencion;
            PuntoPos = puntoPos;
            PuntoRejas = puntoRejas;
            Ramo = ramo;
            Segmentacion = segmentacion;
            Segmento = segmento;
            Tamano = tamano;
            Territorio = territorio;
            TipoCliente = tipoCliente;
            TipoEmpresa = tipoEmpresa;
            TipoReferencia = tipoReferencia;
            TipoZona = tipoZona;
            ZonaEntrega = zonaEntrega;
          
        }

        public Ajuste(Canal canal, CaracteristicaZona caracteristicaZona, Ciudad ciudad, Compania compania,
                         Departamento departamento, FormaAtencion formaAtencion,
                         PuntoPos puntoPos, PuntoRejas puntoRejas, Ramo ramo, Segmentacion segmentacion, Segmento segmento,
                         Tamano tamano, Territorio territorio, TipoCliente tipoCliente, TipoEmpresa tipoEmpresa, TipoReferencia tipoReferencia,
                         TipoZona tipoZona, ZonaEntrega zonaEntrega, Apertura apertura)
        {

            Canal = canal;
            Apertura = apertura;
            CaracteristicaZona = caracteristicaZona;
            Ciudad = ciudad;
            Compania = compania;
            Departamento = departamento;
            FormaAtencion = formaAtencion;
            PuntoPos = puntoPos;
            PuntoRejas = puntoRejas;
            Ramo = ramo;
            Segmentacion = segmentacion;
            Segmento = segmento;
            Tamano = tamano;
            Territorio = territorio;
            TipoCliente = tipoCliente;
            TipoEmpresa = tipoEmpresa;
            TipoReferencia = tipoReferencia;
            TipoZona = tipoZona;
            ZonaEntrega = zonaEntrega;

        }

        public Canal Canal{ get; set; }
        public Gestion Gestion{ get; set; }
        public Apertura Apertura{ get; set; }

        public CaracteristicaZona CaracteristicaZona{ get; set; }
        public Ciudad Ciudad{ get; set; }
        public Compania Compania{ get; set; }
        public Departamento Departamento{ get; set; }
        public FormaAtencion FormaAtencion{ get; set; }
        public PuntoPos PuntoPos{ get; set; }
        public PuntoRejas PuntoRejas{ get; set; }
        public Ramo Ramo{ get; set; }
        public Segmentacion Segmentacion{ get; set; }
        public Segmento Segmento{ get; set; }
        public Tamano Tamano{ get; set; }
        public Territorio Territorio{ get; set; }
        public TipoCliente TipoCliente{ get; set; }
        public TipoEmpresa TipoEmpresa{ get; set; }
        public TipoReferencia TipoReferencia{ get; set; }
        public TipoZona TipoZona{ get; set; }
        public ZonaEntrega ZonaEntrega{ get; set; }

    }
}
