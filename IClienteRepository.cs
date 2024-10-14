using System.Collections.Generic;
using TesteBrPartners.Domain.Entities;

namespace TesteBrPartners.Application.Interfaces
{
    public interface IClienteRepository
    {
        IEnumerable<Cliente> GetAll();
        Cliente GetById(int id);
        void Add(Cliente cliente);
        void Update(Cliente cliente);
        void Delete(int id);
    }
}