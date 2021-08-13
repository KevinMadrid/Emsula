using ProyectoEmsula.Models;
using ProyectoEmsula.DataContext;
using ProyectoEmsula.DomainServices;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoEmsula.ApplicationServices
{
    public class ClienteAppService
    {
        private readonly EmsulaDataContext _baseDatos;
        private readonly ClienteDomainService _clienteDomainServices;

        public ClienteAppService(EmsulaDataContext _context, ClienteDomainService clienteDomainService)
        {
            _baseDatos = _context;
            _clienteDomainServices = clienteDomainService;
        }

        public async Task<String> GetClienteApplicationService(int id)
        {
            var cliente = await _baseDatos.Clientes.FirstOrDefaultAsync(q => q.Id == id);


            var respuestaDomainService = _clienteDomainServices.GetClienteDomainService(id, cliente);

            bool hayErrorEnElDomainService = respuestaDomainService != null;
            if (hayErrorEnElDomainService)
            {
                return respuestaDomainService;
            }
            return null;
        }
        public async Task<String> PostClienteApplicationService(Cliente cliente)

        {

            var respuestaDomainService = _clienteDomainServices.PostClienteDomainService(cliente);

            bool hayErrorEnElDomainService = respuestaDomainService != null;
            if (hayErrorEnElDomainService)
            {
                return respuestaDomainService;
            }

            _baseDatos.Clientes.Add(cliente);
            await _baseDatos.SaveChangesAsync();

            return null;
        }


        public async Task<String> PutClienteApplicationService(int id, Cliente cliente)
        {

            var respuestaDomainService = _clienteDomainServices.PutClienteDomainService(id, cliente);

            bool hayErrorEnElDomainService = respuestaDomainService != null;
            if (hayErrorEnElDomainService)
            {
                return respuestaDomainService;
            }

            _baseDatos.Entry(cliente).State = EntityState.Modified;
            await _baseDatos.SaveChangesAsync();

            return null;
        }
        public async Task<String> DeletArticulosApplicationService(int id)
        {
            var cliente = await _baseDatos.Clientes.FindAsync(id);
            var respuestaDomainService = _clienteDomainServices.DeleteClienteDomainService(id, cliente);

            bool hayErrorEnElDomainService = respuestaDomainService != null;
            if (hayErrorEnElDomainService)
            {
                return respuestaDomainService;
            }

            _baseDatos.Clientes.Remove(cliente);
            await _baseDatos.SaveChangesAsync();

            return null;
        }
    }
    }
