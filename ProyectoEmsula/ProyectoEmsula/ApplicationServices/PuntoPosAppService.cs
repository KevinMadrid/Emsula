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
    public class PuntoPosAppService
    {
        private readonly EmsulaDataContext _baseDatos;
        private readonly PuntoPosDomainService _puntoPosDomainServices;

        public PuntoPosAppService(EmsulaDataContext _context, PuntoPosDomainService puntoPosDomainService)
        {
            _baseDatos = _context;
            _puntoPosDomainServices = puntoPosDomainService;
        }

        public async Task<String> GetPuntoPosApplicationService(int id)
        {
            var puntoPos = await _baseDatos.PuntoPos.FirstOrDefaultAsync(q => q.Id == id);


            var respuestaDomainService = _puntoPosDomainServices.GetPuntoPosDomainService(id, puntoPos);

            bool hayErrorEnElDomainService = respuestaDomainService != null;
            if (hayErrorEnElDomainService)
            {
                return respuestaDomainService;
            }
            return null;
        }

        public async Task<String> PostPuntoPosApplicationService(PuntoPos puntoPos)

        {

            var respuestaDomainService = _puntoPosDomainServices.PostPuntoPosDomainService(puntoPos);

            bool hayErrorEnElDomainService = respuestaDomainService != null;
            if (hayErrorEnElDomainService)
            {
                return respuestaDomainService;
            }

            _baseDatos.PuntoPos.Add(puntoPos);
            await _baseDatos.SaveChangesAsync();
            return null;
        }


        public async Task<String> PutPuntoPosApplicationService(int id, PuntoPos puntoPos)
        {

            var respuestaDomainService = _puntoPosDomainServices.PutPuntoPosDomainService(id, puntoPos);

            bool hayErrorEnElDomainService = respuestaDomainService != null;
            if (hayErrorEnElDomainService)
            {
                return respuestaDomainService;
            }

            _baseDatos.Entry(puntoPos).State = EntityState.Modified;
            await _baseDatos.SaveChangesAsync();
            return null;
        }

        public async Task<String> DeletePuntoPosApplicationService(int id)
        {
            var puntoPos = await _baseDatos.PuntoPos.FindAsync(id);
            var respuestaDomainService = _puntoPosDomainServices.DeletePuntoPosDomainService(id, puntoPos);

            bool hayErrorEnElDomainService = respuestaDomainService != null;
            if (hayErrorEnElDomainService)
            {
                return respuestaDomainService;
            }

            _baseDatos.PuntoPos.Remove(puntoPos);
            await _baseDatos.SaveChangesAsync();

            return null;
        }
    }
    }
