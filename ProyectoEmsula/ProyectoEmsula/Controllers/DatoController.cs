using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProyectoEmsula.DataContext;
using ProyectoEmsula.Models;
using ProyectoEmsula.ApplicationService;

namespace ProyectoEmsula.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class DatoController:ControllerBase
    {
        private readonly EmsulaDataContext _baseDatos;
        private readonly DatoAppService _datoteAppService;

        public DatoController(EmsulaDataContext _context, DatoAppService datoAppService)
        {
            _baseDatos = _context;
            _datoteAppService = datoAppService;


            if (_baseDatos.Datos.Count() == 0)
            {
                _baseDatos.Datos.Add(new Dato {clienteid=1,negocioid=1,ubicacionid=1,datoEmsulaid=1});
                _baseDatos.SaveChanges();
            }
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Dato>>> GetDatos()
        {
            return await _baseDatos.Datos.Include(q => q.cliente).Include(q => q.negocio).Include(q => q.ubicacion).Include(q => q.datoEmsula).ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Dato>> GetDato(int id)
        {
            var respuestaAutoloteAppService = await _datoteAppService.GetDatoApplicationService(id);

            bool noHayErroresEnLasValidaciones = respuestaAutoloteAppService == null;
            if (noHayErroresEnLasValidaciones)
            {
                return await _baseDatos.Datos.Include(q => q.cliente).Include(q => q.negocio).Include(q => q.ubicacion).Include(q => q.datoEmsula).FirstOrDefaultAsync(q => q.Id == id);
            }
            return BadRequest(respuestaAutoloteAppService);

        }

        [HttpPost]
        public async Task<ActionResult<Dato>> PostDato(Dato dato)
        {
            var respuestaAutoloteAppService = await _datoteAppService.PostDatoApplicationService(dato);

            bool noHayErroresEnLasValidaciones = respuestaAutoloteAppService == null;
            if (noHayErroresEnLasValidaciones)
            {
                return CreatedAtAction(nameof(GetDato), new { id = dato.Id }, dato);
            }
            return BadRequest(respuestaAutoloteAppService);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutDato(int id, Dato dato)
        {
            var respuestaAutoloteAppService =   await _datoteAppService.PutDatoApplicationService(id,dato);

            bool noHayErroresEnLasValidaciones = respuestaAutoloteAppService == null;
            if (noHayErroresEnLasValidaciones)
            {
                return NoContent();
            }
            return BadRequest(respuestaAutoloteAppService);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletDato(int id)
        {
            var respuestaAutoloteAppService = await _datoteAppService.DeletDatoApplicationService(id);

            bool noHayErroresEnLasValidaciones = respuestaAutoloteAppService == null;
            if (noHayErroresEnLasValidaciones)
            {
                return NoContent();
            }
            return BadRequest(respuestaAutoloteAppService);

        }
    }
}
