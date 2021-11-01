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
    public class ZonaEntregaController : ControllerBase
    {

        private readonly EmsulaDataContext _baseDatos;
        private readonly ZonaEntregaAppService _zonaEntregaAppService;

        public ZonaEntregaController(EmsulaDataContext baseDeDatos, ZonaEntregaAppService zonaEntregaAppService)
        {
            _baseDatos = baseDeDatos;
            _zonaEntregaAppService= zonaEntregaAppService;

            if (_baseDatos.ZonaEntregas.Count() == 0)
            {
                _baseDatos.ZonaEntregas.Add(new ZonaEntrega { ZonadeEntrega = "1 Zona Entrega Autoventa" });
                _baseDatos.ZonaEntregas.Add(new ZonaEntrega { ZonadeEntrega = "2 Zona Entrega CDI" });
                _baseDatos.ZonaEntregas.Add(new ZonaEntrega { ZonadeEntrega = "3 Zona Entrega Distribuidores" });
                _baseDatos.ZonaEntregas.Add(new ZonaEntrega { ZonadeEntrega = "4 Zona Entrega Plantel" });
                _baseDatos.ZonaEntregas.Add(new ZonaEntrega { ZonadeEntrega = "999 Zonas de Entrega Control" });
                _baseDatos.ZonaEntregas.Add(new ZonaEntrega { ZonadeEntrega = "10 Zona PV 6001" });
                _baseDatos.ZonaEntregas.Add(new ZonaEntrega { ZonadeEntrega = "11 Zona PV 6002" });
                _baseDatos.ZonaEntregas.Add(new ZonaEntrega { ZonadeEntrega = "12 Zona PV 6003" });          

                _baseDatos.SaveChanges();
            }
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ZonaEntrega>>> GetZonaEntrega()
        {
            return await _baseDatos.ZonaEntregas.ToListAsync();

        }


        [HttpGet("{id}")]
        public async Task<ActionResult<ZonaEntrega>> GetZonaEntrega(int id)
        {
            var respuestaZonaEntregaAppService = await _zonaEntregaAppService.GetZonaEntregaApplicationService(id);

            bool noHayErroresEnLasValidaciones = respuestaZonaEntregaAppService == null;
            if (noHayErroresEnLasValidaciones)
            {
                return await _baseDatos.ZonaEntregas.FirstOrDefaultAsync(q => q.Id == id);
            }
            return BadRequest(respuestaZonaEntregaAppService);

        }


        [HttpPost]
        public async Task<ActionResult<ZonaEntrega>> PostZonaEntrega(ZonaEntrega zonaEntrega)
        {
            var respuestaZonaEntregaAppService = await _zonaEntregaAppService.PostZonaEntregaApplicationService(zonaEntrega);

            bool noHayErroresEnLasValidaciones = respuestaZonaEntregaAppService == null;
            if (noHayErroresEnLasValidaciones)
            {
                return CreatedAtAction(nameof(GetZonaEntrega), new { id = zonaEntrega.Id }, zonaEntrega);
            }
            return BadRequest(respuestaZonaEntregaAppService);
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> PutZonaEntrega(int id, ZonaEntrega zonaEntrega)
        {
            var respuestaZonaEntregaAppService = await _zonaEntregaAppService.PutZonaEntregaApplicationService(id, zonaEntrega);

            bool noHayErroresEnLasValidaciones = respuestaZonaEntregaAppService == null;
            if (noHayErroresEnLasValidaciones)
            {
                return NoContent();
            }
            return BadRequest(respuestaZonaEntregaAppService);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteZonaEntrega(int id)
        {
            var respuestaZonaEntregaAppService = await _zonaEntregaAppService.DeleteZonaEntregaApplicationService(id);

            bool noHayErroresEnLasValidaciones = respuestaZonaEntregaAppService == null;
            if (noHayErroresEnLasValidaciones)
            {
                return Ok("success");
            }
            return BadRequest(respuestaZonaEntregaAppService);
        }

    }
}
