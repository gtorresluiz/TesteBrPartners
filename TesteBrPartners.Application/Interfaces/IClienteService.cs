using TesteBrPartners.Domain.Entities;

namespace TesteBrPartners.Application.Interfaces
{
    public interface IClienteService
    {
        Task<Cliente> GetClienteByIdAsync(int id);               // Para obter um cliente por ID
        Task<IEnumerable<Cliente>> GetAllClientesAsync();        // Para obter todos os clientes
        Task<Cliente> CreateClienteAsync(Cliente cliente);       // Para criar um novo cliente
        Task<Cliente> UpdateClienteAsync(Cliente cliente);       // Para atualizar um cliente existente
        Task<bool> DeleteClienteAsync(int id);                   // Para deletar um cliente por ID
    }
}
