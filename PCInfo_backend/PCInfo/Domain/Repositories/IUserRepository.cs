using PCInfo_backend.PCInfo.Domain.Models;

namespace PCInfo_backend.PCInfo.Domain.Repositories;

public interface IUserRepository
{
    Task<IEnumerable<User>> ListAsync();
    Task<User> GetAsync(string id);
    Task SaveAsync(User user);
    void UpdateAsync(string id, User user);
    void DeleteAsync(string id);
}