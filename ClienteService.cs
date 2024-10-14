using System.Collections.Generic;
using TesteBrPartners.Application.Interfaces;
using TesteBrPartners.Domain.Entities;

namespace TesteBrPartners.Application.Services
{
    public class ClienteService
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteService(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public IEnumerable<Cliente> GetAllClientes()
        {
            return _clienteRepository.GetAll();
        }

        public Cliente GetClienteById(int id)
        {
            return _clienteRepository.GetById(id);
        }

        public void CreateCliente(Cliente cliente)
        {
            _clienteRepository.Add(cliente);
        }

        public void UpdateCliente(Cliente cliente)
        {
            _clienteRepository.Update(cliente);
        }

        public void DeleteCliente(int id)
        {
            _clienteRepository.Delete(id);
        }
    }
}