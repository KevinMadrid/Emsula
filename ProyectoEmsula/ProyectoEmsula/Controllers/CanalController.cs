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
    public class CanalController : ControllerBase
    {

        private readonly EmsulaDataContext _baseDatos;
        private readonly CanalAppService _canalAppService;

        public CanalController(EmsulaDataContext baseDeDatos, CanalAppService canalAppService)
        {
            _baseDatos = baseDeDatos;
            _canalAppService = canalAppService;

            if (_baseDatos.Canals.Count() == 0)
            {
                _baseDatos.Canals.Add(new Canal { CodigoCanal= "Afiliadas" });
                _baseDatos.Canals.Add(new Canal { CodigoCanal = "Agregadores" });
                _baseDatos.Canals.Add(new Canal { CodigoCanal = "Autoservicio" });
                _baseDatos.Canals.Add(new Canal { CodigoCanal = "Autoventa" });
                _baseDatos.Canals.Add(new Canal { CodigoCanal = "CDI" });
                _baseDatos.Canals.Add(new Canal { CodigoCanal = "Depositos" });
                _baseDatos.Canals.Add(new Canal { CodigoCanal = "Distribuidores" });
                _baseDatos.Canals.Add(new Canal { CodigoCanal = "Fleteros" });
                _baseDatos.Canals.Add(new Canal { CodigoCanal = "Hogares" });
                _baseDatos.Canals.Add(new Canal { CodigoCanal = "Interno" });
                _baseDatos.Canals.Add(new Canal { CodigoCanal = "Mayoristas" });
                _baseDatos.Canals.Add(new Canal { CodigoCanal = "Mercados Especiales" });
                _baseDatos.Canals.Add(new Canal { CodigoCanal = "Obsequios" });
                _baseDatos.Canals.Add(new Canal { CodigoCanal = "PostMix" });
                _baseDatos.Canals.Add(new Canal { CodigoCanal = "Preventa" });
                _baseDatos.Canals.Add(new Canal { CodigoCanal = "Rutas de Agua" });
                _baseDatos.Canals.Add(new Canal { CodigoCanal = "Sin Canal" });
                _baseDatos.Canals.Add(new Canal { CodigoCanal = "Supermercados" });
                _baseDatos.Canals.Add(new Canal { CodigoCanal = "Ventas Plantel" });
                _baseDatos.Canals.Add(new Canal { CodigoCanal = "Wallmart" });

                _baseDatos.SaveChanges();
            }
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Canal>>> GetCanals()
        {
            return await _baseDatos.Canals.ToListAsync();
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<Canal>> GetCanal(int id)
        {
            var respuestaCanalAppService = await _canalAppService.GetCanalApplicationService(id);

            bool noHayErroresEnLasValidaciones = respuestaCanalAppService == null;
            if (noHayErroresEnLasValidaciones)
            {
                return await _baseDatos.Canals.FirstOrDefaultAsync(q => q.Id == id);
            }
            return BadRequest(respuestaCanalAppService);

        }


        [HttpPost]
        public async Task<ActionResult<Canal>> PostCanal(Canal canal)
        {
            var respuestaCanalAppService = await _canalAppService.PostCanalApplicationService(canal);

            bool noHayErroresEnLasValidaciones = respuestaCanalAppService == null;
            if (noHayErroresEnLasValidaciones)
            {
                return CreatedAtAction(nameof(GetCanal), new { id = canal.Id }, canal);
            }
            return BadRequest(respuestaCanalAppService);
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> PutCanal(int id, Canal canal)
        {
            var respuestaCanalAppService = await _canalAppService.PutCanalApplicationService(id, canal);

            bool noHayErroresEnLasValidaciones = respuestaCanalAppService == null;
            if (noHayErroresEnLasValidaciones)
            {
                return NoContent();
            }
            return BadRequest(respuestaCanalAppService);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCanals(int id)
        {
            var respuestaCanalAppService = await _canalAppService.DeleteCanalApplicationService(id);

            bool noHayErroresEnLasValidaciones = respuestaCanalAppService == null;
            if (noHayErroresEnLasValidaciones)
            {
                return Ok("success");
            }
            return BadRequest(respuestaCanalAppService);
        }

    }
}
