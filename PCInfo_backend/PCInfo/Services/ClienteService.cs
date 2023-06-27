using PCInfo_backend.PCInfo.Domain.Models;
using PCInfo_backend.PCInfo.Domain.Repositories;
using PCInfo_backend.PCInfo.Domain.Services;
using PCInfo_backend.PCInfo.Domain.Services.Communication;

namespace PCInfo_backend.PCInfo.Services;

public class ClienteService : IClienteService
{
    private readonly IClienteRepository _clienteRepository;
    private readonly IUnitOfWork _unitOfWork;
    
    public ClienteService(IClienteRepository clienteRepository, IUnitOfWork unitOfWork)
    {
        _clienteRepository = clienteRepository;
        _unitOfWork = unitOfWork;
    }
    
    public async Task<IEnumerable<Cliente>> ListAsync()
    {
        return await _clienteRepository.ListAsync();
    }

    public async Task<ClienteResponse> SaveAsync(Cliente cliente)
    {
        try
        {
            await _clienteRepository.AddAsync(cliente);
            await _unitOfWork.CompleteAsync();
            return new ClienteResponse(cliente);
        }
        catch (Exception e)
        {
            return new ClienteResponse($"An error occurred while saving the cliente: {e.Message}");
        }
        
    }

    public Task<ClienteResponse> UpdateAsync(int id, Cliente cliente)
    {
        throw new NotImplementedException();
    }

    public Task<ClienteResponse> DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }
}