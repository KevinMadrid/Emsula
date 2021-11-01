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
    public class AperturaController : ControllerBase
    {
        private readonly EmsulaDataContext _baseDatos;
        private readonly AperturaAppService _aperturaAppService;

        public AperturaController(EmsulaDataContext _context, AperturaAppService aperturaAppService)
        {
            _baseDatos = _context;
            _aperturaAppService = aperturaAppService;


            if (_baseDatos.Aperturas.Count() == 0)
            {
                _baseDatos.Aperturas.Add(new Apertura {
                    NumeroIdentidad = 1602199700002,
                    NumeroRTN = 16021997000021,
                    NombreLegalCliente = "Kevin Jafet Madrid Hernandez",
                    NombreCorto = "Kevin Madrid",
                    NombreNegocio = "Pulperia Keivn",
                    ReponsableNegocio = "Kevin Madrid",
                    companiaid = 1,
                    departamentoid = 1,
                    ciudadid = 1,
                    Zona = "Centro",
                    Barrio = "Col.Planeta",
                    caracteristicaZonaid = 2,
                    Calle = "Principal",
                    Avenida = "Principal",
                    Bloque = "F5",
                    NumeroCasa = "11",
                    PuntoReferencia = "1 cuadra abajo de ricuras y mas frente a arbol.",
                    TelefonoCasa = "25553552",
                    TelefonoCelular = 98008557,
                    CorreoElectronico = "kjmadrid@unitec.edu",
                    ramoid = 1,
                    segmentacionid = 6,
                    segmentoid = 1,
                    tipoEmpresaid = 2,
                    tipoReferenciaid = 2,
                    tipoZonaid = 1,
                    tamanoid = 3,
                    puntoRejasid = 2,
                    puntoPosid = 2,
                    tipoClienteid = 2,
                    formaAtencionid = 1,
                    canalid = 1,
                    territorioid = 1,
                    zonaEntregaid = 1,
                });
                _baseDatos.SaveChanges();
            }
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Apertura>>> GetGestions()
        {
            return await _baseDatos.Aperturas.Include(q => q.Canal).Include(q => q.CaracteristicaZona).Include(q => q.Ciudad).Include(q => q.Compania)
                                                    .Include(q => q.Departamento).Include(q => q.FormaAtencion).Include(q => q.PuntoPos)
                                                    .Include(q => q.PuntoRejas).Include(q => q.Ramo).Include(q => q.Segmentacion).Include(q => q.Segmento)
                                                    .Include(q => q.Tamano).Include(q => q.Territorio).Include(q => q.TipoCliente).Include(q => q.TipoEmpresa)
                                                    .Include(q => q.TipoReferencia).Include(q => q.TipoZona).Include(q => q.ZonaEntrega).ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Apertura>> GetGestion(int id)
        {
            var respuestaAperturaAppService = await _aperturaAppService.GetGestionApplicationService(id);

            bool noHayErroresEnLasValidaciones = respuestaAperturaAppService == null;
            if (noHayErroresEnLasValidaciones)
            {
                return await _baseDatos.Aperturas.FirstOrDefaultAsync(q => q.Id == id);
            }
            return BadRequest(respuestaAperturaAppService);

        }

        [HttpPost]
        public async Task<ActionResult<Apertura>> PostGestion(Apertura apertura)
        {
            var respuestaAperturaAppService = await _aperturaAppService.PostAperturaApplicationService(apertura);

            bool noHayErroresEnLasValidaciones = respuestaAperturaAppService == null;
            if (noHayErroresEnLasValidaciones)
            {
                return CreatedAtAction(nameof(GetGestion), new { id = apertura.Id }, apertura);
            }
            return BadRequest(respuestaAperturaAppService);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutGestion(int id, Apertura apertura)
        {
            var respuestaAperturaAppService =   await _aperturaAppService.PutAperturaApplicationService(id,apertura);

            bool noHayErroresEnLasValidaciones = respuestaAperturaAppService == null;
            if (noHayErroresEnLasValidaciones)
            {
                return NoContent();
            }
            return BadRequest(respuestaAperturaAppService);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGestion(int id)
        {
            var respuestaAperturaAppService = await _aperturaAppService.DeleteAperturaApplicationService(id);

            bool noHayErroresEnLasValidaciones = respuestaAperturaAppService == null;
            if (noHayErroresEnLasValidaciones)
            {
                return NoContent();
            }
            return BadRequest(respuestaAperturaAppService);
      
        }
    }
}
