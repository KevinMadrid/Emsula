using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoEmsula.Models
{

    public class Territorio

    {
        public int Id { get; set; }
        public string CodigoTerritorio { get; set; }
        public List<Gestion> gestions{ get; set; }



    }
}
