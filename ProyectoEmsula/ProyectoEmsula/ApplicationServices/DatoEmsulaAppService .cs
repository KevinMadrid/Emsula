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
    public class DatoEmsulaAppService
    {
        private readonly EmsulaDataContext _baseDatos;
        private readonly DatoEmsulaDomainService _datoEmsulaDomainServices;

        public DatoEmsulaAppService(EmsulaDataContext _context, DatoEmsulaDomainService datoEmsulaDomainService)
        {
            _baseDatos = _context;
            _datoEmsulaDomainServices = datoEmsulaDomainService;
        }

        public async Task<String> GetDatoEmsulaApplicationService(int id)
        {
            var datoEmsula = await _baseDatos.DatoEmsulas.FirstOrDefaultAsync(q => q.Id == id);


            var respuestaDomainService = _datoEmsulaDomainServices.GetDatoEmsulaDomainService(id, datoEmsula);

            bool hayErrorEnElDomainService = respuestaDomainService != null;
            if (hayErrorEnElDomainService)
            {
                return respuestaDomainService;
            }
            return null;
        }
        public async Task<String> PostDatoEmsulaApplicationService(DatoEmsula datoEmsula)

        {

            var respuestaDomainService = _datoEmsulaDomainServices.PostDatoEmsulaDomainService(datoEmsula);

            bool hayErrorEnElDomainService = respuestaDomainService != null;
            if (hayErrorEnElDomainService)
            {
                return respuestaDomainService;
            }

            _baseDatos.DatoEmsulas.Add(datoEmsula);
            await _baseDatos.SaveChangesAsync();

            return null;
        }


        public async Task<String> PutDatoEmsulaApplicationService(int id, DatoEmsula datoEmsula)
        {

            var respuestaDomainService = _datoEmsulaDomainServices.PutDatoEmsulaDomainService(id, datoEmsula);

            bool hayErrorEnElDomainService = respuestaDomainService != null;
            if (hayErrorEnElDomainService)
            {
                return respuestaDomainService;
            }

            _baseDatos.Entry(datoEmsula).State = EntityState.Modified;
            await _baseDatos.SaveChangesAsync();

            return null;
        }

        public async Task<String> DeletArticulosApplicationService(int id)
        {
            var datoEmsula = await _baseDatos.DatoEmsulas.FindAsync(id);
            var respuestaDomainService = _datoEmsulaDomainServices.DeleteDatoEmsulaDomainService(id, datoEmsula);

            bool hayErrorEnElDomainService = respuestaDomainService != null;
            if (hayErrorEnElDomainService)
            {
                return respuestaDomainService;
            }

            _baseDatos.DatoEmsulas.Remove(datoEmsula);
            await _baseDatos.SaveChangesAsync();

            return null;
        }
    }
    }
