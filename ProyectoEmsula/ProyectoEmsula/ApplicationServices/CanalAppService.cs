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
    public class CanalAppService
    {
        private readonly EmsulaDataContext _baseDatos;
        private readonly CanalDomainService _canalDomainServices;

        public CanalAppService(EmsulaDataContext _context, CanalDomainService canalDomainService)
        {
            _baseDatos = _context;
            _canalDomainServices = canalDomainService;
        }

        public async Task<String> GetCanalApplicationService(int id)
        {
            var canal = await _baseDatos.Canals.FirstOrDefaultAsync(q => q.Id == id);


            var respuestaDomainService = _canalDomainServices.GetCanalDomainService(id, canal);

            bool hayErrorEnElDomainService = respuestaDomainService != null;
            if (hayErrorEnElDomainService)
            {
                return respuestaDomainService;
            }
            return null;
        }
        public async Task<String> PostCanalApplicationService(Canal canal)

        {

            var respuestaDomainService = _canalDomainServices.PostCanalDomainService(canal);

            bool hayErrorEnElDomainService = respuestaDomainService != null;
            if (hayErrorEnElDomainService)
            {
                return respuestaDomainService;
            }

            _baseDatos.Canals.Add(canal);
            await _baseDatos.SaveChangesAsync();

            return null;
        }


        public async Task<String> PutCanalApplicationService(int id, Canal canal)
        {

            var respuestaDomainService = _canalDomainServices.PutCanalDomainService(id, canal);

            bool hayErrorEnElDomainService = respuestaDomainService != null;
            if (hayErrorEnElDomainService)
            {
                return respuestaDomainService;
            }

            _baseDatos.Entry(canal).State = EntityState.Modified;
            await _baseDatos.SaveChangesAsync();

            return null;
        }
        public async Task<String> DeleteCanalApplicationService(int id)
        {
            var canal = await _baseDatos.Canals.FindAsync(id);
            var respuestaDomainService = _canalDomainServices.DeleteCanalDomainService(id, canal);

            bool hayErrorEnElDomainService = respuestaDomainService != null;
            if (hayErrorEnElDomainService)
            {
                return respuestaDomainService;
            }

            _baseDatos.Canals.Remove(canal);
            await _baseDatos.SaveChangesAsync();

            return null;
        }
    }
    }
