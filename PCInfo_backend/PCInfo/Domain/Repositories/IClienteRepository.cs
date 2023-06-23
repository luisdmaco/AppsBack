using PCInfo_backend.PCInfo.Domain.Models;

namespace PCInfo_backend.PCInfo.Domain.Repositories;

public interface IClienteRepository
{
    Task<IEnumerable<Cliente>> ListAsync();
    Task AddAsync(Cliente cliente);
    void Update(string id, Cliente cliente);
    void Remove(Cliente cliente);
}