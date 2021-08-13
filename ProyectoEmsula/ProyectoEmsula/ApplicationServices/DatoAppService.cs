using ProyectoEmsula.DataContext;
using ProyectoEmsula.DomainService;
using ProyectoEmsula.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoEmsula.ApplicationService
{
    public class DatoAppService
    {

        private readonly EmsulaDataContext _baseDatos;
        private readonly DatoDomainService _datoDomainService;

        public DatoAppService(EmsulaDataContext _context, DatoDomainService datoDomainService)
        {
            _baseDatos = _context;
            _datoDomainService = datoDomainService;

        }
        public async Task<String> GetDatoApplicationService(int id)
        {
            var dato = await _baseDatos.Datos.Include(q => q.cliente).Include(q => q.negocio).Include(q => q.ubicacion).Include(q => q.datoEmsula).FirstOrDefaultAsync(q => q.Id == id);


            var respuestaDomainService = _datoDomainService.GetDatoDomainService(id, dato);

            bool hayErrorEnElDomainService = respuestaDomainService != null;
            if (hayErrorEnElDomainService)
            {
                return respuestaDomainService;
            }
            return null;
        }

        public async Task<String> PostDatoApplicationService(Dato dato)
        {
            Ajuste ajuste= await LlamadaALaBaseDeDatos(dato);

            var respuestaDomainService = _datoDomainService.PosttDatoDomainService(ajuste);

            bool hayErrorEnElDomainService = respuestaDomainService != null;
            if (hayErrorEnElDomainService)
            {
                return respuestaDomainService;
            }
            _baseDatos.Datos.Add(dato);
            await _baseDatos.SaveChangesAsync();

            return null;
        }

        private async Task<Ajuste> LlamadaALaBaseDeDatos(Dato dato)
        {
            Cliente cliente= await _baseDatos.Clientes.FirstOrDefaultAsync(q => q.Id == dato.clienteid);

            Negocio negocio= await _baseDatos.Negocios.FirstOrDefaultAsync(q => q.Id == dato.negocioid  );

            Ubicacion ubicacion= await _baseDatos.Ubicaciones.FirstOrDefaultAsync(q => q.Id == dato.ubicacionid);

            DatoEmsula datoEmsula= await _baseDatos.DatoEmsulas.FirstOrDefaultAsync(q => q.Id == dato.datoEmsulaid);

            var ajuste= new Ajuste(negocio, cliente, ubicacion, datoEmsula);
            return ajuste;
        }

        public async Task<String> PutDatoApplicationService(int id, Dato dato)
        {
            Ajuste ajuste= await LlamadaALaBaseDeDatos(dato);

            var respuestaDomainService = _datoDomainService.PuttDatoDomainService(id, ajuste);

            bool hayErrorEnElDomainService = respuestaDomainService != null;
            if (hayErrorEnElDomainService)
            {
                return respuestaDomainService;
            }

            _baseDatos.Entry(dato).State = EntityState.Modified;
            await _baseDatos.SaveChangesAsync();

            return null;
        }

        public async Task<String> DeletDatoApplicationService(int id)
        {
            var dato = await _baseDatos.Datos.FindAsync(id);
            var respuestaDomainService = _datoDomainService.DeletetDatoDomainService(id, dato);

            bool hayErrorEnElDomainService = respuestaDomainService != null;
            if (hayErrorEnElDomainService)
            {
                return respuestaDomainService;
            }


            _baseDatos.Datos.Remove(dato);
            await _baseDatos.SaveChangesAsync();

            return null;
        }
    }
}
