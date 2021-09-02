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
    public class SegmentacionController : ControllerBase
    {

        private readonly EmsulaDataContext _baseDatos;
        private readonly SegmentacionAppService _segmentacionAppService;

        public SegmentacionController(EmsulaDataContext baseDeDatos, SegmentacionAppService segmentacionAppService)
        {
            _baseDatos = baseDeDatos;
            _segmentacionAppService = segmentacionAppService;

            if (_baseDatos.Segmentacions.Count() == 0)
            {
                _baseDatos.Segmentacions.Add(new Segmentacion { SegmentacionNombre = "Alojamiento" });
                _baseDatos.Segmentacions.Add(new Segmentacion{ SegmentacionNombre = "Bares y Otros Consumo Bebidas Alcoholicas" });
                _baseDatos.Segmentacions.Add(new Segmentacion { SegmentacionNombre = "Bodega" });
                _baseDatos.Segmentacions.Add(new Segmentacion { SegmentacionNombre = "Club de Compradores" });
                _baseDatos.Segmentacions.Add(new Segmentacion { SegmentacionNombre = "Comercializador (Dist)" });
                _baseDatos.Segmentacions.Add(new Segmentacion { SegmentacionNombre = "Comercio (No Abarrotes)" });
                _baseDatos.Segmentacions.Add(new Segmentacion { SegmentacionNombre = "Comida Ambulante" });
                _baseDatos.Segmentacions.Add(new Segmentacion { SegmentacionNombre = "Deportes" });
                _baseDatos.Segmentacions.Add(new Segmentacion { SegmentacionNombre = "Depositos (bebidas)" });
                _baseDatos.Segmentacions.Add(new Segmentacion { SegmentacionNombre = "Educacion Primeria" });
                _baseDatos.Segmentacions.Add(new Segmentacion { SegmentacionNombre = "Educacion Secundaria" });
                _baseDatos.Segmentacions.Add(new Segmentacion { SegmentacionNombre = "Entretenimiento y Recreacion" });
                _baseDatos.Segmentacions.Add(new Segmentacion { SegmentacionNombre = "Exposiciones, Conciertos y Otros Eventos " });
                _baseDatos.Segmentacions.Add(new Segmentacion { SegmentacionNombre = "Farmacias" });
                _baseDatos.Segmentacions.Add(new Segmentacion { SegmentacionNombre = "Feria del Agricultor y Otras Ferias Consumidores" });
                _baseDatos.Segmentacions.Add(new Segmentacion { SegmentacionNombre = "Gubernamental" });
                _baseDatos.Segmentacions.Add(new Segmentacion { SegmentacionNombre = "Hipermarcado" });
                _baseDatos.Segmentacions.Add(new Segmentacion { SegmentacionNombre = "Hogar con Venta" });
                _baseDatos.Segmentacions.Add(new Segmentacion { SegmentacionNombre = "Industria" });
                _baseDatos.Segmentacions.Add(new Segmentacion { SegmentacionNombre = "Minisuper/Minimercado" });
                _baseDatos.Segmentacions.Add(new Segmentacion { SegmentacionNombre = "Otros Abarrotes y Viveres " });
                _baseDatos.Segmentacions.Add(new Segmentacion { SegmentacionNombre = "Otros No Gubernamental" });
                _baseDatos.Segmentacions.Add(new Segmentacion { SegmentacionNombre = "Pulperia" });
                _baseDatos.Segmentacions.Add(new Segmentacion { SegmentacionNombre = "RCR Cadenas" });
                _baseDatos.Segmentacions.Add(new Segmentacion { SegmentacionNombre = "Restautante/Comedor/Cafeteria (No Cadenas)" });
                _baseDatos.Segmentacions.Add(new Segmentacion { SegmentacionNombre = "Salud" });
                _baseDatos.Segmentacions.Add(new Segmentacion { SegmentacionNombre = "Servicios al Detalle" });
                _baseDatos.Segmentacions.Add(new Segmentacion { SegmentacionNombre = "Supermercado" });
                _baseDatos.Segmentacions.Add(new Segmentacion { SegmentacionNombre = "Tiendas de Conveniencia." });
        


                _baseDatos.SaveChanges();
            }
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Segmentacion>>> GetSegmentacions()
        {
            return await _baseDatos.Segmentacions.ToListAsync();
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<Segmentacion>> GetSegmentacion(int id)
        {
            var respuestaSegmentacionAppService = await _segmentacionAppService.GetSegmentacionApplicationService(id);

            bool noHayErroresEnLasValidaciones = respuestaSegmentacionAppService == null;
            if (noHayErroresEnLasValidaciones)
            {
                return await _baseDatos.Segmentacions.FirstOrDefaultAsync(q => q.Id == id);
            }
            return BadRequest(respuestaSegmentacionAppService);

        }


        [HttpPost]
        public async Task<ActionResult<Segmentacion>> PostSegmentacion(Segmentacion segmentacion)
        {
            var respuestaSegmentacionAppService = await _segmentacionAppService.PostSegmentacionApplicationService(segmentacion);

            bool noHayErroresEnLasValidaciones = respuestaSegmentacionAppService == null;
            if (noHayErroresEnLasValidaciones)
            {
                return CreatedAtAction(nameof(GetSegmentacion), new { id = segmentacion.Id }, segmentacion);
            }
            return BadRequest(respuestaSegmentacionAppService);
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> PutSegmentacion(int id, Segmentacion segmentacion)
        {
            var respuestaSegmentacionAppService = await _segmentacionAppService.PutSegmentacionApplicationService(id, segmentacion);

            bool noHayErroresEnLasValidaciones = respuestaSegmentacionAppService == null;
            if (noHayErroresEnLasValidaciones)
            {
                return NoContent();
            }
            return BadRequest(respuestaSegmentacionAppService);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSegmentacion(int id)
        {
            var respuestaSegmentacionAppService = await _segmentacionAppService.DeleteSegmentacionApplicationService(id);

            bool noHayErroresEnLasValidaciones = respuestaSegmentacionAppService == null;
            if (noHayErroresEnLasValidaciones)
            {
                return Ok("success");
            }
            return BadRequest(respuestaSegmentacionAppService);
        }

    }
}
