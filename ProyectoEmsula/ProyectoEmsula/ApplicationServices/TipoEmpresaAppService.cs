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
    public class TipoEmpresaAppService
    {
        private readonly EmsulaDataContext _baseDatos;
        private readonly TipoEmpresaDomainService _tipoEmpresaDomainServices;

        public TipoEmpresaAppService(EmsulaDataContext _context, TipoEmpresaDomainService tipoEmpresaDomainService)
        {
            _baseDatos = _context;
            _tipoEmpresaDomainServices = tipoEmpresaDomainService;
        }

        public async Task<String> GetTipoEmpresaApplicationService(int id)
        {
            var tipoEmpresa = await _baseDatos.TipoEmpresas.FirstOrDefaultAsync(q => q.Id == id);


            var respuestaDomainService = _tipoEmpresaDomainServices.GetTipoEmpresaDomainService(id, tipoEmpresa);

            bool hayErrorEnElDomainService = respuestaDomainService != null;
            if (hayErrorEnElDomainService)
            {
                return respuestaDomainService;
            }
            return null;
        }
        public async Task<String> PostTipoEmpresaApplicationService(TipoEmpresa tipoEmpresa)

        {

            var respuestaDomainService = _tipoEmpresaDomainServices.PostTipoEmpresaDomainService(tipoEmpresa);

            bool hayErrorEnElDomainService = respuestaDomainService != null;
            if (hayErrorEnElDomainService)
            {
                return respuestaDomainService;
            }

            _baseDatos.TipoEmpresas.Add(tipoEmpresa);
            await _baseDatos.SaveChangesAsync();

            return null;
        }


        public async Task<String> PutClienteApplicationService(int id, TipoEmpresa tipoEmpresa)
        {

            var respuestaDomainService = _tipoEmpresaDomainServices.PutTipoEmpresaDomainService(id, tipoEmpresa);

            bool hayErrorEnElDomainService = respuestaDomainService != null;
            if (hayErrorEnElDomainService)
            {
                return respuestaDomainService;
            }

            _baseDatos.Entry(tipoEmpresa).State = EntityState.Modified;
            await _baseDatos.SaveChangesAsync();

            return null;
        }
        public async Task<String> DeleteTipoEmpresaApplicationService(int id)
        {
            var tipoEmpresa = await _baseDatos.TipoEmpresas.FindAsync(id);
            var respuestaDomainService = _tipoEmpresaDomainServices.DeleteTipoEmpresaDomainService(id, tipoEmpresa);

            bool hayErrorEnElDomainService = respuestaDomainService != null;
            if (hayErrorEnElDomainService)
            {
                return respuestaDomainService;
            }

            _baseDatos.TipoEmpresas.Remove(tipoEmpresa );
            await _baseDatos.SaveChangesAsync();

            return null;
        }
    }
    }
