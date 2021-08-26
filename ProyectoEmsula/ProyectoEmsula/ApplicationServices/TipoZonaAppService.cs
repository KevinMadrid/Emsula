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
    public class TipoZonaAppService
    {
        private readonly EmsulaDataContext _baseDatos;
        private readonly TipoZonaDomainService _tipoZonaDomainServices;

        public TipoZonaAppService(EmsulaDataContext _context, TipoZonaDomainService tipoZonaDomainService)
        {
            _baseDatos = _context;
            _tipoZonaDomainServices = tipoZonaDomainService;
        }

        public async Task<String> GetTipoZonaApplicationService(int id)
        {
            var tipoZona = await _baseDatos.TipoZonas.FirstOrDefaultAsync(q => q.Id == id);


            var respuestaDomainService = _tipoZonaDomainServices.GetTipoZonaDomainService(id, tipoZona);

            bool hayErrorEnElDomainService = respuestaDomainService != null;
            if (hayErrorEnElDomainService)
            {
                return respuestaDomainService;
            }
            return null;
        }
        public async Task<String> PostTipoZonaApplicationService(TipoZona tipoZona)

        {

            var respuestaDomainService = _tipoZonaDomainServices.PostTipoZonaDomainService(tipoZona);

            bool hayErrorEnElDomainService = respuestaDomainService != null;
            if (hayErrorEnElDomainService)
            {
                return respuestaDomainService;
            }

            _baseDatos.TipoZonas.Add(tipoZona);
            await _baseDatos.SaveChangesAsync();

            return null;
        }


        public async Task<String> PutTipoZonaApplicationService(int id, TipoZona tipoZona)
        {

            var respuestaDomainService = _tipoZonaDomainServices.PutTipoZonaDomainService(id, tipoZona);

            bool hayErrorEnElDomainService = respuestaDomainService != null;
            if (hayErrorEnElDomainService)
            {
                return respuestaDomainService;
            }

            _baseDatos.Entry(tipoZona).State = EntityState.Modified;
            await _baseDatos.SaveChangesAsync();

            return null;
        }
        public async Task<String> DeletTipoZonaApplicationService(int id)
        {
            var tipoZona = await _baseDatos.TipoZonas.FindAsync(id);
            var respuestaDomainService = _tipoZonaDomainServices.DeleteTipoZonaDomainService(id, tipoZona);

            bool hayErrorEnElDomainService = respuestaDomainService != null;
            if (hayErrorEnElDomainService)
            {
                return respuestaDomainService;
            }

            _baseDatos.TipoZonas.Remove(tipoZona);
            await _baseDatos.SaveChangesAsync();

            return null;
        }
    }
    }
