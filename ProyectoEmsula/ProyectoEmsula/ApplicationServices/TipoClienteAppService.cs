using ProyectoEmsula.Models;
using ProyectoEmsula.DataContext;
using ProyectoEmsula.DomainServices;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoEmsula.ApplicationServices
{
    public class TipoClienteAppService
    {
        private readonly EmsulaDataContext _baseDatos;
        private readonly TipoClienteDomainService _tipoClienteDomainServices;

        public TipoClienteAppService(EmsulaDataContext _context, TipoClienteDomainService tipoClienteDomainService)
        {
            _baseDatos = _context;
            _tipoClienteDomainServices = tipoClienteDomainService;
        }

        public async Task<String> GetTipoClienteApplicationService(int id)
        {
            var tipoCliente = await _baseDatos.TipoClientes.FirstOrDefaultAsync(q => q.Id == id);


            var respuestaDomainService = _tipoClienteDomainServices.GetTipoTipoClienteDomainService(id, tipoCliente);

            bool hayErrorEnElDomainService = respuestaDomainService != null;
            if (hayErrorEnElDomainService)
            {
                return respuestaDomainService;
            }
            return null;
        }
        public async Task<String> PostTipoClienteApplicationService(TipoCliente tipoCliente)

        {

            var respuestaDomainService = _tipoClienteDomainServices.PostTipoClienteDomainService(tipoCliente);

            bool hayErrorEnElDomainService = respuestaDomainService != null;
            if (hayErrorEnElDomainService)
            {
                return respuestaDomainService;
            }

            _baseDatos.TipoClientes.Add(tipoCliente);
            await _baseDatos.SaveChangesAsync();

            return null;
        }


        public async Task<String> PutTipoClienteApplicationService(int id, TipoCliente tipoCliente)
        {

            var respuestaDomainService = _tipoClienteDomainServices.PutTipoClienteDomainService(id, tipoCliente);

            bool hayErrorEnElDomainService = respuestaDomainService != null;
            if (hayErrorEnElDomainService)
            {
                return respuestaDomainService;
            }

            _baseDatos.Entry(tipoCliente).State = EntityState.Modified;
            await _baseDatos.SaveChangesAsync();

            return null;
        }
        public async Task<String> DeletTipoClienteApplicationService(int id)
        {
            var tipoCliente = await _baseDatos.TipoClientes.FindAsync(id);
            var respuestaDomainService = _tipoClienteDomainServices.DeleteTipoClienteDomainService(id, tipoCliente);

            bool hayErrorEnElDomainService = respuestaDomainService != null;
            if (hayErrorEnElDomainService)
            {
                return respuestaDomainService;
            }

            _baseDatos.TipoClientes.Remove(tipoCliente);
            await _baseDatos.SaveChangesAsync();

            return null;
        }
    }
    }
