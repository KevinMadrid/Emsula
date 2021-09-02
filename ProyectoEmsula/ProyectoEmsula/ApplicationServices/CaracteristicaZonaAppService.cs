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
    public class CaracteristicaZonaAppService
    {
        private readonly EmsulaDataContext _baseDatos;
        private readonly CaracteristicaZonaDomainService _caracteristicaZonaDomainServices;

        public CaracteristicaZonaAppService(EmsulaDataContext _context, CaracteristicaZonaDomainService caracteristicaZonaDomainService)
        {
            _baseDatos = _context;
            _caracteristicaZonaDomainServices = caracteristicaZonaDomainService;
        }

        public async Task<String> GetCaracteristicaZonaApplicationService(int id)
        {
            var caracteristicaZona = await _baseDatos.CaracteristicaZonas.FirstOrDefaultAsync(q => q.Id == id);


            var respuestaDomainService = _caracteristicaZonaDomainServices.GetCaracteristicaZonaDomainService(id, caracteristicaZona);

            bool hayErrorEnElDomainService = respuestaDomainService != null;
            if (hayErrorEnElDomainService)
            {
                return respuestaDomainService;
            }
            return null;
        }
        public async Task<String> PostCaracteristicaZonaApplicationService(CaracteristicaZona caracteristicaZona)

        {

            var respuestaDomainService = _caracteristicaZonaDomainServices.PostCaracteristicaZonaDomainService(caracteristicaZona);

            bool hayErrorEnElDomainService = respuestaDomainService != null;
            if (hayErrorEnElDomainService)
            {
                return respuestaDomainService;
            }

            _baseDatos.CaracteristicaZonas.Add(caracteristicaZona);
            await _baseDatos.SaveChangesAsync();

            return null;
        }


        public async Task<String> PutCaracteristicaZonaApplicationService(int id, CaracteristicaZona caracteristicaZona)
        {

            var respuestaDomainService = _caracteristicaZonaDomainServices.PutCaracteristicaZonaDomainService(id, caracteristicaZona);

            bool hayErrorEnElDomainService = respuestaDomainService != null;
            if (hayErrorEnElDomainService)
            {
                return respuestaDomainService;
            }

            _baseDatos.Entry(caracteristicaZona).State = EntityState.Modified;
            await _baseDatos.SaveChangesAsync();

            return null;
        }
        public async Task<String> DeleteCaracteristicaZonaApplicationService(int id)
        {
            var caracteristicaZona = await _baseDatos.CaracteristicaZonas.FindAsync(id);
            var respuestaDomainService = _caracteristicaZonaDomainServices.DeleteCaracteristicaZonaDomainService(id, caracteristicaZona);

            bool hayErrorEnElDomainService = respuestaDomainService != null;
            if (hayErrorEnElDomainService)
            {
                return respuestaDomainService;
            }

            _baseDatos.CaracteristicaZonas.Remove(caracteristicaZona);
            await _baseDatos.SaveChangesAsync();

            return null;
        }
    }
    }
