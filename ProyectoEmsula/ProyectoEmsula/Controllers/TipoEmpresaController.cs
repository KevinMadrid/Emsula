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
    public class TipoEmpresaController : ControllerBase
    {

        private readonly EmsulaDataContext _baseDatos;
        private readonly TipoEmpresaAppService _tipoEmpresaAppService;

        public TipoEmpresaController(EmsulaDataContext baseDeDatos, TipoEmpresaAppService tipoEmpresaAppService)
        {
            _baseDatos = baseDeDatos;
            _tipoEmpresaAppService = tipoEmpresaAppService;

            if (_baseDatos.TipoEmpresas.Count() == 0)
            {
                _baseDatos.TipoEmpresas.Add(new TipoEmpresa { TipoEmpresaLegal = "Estatal" });
                _baseDatos.TipoEmpresas.Add(new TipoEmpresa { TipoEmpresaLegal = "Persona Natural" });
                _baseDatos.TipoEmpresas.Add(new TipoEmpresa { TipoEmpresaLegal = "Privada" });
         


                _baseDatos.SaveChanges();
            }
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<TipoEmpresa>>> GetTipoEmpresa()
        {
            return await _baseDatos.TipoEmpresas.ToListAsync();
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<TipoEmpresa>> GetTipoEmpresa(int id)
        {
            var respuestaTipoEmpresaAppService = await _tipoEmpresaAppService.GetTipoEmpresaApplicationService(id);

            bool noHayErroresEnLasValidaciones = respuestaTipoEmpresaAppService == null;
            if (noHayErroresEnLasValidaciones)
            {
                return await _baseDatos.TipoEmpresas.FirstOrDefaultAsync(q => q.Id == id);
            }
            return BadRequest(respuestaTipoEmpresaAppService);

        }


        [HttpPost]
        public async Task<ActionResult<TipoEmpresa>> PostTipoEmpresa(TipoEmpresa tipoEmpresa)
        {
            var respuestaTipoEmpresaAppService = await _tipoEmpresaAppService.PostTipoEmpresaApplicationService(tipoEmpresa);

            bool noHayErroresEnLasValidaciones = respuestaTipoEmpresaAppService == null;
            if (noHayErroresEnLasValidaciones)
            {
                return CreatedAtAction(nameof(GetTipoEmpresa), new { id = tipoEmpresa.Id }, tipoEmpresa);
            }
            return BadRequest(respuestaTipoEmpresaAppService);
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> PutTipoEmpresa(int id, TipoEmpresa tipoEmpresa)
        {
            var respuestaTipoEmpresaAppService = await _tipoEmpresaAppService.PutClienteApplicationService(id, tipoEmpresa);

            bool noHayErroresEnLasValidaciones = respuestaTipoEmpresaAppService == null;
            if (noHayErroresEnLasValidaciones)
            {
                return NoContent();
            }
            return BadRequest(respuestaTipoEmpresaAppService);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTipoEmpresa(int id)
        {
            var respuestaTipoEmpresaAppService = await _tipoEmpresaAppService.DeleteTipoEmpresaApplicationService(id);

            bool noHayErroresEnLasValidaciones = respuestaTipoEmpresaAppService == null;
            if (noHayErroresEnLasValidaciones)
            {
                return Ok("success");
            }
            return BadRequest(respuestaTipoEmpresaAppService);
        }

    }
}
