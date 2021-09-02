using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoEmsula.Models
{
    public class Gestion
    {
        public int Id { get; set; }
        public long NumeroIdentidad { get; set; }
        public long NumeroRTN { get; set; }
        public string NombreLegalCliente { get; set; }
        public string NombreCorto { get; set; }
        public string NombreNegocio { get; set; }
        public string ReponsableNegocio { get; set; }
        public DateTime FechaAperturaNegocio { get; set; }

        public int companiaid { get; set; }
        public Compania Compania { get; set; }
        public int departamentoid { get; set; }
        public Departamento Departamento{ get; set; }
        public int ciudadid { get; set; }
        public Ciudad Ciudad{ get; set; }
        public string Zona { get; set; }
        public string Barrio { get; set; }
        public int caracteristicaZonaid { get; set; }
        public CaracteristicaZona CaracteristicaZona{ get; set; }
        public string Calle { get; set; }
        public string Avenida { get; set; }
        public string Bloque { get; set; }
        public string Etapa { get; set; }
        public int NumeroCasa { get; set; }
        public string PuntoReferencia { get; set; }
        public int TelefonoNegocio{ get; set; }
        public int TelefonoCasa { get; set; }
        public int TelefonoCelular { get; set; }
        public string CorreoElectronico { get; set; }
        public int ramoid { get; set; }
        public Ramo Ramo{ get; set; }
        public int segmentacionid { get; set; }
        public Segmentacion Segmentacion{ get; set; }
        public int segmentoid { get; set; }
        public Segmento Segmento{ get; set; }
        public int tipoEmpresaid { get; set; }
        public TipoEmpresa TipoEmpresa{ get; set; }
        public int tipoReferenciaid { get; set; }
        public TipoReferencia TipoReferencia{ get; set; }
        public int tipoZonaid { get; set; }
        public TipoZona TipoZona{ get; set; }

        public int tamanoid { get; set; }
        public Tamano Tamano{ get; set; }
        public int puntoRejasid { get; set; }
        public PuntoRejas PuntoRejas{ get; set; }
        public int puntoPosid { get; set; }
        public PuntoPos PuntoPos{ get; set; }
        public int tipoClienteid { get; set; }
        public TipoCliente TipoCliente{ get; set; }
        public int formaAtencionid { get; set; }
        public FormaAtencion FormaAtencion{ get; set; }
        public int canalid { get; set; }
        public Canal Canal{ get; set; }
        public int territorioid { get; set; }
        public Territorio Territorio{ get; set; }
        public int zonaEntregaid { get; set; }
        public ZonaEntrega ZonaEntrega{ get; set; }
        public int diaVisitaid { get; set; }
        public DiaVisita DiaVisita{ get; set; }


    }
}
