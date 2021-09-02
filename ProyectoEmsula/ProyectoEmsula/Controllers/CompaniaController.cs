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
    public class CompaniaController : ControllerBase
    {

        private readonly EmsulaDataContext _baseDatos;
        private readonly CompaniaAppService _companiaAppService;

        public CompaniaController(EmsulaDataContext baseDeDatos, CompaniaAppService companiaAppService)
        {
            _baseDatos = baseDeDatos;
            _companiaAppService = companiaAppService;

            if (_baseDatos.Companias.Count() == 0)
            {
                _baseDatos.Companias.Add(new Compania { CompañiaNombre = "EMS-CD SAN PEDRO SULA" });
                _baseDatos.Companias.Add(new Compania { CompañiaNombre = "EMS-CD LA CEIBA" });
                _baseDatos.Companias.Add(new Compania { CompañiaNombre = "EMS-CD PUERTO CORTES" });
                _baseDatos.Companias.Add(new Compania { CompañiaNombre = "EMS-CD EL PROGRESO" });
                _baseDatos.Companias.Add(new Compania { CompañiaNombre = "EMS-CD TELA" });
                _baseDatos.Companias.Add(new Compania { CompañiaNombre = "EMS-CD AGUAZUL SAN PEDRO SULA" });
                _baseDatos.Companias.Add(new Compania { CompañiaNombre = "EMS-CD TEGUCIGALPA" });
                _baseDatos.Companias.Add(new Compania { CompañiaNombre = "EMS-CD TOCOA" });
                _baseDatos.Companias.Add(new Compania { CompañiaNombre = "EMS-CD COMAYAGUA" });
                _baseDatos.Companias.Add(new Compania { CompañiaNombre = "EMS-CD CHOLUTECA" });
                _baseDatos.Companias.Add(new Compania { CompañiaNombre = "EMS-CD JUTICALPA" });
                _baseDatos.Companias.Add(new Compania { CompañiaNombre = "EMS-CD ROATAN" });
                _baseDatos.Companias.Add(new Compania { CompañiaNombre = "EMS-CD SANTA ROSA DE COPAN" });
                _baseDatos.Companias.Add(new Compania { CompañiaNombre = "EMS-CD SANTA BARBARA" });
                _baseDatos.Companias.Add(new Compania { CompañiaNombre = "EMS-CD OLANCHITO" });
                _baseDatos.Companias.Add(new Compania { CompañiaNombre = "EMS-CD LA ENTRADA" });


                _baseDatos.SaveChanges();
            }
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Compania>>> GetCompanias()
        {
            return await _baseDatos.Companias.ToListAsync();
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<Compania>> GetCompania(int id)
        {
            var respuestaCompaniaAppService = await _companiaAppService.GetCompaniaApplicationService(id);

            bool noHayErroresEnLasValidaciones = respuestaCompaniaAppService == null;
            if (noHayErroresEnLasValidaciones)
            {
                return await _baseDatos.Companias.FirstOrDefaultAsync(q => q.Id == id);
            }
            return BadRequest(respuestaCompaniaAppService);

        }


        [HttpPost]
        public async Task<ActionResult<Compania>> PostCompania(Compania compania)
        {
            var respuestaCompaniaAppService = await _companiaAppService.PostCompaniaApplicationService(compania);

            bool noHayErroresEnLasValidaciones = respuestaCompaniaAppService == null;
            if (noHayErroresEnLasValidaciones)
            {
                return CreatedAtAction(nameof(GetCompania), new { id = compania.Id }, compania);
            }
            return BadRequest(respuestaCompaniaAppService);
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> PutCompania(int id, Compania compania)
        {
            var respuestaCompaniaAppService = await _companiaAppService.PutTipoZonaApplicationService(id, compania);

            bool noHayErroresEnLasValidaciones = respuestaCompaniaAppService == null;
            if (noHayErroresEnLasValidaciones)
            {
                return NoContent();
            }
            return BadRequest(respuestaCompaniaAppService);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCompania(int id)
        {
            var respuestaCompaniaAppService = await _companiaAppService.DeleteCompaniaApplicationService(id);

            bool noHayErroresEnLasValidaciones = respuestaCompaniaAppService == null;
            if (noHayErroresEnLasValidaciones)
            {
                return Ok("success");
            }
            return BadRequest(respuestaCompaniaAppService);
        }

    }
}
