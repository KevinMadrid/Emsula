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
    public class TipoReferenciaController : ControllerBase
    {

        private readonly EmsulaDataContext _baseDatos;
        private readonly TipoReferenciaAppService _tipoReferenciaAppService;

        public TipoReferenciaController(EmsulaDataContext baseDeDatos, TipoReferenciaAppService tipoReferenciaAppService)
        {
            _baseDatos = baseDeDatos;
            _tipoReferenciaAppService = tipoReferenciaAppService;

            if (_baseDatos.TipoReferencias.Count() == 0)
            {
                _baseDatos.TipoReferencias.Add(new TipoReferencia { Tiporeferencia = "Exportacion" });
                _baseDatos.TipoReferencias.Add(new TipoReferencia { Tiporeferencia = "Mixto" });
                _baseDatos.TipoReferencias.Add(new TipoReferencia { Tiporeferencia = "Preferencial" });
         


                _baseDatos.SaveChanges();
            }
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<TipoReferencia>>> GetTipoReferencia()
        {
            return await _baseDatos.TipoReferencias.ToListAsync();
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<TipoReferencia>> GetTipoReferencia(int id)
        {
            var respuestaTipoReferenciaAppService = await _tipoReferenciaAppService.GetTipoReferenciaApplicationService(id);

            bool noHayErroresEnLasValidaciones = respuestaTipoReferenciaAppService == null;
            if (noHayErroresEnLasValidaciones)
            {
                return await _baseDatos.TipoReferencias.FirstOrDefaultAsync(q => q.Id == id);
            }
            return BadRequest(respuestaTipoReferenciaAppService);

        }


        [HttpPost]
        public async Task<ActionResult<TipoReferencia>> PostTipoReferencia(TipoReferencia tipoReferencia)
        {
            var respuestaTipoReferenciaAppService = await _tipoReferenciaAppService.PostTipoReferenciaApplicationService(tipoReferencia);

            bool noHayErroresEnLasValidaciones = respuestaTipoReferenciaAppService == null;
            if (noHayErroresEnLasValidaciones)
            {
                return CreatedAtAction(nameof(GetTipoReferencia), new { id = tipoReferencia.Id }, tipoReferencia);
            }
            return BadRequest(respuestaTipoReferenciaAppService);
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> PutTipoReferencia(int id, TipoReferencia tipoReferencia)
        {
            var respuestaTipoReferenciaAppService = await _tipoReferenciaAppService.PutTipoReferenciaApplicationService(id, tipoReferencia);

            bool noHayErroresEnLasValidaciones = respuestaTipoReferenciaAppService == null;
            if (noHayErroresEnLasValidaciones)
            {
                return NoContent();
            }
            return BadRequest(respuestaTipoReferenciaAppService);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTipoReferencia(int id)
        {
            var respuestaTipoReferenciaAppService = await _tipoReferenciaAppService.DeleteTipoReferenciaApplicationService(id);

            bool noHayErroresEnLasValidaciones = respuestaTipoReferenciaAppService == null;
            if (noHayErroresEnLasValidaciones)
            {
                return Ok("success");
            }
            return BadRequest(respuestaTipoReferenciaAppService);
        }

    }
}
