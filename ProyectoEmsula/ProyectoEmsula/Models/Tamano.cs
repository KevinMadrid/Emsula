using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoEmsula.Models
{

    public class Tamano
    {
        public int Id { get; set; }
        public string TamanoNegocio { get; set; }
     
        public List<Gestion> gestions { get; set; }



    }
}
