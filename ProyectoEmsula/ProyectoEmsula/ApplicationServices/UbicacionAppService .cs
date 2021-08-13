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
    public class UbicacionAppService
    {
        private readonly EmsulaDataContext _baseDatos;
        private readonly UbicacionDomainService _ubicacionDomainServices;

        public UbicacionAppService(EmsulaDataContext _context, UbicacionDomainService ubicacionDomainService)
        {
            _baseDatos = _context;
            _ubicacionDomainServices = ubicacionDomainService;
        }

        public async Task<String> GetUbicacionApplicationService(int id)
        {
            var ubicacion = await _baseDatos.Ubicaciones.FirstOrDefaultAsync(q => q.Id == id);


            var respuestaDomainService = _ubicacionDomainServices.GetUbicacionDomainService(id, ubicacion);

            bool hayErrorEnElDomainService = respuestaDomainService != null;
            if (hayErrorEnElDomainService)
            {
                return respuestaDomainService;
            }
            return null;
        }
        public async Task<String> PostUbicacionApplicationService(Ubicacion ubicacion)

        {

            var respuestaDomainService = _ubicacionDomainServices.PostUbicacionDomainService(ubicacion);

            bool hayErrorEnElDomainService = respuestaDomainService != null;
            if (hayErrorEnElDomainService)
            {
                return respuestaDomainService;
            }

            _baseDatos.Ubicaciones.Add(ubicacion);
            await _baseDatos.SaveChangesAsync();

            return null;
        }


        public async Task<String> PutUbicacionApplicationService(int id, Ubicacion ubicacion)
        {

            var respuestaDomainService = _ubicacionDomainServices.PutUbicacionDomainService(id, ubicacion);

            bool hayErrorEnElDomainService = respuestaDomainService != null;
            if (hayErrorEnElDomainService)
            {
                return respuestaDomainService;
            }

            _baseDatos.Entry(ubicacion).State = EntityState.Modified;
            await _baseDatos.SaveChangesAsync();

            return null;
        }

        public async Task<String> DeletArticulosApplicationService(int id)
        {
            var ubicacion = await _baseDatos.Ubicaciones.FindAsync(id);
            var respuestaDomainService = _ubicacionDomainServices.DeleteUbicacionDomainService(id, ubicacion);

            bool hayErrorEnElDomainService = respuestaDomainService != null;
            if (hayErrorEnElDomainService)
            {
                return respuestaDomainService;
            }

            _baseDatos.Ubicaciones.Remove(ubicacion);
            await _baseDatos.SaveChangesAsync();

            return null;
        }
    }
    }
