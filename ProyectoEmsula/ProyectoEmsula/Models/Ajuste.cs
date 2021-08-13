using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoEmsula.Models
{
    public class Ajuste
    {

        public Ajuste(Negocio negocio, Cliente cliente, Ubicacion ubicacion, DatoEmsula datoEmsula)
        {
            Cliente = cliente;
            Ubicacion = ubicacion;
            DatoEmsula= datoEmsula;
            Negocio = negocio;
        }
     
    
        public Cliente Cliente{ get; set; }
        public Ubicacion Ubicacion{ get; set; }
        public DatoEmsula DatoEmsula{ get; set; }
        public Negocio Negocio{ get; set; }
    }
}
