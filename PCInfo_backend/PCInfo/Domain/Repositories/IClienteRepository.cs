using PCInfo_backend.PCInfo.Domain.Models;

namespace PCInfo_backend.PCInfo.Domain.Repositories;

public interface IClienteRepository
{
    Task<IEnumerable<Cliente>> ListAsync();
    Task<Cliente> GetAsync(string id);
    Task SaveAsync(Cliente cliente);
    void UpdateAsync(string id, Cliente cliente);
    void DeleteAsync(string id);
}