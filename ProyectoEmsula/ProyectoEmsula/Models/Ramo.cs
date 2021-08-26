using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoEmsula.Models
{

    public class Ramo

    {
        public int Id { get; set; }
     
        public string RamoNombre { get; set; }
      
        public List<Gestion> gestions{ get; set; }



    }
}
