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
    public class TerritorioController : ControllerBase
    {

        private readonly EmsulaDataContext _baseDatos;
        private readonly TerritorioAppService _territorioAppService;

        public TerritorioController(EmsulaDataContext baseDeDatos, TerritorioAppService territorioAppService)
        {
            _baseDatos = baseDeDatos;
            _territorioAppService = territorioAppService;

            if (_baseDatos.Territorios.Count() == 0)
            {
                _baseDatos.Territorios.Add(new Territorio { CodigoTerritorio = "R Introduccion" });
                _baseDatos.Territorios.Add(new Territorio { CodigoTerritorio= "100 Venta PLT Coagu" });           
                _baseDatos.Territorios.Add(new Territorio { CodigoTerritorio = "101 TRR 101/AVAG" });
                _baseDatos.Territorios.Add(new Territorio { CodigoTerritorio = "102 TRR 102/AVAG" });
                _baseDatos.Territorios.Add(new Territorio { CodigoTerritorio = "6001 TRR 6001/PV" });
                _baseDatos.Territorios.Add(new Territorio { CodigoTerritorio = "6002 TRR 6002/PV" });
                _baseDatos.Territorios.Add(new Territorio { CodigoTerritorio = "6003 TRR 6003/PV" });    
                _baseDatos.Territorios.Add(new Territorio { CodigoTerritorio = "604 TRR 604/AV" });
                _baseDatos.Territorios.Add(new Territorio { CodigoTerritorio = "605 TRR 605/AV" });
                _baseDatos.Territorios.Add(new Territorio { CodigoTerritorio = "606 TRR 606/AV" });
                _baseDatos.Territorios.Add(new Territorio { CodigoTerritorio = "901 TRR 901/CDI" });
                _baseDatos.Territorios.Add(new Territorio { CodigoTerritorio = "902 TRR 902/CDI" });    _baseDatos.Territorios.Add(new Territorio { CodigoTerritorio = "931 TRR 931/CDI T" });
                _baseDatos.Territorios.Add(new Territorio { CodigoTerritorio = "999 Sin Territorio" });
               

                _baseDatos.SaveChanges();
            }
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Territorio>>> GetTerritorios()
        {
            return await _baseDatos.Territorios.ToListAsync();
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<Territorio>> GetTerritorio(int id)
        {
            var respuestaTerritorioAppService = await _territorioAppService.GetTerritorioApplicationService(id);

            bool noHayErroresEnLasValidaciones = respuestaTerritorioAppService == null;
            if (noHayErroresEnLasValidaciones)
            {
                return await _baseDatos.Territorios.FirstOrDefaultAsync(q => q.Id == id);
            }
            return BadRequest(respuestaTerritorioAppService);

        }


        [HttpPost]
        public async Task<ActionResult<Territorio>> PostTamano(Territorio territorio)
        {
            var respuestaTerritorioAppService = await _territorioAppService.PostTerritorioApplicationService(territorio);

            bool noHayErroresEnLasValidaciones = respuestaTerritorioAppService == null;
            if (noHayErroresEnLasValidaciones)
            {
                return CreatedAtAction(nameof(GetTerritorio), new { id = territorio.Id }, territorio);
            }
            return BadRequest(respuestaTerritorioAppService);
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> PutTerritorio(int id, Territorio territorio)
        {
            var respuestaTerritorioAppService = await _territorioAppService.PutTerritorioApplicationService(id, territorio);

            bool noHayErroresEnLasValidaciones = respuestaTerritorioAppService == null;
            if (noHayErroresEnLasValidaciones)
            {
                return NoContent();
            }
            return BadRequest(respuestaTerritorioAppService);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTerritorio(int id)
        {
            var respuestaTerritorioAppService = await _territorioAppService.DeleteTerritorioApplicationService(id);

            bool noHayErroresEnLasValidaciones = respuestaTerritorioAppService == null;
            if (noHayErroresEnLasValidaciones)
            {
                return Ok("success");
            }
            return BadRequest(respuestaTerritorioAppService);
        }

    }
}
