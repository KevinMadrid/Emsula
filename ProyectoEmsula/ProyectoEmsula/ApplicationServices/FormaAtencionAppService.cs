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
    public class FormaAtencionAppService
    {
        private readonly EmsulaDataContext _baseDatos;
        private readonly FormaAtencionDomainService _formaAtencionDomainServices;

        public FormaAtencionAppService(EmsulaDataContext _context, FormaAtencionDomainService formaAtencionDomainService)
        {
            _baseDatos = _context;
            _formaAtencionDomainServices = formaAtencionDomainService;
        }

        public async Task<String> GetFormaAtencionApplicationService(int id)
        {
            var formaAtencion = await _baseDatos.FormaAtencions.FirstOrDefaultAsync(q => q.Id == id);


            var respuestaDomainService = _formaAtencionDomainServices.GetFormaAtencionDomainService(id, formaAtencion);

            bool hayErrorEnElDomainService = respuestaDomainService != null;
            if (hayErrorEnElDomainService)
            {
                return respuestaDomainService;
            }
            return null;
        }
        public async Task<String> PostFormaAtencionApplicationService(FormaAtencion formaAtencion)

        {

            var respuestaDomainService = _formaAtencionDomainServices.PostFormaAtencionDomainService(formaAtencion);

            bool hayErrorEnElDomainService = respuestaDomainService != null;
            if (hayErrorEnElDomainService)
            {
                return respuestaDomainService;
            }

            _baseDatos.FormaAtencions.Add(formaAtencion);
            await _baseDatos.SaveChangesAsync();

            return null;
        }


        public async Task<String> PutFormaAtencionApplicationService(int id, FormaAtencion formaAtencion)
        {

            var respuestaDomainService = _formaAtencionDomainServices.PutFormaAtencionDomainService(id, formaAtencion);

            bool hayErrorEnElDomainService = respuestaDomainService != null;
            if (hayErrorEnElDomainService)
            {
                return respuestaDomainService;
            }

            _baseDatos.Entry(formaAtencion).State = EntityState.Modified;
            await _baseDatos.SaveChangesAsync();

            return null;
        }
        public async Task<String> DeleteFormaAtencionApplicationService(int id)
        {
            var formaAtencion = await _baseDatos.FormaAtencions.FindAsync(id);
            var respuestaDomainService = _formaAtencionDomainServices.DeleteFormaAtencionDomainService(id, formaAtencion);

            bool hayErrorEnElDomainService = respuestaDomainService != null;
            if (hayErrorEnElDomainService)
            {
                return respuestaDomainService;
            }

            _baseDatos.FormaAtencions.Remove(formaAtencion);
            await _baseDatos.SaveChangesAsync();

            return null;
        }
    }
    }
