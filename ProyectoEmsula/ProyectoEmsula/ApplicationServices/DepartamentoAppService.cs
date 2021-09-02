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
    public class DepartamentoAppService
    {
        private readonly EmsulaDataContext _baseDatos;
        private readonly DepartamentoDomainService _departamentoDomainServices;

        public DepartamentoAppService(EmsulaDataContext _context, DepartamentoDomainService departamentoDomainService)
        {
            _baseDatos = _context;
            _departamentoDomainServices = departamentoDomainService;
        }

        public async Task<String> GetDepartamentoApplicationService(int id)
        {
            var departamento = await _baseDatos.Departamentos.FirstOrDefaultAsync(q => q.Id == id);


            var respuestaDomainService = _departamentoDomainServices.GetDepartamentoDomainService(id, departamento);

            bool hayErrorEnElDomainService = respuestaDomainService != null;
            if (hayErrorEnElDomainService)
            {
                return respuestaDomainService;
            }
            return null;
        }
        public async Task<String> PostDepartamentoApplicationService(Departamento departamento)

        {

            var respuestaDomainService = _departamentoDomainServices.PostDepartamentoDomainService(departamento);

            bool hayErrorEnElDomainService = respuestaDomainService != null;
            if (hayErrorEnElDomainService)
            {
                return respuestaDomainService;
            }

            _baseDatos.Departamentos.Add(departamento);
            await _baseDatos.SaveChangesAsync();

            return null;
        }


        public async Task<String> PutDepartamentoApplicationService(int id, Departamento departamento)
        {

            var respuestaDomainService = _departamentoDomainServices.PutDepartamentoDomainService(id, departamento);

            bool hayErrorEnElDomainService = respuestaDomainService != null;
            if (hayErrorEnElDomainService)
            {
                return respuestaDomainService;
            }

            _baseDatos.Entry(departamento).State = EntityState.Modified;
            await _baseDatos.SaveChangesAsync();

            return null;
        }
        public async Task<String> DeleteDepartamentoApplicationService(int id)
        {
            var departamento = await _baseDatos.Departamentos.FindAsync(id);
            var respuestaDomainService = _departamentoDomainServices.DeleteDepartamentoDomainService(id, departamento);

            bool hayErrorEnElDomainService = respuestaDomainService != null;
            if (hayErrorEnElDomainService)
            {
                return respuestaDomainService;
            }

            _baseDatos.Departamentos.Remove(departamento);
            await _baseDatos.SaveChangesAsync();

            return null;
        }
    }
    }
