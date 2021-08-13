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
    public class NegocioController : ControllerBase
    {

        private readonly EmsulaDataContext _baseDatos;
        private readonly NegocioAppService _negocioAppService;

        public NegocioController(EmsulaDataContext baseDeDatos, NegocioAppService negocioAppService)
        {
            _baseDatos = baseDeDatos;
            _negocioAppService = negocioAppService;

            if (_baseDatos.Negocios.Count() == 0)
            {
                _baseDatos.Negocios.Add(new Negocio { NombreNegocio = "Pulperia Lopez", ReponsableNegocio="Juana Lopez Flores",TelefonoNegocio= 94635789 ,TamanoNegocio="25m a 50m",PuntoRejas="Si",PuntoPos="No",FechaAperturaNegocio = "8/05/1994"});
                _baseDatos.Negocios.Add(new Negocio { NombreNegocio = "Hotel Hyat", ReponsableNegocio = "Maria Faraj", TelefonoNegocio = 94125687, TamanoNegocio = "50m a 75m", PuntoRejas = "No", PuntoPos = "No", FechaAperturaNegocio = "18/05/2014" });
                _baseDatos.SaveChanges();
            }
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Negocio>>> GetNegocios()
        {
            return await _baseDatos.Negocios.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Negocio>> GetNegocio(int id)
        {
            var respuestaNegocioAppService = await _negocioAppService.GetNegocioApplicationService(id);

            bool noHayErroresEnLasValidaciones = respuestaNegocioAppService == null;
            if (noHayErroresEnLasValidaciones)
            {
                return await _baseDatos.Negocios.FirstOrDefaultAsync(q => q.Id == id);
            }
            return BadRequest(respuestaNegocioAppService);

        }

        [HttpPost]
        public async Task<ActionResult<Negocio>> PostNegocio(Negocio negocio)
        {
            var respuestaNegocioAppService = await _negocioAppService.PostNegocioApplicationService(negocio);

            bool noHayErroresEnLasValidaciones = respuestaNegocioAppService == null;
            if (noHayErroresEnLasValidaciones)
            {
                return CreatedAtAction(nameof(GetNegocio), new { id = negocio.Id }, negocio);
            }
            return BadRequest(respuestaNegocioAppService);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutNegocio(int id, Negocio negocio)
        {
            var respuestaNegocioAppService = await _negocioAppService.PutNegocioApplicationService(id, negocio);

            bool noHayErroresEnLasValidaciones = respuestaNegocioAppService == null;
            if (noHayErroresEnLasValidaciones)
            {
                return NoContent();
            }
            return BadRequest(respuestaNegocioAppService);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteNegocio(int id)
        {
            var respuestaNegocioAppService = await _negocioAppService.DeletArticulosApplicationService(id);

            bool noHayErroresEnLasValidaciones = respuestaNegocioAppService == null;
            if (noHayErroresEnLasValidaciones)
            {
                return Ok("success");
            }
            return BadRequest(respuestaNegocioAppService);
        }
    }
}
