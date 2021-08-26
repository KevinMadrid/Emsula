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
    public class TamanoAppService
    {
        private readonly EmsulaDataContext _baseDatos;
        private readonly TamanoDomainService _tamanoDomainServices;

        public TamanoAppService(EmsulaDataContext _context, TamanoDomainService tamanoDomainService)
        {
            _baseDatos = _context;
            _tamanoDomainServices = tamanoDomainService;
        }

        public async Task<String> GetTamanoApplicationService(int id)
        {
            var tamano = await _baseDatos.Tamanos.FirstOrDefaultAsync(q => q.Id == id);


            var respuestaDomainService = _tamanoDomainServices.GetTamanoDomainService(id, tamano);

            bool hayErrorEnElDomainService = respuestaDomainService != null;
            if (hayErrorEnElDomainService)
            {
                return respuestaDomainService;
            }
            return null;
        }

        public async Task<String> PostTamanoApplicationService(Tamano tamano)

        {

            var respuestaDomainService = _tamanoDomainServices.PostTamanoDomainService(tamano);

            bool hayErrorEnElDomainService = respuestaDomainService != null;
            if (hayErrorEnElDomainService)
            {
                return respuestaDomainService;
            }

            _baseDatos.Tamanos.Add(tamano);
            await _baseDatos.SaveChangesAsync();

            return null;
        }


        public async Task<String> PutTamanoApplicationService(int id, Tamano tamano)
        {

            var respuestaDomainService = _tamanoDomainServices.PutTamanoDomainService(id, tamano);

            bool hayErrorEnElDomainService = respuestaDomainService != null;
            if (hayErrorEnElDomainService)
            {
                return respuestaDomainService;
            }

            _baseDatos.Entry(tamano).State = EntityState.Modified;
            await _baseDatos.SaveChangesAsync();

            return null;
        }


        public async Task<String> DeleteTamanoApplicationService(int id)
        {
            var tamano = await _baseDatos.Tamanos.FindAsync(id);
            var respuestaDomainService = _tamanoDomainServices.DeleteTamanoDomainService(id, tamano);

            bool hayErrorEnElDomainService = respuestaDomainService != null;
            if (hayErrorEnElDomainService)
            {
                return respuestaDomainService;
            }

            _baseDatos.Tamanos.Remove(tamano);
            await _baseDatos.SaveChangesAsync();

            return null;
        }
    }
    }
