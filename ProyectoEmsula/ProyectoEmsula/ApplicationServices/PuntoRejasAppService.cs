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
    public class PuntoRejasAppService
    {
        private readonly EmsulaDataContext _baseDatos;
        private readonly PuntoRejasDomainService _puntoRejasDomainServices;

        public PuntoRejasAppService(EmsulaDataContext _context, PuntoRejasDomainService puntoRejasDomainService)
        {
            _baseDatos = _context;
            _puntoRejasDomainServices = puntoRejasDomainService;
        }

        public async Task<String> GetPuntoRejasApplicationService(int id)
        {
            var puntoRejas = await _baseDatos.PuntoRejas.FirstOrDefaultAsync(q => q.Id == id);


            var respuestaDomainService = _puntoRejasDomainServices.GetPuntoRejasDomainService(id, puntoRejas);

            bool hayErrorEnElDomainService = respuestaDomainService != null;
            if (hayErrorEnElDomainService)
            {
                return respuestaDomainService;
            }
            return null;
        }
        public async Task<String> PostPuntoRejasApplicationService(PuntoRejas puntoRejas)

        {

            var respuestaDomainService = _puntoRejasDomainServices.PostPuntoRejasDomainService(puntoRejas);

            bool hayErrorEnElDomainService = respuestaDomainService != null;
            if (hayErrorEnElDomainService)
            {
                return respuestaDomainService;
            }

            _baseDatos.PuntoRejas.Add(puntoRejas);
            await _baseDatos.SaveChangesAsync();

            return null;
        }


        public async Task<String> PutPuntoRejasApplicationService(int id, PuntoRejas puntoRejas)
        {

            var respuestaDomainService = _puntoRejasDomainServices.PutPuntoRejasDomainService(id, puntoRejas);

            bool hayErrorEnElDomainService = respuestaDomainService != null;
            if (hayErrorEnElDomainService)
            {
                return respuestaDomainService;
            }

            _baseDatos.Entry(puntoRejas).State = EntityState.Modified;
            await _baseDatos.SaveChangesAsync();

            return null;
        }
        public async Task<String> DeletePuntoRejasApplicationService(int id)
        {
            var puntoRejas = await _baseDatos.PuntoRejas.FindAsync(id);
            var respuestaDomainService = _puntoRejasDomainServices.DeletePuntoRejasDomainService(id, puntoRejas);

            bool hayErrorEnElDomainService = respuestaDomainService != null;
            if (hayErrorEnElDomainService)
            {
                return respuestaDomainService;
            }

            _baseDatos.PuntoRejas.Remove(puntoRejas);
            await _baseDatos.SaveChangesAsync();

            return null;
        }
    }
    }
