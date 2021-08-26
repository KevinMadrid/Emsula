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
    public class TamanoController : ControllerBase
    {

        private readonly EmsulaDataContext _baseDatos;
        private readonly TamanoAppService _tamanoAppService;

        public TamanoController(EmsulaDataContext baseDeDatos, TamanoAppService tamanoAppService)
        {
            _baseDatos = baseDeDatos;
            _tamanoAppService = tamanoAppService;

            if (_baseDatos.Tamanos.Count() == 0)
            {
                _baseDatos.Tamanos.Add(new Tamano { TamanoNegocio = "Muy Grande mas de 100 M" });
                _baseDatos.Tamanos.Add(new Tamano { TamanoNegocio = "Grande 50 M a 100M" });
                _baseDatos.Tamanos.Add(new Tamano { TamanoNegocio = "Mediano 25 M a 50M " });
                _baseDatos.Tamanos.Add(new Tamano { TamanoNegocio = "Pequeño 0 M a 25 M" });
               
               

                _baseDatos.SaveChanges();
            }
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tamano>>> GetTamanos()
        {
            return await _baseDatos.Tamanos.ToListAsync();
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<Tamano>> GetTamano(int id)
        {
            var respuestaTamanoAppService = await _tamanoAppService.GetTamanoApplicationService(id);

            bool noHayErroresEnLasValidaciones = respuestaTamanoAppService == null;
            if (noHayErroresEnLasValidaciones)
            {
                return await _baseDatos.Tamanos.FirstOrDefaultAsync(q => q.Id == id);
            }
            return BadRequest(respuestaTamanoAppService);

        }


        [HttpPost]
        public async Task<ActionResult<Tamano>> PostTamano(Tamano tamano)
        {
            var respuestaTamanoAppService = await _tamanoAppService.PostTamanoApplicationService(tamano);

            bool noHayErroresEnLasValidaciones = respuestaTamanoAppService == null;
            if (noHayErroresEnLasValidaciones)
            {
                return CreatedAtAction(nameof(GetTamano), new { id = tamano.Id }, tamano);
            }
            return BadRequest(respuestaTamanoAppService);
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> PutTamano(int id, Tamano tamano)
        {
            var respuestaTamanoAppService = await _tamanoAppService.PutTamanoApplicationService(id, tamano);

            bool noHayErroresEnLasValidaciones = respuestaTamanoAppService == null;
            if (noHayErroresEnLasValidaciones)
            {
                return NoContent();
            }
            return BadRequest(respuestaTamanoAppService);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTamano(int id)
        {
            var respuestaTamanoAppService = await _tamanoAppService.DeleteTamanoApplicationService(id);

            bool noHayErroresEnLasValidaciones = respuestaTamanoAppService == null;
            if (noHayErroresEnLasValidaciones)
            {
                return Ok("success");
            }
            return BadRequest(respuestaTamanoAppService);
        }

    }
}
