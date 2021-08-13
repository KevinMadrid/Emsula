using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoEmsula.Models
{
    public class Usuario
    {
        public string UsuarioId { get; set; }
        public string Contrasenia { get; set; }

        public string Permiso { get; set; }
        public bool EstaActivo { get; set; }

    }
}
