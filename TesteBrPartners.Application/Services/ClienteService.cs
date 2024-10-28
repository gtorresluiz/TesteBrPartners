using TesteBrPartners.Application.Interfaces;
using TesteBrPartners.Domain.Models;

namespace TesteBrPartners.Application.Services
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteService(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public async Task<Cliente> GetClienteByIdAsync(int id)
        {
            return await _clienteRepository.GetClienteByIdAsync(id);
        }

        public async Task<IEnumerable<Cliente>> GetAllClientesAsync()
        {
            return await _clienteRepository.GetAllClientesAsync();
        }

        public async Task<Cliente> CreateClienteAsync(Cliente cliente)
        {
            await _clienteRepository.AddClienteAsync(cliente);
            return cliente; // Retorna o cliente criado
        }

        public async Task<Cliente> UpdateClienteAsync(Cliente cliente)
        {
            await _clienteRepository.UpdateClienteAsync(cliente);
            return cliente; // Retorna o cliente atualizado
        }

        public async Task<bool> DeleteClienteAsync(int id)
        {
            await _clienteRepository.DeleteClienteAsync(id);
            return true; // Retorna verdadeiro se o cliente foi deletado
        }
    }
}
