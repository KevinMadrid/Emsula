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
    public class CiudadAppService
    {
        private readonly EmsulaDataContext _baseDatos;
        private readonly CiudadDomainService _ciudadDomainServices;

        public CiudadAppService(EmsulaDataContext _context, CiudadDomainService ciudadDomainService)
        {
            _baseDatos = _context;
            _ciudadDomainServices = ciudadDomainService;
        }

        public async Task<String> GetCiudadApplicationService(int id)
        {
            var ciudad = await _baseDatos.Ciudads.FirstOrDefaultAsync(q => q.Id == id);


            var respuestaDomainService = _ciudadDomainServices.GetCiudadDomainService(id, ciudad);

            bool hayErrorEnElDomainService = respuestaDomainService != null;
            if (hayErrorEnElDomainService)
            {
                return respuestaDomainService;
            }
            return null;
        }
        public async Task<String> PostCiudadApplicationService(Ciudad ciudad)

        {

            var respuestaDomainService = _ciudadDomainServices.PostCiudadDomainService(ciudad);

            bool hayErrorEnElDomainService = respuestaDomainService != null;
            if (hayErrorEnElDomainService)
            {
                return respuestaDomainService;
            }

            _baseDatos.Ciudads.Add(ciudad);
            await _baseDatos.SaveChangesAsync();

            return null;
        }


        public async Task<String> PutCiudadApplicationService(int id, Ciudad ciudad)
        {

            var respuestaDomainService = _ciudadDomainServices.PutCiudadDomainService(id, ciudad);

            bool hayErrorEnElDomainService = respuestaDomainService != null;
            if (hayErrorEnElDomainService)
            {
                return respuestaDomainService;
            }

            _baseDatos.Entry(ciudad).State = EntityState.Modified;
            await _baseDatos.SaveChangesAsync();

            return null;
        }
        public async Task<String> DeletCiudadApplicationService(int id)
        {
            var ciudad = await _baseDatos.Ciudads.FindAsync(id);
            var respuestaDomainService = _ciudadDomainServices.DeleteCiudadDomainService(id, ciudad);

            bool hayErrorEnElDomainService = respuestaDomainService != null;
            if (hayErrorEnElDomainService)
            {
                return respuestaDomainService;
            }

            _baseDatos.Ciudads.Remove(ciudad);
            await _baseDatos.SaveChangesAsync();

            return null;
        }
    }
    }
