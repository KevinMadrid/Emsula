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
    public class DiaVisitaController : ControllerBase
    {

        private readonly EmsulaDataContext _baseDatos;
        private readonly DiaVisitaAppService _diaVisitaAppService;

        public DiaVisitaController(EmsulaDataContext baseDeDatos, DiaVisitaAppService diaVisitaAppService)
        {
            _baseDatos = baseDeDatos;
            _diaVisitaAppService = diaVisitaAppService;

            if (_baseDatos.DiaVisitas.Count() == 0)
            {
                _baseDatos.DiaVisitas.Add(new DiaVisita { DiasVisita = "Lunes" ,OrdenVisita = 24});
                _baseDatos.DiaVisitas.Add(new DiaVisita { DiasVisita= "Martes" ,OrdenVisita = 12});
                _baseDatos.DiaVisitas.Add(new DiaVisita { DiasVisita= "Miercoles" ,OrdenVisita=78});
                _baseDatos.DiaVisitas.Add(new DiaVisita { DiasVisita= "Jueves" ,OrdenVisita=124});
                _baseDatos.DiaVisitas.Add(new DiaVisita { DiasVisita= "Viernes",OrdenVisita=10 });
                _baseDatos.DiaVisitas.Add(new DiaVisita { DiasVisita= "Sabado" ,OrdenVisita=160});
            


                _baseDatos.SaveChanges();
            }
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<DiaVisita>>> GetDiaVisitas()
        {
            return await _baseDatos.DiaVisitas.ToListAsync();
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<DiaVisita>> GetDepartamento(int id)
        {
            var respuestaDiaVisitaAppService = await _diaVisitaAppService.GetDiaVisitaApplicationService(id);

            bool noHayErroresEnLasValidaciones = respuestaDiaVisitaAppService == null;
            if (noHayErroresEnLasValidaciones)
            {
                return await _baseDatos.DiaVisitas.FirstOrDefaultAsync(q => q.Id == id);
            }
            return BadRequest(respuestaDiaVisitaAppService);

        }


        [HttpPost]
        public async Task<ActionResult<DiaVisita>> PostDiaVisita(DiaVisita diaVisita)
        {
            var respuestaDiaVisitaAppService = await _diaVisitaAppService.PostDiaVisitaApplicationService(diaVisita);

            bool noHayErroresEnLasValidaciones = respuestaDiaVisitaAppService == null;
            if (noHayErroresEnLasValidaciones)
            {
                return CreatedAtAction(nameof(GetDepartamento), new { id = diaVisita.Id }, diaVisita);
            }
            return BadRequest(respuestaDiaVisitaAppService);
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> PutDiaVisita(int id, DiaVisita diaVisita)
        {
            var respuestaDiaVisitaAppService = await _diaVisitaAppService.PutDiaVisitaApplicationService(id, diaVisita);

            bool noHayErroresEnLasValidaciones = respuestaDiaVisitaAppService == null;
            if (noHayErroresEnLasValidaciones)
            {
                return NoContent();
            }
            return BadRequest(respuestaDiaVisitaAppService);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDiaVisita(int id)
        {
            var respuestaDiaVisitaAppService = await _diaVisitaAppService.DeleteDiaVisitaApplicationService(id);

            bool noHayErroresEnLasValidaciones = respuestaDiaVisitaAppService == null;
            if (noHayErroresEnLasValidaciones)
            {
                return Ok("success");
            }
            return BadRequest(respuestaDiaVisitaAppService);
        }

    }
}
