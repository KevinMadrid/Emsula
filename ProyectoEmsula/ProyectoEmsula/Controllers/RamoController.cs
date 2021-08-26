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
    public class RamoController : ControllerBase
    {

        private readonly EmsulaDataContext _baseDatos;
        private readonly RamoAppService _ramoAppService;

        public RamoController(EmsulaDataContext baseDeDatos, RamoAppService ramoAppService)
        {
            _baseDatos = baseDeDatos;
            _ramoAppService = ramoAppService;

            if (_baseDatos.Ramos.Count() == 0)
            {
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "Abarroteria" });
                _baseDatos.Ramos.Add(new Ramo{ RamoNombre = "Afiliados" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "Agencia de Publicidad" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "Agencia de Viajes" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "Agro Industria" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "Agua" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "Ambulantes" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "Aseguradoras" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "Autolote" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "Balneario" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "Banco" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "Bar" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "Barberias" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "Base Aerea" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "Base Militar" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "Base Naval" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "Base Policial" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "Batallones" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "Billar" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "Bloqueras" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "Bodega" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "Bufete" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "Ambulantes" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "Cafeteria" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "Canchas de Futbol" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "Cantina" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "Car Wash" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "Carniceria" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "Carreta" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "Casa de Empeño" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "Casa Hogar" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "Casetas" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "Casinos" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "Chatarreras" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "Chiclera" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "Cine" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "Clinica" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "Clinica Privada" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "Club" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "Club Capestre" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "Club Social" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "Colaborador" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "Colegio Publico" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "Colegio Privado" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "Comedor" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "Comerciales" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "Comercializador" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "Comercio" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "Consumo" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "Cooperativa" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "Corporacion" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "CyberCafe" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "Deposito Agua" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "Deposito Mixto" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "Deposito Empresa" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "Deposito Refresco" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "Disco" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "Distribuidor" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "Editorial" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "Embajada" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "Empacadoras" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "Empresas" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "Emsula" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "Escuela Privada" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "Escuela Publica" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "Estadios" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "Exp. Temporales" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "Espendios" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "Expo Permanentes" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "Fabricas" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "Farmacias" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "Ferias" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "Ferreterias" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "Fiesta Patrona" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "Fijo Recurrente" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "Fincas" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "Fleteros" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "Fotocopiadora" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "Galeria de Arte" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "Ganaderia" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "Gasolinera" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "Gimnacio" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "Gobierto Local" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "Gobierno Nacion" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "Golosinas" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "Granja" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "Gubernamentales" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "Heladeria" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "Hogar" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "Hogares" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "Hogares de Retri" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "Hospedaje" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "Hospital Privado" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "Hospitales" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "Hoteles" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "Iglesias" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "Joyeria" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "Juegos Electro" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "Karaoker" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "Kinder Privado" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "Kinder Publico" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "Kiosko" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "Laboratorios" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "Lavanderia" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "Libreria" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "Licoreria" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "Maderera" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "Maquilas" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "Maquinas Moneda" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "Mercado" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "Mini Super" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "Motel" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "Night Club" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "Novedades" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "Obsequios Navideños" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "Obsequios" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "Ocacional" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "Ofic.Come.Prof" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "Oficinas" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "Otros" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "Otros Com. Bed" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "Otros Gobiernos" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "Otros Intermedi" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "Otros Recreacion" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "Otros Recreacion" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "Panaderia" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "Papeleria" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "Parque Diversiones" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "Picnic" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "Playa" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "Pulperias " });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "Punto de Taxis" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "Punto de Ventas" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "RCR Indp. Local" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "RCR Internacion" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "Reposterias" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "Restaurante Lujo" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "Hogares de Retri" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "Restaurantes" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "Rotura" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "Sala de Belleza" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "Sastreria" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "Super. Independ" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "Supermercados" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "Super. Independiente" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "Talleres" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "Teatro" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "Tienda Conv Cad" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "Tienda Conv Ind" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "Tiendas" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "Transporte " });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "U Privada" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "U Publica" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "Varios" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "Vendedore Cedis" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "Venta Repuestos" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "VideoClub" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "Viveros" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "Viveros" });
                _baseDatos.Ramos.Add(new Ramo { RamoNombre = "Zapateria" });
        


                _baseDatos.SaveChanges();
            }
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Ramo>>> GetRamos()
        {
            return await _baseDatos.Ramos.ToListAsync();
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<Ramo>> GetRamo(int id)
        {
            var respuestaRamoAppService = await _ramoAppService.GetRamoApplicationService(id);

            bool noHayErroresEnLasValidaciones = respuestaRamoAppService == null;
            if (noHayErroresEnLasValidaciones)
            {
                return await _baseDatos.Ramos.FirstOrDefaultAsync(q => q.Id == id);
            }
            return BadRequest(respuestaRamoAppService);

        }


        [HttpPost]
        public async Task<ActionResult<Ramo>> PostRamo(Ramo ramo)
        {
            var respuestaRamoAppService = await _ramoAppService.PostRamoApplicationService(ramo);

            bool noHayErroresEnLasValidaciones = respuestaRamoAppService == null;
            if (noHayErroresEnLasValidaciones)
            {
                return CreatedAtAction(nameof(GetRamo), new { id = ramo.Id }, ramo);
            }
            return BadRequest(respuestaRamoAppService);
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> PutRamo(int id, Ramo ramo)
        {
            var respuestaRamoAppService = await _ramoAppService.PutRamoApplicationService(id, ramo);

            bool noHayErroresEnLasValidaciones = respuestaRamoAppService == null;
            if (noHayErroresEnLasValidaciones)
            {
                return NoContent();
            }
            return BadRequest(respuestaRamoAppService);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRamo(int id)
        {
            var respuestaRamoAppService = await _ramoAppService.DeleteRamoApplicationService(id);

            bool noHayErroresEnLasValidaciones = respuestaRamoAppService == null;
            if (noHayErroresEnLasValidaciones)
            {
                return Ok("success");
            }
            return BadRequest(respuestaRamoAppService);
        }

    }
}
