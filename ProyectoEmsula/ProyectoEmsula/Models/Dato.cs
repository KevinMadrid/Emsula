using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoEmsula.Models
{
    public class Dato
    {
        public int Id { get; set; }
        public int clienteid { get; set; }
        public Cliente cliente{ get; set; }
        public int datoEmsulaid { get; set; }
        public DatoEmsula datoEmsula{ get; set; }
        public int negocioid { get; set; }
        public Negocio negocio{ get; set; }
        public int ubicacionid { get; set; }
        public Ubicacion ubicacion{ get; set; }


    }
}
