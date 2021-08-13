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
    public class UbicacionController : ControllerBase
    {

        private readonly EmsulaDataContext _baseDatos;
        private readonly UbicacionAppService _ubicacionAppService;

        public UbicacionController(EmsulaDataContext baseDeDatos, UbicacionAppService ubicacionAppService)
        {
            _baseDatos = baseDeDatos;
            _ubicacionAppService = ubicacionAppService;

            if (_baseDatos.Ubicaciones.Count() == 0)
            {
                _baseDatos.Ubicaciones.Add(new Ubicacion { Departamento = "Cortes", Ciudad= "San Pedro Sula", Zona= "Centro" ,Barrio="Bo. Medina",Calle="10",Avenida="8",Bloque= "", Etapa="", NumeroCasa="",PuntoReferencia="2 cuadras a la par de pulperia juana"});
                _baseDatos.Ubicaciones.Add(new Ubicacion { Departamento = "Cortes", Ciudad ="Tegucigalpa", Zona = "Centro", Barrio = "Res. Altos del Trapiche", Calle = "Principal", Avenida = "", Bloque = "", Etapa = "", NumeroCasa = "", PuntoReferencia = "Arriba de la escuela amador" });
                _baseDatos.SaveChanges();
            }
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Ubicacion>>> GetUbicacions()
        {
            return await _baseDatos.Ubicaciones.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Ubicacion>> GetUbicacion(int id)
        {
            var respuestaUbicacionAppService = await _ubicacionAppService.GetUbicacionApplicationService(id);

            bool noHayErroresEnLasValidaciones = respuestaUbicacionAppService == null;
            if (noHayErroresEnLasValidaciones)
            {
                return await _baseDatos.Ubicaciones.FirstOrDefaultAsync(q => q.Id == id);
            }
            return BadRequest(respuestaUbicacionAppService);

        }

        [HttpPost]
        public async Task<ActionResult<Ubicacion>> PostUbicacion(Ubicacion ubicacion)
        {
            var respuestaUbicacionAppService = await _ubicacionAppService.PostUbicacionApplicationService(ubicacion);

            bool noHayErroresEnLasValidaciones = respuestaUbicacionAppService == null;
            if (noHayErroresEnLasValidaciones)
            {
                return CreatedAtAction(nameof(GetUbicacion), new { id = ubicacion.Id }, ubicacion);
            }
            return BadRequest(respuestaUbicacionAppService);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutUbicacion(int id, Ubicacion ubicacion)
        {
            var respuestaUbicacionAppService = await _ubicacionAppService.PutUbicacionApplicationService(id, ubicacion);

            bool noHayErroresEnLasValidaciones = respuestaUbicacionAppService == null;
            if (noHayErroresEnLasValidaciones)
            {
                return NoContent();
            }
            return BadRequest(respuestaUbicacionAppService);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUbicacion(int id)
        {
            var respuestaUbicacionAppService = await _ubicacionAppService.DeletArticulosApplicationService(id);

            bool noHayErroresEnLasValidaciones = respuestaUbicacionAppService == null;
            if (noHayErroresEnLasValidaciones)
            {
                return Ok("success");
            }
            return BadRequest(respuestaUbicacionAppService);
        }
    }
}
