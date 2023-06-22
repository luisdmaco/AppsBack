using PCInfo_backend.PCInfo.Domain.Models;
using PCInfo_backend.Shared.Domain.Services.Communication;

namespace PCInfo_backend.PCInfo.Domain.Services.Communication;

public class ClienteResponse : BaseResponse<Cliente>
{
    public ClienteResponse(string message) : base(message)
    {
    }
    public ClienteResponse(Cliente resource) : base(resource)
    {
    }
}