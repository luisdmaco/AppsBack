using Microsoft.EntityFrameworkCore;
using PCInfo_backend.PCInfo.Domain.Models;
using PCInfo_backend.PCInfo.Domain.Repositories;
using PCInfo_backend.PCInfo.Persistence.Contexts;

namespace PCInfo_backend.PCInfo.Persistence.Repositories;

public class ClienteRepository : BaseRepository, IClienteRepository
{
    public ClienteRepository(AppDbContext context) : base(context)
    {
    }
    
    public async Task<IEnumerable<Cliente>> ListAsync()
    {
        return await _context.Clientes
            .Include(p => p.user)
            .ToListAsync();
    }
    
    public async Task AddAsync(Cliente cliente)
    {
        await _context.Clientes.AddAsync(cliente);
    }
    
    public void Update(string id, Cliente cliente)
    {
        _context.Clientes.Update(cliente);
    }
    
    public void Remove(Cliente cliente)
    {
        _context.Clientes.Remove(cliente);
    }
}