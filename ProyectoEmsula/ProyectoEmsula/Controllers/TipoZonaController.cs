using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProyectoEmsula.ApplicationServices;
using ProyectoEmsula.DataContext;
using ProyectoEmsula.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProyectoEmsula.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoZonaController : ControllerBase
    {

        private readonly EmsulaDataContext _baseDatos;
        private readonly TipoZonaAppService _tipoZonaAppService;

        public TipoZonaController(EmsulaDataContext baseDeDatos, TipoZonaAppService tipoZonaAppService)
        {
            _baseDatos = baseDeDatos;
            _tipoZonaAppService = tipoZonaAppService;

            if (_baseDatos.TipoZonas.Count() == 0)
            {
                _baseDatos.TipoZonas.Add(new TipoZona { TipoZonaNombre = "Centrico" });
                _baseDatos.TipoZonas.Add(new TipoZona { TipoZonaNombre = "Comercial" });
                _baseDatos.TipoZonas.Add(new TipoZona { TipoZonaNombre = "Industrial" });
                _baseDatos.TipoZonas.Add(new TipoZona { TipoZonaNombre = "Residencial" });
                _baseDatos.TipoZonas.Add(new TipoZona { TipoZonaNombre = "RuralMontaña" });

                _baseDatos.SaveChanges();
            }
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<TipoZona>>> GetTipoZona()
        {
            return await _baseDatos.TipoZonas.ToListAsync();

        }


        [HttpGet("{id}")]
        public async Task<ActionResult<TipoZona>> GetTipoZona(int id)
        {
            var respuestaTipoZonaAppService = await _tipoZonaAppService.GetTipoZonaApplicationService(id);

            bool noHayErroresEnLasValidaciones = respuestaTipoZonaAppService == null;
            if (noHayErroresEnLasValidaciones)
            {
                return await _baseDatos.TipoZonas.FirstOrDefaultAsync(q => q.Id == id);
            }
            return BadRequest(respuestaTipoZonaAppService);

        }


        [HttpPost]
        public async Task<ActionResult<TipoZona>> PostTipoZona(TipoZona tipoZona)
        {
            var respuestaTipoZonaAppService = await _tipoZonaAppService.PostTipoZonaApplicationService(tipoZona);

            bool noHayErroresEnLasValidaciones = respuestaTipoZonaAppService == null;
            if (noHayErroresEnLasValidaciones)
            {
                return CreatedAtAction(nameof(GetTipoZona), new { id = tipoZona.Id }, tipoZona);
            }
            return BadRequest(respuestaTipoZonaAppService);
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> PutTipoZona(int id, TipoZona tipoZona)
        {
            var respuestaTipoZonaAppService = await _tipoZonaAppService.PutTipoZonaApplicationService(id, tipoZona);

            bool noHayErroresEnLasValidaciones = respuestaTipoZonaAppService == null;
            if (noHayErroresEnLasValidaciones)
            {
                return NoContent();
            }
            return BadRequest(respuestaTipoZonaAppService);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTipoZona(int id)
        {
            var respuestaTipoZonaAppService = await _tipoZonaAppService.DeletTipoZonaApplicationService(id);

            bool noHayErroresEnLasValidaciones = respuestaTipoZonaAppService == null;
            if (noHayErroresEnLasValidaciones)
            {
                return Ok("success");
            }
            return BadRequest(respuestaTipoZonaAppService);
        }

    }
}
