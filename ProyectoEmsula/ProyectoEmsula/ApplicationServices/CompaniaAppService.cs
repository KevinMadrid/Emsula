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
    public class CompaniaAppService
    {
        private readonly EmsulaDataContext _baseDatos;
        private readonly CompaniaDomainService _companiaDomainServices;

        public CompaniaAppService(EmsulaDataContext _context, CompaniaDomainService companiaDomainService)
        {
            _baseDatos = _context;
            _companiaDomainServices = companiaDomainService;
        }

        public async Task<String> GetCompaniaApplicationService(int id)
        {
            var compania = await _baseDatos.Companias.FirstOrDefaultAsync(q => q.Id == id);


            var respuestaDomainService = _companiaDomainServices.GetCompaniaDomainService(id, compania);

            bool hayErrorEnElDomainService = respuestaDomainService != null;
            if (hayErrorEnElDomainService)
            {
                return respuestaDomainService;
            }
            return null;
        }
        public async Task<String> PostCompaniaApplicationService(Compania compania)

        {

            var respuestaDomainService = _companiaDomainServices.PostCompaniaDomainService(compania);

            bool hayErrorEnElDomainService = respuestaDomainService != null;
            if (hayErrorEnElDomainService)
            {
                return respuestaDomainService;
            }

            _baseDatos.Companias.Add(compania);
            await _baseDatos.SaveChangesAsync();

            return null;
        }


        public async Task<String> PutTipoZonaApplicationService(int id, Compania compania)
        {

            var respuestaDomainService = _companiaDomainServices.PutCompaniaDomainService(id, compania);

            bool hayErrorEnElDomainService = respuestaDomainService != null;
            if (hayErrorEnElDomainService)
            {
                return respuestaDomainService;
            }

            _baseDatos.Entry(compania).State = EntityState.Modified;
            await _baseDatos.SaveChangesAsync();

            return null;
        }
        public async Task<String> DeleteCompaniaApplicationService(int id)
        {
            var compania = await _baseDatos.Companias.FindAsync(id);
            var respuestaDomainService = _companiaDomainServices.DeleteCompaniaDomainService(id, compania);

            bool hayErrorEnElDomainService = respuestaDomainService != null;
            if (hayErrorEnElDomainService)
            {
                return respuestaDomainService;
            }

            _baseDatos.Companias.Remove(compania);
            await _baseDatos.SaveChangesAsync();

            return null;
        }
    }
    }
