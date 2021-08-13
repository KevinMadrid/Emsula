using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProyectoEmsula.ApplicationServices;
using ProyectoEmsula.DataContext;
using ProyectoEmsula.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ProyectoEmsula.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DatoEmsulaController : ControllerBase
    {

        private readonly EmsulaDataContext _baseDatos;
        private readonly DatoEmsulaAppService _datoEmsulaAppService;

        public DatoEmsulaController(EmsulaDataContext baseDeDatos, DatoEmsulaAppService datoEmsulaAppService)
        {
            _baseDatos = baseDeDatos;
            _datoEmsulaAppService = datoEmsulaAppService;

            if (_baseDatos.DatoEmsulas.Count() == 0)
            {
                _baseDatos.DatoEmsulas.Add(new DatoEmsula { Compania = "EMS-CD SPS", Ramo="Pulperia", Segmentacion = "Pulperia", Segmento = "Comiendo y Bebiendo",TipoEmpresa="Persona Natural",Tiporeferencia= "Mixto",TipoZona="Comercial", TipoCliente = "Preventa", FormaAtencion = "Preventa", CodigoCanal ="Preventa",CodigoTerritorio="TRR 607/PV",ZonaEntrega="PV 607",DiasVisita="Lunes,Miercoles,Sabado"});
                _baseDatos.DatoEmsulas.Add(new DatoEmsula { Compania = "EMS-CD TEGUCIGALPA", Ramo = "Pulperia", Segmentacion = "Pulperia", Segmento = "Comiendo y Bebiendo", TipoEmpresa = "Persona Natural", Tiporeferencia = "Preferencial", TipoZona = "Comercial", TipoCliente = "CDI", FormaAtencion = "CDI", CodigoCanal = "CDI", CodigoTerritorio = "TRR 906/CDI", ZonaEntrega = "ZONA DE ENTREGA CD", DiasVisita = "Martes,Jueves" });
                _baseDatos.SaveChanges();
            }
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<DatoEmsula>>> GetDatoEmsulas()
        {
            return await _baseDatos.DatoEmsulas.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<DatoEmsula>> GetDatoEmsula(int id)
        {
            var respuestaDatoEmsulaAppService = await _datoEmsulaAppService.GetDatoEmsulaApplicationService(id);

            bool noHayErroresEnLasValidaciones = respuestaDatoEmsulaAppService == null;
            if (noHayErroresEnLasValidaciones)
            {
                return await _baseDatos.DatoEmsulas.FirstOrDefaultAsync(q => q.Id == id);
            }
            return BadRequest(respuestaDatoEmsulaAppService);

        }

        [HttpPost]
        public async Task<ActionResult<DatoEmsula>> PostDatoEmsula(DatoEmsula datoEmsula)
        {
            var respuestaDatoEmsulaAppService = await _datoEmsulaAppService.PostDatoEmsulaApplicationService(datoEmsula);

            bool noHayErroresEnLasValidaciones = respuestaDatoEmsulaAppService == null;
            if (noHayErroresEnLasValidaciones)
            {
                return CreatedAtAction(nameof(GetDatoEmsula), new { id = datoEmsula.Id }, datoEmsula);
            }
            return BadRequest(respuestaDatoEmsulaAppService);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutDatoEmsula(int id, DatoEmsula datoEmsula)
        {
            var respuestaDatoEmsulaAppService = await _datoEmsulaAppService.PutDatoEmsulaApplicationService(id, datoEmsula);

            bool noHayErroresEnLasValidaciones = respuestaDatoEmsulaAppService == null;
            if (noHayErroresEnLasValidaciones)
            {
                return NoContent();
            }
            return BadRequest(respuestaDatoEmsulaAppService);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDatoEmsula(int id)
        {
            var respuestaDatoEmsulaAppService = await _datoEmsulaAppService.DeletArticulosApplicationService(id);

            bool noHayErroresEnLasValidaciones = respuestaDatoEmsulaAppService == null;
            if (noHayErroresEnLasValidaciones)
            {
                return Ok("success");
            }
            return BadRequest(respuestaDatoEmsulaAppService);
        }
    }
}
