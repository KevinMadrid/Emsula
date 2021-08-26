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
                _baseDatos.ZonaEntregas.Add(new ZonaEntrega { ZonadeEntrega = "13 Zona PV 6004" });
                _baseDatos.ZonaEntregas.Add(new ZonaEntrega { ZonadeEntrega = "14 Zona PV 6005" });
                _baseDatos.ZonaEntregas.Add(new ZonaEntrega { ZonadeEntrega = "15 Zona PV 6006" });
                _baseDatos.ZonaEntregas.Add(new ZonaEntrega { ZonadeEntrega = "16 Zona PV 6007" });
                _baseDatos.ZonaEntregas.Add(new ZonaEntrega { ZonadeEntrega = "17 Zona PV 6008" });
                _baseDatos.ZonaEntregas.Add(new ZonaEntrega { ZonadeEntrega = "18 Zona PV 6009" });
                _baseDatos.ZonaEntregas.Add(new ZonaEntrega { ZonadeEntrega = "19 Zona PV 6010" });
                _baseDatos.ZonaEntregas.Add(new ZonaEntrega { ZonadeEntrega = "20 Zona PV 6011" });
                _baseDatos.ZonaEntregas.Add(new ZonaEntrega { ZonadeEntrega = "21 Zona PV 6012" });
                _baseDatos.ZonaEntregas.Add(new ZonaEntrega { ZonadeEntrega = "22 Zona PV 6013" });
                _baseDatos.ZonaEntregas.Add(new ZonaEntrega { ZonadeEntrega = "23 Zona PV 6014" });
                _baseDatos.ZonaEntregas.Add(new ZonaEntrega { ZonadeEntrega = "24 Zona PV 6015" });
                _baseDatos.ZonaEntregas.Add(new ZonaEntrega { ZonadeEntrega = "25 Zona PV 6020" });
                _baseDatos.ZonaEntregas.Add(new ZonaEntrega { ZonadeEntrega = "26 Zona PV 6016" });
                _baseDatos.ZonaEntregas.Add(new ZonaEntrega { ZonadeEntrega = "27 Zona PV 6017" });
                _baseDatos.ZonaEntregas.Add(new ZonaEntrega { ZonadeEntrega = "30 Zona PV 6025" });
                _baseDatos.ZonaEntregas.Add(new ZonaEntrega { ZonadeEntrega = "64 Zona PV 6026" });
                _baseDatos.ZonaEntregas.Add(new ZonaEntrega { ZonadeEntrega = "32 Zona PV 6027" });
                _baseDatos.ZonaEntregas.Add(new ZonaEntrega { ZonadeEntrega = "33 Zona PV 6028" });
                _baseDatos.ZonaEntregas.Add(new ZonaEntrega { ZonadeEntrega = "34 Zona 34 Ruta PrivatizadaSYD" });
                _baseDatos.ZonaEntregas.Add(new ZonaEntrega { ZonadeEntrega = "35 Zona PV 6029 ZE35" });
                _baseDatos.ZonaEntregas.Add(new ZonaEntrega { ZonadeEntrega = "36 Zona PV 6029 ZE36" });
                _baseDatos.ZonaEntregas.Add(new ZonaEntrega { ZonadeEntrega = "37 Zona PV 6029 ZE37" });
                _baseDatos.ZonaEntregas.Add(new ZonaEntrega { ZonadeEntrega = "38 Zona PV 6030" });
                _baseDatos.ZonaEntregas.Add(new ZonaEntrega { ZonadeEntrega = "500 Pedidos Especiales Sin Roadnet" });

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
