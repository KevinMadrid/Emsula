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
    public class SegmentacionAppService
    {
        private readonly EmsulaDataContext _baseDatos;
        private readonly SegmentacionDomainService _segmentacionDomainServices;

        public SegmentacionAppService(EmsulaDataContext _context, SegmentacionDomainService segmentacionDomainService)
        {
            _baseDatos = _context;
            _segmentacionDomainServices = segmentacionDomainService;
        }

        public async Task<String> GetSegmentacionApplicationService(int id)
        {
            var segmentacion = await _baseDatos.Segmentacions.FirstOrDefaultAsync(q => q.Id == id);


            var respuestaDomainService = _segmentacionDomainServices.GetSegmentacionDomainService(id, segmentacion);

            bool hayErrorEnElDomainService = respuestaDomainService != null;
            if (hayErrorEnElDomainService)
            {
                return respuestaDomainService;
            }
            return null;
        }
        public async Task<String> PostSegmentacionApplicationService(Segmentacion segmentacion)

        {

            var respuestaDomainService = _segmentacionDomainServices.PostSegmentacionDomainService(segmentacion);

            bool hayErrorEnElDomainService = respuestaDomainService != null;
            if (hayErrorEnElDomainService)
            {
                return respuestaDomainService;
            }

            _baseDatos.Segmentacions.Add(segmentacion);
            await _baseDatos.SaveChangesAsync();

            return null;
        }


        public async Task<String> PutSegmentacionApplicationService(int id, Segmentacion segmentacion)
        {

            var respuestaDomainService = _segmentacionDomainServices.PutSegmentacionDomainService(id, segmentacion);

            bool hayErrorEnElDomainService = respuestaDomainService != null;
            if (hayErrorEnElDomainService)
            {
                return respuestaDomainService;
            }

            _baseDatos.Entry(segmentacion).State = EntityState.Modified;
            await _baseDatos.SaveChangesAsync();

            return null;
        }

        public async Task<String> DeleteSegmentacionApplicationService(int id)
        {
            var segmentacion = await _baseDatos.Segmentacions.FindAsync(id);
            var respuestaDomainService = _segmentacionDomainServices.DeleteSegmentacionDomainService(id, segmentacion);

            bool hayErrorEnElDomainService = respuestaDomainService != null;
            if (hayErrorEnElDomainService)
            {
                return respuestaDomainService;
            }

            _baseDatos.Segmentacions.Remove(segmentacion);
            await _baseDatos.SaveChangesAsync();

            return null;
        }
    }
    }
