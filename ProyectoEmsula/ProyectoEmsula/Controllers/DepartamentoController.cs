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
    public class DepartamentoController : ControllerBase
    {

        private readonly EmsulaDataContext _baseDatos;
        private readonly DepartamentoAppService _departamentoAppService;

        public DepartamentoController(EmsulaDataContext baseDeDatos, DepartamentoAppService departamentoAppService)
        {
            _baseDatos = baseDeDatos;
            _departamentoAppService = departamentoAppService;

            if (_baseDatos.Departamentos.Count() == 0)
            {
                _baseDatos.Departamentos.Add(new Departamento { DepartamentoNombre = "Cortes" });
                _baseDatos.Departamentos.Add(new Departamento { DepartamentoNombre = "Francisco Morazan" });
                _baseDatos.Departamentos.Add(new Departamento { DepartamentoNombre = "Santa Barbara" });
                _baseDatos.Departamentos.Add(new Departamento { DepartamentoNombre = "Copan" });
                _baseDatos.Departamentos.Add(new Departamento { DepartamentoNombre = "Ocotepeque" });
                _baseDatos.Departamentos.Add(new Departamento { DepartamentoNombre = "Intibuca" });
                _baseDatos.Departamentos.Add(new Departamento { DepartamentoNombre = "La Paz" });
                _baseDatos.Departamentos.Add(new Departamento { DepartamentoNombre = "Yoro" });
                _baseDatos.Departamentos.Add(new Departamento { DepartamentoNombre = "Atlantida" });
                _baseDatos.Departamentos.Add(new Departamento { DepartamentoNombre = "Olancho" });
                _baseDatos.Departamentos.Add(new Departamento { DepartamentoNombre = "Juticalpa" });
                _baseDatos.Departamentos.Add(new Departamento { DepartamentoNombre = "Choluteca" });
                _baseDatos.Departamentos.Add(new Departamento { DepartamentoNombre = "Islas de la Bahia" });
                _baseDatos.Departamentos.Add(new Departamento { DepartamentoNombre = "El Paraiso" });
                _baseDatos.Departamentos.Add(new Departamento { DepartamentoNombre = "Gracias a Dios" });
                _baseDatos.Departamentos.Add(new Departamento { DepartamentoNombre = "Colon" });
                _baseDatos.Departamentos.Add(new Departamento { DepartamentoNombre = "Comayagua" });
                _baseDatos.Departamentos.Add(new Departamento { DepartamentoNombre = "Lempira" });
                _baseDatos.Departamentos.Add(new Departamento { DepartamentoNombre = "Valle" });


                _baseDatos.SaveChanges();
            }
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Departamento>>> GetDepartamentos()
        {
            return await _baseDatos.Departamentos.ToListAsync();
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<Departamento>> GetDepartamento(int id)
        {
            var respuestaDepartamentoAppService = await _departamentoAppService.GetDepartamentoApplicationService(id);

            bool noHayErroresEnLasValidaciones = respuestaDepartamentoAppService == null;
            if (noHayErroresEnLasValidaciones)
            {
                return await _baseDatos.Departamentos.FirstOrDefaultAsync(q => q.Id == id);
            }
            return BadRequest(respuestaDepartamentoAppService);

        }


        [HttpPost]
        public async Task<ActionResult<Departamento>> PostDepartamento(Departamento departamento)
        {
            var respuestaDepartamentoAppService = await _departamentoAppService.PostDepartamentoApplicationService(departamento);

            bool noHayErroresEnLasValidaciones = respuestaDepartamentoAppService == null;
            if (noHayErroresEnLasValidaciones)
            {
                return CreatedAtAction(nameof(GetDepartamento), new { id = departamento.Id }, departamento);
            }
            return BadRequest(respuestaDepartamentoAppService);
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> PutDepartamento(int id, Departamento departamento)
        {
            var respuestaDepartamentoAppService = await _departamentoAppService.PutDepartamentoApplicationService(id, departamento);

            bool noHayErroresEnLasValidaciones = respuestaDepartamentoAppService == null;
            if (noHayErroresEnLasValidaciones)
            {
                return NoContent();
            }
            return BadRequest(respuestaDepartamentoAppService);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDepartamento(int id)
        {
            var respuestaDepartamentoAppService = await _departamentoAppService.DeleteDepartamentoApplicationService(id);

            bool noHayErroresEnLasValidaciones = respuestaDepartamentoAppService == null;
            if (noHayErroresEnLasValidaciones)
            {
                return Ok("success");
            }
            return BadRequest(respuestaDepartamentoAppService);
        }

    }
}
