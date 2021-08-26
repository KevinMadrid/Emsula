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
    public class ZonaEntregaAppService
    {
        private readonly EmsulaDataContext _baseDatos;
        private readonly ZonaEntregaDomainService _zonaEntregaDomainServices;

        public ZonaEntregaAppService(EmsulaDataContext _context, ZonaEntregaDomainService zonaEntregaDomainService)
        {
            _baseDatos = _context;
            _zonaEntregaDomainServices = zonaEntregaDomainService;
        }

        public async Task<String> GetZonaEntregaApplicationService(int id)
        {
            var zonaEntrega = await _baseDatos.ZonaEntregas.FirstOrDefaultAsync(q => q.Id == id);


            var respuestaDomainService = _zonaEntregaDomainServices.GetZonaEntregaDomainService(id, zonaEntrega);

            bool hayErrorEnElDomainService = respuestaDomainService != null;
            if (hayErrorEnElDomainService)
            {
                return respuestaDomainService;
            }
            return null;
        }
        public async Task<String> PostZonaEntregaApplicationService(ZonaEntrega zonaEntrega)

        {

            var respuestaDomainService = _zonaEntregaDomainServices.PostZonaEntregaDomainService(zonaEntrega);

            bool hayErrorEnElDomainService = respuestaDomainService != null;
            if (hayErrorEnElDomainService)
            {
                return respuestaDomainService;
            }

            _baseDatos.ZonaEntregas.Add(zonaEntrega);
            await _baseDatos.SaveChangesAsync();

            return null;
        }


        public async Task<String> PutZonaEntregaApplicationService(int id, ZonaEntrega zonaEntrega)
        {

            var respuestaDomainService = _zonaEntregaDomainServices.PutZonaEntregaDomainService(id, zonaEntrega);

            bool hayErrorEnElDomainService = respuestaDomainService != null;
            if (hayErrorEnElDomainService)
            {
                return respuestaDomainService;
            }

            _baseDatos.Entry(zonaEntrega).State = EntityState.Modified;
            await _baseDatos.SaveChangesAsync();

            return null;
        }
        public async Task<String> DeleteZonaEntregaApplicationService(int id)
        {
            var zonaEntrega = await _baseDatos.ZonaEntregas.FindAsync(id);
            var respuestaDomainService = _zonaEntregaDomainServices.DeleteZonaEntregaDomainService(id, zonaEntrega);

            bool hayErrorEnElDomainService = respuestaDomainService != null;
            if (hayErrorEnElDomainService)
            {
                return respuestaDomainService;
            }

            _baseDatos.ZonaEntregas.Remove(zonaEntrega);
            await _baseDatos.SaveChangesAsync();

            return null;
        }
    }
    }
