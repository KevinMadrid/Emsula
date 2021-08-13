using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoEmsula.Models
{

    public class DatoEmsula

    {
        public int Id { get; set; }
        public string Compania { get; set; }
        public string Ramo { get; set; }
        public string Segmentacion { get; set; }
        public string Segmento { get; set; }
        public string TipoCliente { get; set; }
        public string FormaAtencion { get; set; }
        public string TipoEmpresa { get; set; }
        public string Tiporeferencia { get; set; }
        public string TipoZona { get; set; }
        public string CodigoCanal { get; set; }
        public string CodigoTerritorio { get; set; }
        public string ZonaEntrega { get; set; }
        public string DiasVisita { get; set; }
        public int OrdenVisita { get; set; }
        public List<Dato> datos{ get; set; }



    }
}
