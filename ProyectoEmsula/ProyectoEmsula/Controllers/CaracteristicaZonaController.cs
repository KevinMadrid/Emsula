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
    public class CaracteristicaZonaController : ControllerBase
    {

        private readonly EmsulaDataContext _baseDatos;
        private readonly CaracteristicaZonaAppService _caracteristicaAppService;

        public CaracteristicaZonaController(EmsulaDataContext baseDeDatos, CaracteristicaZonaAppService caracteristicaZonaAppService)
        {
            _baseDatos = baseDeDatos;
            _caracteristicaAppService = caracteristicaZonaAppService;

            if (_baseDatos.CaracteristicaZonas.Count() == 0)
            {
                _baseDatos.CaracteristicaZonas.Add(new CaracteristicaZona { CaracteristicadeZona = "BarrioSeguro" });
                _baseDatos.CaracteristicaZonas.Add(new CaracteristicaZona { CaracteristicadeZona = "BarrioInseguro" });
                _baseDatos.CaracteristicaZonas.Add(new CaracteristicaZona { CaracteristicadeZona = "DificilAcceso" });
                _baseDatos.CaracteristicaZonas.Add(new CaracteristicaZona { CaracteristicadeZona = "SinCaracteristicas" });
              

                _baseDatos.SaveChanges();
            }
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CaracteristicaZona>>> GetCaracteristicaZonas()
        {
            return await _baseDatos.CaracteristicaZonas.ToListAsync();
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<CaracteristicaZona>> GetCaracteristicaZona(int id)
        {
            var respuestaCaracteristicaZonaAppService = await _caracteristicaAppService.GetCaracteristicaZonaApplicationService(id);

            bool noHayErroresEnLasValidaciones = respuestaCaracteristicaZonaAppService == null;
            if (noHayErroresEnLasValidaciones)
            {
                return await _baseDatos.CaracteristicaZonas.FirstOrDefaultAsync(q => q.Id == id);
            }
            return BadRequest(respuestaCaracteristicaZonaAppService);

        }


        [HttpPost]
        public async Task<ActionResult<CaracteristicaZona>> PostCaracteristicaZona(CaracteristicaZona caracteristicaZona)
        {
            var respuestaCaracteristicaZonaAppService = await _caracteristicaAppService.PostCaracteristicaZonaApplicationService(caracteristicaZona);

            bool noHayErroresEnLasValidaciones = respuestaCaracteristicaZonaAppService == null;
            if (noHayErroresEnLasValidaciones)
            {
                return CreatedAtAction(nameof(GetCaracteristicaZona), new { id = caracteristicaZona.Id }, caracteristicaZona);
            }
            return BadRequest(respuestaCaracteristicaZonaAppService);
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> PutCaracteristicaZona(int id, CaracteristicaZona caracteristicaZona)
        {
            var respuestaCaracteristicaZonaAppService = await _caracteristicaAppService.PutCaracteristicaZonaApplicationService(id, caracteristicaZona);

            bool noHayErroresEnLasValidaciones = respuestaCaracteristicaZonaAppService == null;
            if (noHayErroresEnLasValidaciones)
            {
                return NoContent();
            }
            return BadRequest(respuestaCaracteristicaZonaAppService);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCaracteristicaZonas(int id)
        {
            var respuestaCaracteristicaZonaAppService = await _caracteristicaAppService.DeleteCaracteristicaZonaApplicationService(id);

            bool noHayErroresEnLasValidaciones = respuestaCaracteristicaZonaAppService == null;
            if (noHayErroresEnLasValidaciones)
            {
                return Ok("success");
            }
            return BadRequest(respuestaCaracteristicaZonaAppService);
        }

    }
}
