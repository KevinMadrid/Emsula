using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoEmsula.Models
{

    public class PuntoRejas
    {
        public int Id { get; set; }
        public string PuntoconRejas { get; set; }
        public List<Gestion> gestions { get; set; }



    }
}
