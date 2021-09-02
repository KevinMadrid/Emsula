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
    public class GestionController : ControllerBase
    {
        private readonly EmsulaDataContext _baseDatos;
        private readonly GestionAppService _gestionAppService;

        public GestionController(EmsulaDataContext _context, GestionAppService gestionAppService)
        {
            _baseDatos = _context;
            _gestionAppService = gestionAppService;


            if (_baseDatos.Gestions.Count() == 0)
            {
                _baseDatos.Gestions.Add(new Gestion {NumeroIdentidad = 1602199700002,NumeroRTN=16021997000021, NombreLegalCliente="Kevin Jafet Madrid Hernandez",NombreCorto="Kevin Madrid",NombreNegocio="Pulperia Keivn",ReponsableNegocio="Kevin Madrid",
                                                    companiaid=1,departamentoid=1,ciudadid=1,Zona="Centro",Barrio="Col.Planeta" ,caracteristicaZonaid=2,Calle="Principal",Avenida="Principal",
                                                    Bloque="F5",NumeroCasa=11,PuntoReferencia="1 cuadra abajo de ricuras y mas frente a arbol.",TelefonoCasa=25553552,TelefonoCelular=98008557,CorreoElectronico="kjmadrid@unitec.edu",
                                                    ramoid=160,segmentacionid=6,segmentoid=1,tipoEmpresaid=2,tipoReferenciaid=2,tipoZonaid=1,tamanoid=3,puntoRejasid=2,puntoPosid=2,tipoClienteid=24,formaAtencionid=18,
                                                    canalid=16,territorioid=15,zonaEntregaid=1,diaVisitaid=1 });
                _baseDatos.SaveChanges();
            }
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Gestion>>> GetGestions()
        {
            return await _baseDatos.Gestions.Include(q => q.Canal).Include(q => q.CaracteristicaZona).Include(q => q.Ciudad).Include(q => q.Compania)
                                                    .Include(q => q.Departamento).Include(q => q.DiaVisita).Include(q => q.FormaAtencion).Include(q => q.PuntoPos)
                                                    .Include(q => q.PuntoRejas).Include(q => q.Ramo).Include(q => q.Segmentacion).Include(q => q.Segmento)
                                                    .Include(q => q.Tamano).Include(q => q.Territorio).Include(q => q.TipoCliente).Include(q => q.TipoEmpresa)
                                                    .Include(q => q.TipoReferencia).Include(q => q.TipoZona).Include(q => q.ZonaEntrega).ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Gestion>> GetGestion(int id)
        {
            var respuestaGestionAppService = await _gestionAppService.GetGestionApplicationService(id);

            bool noHayErroresEnLasValidaciones = respuestaGestionAppService == null;
            if (noHayErroresEnLasValidaciones)
            {
                return await _baseDatos.Gestions.FirstOrDefaultAsync(q => q.Id == id);
            }
            return BadRequest(respuestaGestionAppService);

        }

        [HttpPost]
        public async Task<ActionResult<Gestion>> PostGestion(Gestion gestion)
        {
            var respuestaGestionAppService = await _gestionAppService.PostGestionApplicationService(gestion);

            bool noHayErroresEnLasValidaciones = respuestaGestionAppService == null;
            if (noHayErroresEnLasValidaciones)
            {
                return CreatedAtAction(nameof(GetGestion), new { id = gestion.Id }, gestion);
            }
            return BadRequest(respuestaGestionAppService);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutGestion(int id, Gestion gestion)
        {
            var respuestaGestionAppService =   await _gestionAppService.PutGestionApplicationService(id,gestion);

            bool noHayErroresEnLasValidaciones = respuestaGestionAppService == null;
            if (noHayErroresEnLasValidaciones)
            {
                return NoContent();
            }
            return BadRequest(respuestaGestionAppService);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGestion(int id)
        {
            var respuestaGestionAppService = await _gestionAppService.DeleteGestionApplicationService(id);

            bool noHayErroresEnLasValidaciones = respuestaGestionAppService == null;
            if (noHayErroresEnLasValidaciones)
            {
                return NoContent();
            }
            return BadRequest(respuestaGestionAppService);
      
        }
    }
}
