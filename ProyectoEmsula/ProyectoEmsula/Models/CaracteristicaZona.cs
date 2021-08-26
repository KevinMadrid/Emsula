using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoEmsula.Models
{

    public class CaracteristicaZona

    {
        public int Id { get; set; }
        public string CaracteristicadeZona { get; set; }

        public List<Gestion> gestions{ get; set; }



    }
}
