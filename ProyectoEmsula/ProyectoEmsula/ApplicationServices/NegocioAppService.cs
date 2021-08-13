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
    public class NegocioAppService
    {
        private readonly EmsulaDataContext _baseDatos;
        private readonly NegocioDomainService _negocioDomainServices;

        public NegocioAppService(EmsulaDataContext _context, NegocioDomainService negocioDomainService)
        {
            _baseDatos = _context;
            _negocioDomainServices = negocioDomainService;
        }

        public async Task<String> GetNegocioApplicationService(int id)
        {
            var negocio = await _baseDatos.Negocios.FirstOrDefaultAsync(q => q.Id == id);


            var respuestaDomainService = _negocioDomainServices.GetNegocioDomainService(id, negocio);

            bool hayErrorEnElDomainService = respuestaDomainService != null;
            if (hayErrorEnElDomainService)
            {
                return respuestaDomainService;
            }
            return null;
        }
        public async Task<String> PostNegocioApplicationService(Negocio negocio)

        {

            var respuestaDomainService = _negocioDomainServices.PostNegocioDomainService(negocio);

            bool hayErrorEnElDomainService = respuestaDomainService != null;
            if (hayErrorEnElDomainService)
            {
                return respuestaDomainService;
            }

            _baseDatos.Negocios.Add(negocio);
            await _baseDatos.SaveChangesAsync();

            return null;
        }


        public async Task<String> PutNegocioApplicationService(int id, Negocio negocio)
        {

            var respuestaDomainService = _negocioDomainServices.PutNegocioDomainService(id, negocio);

            bool hayErrorEnElDomainService = respuestaDomainService != null;
            if (hayErrorEnElDomainService)
            {
                return respuestaDomainService;
            }

            _baseDatos.Entry(negocio).State = EntityState.Modified;
            await _baseDatos.SaveChangesAsync();

            return null;
        }

        public async Task<String> DeletArticulosApplicationService(int id)
        {
            var negocio = await _baseDatos.Negocios.FindAsync(id);
            var respuestaDomainService = _negocioDomainServices.DeleteNegocioDomainService(id, negocio);

            bool hayErrorEnElDomainService = respuestaDomainService != null;
            if (hayErrorEnElDomainService)
            {
                return respuestaDomainService;
            }

            _baseDatos.Negocios.Remove(negocio);
            await _baseDatos.SaveChangesAsync();

            return null;
        }
    }
    }
