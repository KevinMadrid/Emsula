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
    public class SegmentoController : ControllerBase
    {

        private readonly EmsulaDataContext _baseDatos;
        private readonly SegmentoAppService _segmentoAppService;

        public SegmentoController(EmsulaDataContext baseDeDatos, SegmentoAppService segmentoAppService)
        {
            _baseDatos = baseDeDatos;
            _segmentoAppService = segmentoAppService;

            if (_baseDatos.Segmentos.Count() == 0)
            {
                _baseDatos.Segmentos.Add(new Segmento { SegmentoNombre = "Comiendo y Bebiendo/Diversion" });
                _baseDatos.Segmentos.Add(new Segmento { SegmentoNombre = "Comiendo y Bebiendo/Otras Comidas y Bebitas" });
                _baseDatos.Segmentos.Add(new Segmento { SegmentoNombre = "Comiendo y Bebiendo/Restaurantes" });
                _baseDatos.Segmentos.Add(new Segmento { SegmentoNombre = "Comiendo y Bebiendo/Restaurantes de Comida RC" });
                _baseDatos.Segmentos.Add(new Segmento { SegmentoNombre = "Comiendo y Bebiendo/Venta de Calle" });
                _baseDatos.Segmentos.Add(new Segmento { SegmentoNombre = "Compra de Abarrotes y Viveres/Hipermercados" });
                _baseDatos.Segmentos.Add(new Segmento { SegmentoNombre = "Compra de Abarrotes y Viveres/Licoreras/Cerv" });
                _baseDatos.Segmentos.Add(new Segmento { SegmentoNombre = "Compra de Abarrotes y Viveres/Supermercados" });
                _baseDatos.Segmentos.Add(new Segmento { SegmentoNombre = "Compra de Abarrotes y Viveres/Tiendas Conven" });
                _baseDatos.Segmentos.Add(new Segmento { SegmentoNombre = "Compra de Abarrotes y Viveres/Tiendas Espec." });
                _baseDatos.Segmentos.Add(new Segmento { SegmentoNombre = "Compra de Abarrotes y Viveres/Tradicionales" });
                _baseDatos.Segmentos.Add(new Segmento { SegmentoNombre = "Compra de Abarrotes y Viveres/Tradicionales" });
                _baseDatos.Segmentos.Add(new Segmento { SegmentoNombre = "Educacion/Pre-Escola y Escolar" });
                _baseDatos.Segmentos.Add(new Segmento { SegmentoNombre = "Educacion/Secundaria/Nivel Medio" });
                _baseDatos.Segmentos.Add(new Segmento { SegmentoNombre = "Educacion/Superior/Universidades" });
                _baseDatos.Segmentos.Add(new Segmento { SegmentoNombre = "En el Trabajo/Agricultura" });
                _baseDatos.Segmentos.Add(new Segmento { SegmentoNombre = "En el Trabajo/Agricultura" });
                _baseDatos.Segmentos.Add(new Segmento { SegmentoNombre = "En el Trabajo/Industria" });
                _baseDatos.Segmentos.Add(new Segmento { SegmentoNombre = "En el Trabajo/Instituciones Publicas/Gobierno" });
                _baseDatos.Segmentos.Add(new Segmento { SegmentoNombre = "En el Trabajo/Militar" });
                _baseDatos.Segmentos.Add(new Segmento { SegmentoNombre = "En el Trabajo/Oficinas Comerciales/Profeciona" });
                _baseDatos.Segmentos.Add(new Segmento { SegmentoNombre = "En el Trabajo/Salud" });
                _baseDatos.Segmentos.Add(new Segmento { SegmentoNombre = "Entretenimiento y Recreacion/Deportes/Centros" });
                _baseDatos.Segmentos.Add(new Segmento { SegmentoNombre = "Entretenimiento y Recreacion/Entretenimiento" });
                _baseDatos.Segmentos.Add(new Segmento { SegmentoNombre = "No Usar" });
                _baseDatos.Segmentos.Add(new Segmento { SegmentoNombre = "Otros Bienes y Servicios/Comercio General" });
                _baseDatos.Segmentos.Add(new Segmento { SegmentoNombre = "Otros Bienes y Servicios/Farmacias" });
                _baseDatos.Segmentos.Add(new Segmento { SegmentoNombre = "Otros Bienes y Servicios/Servicios al Detalle" });
                _baseDatos.Segmentos.Add(new Segmento { SegmentoNombre = "Otros Bienes y Servicios/Servicios Automovili" });
                _baseDatos.Segmentos.Add(new Segmento { SegmentoNombre = "Otros Intermediarios/Comercializadores" });
                _baseDatos.Segmentos.Add(new Segmento { SegmentoNombre = "Otros Intermediarios/Depositos" });
                _baseDatos.Segmentos.Add(new Segmento { SegmentoNombre = "Otros Intermediarios/Operadores de Vending" });
                _baseDatos.Segmentos.Add(new Segmento { SegmentoNombre = "Transporte y Alojamiento/Alojamiento" });
                _baseDatos.Segmentos.Add(new Segmento { SegmentoNombre = "Transporte y Alojamiento/Transporte" });
               

                _baseDatos.SaveChanges();
            }
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Segmento>>> GetSegmentos()
        {
            return await _baseDatos.Segmentos.ToListAsync();
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<Segmento>> GetSegmento(int id)
        {
            var respuestaSegmentoAppService = await _segmentoAppService.GetSegmentoApplicationService(id);

            bool noHayErroresEnLasValidaciones = respuestaSegmentoAppService == null;
            if (noHayErroresEnLasValidaciones)
            {
                return await _baseDatos.Segmentos.FirstOrDefaultAsync(q => q.Id == id);
            }
            return BadRequest(respuestaSegmentoAppService);

        }


        [HttpPost]
        public async Task<ActionResult<Segmento>> PostSegmento(Segmento segmento)
        {
            var respuestaSegmentoAppService = await _segmentoAppService.PostSegmentoApplicationService(segmento);

            bool noHayErroresEnLasValidaciones = respuestaSegmentoAppService == null;
            if (noHayErroresEnLasValidaciones)
            {
                return CreatedAtAction(nameof(GetSegmento), new { id = segmento.Id }, segmento);
            }
            return BadRequest(respuestaSegmentoAppService);
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> PutSegmento(int id, Segmento segmento)
        {
            var respuestaSegmentoAppService = await _segmentoAppService.PutSegmentoApplicationService(id, segmento);

            bool noHayErroresEnLasValidaciones = respuestaSegmentoAppService == null;
            if (noHayErroresEnLasValidaciones)
            {
                return NoContent();
            }
            return BadRequest(respuestaSegmentoAppService);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSegmento(int id)
        {
            var respuestaSegmentoAppService = await _segmentoAppService.DeletSegmentoApplicationService(id);

            bool noHayErroresEnLasValidaciones = respuestaSegmentoAppService == null;
            if (noHayErroresEnLasValidaciones)
            {
                return Ok("success");
            }
            return BadRequest(respuestaSegmentoAppService);
        }

    }
}
