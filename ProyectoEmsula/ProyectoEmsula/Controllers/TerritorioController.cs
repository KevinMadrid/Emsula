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
                _baseDatos.Territorios.Add(new Territorio { CodigoTerritorio = "R Introduccion" });
                _baseDatos.Territorios.Add(new Territorio { CodigoTerritorio= "100 Venta PLT Coagu" });
                _baseDatos.Territorios.Add(new Territorio { CodigoTerritorio= "10001 Agustin Martine" });
                _baseDatos.Territorios.Add(new Territorio { CodigoTerritorio = "1002 Terecio Roca" });
                _baseDatos.Territorios.Add(new Territorio { CodigoTerritorio = "1003 Edgar Viera" });
                _baseDatos.Territorios.Add(new Territorio { CodigoTerritorio = "1004 Hector Hernandez" });
                _baseDatos.Territorios.Add(new Territorio { CodigoTerritorio = "1005 Juan Bardales" });
                _baseDatos.Territorios.Add(new Territorio { CodigoTerritorio = "1006 Leobardo Aleman" });
                _baseDatos.Territorios.Add(new Territorio { CodigoTerritorio = "1007 Oscar Agurcia" });
                _baseDatos.Territorios.Add(new Territorio { CodigoTerritorio = "101 TRR 101/AVAG" });
                _baseDatos.Territorios.Add(new Territorio { CodigoTerritorio = "1015 INTR DISTR" });
                _baseDatos.Territorios.Add(new Territorio { CodigoTerritorio = "102 TRR 102/AVAG" });
                _baseDatos.Territorios.Add(new Territorio { CodigoTerritorio = "103 TRR 103/AVAG" });
                _baseDatos.Territorios.Add(new Territorio { CodigoTerritorio = "5000 Venta Varios" });
                _baseDatos.Territorios.Add(new Territorio { CodigoTerritorio = "60000 TRR Incobrable" });
                _baseDatos.Territorios.Add(new Territorio { CodigoTerritorio = "6001 TRR 6001/PV" });
                _baseDatos.Territorios.Add(new Territorio { CodigoTerritorio = "6002 TRR 6002/PV" });
                _baseDatos.Territorios.Add(new Territorio { CodigoTerritorio = "6003 TRR 6003/PV" });
                _baseDatos.Territorios.Add(new Territorio { CodigoTerritorio = "6004 TRR 6004/PV" });
                _baseDatos.Territorios.Add(new Territorio { CodigoTerritorio = "6005 TRR 6005/PV" });
                _baseDatos.Territorios.Add(new Territorio { CodigoTerritorio = "6006 TRR 6006/PV" });
                _baseDatos.Territorios.Add(new Territorio { CodigoTerritorio = "6007 TRR 6007/PV" });
                _baseDatos.Territorios.Add(new Territorio { CodigoTerritorio = "6008 TRR 6008/PV" });
                _baseDatos.Territorios.Add(new Territorio { CodigoTerritorio = "6008 TRR 6008/PV" });
                _baseDatos.Territorios.Add(new Territorio { CodigoTerritorio = "601 TRR 601/AV" });
                _baseDatos.Territorios.Add(new Territorio { CodigoTerritorio = "6010 TRR 6010/PV" });
                _baseDatos.Territorios.Add(new Territorio { CodigoTerritorio = "6011 TRR 6011/PV" });
                _baseDatos.Territorios.Add(new Territorio { CodigoTerritorio = "6012 TRR 6012/PV" });
                _baseDatos.Territorios.Add(new Territorio { CodigoTerritorio = "6013 TRR 6013/PV" });
                _baseDatos.Territorios.Add(new Territorio { CodigoTerritorio = "6014 TRR 6014/PV" });
                _baseDatos.Territorios.Add(new Territorio { CodigoTerritorio = "6015 TRR 6015/PV" });
                _baseDatos.Territorios.Add(new Territorio { CodigoTerritorio = "6016 TRR 6016/PV" });
                _baseDatos.Territorios.Add(new Territorio { CodigoTerritorio = "6017 TRR 6017/PV" });
                _baseDatos.Territorios.Add(new Territorio { CodigoTerritorio = "602 TRR 602/AV" });
                _baseDatos.Territorios.Add(new Territorio { CodigoTerritorio = "6020 TRR 6020/PV " });
                _baseDatos.Territorios.Add(new Territorio { CodigoTerritorio = "6025 TRR 6025/PV" });
                _baseDatos.Territorios.Add(new Territorio { CodigoTerritorio = "6026 TRR 6026/PV" });
                _baseDatos.Territorios.Add(new Territorio { CodigoTerritorio = "6027 TRR 6027/PV" });
                _baseDatos.Territorios.Add(new Territorio { CodigoTerritorio = "6028 TRR 6028/PV" });
                _baseDatos.Territorios.Add(new Territorio { CodigoTerritorio = "6029 TRR 6029/PV" });
                _baseDatos.Territorios.Add(new Territorio { CodigoTerritorio = "603 TRR 603/AV" });
                _baseDatos.Territorios.Add(new Territorio { CodigoTerritorio = "6030 TRR 6030/PV" });
                _baseDatos.Territorios.Add(new Territorio { CodigoTerritorio = "604 TRR 604/AV" });
                _baseDatos.Territorios.Add(new Territorio { CodigoTerritorio = "605 TRR 605/AV" });
                _baseDatos.Territorios.Add(new Territorio { CodigoTerritorio = "606 TRR 606/AV" });
                _baseDatos.Territorios.Add(new Territorio { CodigoTerritorio = "607 TRR 607/AV" });
                _baseDatos.Territorios.Add(new Territorio { CodigoTerritorio = "608 TRR 608/AV" });
                _baseDatos.Territorios.Add(new Territorio { CodigoTerritorio = "609 TRR 6609/AV" });
                _baseDatos.Territorios.Add(new Territorio { CodigoTerritorio = "610 TRR 610/AV" });
                _baseDatos.Territorios.Add(new Territorio { CodigoTerritorio = "611 TRR 611/AV " });
                _baseDatos.Territorios.Add(new Territorio { CodigoTerritorio = "612 TRR 612/AV" });
                _baseDatos.Territorios.Add(new Territorio { CodigoTerritorio = "613 TRR 613/AV" });
                _baseDatos.Territorios.Add(new Territorio { CodigoTerritorio = "614 TRR 614/AV" });
                _baseDatos.Territorios.Add(new Territorio { CodigoTerritorio = "615 TRR 615/AV" });
                _baseDatos.Territorios.Add(new Territorio { CodigoTerritorio = "616 TRR 616/AV" });
                _baseDatos.Territorios.Add(new Territorio { CodigoTerritorio = "617 TRR 617AV" });
                _baseDatos.Territorios.Add(new Territorio { CodigoTerritorio = "620 TRR 620/AV" });
                _baseDatos.Territorios.Add(new Territorio { CodigoTerritorio = "625 TRR 625/AV" });
                _baseDatos.Territorios.Add(new Territorio { CodigoTerritorio = "626 TRR 626/AV" });
                _baseDatos.Territorios.Add(new Territorio { CodigoTerritorio = "627 TRR 627/AV" });
                _baseDatos.Territorios.Add(new Territorio { CodigoTerritorio = "628 TRR 628/AV" });
                _baseDatos.Territorios.Add(new Territorio { CodigoTerritorio = "629 TRR 629/AV" });
                _baseDatos.Territorios.Add(new Territorio { CodigoTerritorio = "630 TRR 630/AV  " });
                _baseDatos.Territorios.Add(new Territorio { CodigoTerritorio = "7000 Territorio" });
                _baseDatos.Territorios.Add(new Territorio { CodigoTerritorio = "7001 Emsula/Afiliado" });
                _baseDatos.Territorios.Add(new Territorio { CodigoTerritorio = "7070 TRR Transf" });
                _baseDatos.Territorios.Add(new Territorio { CodigoTerritorio = "900 CDI PLT" });
                _baseDatos.Territorios.Add(new Territorio { CodigoTerritorio = "901 TRR 901/CDI" });
                _baseDatos.Territorios.Add(new Territorio { CodigoTerritorio = "902 TRR 902/CDI" });
                _baseDatos.Territorios.Add(new Territorio { CodigoTerritorio = "903 TRR 603/CDI" });
                _baseDatos.Territorios.Add(new Territorio { CodigoTerritorio = "907 TRR 904/CDI" });
                _baseDatos.Territorios.Add(new Territorio { CodigoTerritorio = "905 TRR 905/CDI" });
                _baseDatos.Territorios.Add(new Territorio { CodigoTerritorio = "906 TRR 906/CDI" });
                _baseDatos.Territorios.Add(new Territorio { CodigoTerritorio = "907 TRR 907/CDI" });
                _baseDatos.Territorios.Add(new Territorio { CodigoTerritorio = "908 TRR 908/CDIAG" });
                _baseDatos.Territorios.Add(new Territorio { CodigoTerritorio = "915 TRR 915/CDI" });
                _baseDatos.Territorios.Add(new Territorio { CodigoTerritorio = "916 TRR 916/CDI" });
                _baseDatos.Territorios.Add(new Territorio { CodigoTerritorio = "917 TRR 917/CDI" });
                _baseDatos.Territorios.Add(new Territorio { CodigoTerritorio = "918 TRR 918/CDI" });
                _baseDatos.Territorios.Add(new Territorio { CodigoTerritorio = "918 TRR 918/CDI" });
                _baseDatos.Territorios.Add(new Territorio { CodigoTerritorio = "930 TRR 930/CD T" });
                _baseDatos.Territorios.Add(new Territorio { CodigoTerritorio = "931 TRR 931/CDI T" });
                _baseDatos.Territorios.Add(new Territorio { CodigoTerritorio = "950 CDI PLT OLANCHITO" });
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
