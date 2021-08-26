using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoEmsula.Models
{

    public class Departamento

    {
        public int Id { get; set; }
        public string DepartamentoNombre { get; set; }

        public List<Gestion> gestions{ get; set; }



    }
}
