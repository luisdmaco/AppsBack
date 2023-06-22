using PCInfo_backend.PCInfo.Domain.Models;
using PCInfo_backend.PCInfo.Domain.Services.Communication;

namespace PCInfo_backend.PCInfo.Domain.Services;

public interface IClienteService
{
    Task<IEnumerable<Cliente>> ListAsync();
    Task<ClienteResponse> SaveAsync(Cliente cliente);
    Task<ClienteResponse> UpdateAsync(int id, Cliente cliente);
    Task<ClienteResponse> DeleteAsync(int id);
}