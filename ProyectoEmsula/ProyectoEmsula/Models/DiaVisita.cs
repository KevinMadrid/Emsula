using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoEmsula.Models
{

    public class DiaVisita


    {
        public int Id { get; set; }
        public string DiasVisita { get; set; }
        public int OrdenVisita { get; set; }
        public List<Gestion> gestions{ get; set; }



    }
}
