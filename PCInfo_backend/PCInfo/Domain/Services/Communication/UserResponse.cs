using PCInfo_backend.PCInfo.Domain.Models;
using PCInfo_backend.Shared.Domain.Services.Communication;

namespace PCInfo_backend.PCInfo.Domain.Services.Communication;

public class UserResponse : BaseResponse<User>
{
    UserResponse(string message) : base(message)
    {
    }
    UserResponse(User resource) : base(resource)
    {
    }
}