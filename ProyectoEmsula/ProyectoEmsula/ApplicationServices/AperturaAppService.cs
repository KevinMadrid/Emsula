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
    public class AperturaAppService
    {

        private readonly EmsulaDataContext _baseDatos;
        private readonly AperturaDomainService _aperturaDomainService;

        public AperturaAppService(EmsulaDataContext _context, AperturaDomainService aperturaDomainService)
        {
            _baseDatos = _context;
            _aperturaDomainService = aperturaDomainService;

        }
        public async Task<String> GetGestionApplicationService(int id)
        {
            var apertura = await _baseDatos.Aperturas.Include(q => q.Canal).Include(q => q.CaracteristicaZona).Include(q => q.Ciudad).Include(q => q.Compania)
                                                    .Include(q => q.Departamento).Include(q => q.FormaAtencion).Include(q => q.PuntoPos)
                                                    .Include(q => q.PuntoRejas).Include(q => q.Ramo).Include(q => q.Segmentacion).Include(q => q.Segmento)
                                                    .Include(q => q.Tamano).Include(q => q.Territorio).Include(q => q.TipoCliente).Include(q => q.TipoEmpresa)
                                                    .Include(q => q.TipoReferencia).Include(q => q.TipoZona).Include(q => q.ZonaEntrega).FirstOrDefaultAsync(q => q.Id == id);


            var respuestaDomainService = _aperturaDomainService.GetAperturaDomainService(id, apertura);

            bool hayErrorEnElDomainService = respuestaDomainService != null;
            if (hayErrorEnElDomainService)
            {
                return respuestaDomainService;
            }
            return null;
        }

        public async Task<String> PostAperturaApplicationService(Apertura apertura)
        {
            Ajuste ajuste= await LlamadaALaBaseDeDatos(apertura);

            var respuestaDomainService = _aperturaDomainService.PostAperturaDomainService(ajuste);

            bool hayErrorEnElDomainService = respuestaDomainService != null;
            if (hayErrorEnElDomainService)
            {
                return respuestaDomainService;
            }
            _baseDatos.Aperturas.Add(apertura);
            await _baseDatos.SaveChangesAsync();

            return null;
        }

        private async Task<Ajuste> LlamadaALaBaseDeDatos(Apertura apertura)
        {
            Canal canal= await _baseDatos.Canals.FirstOrDefaultAsync(q => q.Id == apertura.canalid);

            CaracteristicaZona caracteristicaZona= await _baseDatos.CaracteristicaZonas.FirstOrDefaultAsync(q => q.Id == apertura.caracteristicaZonaid);

            Ciudad ciudad= await _baseDatos.Ciudads.FirstOrDefaultAsync(q => q.Id == apertura.ciudadid);

            Compania compania= await _baseDatos.Companias.FirstOrDefaultAsync(q => q.Id == apertura.companiaid);

            Departamento departamento = await _baseDatos.Departamentos.FirstOrDefaultAsync(q => q.Id == apertura.departamentoid);


            FormaAtencion formaAtencion= await _baseDatos.FormaAtencions.FirstOrDefaultAsync(q => q.Id == apertura.formaAtencionid);

            PuntoPos puntoPos= await _baseDatos.PuntoPos.FirstOrDefaultAsync(q => q.Id == apertura.puntoPosid);
           
            PuntoRejas puntoRejas= await _baseDatos.PuntoRejas.FirstOrDefaultAsync(q => q.Id == apertura.puntoRejasid);

            Ramo ramo= await _baseDatos.Ramos.FirstOrDefaultAsync(q => q.Id == apertura.ramoid);

            Segmentacion segmentacion= await _baseDatos.Segmentacions.FirstOrDefaultAsync(q => q.Id == apertura.segmentacionid);

            Segmento segmento= await _baseDatos.Segmentos.FirstOrDefaultAsync(q => q.Id == apertura.segmentoid);

            Tamano tamano= await _baseDatos.Tamanos.FirstOrDefaultAsync(q => q.Id == apertura.tamanoid);

            Territorio territorio= await _baseDatos.Territorios.FirstOrDefaultAsync(q => q.Id == apertura.territorioid);

            TipoCliente tipoCliente= await _baseDatos.TipoClientes.FirstOrDefaultAsync(q => q.Id == apertura.tipoClienteid);

            TipoEmpresa tipoEmpresa= await _baseDatos.TipoEmpresas.FirstOrDefaultAsync(q => q.Id == apertura.tipoEmpresaid);

            TipoReferencia tipoReferencia= await _baseDatos.TipoReferencias.FirstOrDefaultAsync(q => q.Id == apertura.tipoReferenciaid);

            TipoZona tipoZona= await _baseDatos.TipoZonas.FirstOrDefaultAsync(q => q.Id == apertura.tipoZonaid);

            ZonaEntrega zonaEntrega= await _baseDatos.ZonaEntregas.FirstOrDefaultAsync(q => q.Id == apertura.zonaEntregaid);


            var ajuste= new Ajuste(canal, caracteristicaZona, ciudad, compania,
                                   departamento, formaAtencion,
                                   puntoPos, puntoRejas, ramo, segmentacion, segmento,
                                   tamano, territorio, tipoCliente,  tipoEmpresa, tipoReferencia,
                                   tipoZona, zonaEntrega, apertura);
            return ajuste;
        }

        public async Task<String> PutAperturaApplicationService(int id, Apertura apertura)
        {
            Ajuste ajuste= await LlamadaALaBaseDeDatos(apertura);

            var respuestaDomainService = _aperturaDomainService.PutAperturaDomainService(id, ajuste);

            bool hayErrorEnElDomainService = respuestaDomainService != null;
            if (hayErrorEnElDomainService)
            {
                return respuestaDomainService;
            }

            _baseDatos.Entry(apertura).State = EntityState.Modified;
            await _baseDatos.SaveChangesAsync();

            return null;
        }

        public async Task<String> DeleteAperturaApplicationService(int id)
        {
            var apertura = await _baseDatos.Aperturas.FindAsync(id);
            var respuestaDomainService = _aperturaDomainService.DeleteAperturaDomainService(id, apertura);

            bool hayErrorEnElDomainService = respuestaDomainService != null;
            if (hayErrorEnElDomainService)
            {
                return respuestaDomainService;
            }


            _baseDatos.Aperturas.Remove(apertura);
            await _baseDatos.SaveChangesAsync();

            return null;
        }
    }
}
