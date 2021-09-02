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
    public class TipoReferenciaAppService
    {
        private readonly EmsulaDataContext _baseDatos;
        private readonly TipoReferenciaDomainService _tipoReferenciaDomainServices;

        public TipoReferenciaAppService(EmsulaDataContext _context, TipoReferenciaDomainService tipoReferenciaDomainService)
        {
            _baseDatos = _context;
            _tipoReferenciaDomainServices= tipoReferenciaDomainService;
        }

        public async Task<String> GetTipoReferenciaApplicationService(int id)
        {
            var tipoReferencia = await _baseDatos.TipoReferencias.FirstOrDefaultAsync(q => q.Id == id);


            var respuestaDomainService = _tipoReferenciaDomainServices.GetTipoReferenciaDomainService(id, tipoReferencia);

            bool hayErrorEnElDomainService = respuestaDomainService != null;
            if (hayErrorEnElDomainService)
            {
                return respuestaDomainService;
            }
            return null;
        }
        public async Task<String> PostTipoReferenciaApplicationService(TipoReferencia tipoReferencia)

        {

            var respuestaDomainService = _tipoReferenciaDomainServices.PostTipoReferenciaDomainService(tipoReferencia);

            bool hayErrorEnElDomainService = respuestaDomainService != null;
            if (hayErrorEnElDomainService)
            {
                return respuestaDomainService;
            }

            _baseDatos.TipoReferencias.Add(tipoReferencia);
            await _baseDatos.SaveChangesAsync();

            return null;
        }


        public async Task<String> PutTipoReferenciaApplicationService(int id, TipoReferencia tipoReferencia)
        {

            var respuestaDomainService = _tipoReferenciaDomainServices.PutTipoReferenciaDomainService(id, tipoReferencia);

            bool hayErrorEnElDomainService = respuestaDomainService != null;
            if (hayErrorEnElDomainService)
            {
                return respuestaDomainService;
            }

            _baseDatos.Entry(tipoReferencia).State = EntityState.Modified;
            await _baseDatos.SaveChangesAsync();

            return null;
        }
        public async Task<String> DeleteTipoReferenciaApplicationService(int id)
        {
            var tipoReferencia = await _baseDatos.TipoReferencias.FindAsync(id);
            var respuestaDomainService = _tipoReferenciaDomainServices.DeleteTipoReferenciaDomainService(id, tipoReferencia);

            bool hayErrorEnElDomainService = respuestaDomainService != null;
            if (hayErrorEnElDomainService)
            {
                return respuestaDomainService;
            }

            _baseDatos.TipoReferencias.Remove(tipoReferencia);
            await _baseDatos.SaveChangesAsync();

            return null;
        }
    }
    }
