using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoEmsula.Models
{
    public class Ubicacion

    {
        public int Id { get; set; }
        public string Departamento { get; set; }
        public string Ciudad { get; set; }
        public string Zona { get; set; }
        public string Barrio { get; set; }
        public string CaracteristicaZona { get; set; }
        public string Calle { get; set; }
        public string Avenida { get; set; }
        public string Bloque { get; set; }
        public string Etapa { get; set; }
        public string NumeroCasa { get; set; }
        public string PuntoReferencia { get; set; }
        public List<Dato> datos { get; set; }


    }
}
