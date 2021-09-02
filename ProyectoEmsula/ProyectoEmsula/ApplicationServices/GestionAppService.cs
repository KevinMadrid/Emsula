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
    public class GestionAppService
    {

        private readonly EmsulaDataContext _baseDatos;
        private readonly GestionDomainService _gestionDomainService;

        public GestionAppService(EmsulaDataContext _context, GestionDomainService gestionDomainService)
        {
            _baseDatos = _context;
            _gestionDomainService = gestionDomainService;

        }
        public async Task<String> GetGestionApplicationService(int id)
        {
            var gestion = await _baseDatos.Gestions.Include(q => q.Canal).Include(q => q.CaracteristicaZona).Include(q => q.Ciudad).Include(q => q.Compania)
                                                    .Include(q => q.Departamento).Include(q => q.DiaVisita).Include(q => q.FormaAtencion).Include(q => q.PuntoPos)
                                                    .Include(q => q.PuntoRejas).Include(q => q.Ramo).Include(q => q.Segmentacion).Include(q => q.Segmento)
                                                    .Include(q => q.Tamano).Include(q => q.Territorio).Include(q => q.TipoCliente).Include(q => q.TipoEmpresa)
                                                    .Include(q => q.TipoReferencia).Include(q => q.TipoZona).Include(q => q.ZonaEntrega).FirstOrDefaultAsync(q => q.Id == id);


            var respuestaDomainService = _gestionDomainService.GetGestionDomainService(id, gestion);

            bool hayErrorEnElDomainService = respuestaDomainService != null;
            if (hayErrorEnElDomainService)
            {
                return respuestaDomainService;
            }
            return null;
        }

        public async Task<String> PostGestionApplicationService(Gestion gestion)
        {
            Ajuste ajuste= await LlamadaALaBaseDeDatos(gestion);

            var respuestaDomainService = _gestionDomainService.PostGestionDomainService(ajuste);

            bool hayErrorEnElDomainService = respuestaDomainService != null;
            if (hayErrorEnElDomainService)
            {
                return respuestaDomainService;
            }
            _baseDatos.Gestions.Add(gestion);
            await _baseDatos.SaveChangesAsync();

            return null;
        }

        private async Task<Ajuste> LlamadaALaBaseDeDatos(Gestion gestion)
        {
            Canal canal= await _baseDatos.Canals.FirstOrDefaultAsync(q => q.Id == gestion.canalid);

            CaracteristicaZona caracteristicaZona= await _baseDatos.CaracteristicaZonas.FirstOrDefaultAsync(q => q.Id == gestion.caracteristicaZonaid);

            Ciudad ciudad= await _baseDatos.Ciudads.FirstOrDefaultAsync(q => q.Id == gestion.ciudadid);

            Compania compania= await _baseDatos.Companias.FirstOrDefaultAsync(q => q.Id == gestion.companiaid);

            Departamento departamento = await _baseDatos.Departamentos.FirstOrDefaultAsync(q => q.Id == gestion.departamentoid);

            DiaVisita diaVisita= await _baseDatos.DiaVisitas.FirstOrDefaultAsync(q => q.Id == gestion.diaVisitaid);

            FormaAtencion formaAtencion= await _baseDatos.FormaAtencions.FirstOrDefaultAsync(q => q.Id == gestion.formaAtencionid);

            PuntoPos puntoPos= await _baseDatos.PuntoPos.FirstOrDefaultAsync(q => q.Id == gestion.puntoPosid);
           
            PuntoRejas puntoRejas= await _baseDatos.PuntoRejas.FirstOrDefaultAsync(q => q.Id == gestion.puntoRejasid);

            Ramo ramo= await _baseDatos.Ramos.FirstOrDefaultAsync(q => q.Id == gestion.ramoid);

            Segmentacion segmentacion= await _baseDatos.Segmentacions.FirstOrDefaultAsync(q => q.Id == gestion.segmentacionid);

            Segmento segmento= await _baseDatos.Segmentos.FirstOrDefaultAsync(q => q.Id == gestion.segmentoid);

            Tamano tamano= await _baseDatos.Tamanos.FirstOrDefaultAsync(q => q.Id == gestion.tamanoid);

            Territorio territorio= await _baseDatos.Territorios.FirstOrDefaultAsync(q => q.Id == gestion.territorioid);

            TipoCliente tipoCliente= await _baseDatos.TipoClientes.FirstOrDefaultAsync(q => q.Id == gestion.tipoClienteid);

            TipoEmpresa tipoEmpresa= await _baseDatos.TipoEmpresas.FirstOrDefaultAsync(q => q.Id == gestion.tipoEmpresaid);

            TipoReferencia tipoReferencia= await _baseDatos.TipoReferencias.FirstOrDefaultAsync(q => q.Id == gestion.tipoReferenciaid);

            TipoZona tipoZona= await _baseDatos.TipoZonas.FirstOrDefaultAsync(q => q.Id == gestion.tipoZonaid);

            ZonaEntrega zonaEntrega= await _baseDatos.ZonaEntregas.FirstOrDefaultAsync(q => q.Id == gestion.zonaEntregaid);


            var ajuste= new Ajuste(canal, caracteristicaZona, ciudad, compania,
                                   departamento, diaVisita, formaAtencion,
                                   puntoPos, puntoRejas, ramo, segmentacion, segmento,
                                   tamano, territorio, tipoCliente,  tipoEmpresa, tipoReferencia,
                                   tipoZona, zonaEntrega,gestion);
            return ajuste;
        }

        public async Task<String> PutGestionApplicationService(int id, Gestion gestion)
        {
            Ajuste ajuste= await LlamadaALaBaseDeDatos(gestion);

            var respuestaDomainService = _gestionDomainService.PutGestionDomainService(id, ajuste);

            bool hayErrorEnElDomainService = respuestaDomainService != null;
            if (hayErrorEnElDomainService)
            {
                return respuestaDomainService;
            }

            _baseDatos.Entry(gestion).State = EntityState.Modified;
            await _baseDatos.SaveChangesAsync();

            return null;
        }

        public async Task<String> DeleteGestionApplicationService(int id)
        {
            var gestion = await _baseDatos.Gestions.FindAsync(id);
            var respuestaDomainService = _gestionDomainService.DeletetGestionDomainService(id, gestion);

            bool hayErrorEnElDomainService = respuestaDomainService != null;
            if (hayErrorEnElDomainService)
            {
                return respuestaDomainService;
            }


            _baseDatos.Gestions.Remove(gestion);
            await _baseDatos.SaveChangesAsync();

            return null;
        }
    }
}
