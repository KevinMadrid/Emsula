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
    public class TerritorioAppService
    {
        private readonly EmsulaDataContext _baseDatos;
        private readonly TerritorioDomainService _territorioDomainServices;

        public TerritorioAppService(EmsulaDataContext _context, TerritorioDomainService territorioDomainService)
        {
            _baseDatos = _context;
            _territorioDomainServices = territorioDomainService;
        }

        public async Task<String> GetTerritorioApplicationService(int id)
        {
            var territorio = await _baseDatos.Territorios.FirstOrDefaultAsync(q => q.Id == id);


            var respuestaDomainService = _territorioDomainServices.GetTerritorioDomainService(id, territorio);

            bool hayErrorEnElDomainService = respuestaDomainService != null;
            if (hayErrorEnElDomainService)
            {
                return respuestaDomainService;
            }
            return null;
        }


        public async Task<String> PostTerritorioApplicationService(Territorio territorio)

        {

            var respuestaDomainService = _territorioDomainServices.PostTerritorioDomainService(territorio);

            bool hayErrorEnElDomainService = respuestaDomainService != null;
            if (hayErrorEnElDomainService)
            {
                return respuestaDomainService;
            }

            _baseDatos.Territorios.Add(territorio);
            await _baseDatos.SaveChangesAsync();

            return null;
        }


        public async Task<String> PutTerritorioApplicationService(int id, Territorio territorio)
        {

            var respuestaDomainService = _territorioDomainServices.PutTerritorioDomainService(id, territorio);

            bool hayErrorEnElDomainService = respuestaDomainService != null;
            if (hayErrorEnElDomainService)
            {
                return respuestaDomainService;
            }

            _baseDatos.Entry(territorio).State = EntityState.Modified;
            await _baseDatos.SaveChangesAsync();

            return null;
        }

        public async Task<String> DeleteTerritorioApplicationService(int id)
        {
            var territorio = await _baseDatos.Territorios.FindAsync(id);
            var respuestaDomainService = _territorioDomainServices.DeleteTerritorioDomainService(id, territorio);

            bool hayErrorEnElDomainService = respuestaDomainService != null;
            if (hayErrorEnElDomainService)
            {
                return respuestaDomainService;
            }

            _baseDatos.Territorios.Remove(territorio);
            await _baseDatos.SaveChangesAsync();

            return null;
        }
    }
    }
