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
    public class DiaVisitaAppService
    {
        private readonly EmsulaDataContext _baseDatos;
        private readonly DiaVisitaDomainService _diaVisitaDomainServices;

        public DiaVisitaAppService(EmsulaDataContext _context, DiaVisitaDomainService diaVisitaDomainService)
        {
            _baseDatos = _context;
            _diaVisitaDomainServices = diaVisitaDomainService;
        }

        public async Task<String> GetDiaVisitaApplicationService(int id)
        {
            var diaVisita = await _baseDatos.DiaVisitas.FirstOrDefaultAsync(q => q.Id == id);


            var respuestaDomainService = _diaVisitaDomainServices.GetDiaVisitaDomainService(id, diaVisita);

            bool hayErrorEnElDomainService = respuestaDomainService != null;
            if (hayErrorEnElDomainService)
            {
                return respuestaDomainService;
            }
            return null;
        }
        public async Task<String> PostDiaVisitaApplicationService(DiaVisita diaVisita)

        {

            var respuestaDomainService = _diaVisitaDomainServices.PostDiaVisitaDomainService(diaVisita);

            bool hayErrorEnElDomainService = respuestaDomainService != null;
            if (hayErrorEnElDomainService)
            {
                return respuestaDomainService;
            }

            _baseDatos.DiaVisitas.Add(diaVisita);
            await _baseDatos.SaveChangesAsync();

            return null;
        }


        public async Task<String> PutDiaVisitaApplicationService(int id, DiaVisita diaVisita)
        {

            var respuestaDomainService = _diaVisitaDomainServices.PutDiaVisitaDomainService(id, diaVisita);

            bool hayErrorEnElDomainService = respuestaDomainService != null;
            if (hayErrorEnElDomainService)
            {
                return respuestaDomainService;
            }

            _baseDatos.Entry(diaVisita).State = EntityState.Modified;
            await _baseDatos.SaveChangesAsync();

            return null;
        }
        public async Task<String> DeleteDiaVisitaApplicationService(int id)
        {
            var diaVisita = await _baseDatos.DiaVisitas.FindAsync(id);
            var respuestaDomainService = _diaVisitaDomainServices.DeleteDiaVisitaDomainService(id, diaVisita);

            bool hayErrorEnElDomainService = respuestaDomainService != null;
            if (hayErrorEnElDomainService)
            {
                return respuestaDomainService;
            }

            _baseDatos.DiaVisitas.Remove(diaVisita);
            await _baseDatos.SaveChangesAsync();

            return null;
        }
    }
    }
