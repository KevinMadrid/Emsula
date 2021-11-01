﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProyectoEmsula.Models;

namespace ProyectoEmsula.DomainServices
{
    public class UsuarioDomainService
    {
        public string TieneAcceso(Usuario usuario)
        {
            if (usuario == null)
            {
                return "El usuario o la contraseña no son válidos";
            }

            if (!usuario.EstaActivo)
            {
                return "El usuario no está activo";
            }

            return "sucess";
        }
    }
}
