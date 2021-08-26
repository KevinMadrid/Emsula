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
    public class SegmentoAppService
    {
        private readonly EmsulaDataContext _baseDatos;
        private readonly SegmentoDomainService _segmentoDomainServices;

        public SegmentoAppService(EmsulaDataContext _context, SegmentoDomainService segmentoDomainService)
        {
            _baseDatos = _context;
            _segmentoDomainServices = segmentoDomainService;
        }


        public async Task<String> GetSegmentoApplicationService(int id)
        {
            var segmento = await _baseDatos.Segmentos.FirstOrDefaultAsync(q => q.Id == id);


            var respuestaDomainService = _segmentoDomainServices.GetSegmentoDomainService(id, segmento);

            bool hayErrorEnElDomainService = respuestaDomainService != null;
            if (hayErrorEnElDomainService)
            {
                return respuestaDomainService;
            }
            return null;
        }


        public async Task<String> PostSegmentoApplicationService(Segmento segmento)

        {

            var respuestaDomainService = _segmentoDomainServices.PostSegmentoDomainService(segmento);

            bool hayErrorEnElDomainService = respuestaDomainService != null;
            if (hayErrorEnElDomainService)
            {
                return respuestaDomainService;
            }

            _baseDatos.Segmentos.Add(segmento);
            await _baseDatos.SaveChangesAsync();

            return null;
        }


        public async Task<String> PutSegmentoApplicationService(int id, Segmento segmento)
        {

            var respuestaDomainService = _segmentoDomainServices.PutSegmentoDomainService(id, segmento);

            bool hayErrorEnElDomainService = respuestaDomainService != null;
            if (hayErrorEnElDomainService)
            {
                return respuestaDomainService;
            }

            _baseDatos.Entry(segmento).State = EntityState.Modified;
            await _baseDatos.SaveChangesAsync();

            return null;
        }


        public async Task<String> DeletSegmentoApplicationService(int id)
        {
            var segmento = await _baseDatos.Segmentos.FindAsync(id);
            var respuestaDomainService = _segmentoDomainServices.DeleteSegmentoDomainService(id, segmento);

            bool hayErrorEnElDomainService = respuestaDomainService != null;
            if (hayErrorEnElDomainService)
            {
                return respuestaDomainService;
            }

            _baseDatos.Segmentos.Remove(segmento);
            await _baseDatos.SaveChangesAsync();

            return null;
        }
    }
    }
