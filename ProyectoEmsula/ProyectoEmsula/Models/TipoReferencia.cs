using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoEmsula.Models
{

    public class TipoReferencia

    {
        public int Id { get; set; }
        public string Tiporeferencia { get; set; }
        public List<Gestion> gestions{ get; set; }



    }
}
