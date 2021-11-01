using ProyectoEmsula.DataContext;
using ProyectoEmsula.DomainServices;
using ProyectoEmsula.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoEmsula.ApplicationServices
{
    public class UsuarioAppService
    {

        private readonly EmsulaDataContext _baseDatos;
        private readonly UsuarioDomainService _usuarioDomainServices;

        public UsuarioAppService(EmsulaDataContext baseDatos, UsuarioDomainService usuarioDomainServiceaseDatos)
        {
            _baseDatos = baseDatos;
            _usuarioDomainServices = usuarioDomainServiceaseDatos;
        }


        public async Task<Usuario> TieneAccesoUsuario(string usuarioId, string contrasenia)
        {
            var usuario = await _baseDatos.Usuarios.FirstOrDefaultAsync(q => q.UsuarioId == usuarioId 
            && q.Contrasenia == contrasenia);
 

           var respuestaDomain = _usuarioDomainServices.TieneAcceso(usuario);

            bool vieneConErrorEnElDomain = respuestaDomain != "sucess";
            if (vieneConErrorEnElDomain)
            {
                return null;
            }
                       
            return usuario;

        }

    }
}
