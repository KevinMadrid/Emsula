using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoEmsula.Models
{

    public class ZonaEntrega

    {
        public int Id { get; set; }

        public string ZonadeEntrega { get; set; }

        public List<Gestion> gestions{ get; set; }



    }
}
