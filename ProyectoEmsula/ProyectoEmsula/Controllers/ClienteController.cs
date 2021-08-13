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
    public class ClienteController : ControllerBase
    {

        private readonly EmsulaDataContext _baseDatos;
        private readonly ClienteAppService _clienteAppService;

        public ClienteController(EmsulaDataContext baseDeDatos, ClienteAppService clienteAppService)
        {
            _baseDatos = baseDeDatos;
            _clienteAppService = clienteAppService;

            if (_baseDatos.Clientes.Count() == 0)
            {
                _baseDatos.Clientes.Add(new Cliente { NumeroIdentidad = 1602199700002 ,NombreLegalCliente="Kevin Jafet Madrid Hernandez",NombreCorto="Kevin Madrid", TelefonoCelular = 98008557    });
                _baseDatos.Clientes.Add(new Cliente { NumeroIdentidad = 0501199501254, NombreLegalCliente = "Mario Javier Lopez Perez", NombreCorto = "Mario Lopez", TelefonoCelular = 94857423 });
                _baseDatos.SaveChanges();
            }
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Cliente>>> GetClientes()
        {
            return await _baseDatos.Clientes.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Cliente>> GetCliente(int id)
        {
            var respuestaClienteAppService = await _clienteAppService.GetClienteApplicationService(id);

            bool noHayErroresEnLasValidaciones = respuestaClienteAppService == null;
            if (noHayErroresEnLasValidaciones)
            {
                return await _baseDatos.Clientes.FirstOrDefaultAsync(q => q.Id == id);
            }
            return BadRequest(respuestaClienteAppService);

        }

        [HttpPost]
        public async Task<ActionResult<Cliente>> PostCliente(Cliente cliente)
        {
            var respuestaClienteAppService = await _clienteAppService.PostClienteApplicationService(cliente);

            bool noHayErroresEnLasValidaciones = respuestaClienteAppService == null;
            if (noHayErroresEnLasValidaciones)
            {
                return CreatedAtAction(nameof(GetCliente), new { id = cliente.Id }, cliente);
            }
            return BadRequest(respuestaClienteAppService);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutCliente(int id, Cliente cliente)
        {
            var respuestaClienteAppService = await _clienteAppService.PutClienteApplicationService(id, cliente);

            bool noHayErroresEnLasValidaciones = respuestaClienteAppService == null;
            if (noHayErroresEnLasValidaciones)
            {
                return NoContent();
            }
            return BadRequest(respuestaClienteAppService);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCliente(int id)
        {
            var respuestaClienteAppService = await _clienteAppService.DeletArticulosApplicationService(id);

            bool noHayErroresEnLasValidaciones = respuestaClienteAppService == null;
            if (noHayErroresEnLasValidaciones)
            {
                return Ok("success");
            }
            return BadRequest(respuestaClienteAppService);
        }

    }
}
