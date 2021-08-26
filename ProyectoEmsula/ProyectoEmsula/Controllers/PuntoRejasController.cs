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
    public class PuntoRejasController : ControllerBase
    {

        private readonly EmsulaDataContext _baseDatos;
        private readonly PuntoRejasAppService _puntoRejasAppService;

        public PuntoRejasController(EmsulaDataContext baseDeDatos, PuntoRejasAppService puntoRejasAppService)
        {
            _baseDatos = baseDeDatos;
            _puntoRejasAppService = puntoRejasAppService;

            if (_baseDatos.PuntoRejas.Count() == 0)
            {
                _baseDatos.PuntoRejas.Add(new PuntoRejas { PuntoconRejas = "Si" });
                _baseDatos.PuntoRejas.Add(new PuntoRejas { PuntoconRejas = "No" });
      
                _baseDatos.SaveChanges();
            }
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<PuntoRejas>>> GetPuntoRejass()
        {
            return await _baseDatos.PuntoRejas.ToListAsync();
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<PuntoRejas>> GetPuntoRejas(int id)
        {
            var respuestaPuntoRejasAppService = await _puntoRejasAppService.GetPuntoRejasApplicationService(id);

            bool noHayErroresEnLasValidaciones = respuestaPuntoRejasAppService == null;
            if (noHayErroresEnLasValidaciones)
            {
                return await _baseDatos.PuntoRejas.FirstOrDefaultAsync(q => q.Id == id);
            }
            return BadRequest(respuestaPuntoRejasAppService);

        }


        [HttpPost]
        public async Task<ActionResult<PuntoRejas>> PostPuntoRejas(PuntoRejas puntoRejas)
        {
            var respuestaPuntoRejasAppService = await _puntoRejasAppService.PostPuntoRejasApplicationService(puntoRejas);

            bool noHayErroresEnLasValidaciones = respuestaPuntoRejasAppService == null;
            if (noHayErroresEnLasValidaciones)
            {
                return CreatedAtAction(nameof(GetPuntoRejas), new { id = puntoRejas.Id }, puntoRejas);
            }
            return BadRequest(respuestaPuntoRejasAppService);
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> PutPuntoRejas(int id, PuntoRejas puntoRejas)
        {
            var respuestaPuntoRejasAppService = await _puntoRejasAppService.PutPuntoRejasApplicationService(id, puntoRejas);

            bool noHayErroresEnLasValidaciones = respuestaPuntoRejasAppService == null;
            if (noHayErroresEnLasValidaciones)
            {
                return NoContent();
            }
            return BadRequest(respuestaPuntoRejasAppService);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePuntoRejas(int id)
        {
            var respuestaPuntoRejasAppService = await _puntoRejasAppService.DeletePuntoRejasApplicationService(id);

            bool noHayErroresEnLasValidaciones = respuestaPuntoRejasAppService == null;
            if (noHayErroresEnLasValidaciones)
            {
                return Ok("success");
            }
            return BadRequest(respuestaPuntoRejasAppService);
        }

    }
}
