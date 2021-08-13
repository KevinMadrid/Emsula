using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoEmsula.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public long NumeroIdentidad { get; set; }
        public long NumeroRTN { get; set; }
        public string NombreLegalCliente{ get; set; }
        public string NombreCorto { get; set; }
        public int TelefonoCasa { get; set; }
        public int TelefonoCelular { get; set; }
        public string CorreoElectronico { get; set; }
        public List<Dato> datos{ get; set; }


    }
}
