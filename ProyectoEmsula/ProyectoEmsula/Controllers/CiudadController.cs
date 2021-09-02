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
    public class CiudadController : ControllerBase
    {

        private readonly EmsulaDataContext _baseDatos;
        private readonly CiudadAppService _ciudadAppService;

        public CiudadController(EmsulaDataContext baseDeDatos, CiudadAppService ciudadAppService)
        {
            _baseDatos = baseDeDatos;
            _ciudadAppService = ciudadAppService;

            if (_baseDatos.Ciudads.Count() == 0)
            {
                _baseDatos.Ciudads.Add(new Ciudad { CiudadNombre = "San Pedro Sula" });
                _baseDatos.Ciudads.Add(new Ciudad { CiudadNombre = "Choloma" });
                _baseDatos.Ciudads.Add(new Ciudad { CiudadNombre = "Villanueva" });
                _baseDatos.Ciudads.Add(new Ciudad { CiudadNombre= "Omoa" });
                _baseDatos.Ciudads.Add(new Ciudad { CiudadNombre = "Pimienta" });
                _baseDatos.Ciudads.Add(new Ciudad { CiudadNombre = "Potrerillos" });
                _baseDatos.Ciudads.Add(new Ciudad { CiudadNombre = "Puerto Cortes" });
                _baseDatos.Ciudads.Add(new Ciudad { CiudadNombre = "San Antonio de Cortes" });
                _baseDatos.Ciudads.Add(new Ciudad { CiudadNombre = "San Francisco de Yojoa" });
                _baseDatos.Ciudads.Add(new Ciudad { CiudadNombre = "San Manuel" });
                _baseDatos.Ciudads.Add(new Ciudad { CiudadNombre = "Santa Cruz de Yojoa" });
                _baseDatos.Ciudads.Add(new Ciudad { CiudadNombre = "Villanueva" });
                _baseDatos.Ciudads.Add(new Ciudad { CiudadNombre = "La Lima" });
                _baseDatos.Ciudads.Add(new Ciudad { CiudadNombre = "Cofradia" });
                _baseDatos.Ciudads.Add(new Ciudad { CiudadNombre = "Cuyamel" });


                _baseDatos.SaveChanges();
            }
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Ciudad>>> GetCiudads()
        {
            return await _baseDatos.Ciudads.ToListAsync();
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<Ciudad>> GetCiudad(int id)
        {
            var respuestaCiudadAppService = await _ciudadAppService.GetCiudadApplicationService(id);

            bool noHayErroresEnLasValidaciones = respuestaCiudadAppService == null;
            if (noHayErroresEnLasValidaciones)
            {
                return await _baseDatos.Ciudads.FirstOrDefaultAsync(q => q.Id == id);
            }
            return BadRequest(respuestaCiudadAppService);

        }


        [HttpPost]
        public async Task<ActionResult<Ciudad>> PostCiudad(Ciudad ciudad)
        {
            var respuestaCiudadAppService = await _ciudadAppService.PostCiudadApplicationService(ciudad);

            bool noHayErroresEnLasValidaciones = respuestaCiudadAppService == null;
            if (noHayErroresEnLasValidaciones)
            {
                return CreatedAtAction(nameof(GetCiudad), new { id = ciudad.Id }, ciudad);
            }
            return BadRequest(respuestaCiudadAppService);
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> PutCiudad(int id, Ciudad ciudad)
        {
            var respuestaCiudadAppService = await _ciudadAppService.PutCiudadApplicationService(id, ciudad);

            bool noHayErroresEnLasValidaciones = respuestaCiudadAppService == null;
            if (noHayErroresEnLasValidaciones)
            {
                return NoContent();
            }
            return BadRequest(respuestaCiudadAppService);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCiudad(int id)
        {
            var respuestaCiudadAppService = await _ciudadAppService.DeletCiudadApplicationService(id);

            bool noHayErroresEnLasValidaciones = respuestaCiudadAppService == null;
            if (noHayErroresEnLasValidaciones)
            {
                return Ok("success");
            }
            return BadRequest(respuestaCiudadAppService);
        }
         
    }
}
