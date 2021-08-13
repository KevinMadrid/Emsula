using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoEmsula.Models
{

    public class Negocio
    {
        public int Id { get; set; }
        public string NombreNegocio { get; set; }
        public string ReponsableNegocio { get; set; }
        public int TelefonoNegocio { get; set; }
        public string TamanoNegocio { get; set; }
        public string PuntoRejas { get; set; }
        public string PuntoPos{ get; set; }
        public string FechaAperturaNegocio { get; set; }
        public List<Dato> datos { get; set; }



    }
}
