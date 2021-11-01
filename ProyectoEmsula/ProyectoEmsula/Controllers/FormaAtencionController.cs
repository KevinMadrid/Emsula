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
    public class FormaAtencionController : ControllerBase
    {

        private readonly EmsulaDataContext _baseDatos;
        private readonly FormaAtencionAppService _formaAtencionAppService;

        public FormaAtencionController(EmsulaDataContext baseDeDatos, FormaAtencionAppService formaAtencionAppService)
        {
            _baseDatos = baseDeDatos;
            _formaAtencionAppService = formaAtencionAppService;

            if (_baseDatos.FormaAtencions.Count() == 0)
            {
                _baseDatos.FormaAtencions.Add(new FormaAtencion { FormaAtencionCliente= "Autoventa" });
                _baseDatos.FormaAtencions.Add(new FormaAtencion { FormaAtencionCliente = "CDI" });                         _baseDatos.FormaAtencions.Add(new FormaAtencion { FormaAtencionCliente = "Clientes Especiales" });
                _baseDatos.FormaAtencions.Add(new FormaAtencion { FormaAtencionCliente = "Distribuidores" });
                _baseDatos.FormaAtencions.Add(new FormaAtencion { FormaAtencionCliente = "Mercados Especiales" });
                _baseDatos.FormaAtencions.Add(new FormaAtencion { FormaAtencionCliente = "Plantel" });
                _baseDatos.FormaAtencions.Add(new FormaAtencion { FormaAtencionCliente = "Preventa" });
                _baseDatos.FormaAtencions.Add(new FormaAtencion { FormaAtencionCliente = "Preventa 2X" });
                _baseDatos.FormaAtencions.Add(new FormaAtencion { FormaAtencionCliente = "Preventa 3X" });
                _baseDatos.FormaAtencions.Add(new FormaAtencion { FormaAtencionCliente = "SM La Colonia" });
                _baseDatos.FormaAtencions.Add(new FormaAtencion { FormaAtencionCliente = "Super La20" });
                _baseDatos.SaveChanges();
            }
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<FormaAtencion>>> GetFormaAtencions()
        {
            return await _baseDatos.FormaAtencions.ToListAsync();
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<FormaAtencion>> GetFormaAtencion(int id)
        {
            var respuestaFormaAtencionAppService = await _formaAtencionAppService.GetFormaAtencionApplicationService(id);

            bool noHayErroresEnLasValidaciones = respuestaFormaAtencionAppService == null;
            if (noHayErroresEnLasValidaciones)
            {
                return await _baseDatos.FormaAtencions.FirstOrDefaultAsync(q => q.Id == id);
            }
            return BadRequest(respuestaFormaAtencionAppService);

        }


        [HttpPost]
        public async Task<ActionResult<FormaAtencion>> PostFormaAtencion(FormaAtencion formaAtencion)
        {
            var respuestaFormaAtencionAppService = await _formaAtencionAppService.PostFormaAtencionApplicationService(formaAtencion);

            bool noHayErroresEnLasValidaciones = respuestaFormaAtencionAppService == null;
            if (noHayErroresEnLasValidaciones)
            {
                return CreatedAtAction(nameof(GetFormaAtencion), new { id = formaAtencion.Id }, formaAtencion);
            }
            return BadRequest(respuestaFormaAtencionAppService);
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> PutFormaAtencion(int id, FormaAtencion formaAtencion)
        {
            var respuestaFormaAtencionAppService = await _formaAtencionAppService.PutFormaAtencionApplicationService(id, formaAtencion);

            bool noHayErroresEnLasValidaciones = respuestaFormaAtencionAppService == null;
            if (noHayErroresEnLasValidaciones)
            {
                return NoContent();
            }
            return BadRequest(respuestaFormaAtencionAppService);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFormaAtencion(int id)
        {
            var respuestaFormaAtencionAppService = await _formaAtencionAppService.DeleteFormaAtencionApplicationService(id);

            bool noHayErroresEnLasValidaciones = respuestaFormaAtencionAppService == null;
            if (noHayErroresEnLasValidaciones)
            {
                return Ok("success");
            }
            return BadRequest(respuestaFormaAtencionAppService);
        }

    }
}
