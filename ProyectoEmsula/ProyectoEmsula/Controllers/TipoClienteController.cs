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
    public class TipoClienteController : ControllerBase
    {

        private readonly EmsulaDataContext _baseDatos;
        private readonly TipoClienteAppService _tipoClienteAppService;

        public TipoClienteController(EmsulaDataContext baseDeDatos, TipoClienteAppService tipoClienteAppService)
        {
            _baseDatos = baseDeDatos;
            _tipoClienteAppService = tipoClienteAppService;

            if (_baseDatos.TipoClientes.Count() == 0)
            {
                _baseDatos.TipoClientes.Add(new TipoCliente { TipoClienteContable= "Aguazul Danli" });
                _baseDatos.TipoClientes.Add(new TipoCliente { TipoClienteContable = "Aguazul SPS" });
                _baseDatos.TipoClientes.Add(new TipoCliente { TipoClienteContable = "Aguazul Choluteca" });
                _baseDatos.TipoClientes.Add(new TipoCliente { TipoClienteContable = "Aguazul Comayaguai" });
                _baseDatos.TipoClientes.Add(new TipoCliente { TipoClienteContable = "Aguazul Juticalpa" });
                _baseDatos.TipoClientes.Add(new TipoCliente { TipoClienteContable = "Aguazul Tegucigalpa" });
                _baseDatos.TipoClientes.Add(new TipoCliente { TipoClienteContable = "Autoventa" });
                _baseDatos.TipoClientes.Add(new TipoCliente { TipoClienteContable = "CDI EMS/DIB" });
                _baseDatos.TipoClientes.Add(new TipoCliente { TipoClienteContable = "CDI" });
                _baseDatos.TipoClientes.Add(new TipoCliente { TipoClienteContable = "Cliente Export" });
                _baseDatos.TipoClientes.Add(new TipoCliente { TipoClienteContable = "Coaguan " });
                _baseDatos.TipoClientes.Add(new TipoCliente { TipoClienteContable = "Comtela" });
                _baseDatos.TipoClientes.Add(new TipoCliente { TipoClienteContable = "Coresa" });
                _baseDatos.TipoClientes.Add(new TipoCliente { TipoClienteContable = "Datlan" });
                _baseDatos.TipoClientes.Add(new TipoCliente { TipoClienteContable = "Dibesa" });
                _baseDatos.TipoClientes.Add(new TipoCliente { TipoClienteContable = "Dichosa" });
                _baseDatos.TipoClientes.Add(new TipoCliente { TipoClienteContable = "Dichosa" });
                _baseDatos.TipoClientes.Add(new TipoCliente { TipoClienteContable = "Embatlan " });
                _baseDatos.TipoClientes.Add(new TipoCliente { TipoClienteContable = "Emsula" });
                _baseDatos.TipoClientes.Add(new TipoCliente { TipoClienteContable = "Exportacion" });
                _baseDatos.TipoClientes.Add(new TipoCliente { TipoClienteContable = "HDM Distribuidor" });
                _baseDatos.TipoClientes.Add(new TipoCliente { TipoClienteContable = "Incobrable" });
                _baseDatos.TipoClientes.Add(new TipoCliente { TipoClienteContable = "Postmix" });
                _baseDatos.TipoClientes.Add(new TipoCliente { TipoClienteContable = "Preventa" });
                _baseDatos.TipoClientes.Add(new TipoCliente { TipoClienteContable = "Dichosa" });
                _baseDatos.TipoClientes.Add(new TipoCliente { TipoClienteContable = "Preventa " });
                _baseDatos.TipoClientes.Add(new TipoCliente { TipoClienteContable = "Roatan" });
                _baseDatos.TipoClientes.Add(new TipoCliente { TipoClienteContable = "Santa Rosa de Copan" });
                _baseDatos.TipoClientes.Add(new TipoCliente { TipoClienteContable = "Vendedores" });
                _baseDatos.TipoClientes.Add(new TipoCliente { TipoClienteContable = "Ventas Plantel" });
                _baseDatos.TipoClientes.Add(new TipoCliente { TipoClienteContable = "Villacentro" });


                _baseDatos.SaveChanges();
            }
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<TipoCliente>>> GetTipoClientes()
        {
            return await _baseDatos.TipoClientes.ToListAsync();
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<TipoCliente>> GetTipoCliente(int id)
        {
            var respuestaClienteAppService = await _tipoClienteAppService.GetTipoClienteApplicationService(id);

            bool noHayErroresEnLasValidaciones = respuestaClienteAppService == null;
            if (noHayErroresEnLasValidaciones)
            {
                return await _baseDatos.TipoClientes.FirstOrDefaultAsync(q => q.Id == id);
            }
            return BadRequest(respuestaClienteAppService);

        }


        [HttpPost]
        public async Task<ActionResult<TipoCliente>> PostTipoCliente(TipoCliente tipoCliente)
        {
            var respuestaTipoClienteAppService = await _tipoClienteAppService.PostTipoClienteApplicationService(tipoCliente);

            bool noHayErroresEnLasValidaciones = respuestaTipoClienteAppService == null;
            if (noHayErroresEnLasValidaciones)
            {
                return CreatedAtAction(nameof(GetTipoCliente), new { id = tipoCliente.Id }, tipoCliente);
            }
            return BadRequest(respuestaTipoClienteAppService);
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> PutTipoCliente(int id, TipoCliente tipoCliente)
        {
            var respuestaTipoClienteAppService = await _tipoClienteAppService.PutTipoClienteApplicationService(id, tipoCliente);

            bool noHayErroresEnLasValidaciones = respuestaTipoClienteAppService == null;
            if (noHayErroresEnLasValidaciones)
            {
                return NoContent();
            }
            return BadRequest(respuestaTipoClienteAppService);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTipoCliente(int id)
        {
            var respuestaTipoClienteAppService = await _tipoClienteAppService.DeletTipoClienteApplicationService(id);

            bool noHayErroresEnLasValidaciones = respuestaTipoClienteAppService == null;
            if (noHayErroresEnLasValidaciones)
            {
                return Ok("success");
            }
            return BadRequest(respuestaTipoClienteAppService);
        }

    }
}
