﻿using TesteBrPartners.Domain.Models;

namespace TesteBrPartners.Application.Interfaces
{
    public interface IClienteRepository
    {
        Task<Cliente> GetClienteByIdAsync(int id);
        Task<IEnumerable<Cliente>> GetAllClientesAsync();
        Task AddClienteAsync(Cliente cliente);
        Task UpdateClienteAsync(Cliente cliente);
        Task DeleteClienteAsync(int id);
    }
}
