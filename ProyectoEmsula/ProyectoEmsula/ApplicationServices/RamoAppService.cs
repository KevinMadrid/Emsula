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
    public class RamoAppService
    {
        private readonly EmsulaDataContext _baseDatos;
        private readonly RamoDomainService _ramoDomainServices;

        public RamoAppService(EmsulaDataContext _context, RamoDomainService ramoDomainService)
        {
            _baseDatos = _context;
            _ramoDomainServices = ramoDomainService;
        }

        public async Task<String> GetRamoApplicationService(int id)
        {
            var ramo = await _baseDatos.Ramos.FirstOrDefaultAsync(q => q.Id == id);


            var respuestaDomainService = _ramoDomainServices.GetRamoDomainService(id, ramo);

            bool hayErrorEnElDomainService = respuestaDomainService != null;
            if (hayErrorEnElDomainService)
            {
                return respuestaDomainService;
            }
            return null;
        }

        public async Task<String> PostRamoApplicationService(Ramo ramo)

        {

            var respuestaDomainService = _ramoDomainServices.PostRamoDomainService(ramo);

            bool hayErrorEnElDomainService = respuestaDomainService != null;
            if (hayErrorEnElDomainService)
            {
                return respuestaDomainService;
            }

            _baseDatos.Ramos.Add(ramo);
            await _baseDatos.SaveChangesAsync();

            return null;
        }


        public async Task<String> PutRamoApplicationService(int id, Ramo ramo)
        {

            var respuestaDomainService = _ramoDomainServices.PutRamoDomainService(id, ramo);

            bool hayErrorEnElDomainService = respuestaDomainService != null;
            if (hayErrorEnElDomainService)
            {
                return respuestaDomainService;
            }

            _baseDatos.Entry(ramo).State = EntityState.Modified;
            await _baseDatos.SaveChangesAsync();

            return null;
        }

        public async Task<String> DeleteRamoApplicationService(int id)
        {
            var ramo = await _baseDatos.Ramos.FindAsync(id);
            var respuestaDomainService = _ramoDomainServices.DeleteRamoDomainService(id, ramo);

            bool hayErrorEnElDomainService = respuestaDomainService != null;
            if (hayErrorEnElDomainService)
            {
                return respuestaDomainService;
            }

            _baseDatos.Ramos.Remove(ramo);
            await _baseDatos.SaveChangesAsync();

            return null;
        }
    }
    }
