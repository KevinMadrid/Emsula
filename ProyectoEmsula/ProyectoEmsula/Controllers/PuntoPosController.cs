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
    public class PuntoPosController : ControllerBase
    {

        private readonly EmsulaDataContext _baseDatos;
        private readonly PuntoPosAppService _puntoPosAppService;

        public PuntoPosController(EmsulaDataContext baseDeDatos, PuntoPosAppService puntoPosAppService)
        {
            _baseDatos = baseDeDatos;
            _puntoPosAppService = puntoPosAppService;

            if (_baseDatos.PuntoPos.Count() == 0)
            {
                _baseDatos.PuntoPos.Add(new PuntoPos { PuntoconPos = "Si" });
                _baseDatos.PuntoPos.Add(new PuntoPos { PuntoconPos= "No" });
      
                _baseDatos.SaveChanges();
            }
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<PuntoPos>>> GetPuntoPoss()
        {
            return await _baseDatos.PuntoPos.ToListAsync();
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<PuntoPos>> GetPuntoPos(int id)
        {
            var respuestaPuntoPosAppService = await _puntoPosAppService.GetPuntoPosApplicationService(id);

            bool noHayErroresEnLasValidaciones = respuestaPuntoPosAppService == null;
            if (noHayErroresEnLasValidaciones)
            {
                return await _baseDatos.PuntoPos.FirstOrDefaultAsync(q => q.Id == id);
            }
            return BadRequest(respuestaPuntoPosAppService);

        }


        [HttpPost]
        public async Task<ActionResult<PuntoPos>> PostPuntoPos(PuntoPos puntoPos)
        {
            var respuestaPuntoPosAppService = await _puntoPosAppService.PostPuntoPosApplicationService(puntoPos);

            bool noHayErroresEnLasValidaciones = respuestaPuntoPosAppService == null;
            if (noHayErroresEnLasValidaciones)
            {
                return CreatedAtAction(nameof(GetPuntoPos), new { id = puntoPos.Id }, puntoPos);
            }
            return BadRequest(respuestaPuntoPosAppService);
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> PutPuntoPos(int id, PuntoPos puntoPos)
        {
            var respuestaPuntoPosAppService = await _puntoPosAppService.PutPuntoPosApplicationService(id, puntoPos);

            bool noHayErroresEnLasValidaciones = respuestaPuntoPosAppService == null;
            if (noHayErroresEnLasValidaciones)
            {
                return NoContent();
            }
            return BadRequest(respuestaPuntoPosAppService);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePuntoPos(int id)
        {
            var respuestaPuntoPosAppService = await _puntoPosAppService.DeletePuntoPosApplicationService(id);

            bool noHayErroresEnLasValidaciones = respuestaPuntoPosAppService == null;
            if (noHayErroresEnLasValidaciones)
            {
                return Ok("success");
            }
            return BadRequest(respuestaPuntoPosAppService);
        }

    }
}
